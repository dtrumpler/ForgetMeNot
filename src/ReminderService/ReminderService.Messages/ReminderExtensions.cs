﻿using System;
using ReminderService.Common;
using ReminderService.Messages;
using System.Collections.Generic;

namespace ReminderService.Messages
{
	public static class ReminderExtensions
	{
		public static ReminderMessage.Due AsDue(this ReminderMessage.Schedule source)
		{
			return new ReminderMessage.Due (
				source.ReminderId,
				source.DeliveryUrl,
				source.DeadLetterUrl,
				source.ContentType,
				source.TimeoutAt,
				source.Payload);
		}

		public static ReminderMessage.Sent AsSent(this ReminderMessage.Due source)
		{
			return AsSent (source, SystemTime.Now());
		}

		public static ReminderMessage.Sent AsSent(this ReminderMessage.Due source, DateTime sentStamp)
		{
			return new ReminderMessage.Sent (source.ReminderId, sentStamp);
		}
	}
}

