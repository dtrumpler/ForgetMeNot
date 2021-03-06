﻿using ReminderService.Router.MessageInterfaces;


namespace ReminderService.Router
{
	public interface ISubscribeToQueries
	{
		void Subscribe<TRequest, TResponse> (IHandleQueries<TRequest, TResponse> queryhandler) where TRequest : IRequest<TResponse>;
	}
}

