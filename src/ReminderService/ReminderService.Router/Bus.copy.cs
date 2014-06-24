﻿using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using ReminderService.Router.Consumers;

namespace ReminderService.Router
{
    public class Bus : IBus
    {
        private readonly MessageTypeTopics _messageTypeTopics = new MessageTypeTopics();
		private readonly ConcurrentDictionary<string, List<IDispatchMessages>> _subscribers
		= new ConcurrentDictionary<string, List<IDispatchMessages>>();

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
			List<IDispatchMessages> handlers;
			if (_subscribers.TryGetValue (topic, out handlers)) {
				foreach (var handler in handlers) {
					handler.Dispatch (message);
				}
			}
        }

		public void Subscribe<T>(IConsume<T> consumer) where T : class, IMessage
        {
			IDispatchMessages handler = new MessageDispatcher<T> (consumer);
			_subscribers.AddOrUpdate (typeof(T).FullName,
				s => {
					var list = new List<IDispatchMessages> ();
					list.Add(handler);
					return list;
				},
				(_, list) => {
					list.Add (handler);
					return list;
				});
        }

        public void UnSubscribe<T>(IConsume<T> handler) where T : IMessage
        {
            throw new System.NotImplementedException();
        }

        public void ClearSubscribers()
        {
            _subscribers.Clear();
        }
    }
}