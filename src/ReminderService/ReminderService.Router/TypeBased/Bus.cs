﻿using System.Collections.Concurrent;

namespace ReminderService.Router.TypeBased
{
    public class Bus : IBus
    {
        private readonly MessageTypeTopics _messageTypeTopics = new MessageTypeTopics();
        private readonly ConcurrentDictionary<string, Multiplexer<IMessage>> _subscribers
            = new ConcurrentDictionary<string, Multiplexer<IMessage>>();

        public void Publish(IMessage message)
        {
            var topics = _messageTypeTopics.GetTopicsForType(message.GetType());
            foreach (var topic in topics)
            {
                PublishToTopic(topic, message);
            }
        }

        private void PublishToTopic(string topic, IMessage message)
        {
            Multiplexer<IMessage> multiplexer;
            if (_subscribers.TryGetValue(topic, out multiplexer))
                multiplexer.Handle(message);
        }

        public void SubscribeTo<T>(IConsume<T> consumer) where T : IMessage
        {
            var wideningConsumer = new WideningConsumer<IMessage, T>(consumer);
            _subscribers.AddOrUpdate(typeof (T).FullName,
                                     s => new Multiplexer<IMessage>(wideningConsumer),
                                     (_, multiplexer) =>
                                         {
                                             multiplexer.Attach(wideningConsumer);
                                             return multiplexer;
                                         });
        }

        public void UnSubscribeTo<T>(IConsume<T> handler) where T : IMessage
        {
            throw new System.NotImplementedException();
        }

        public void ClearSubscribers()
        {
            _subscribers.Clear();
        }
    }
}