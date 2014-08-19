﻿using System;
using ReminderService.Router.MessageInterfaces;

namespace ReminderService.Router.Tests
{
	public class FakeQueryHandler<TRequest, TResponse> 
		: IHandleQueries<TRequest, TResponse>  
		where TRequest : IRequest<TResponse>
	{
		private readonly Func<TRequest, TResponse> _handlerDelegate;

		public FakeQueryHandler (Func<TRequest, TResponse> handler)
		{
			_handlerDelegate = handler;
		}

		public TResponse Handle (TRequest request)
		{
			return _handlerDelegate (request);
		}

	}
}

