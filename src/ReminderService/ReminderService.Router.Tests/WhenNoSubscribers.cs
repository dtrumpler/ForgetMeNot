﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using ReminderService.Router.Tests.Helpers;

namespace ReminderService.Router.Tests
{
	[TestFixture ()]
	public class WhenNoSubscibers : Given_a_bus_instance
	{
		[TestFixtureSetUp]
		public void Given_a_bus_with_subscribers()
		{	
			WithConsumer (new FakeConsumer<TestMessages.ADerivedTestMessage>(RecordRoutedMessages));
			WithConsumer (new FakeConsumer<TestMessages.NotDerivedTestMessage> (RecordRoutedMessages));
		}

		[SetUp]
		public void When_a_message_is_published()
		{
			Bus.Publish(new TestMessages.SiblingOfADerivedTestMessage());
		}

		[Test ()]
		public void Then_no_messages_are_received ()
		{
			Assert.AreEqual (0, _routedMessages.Count);
		}
	}
}

