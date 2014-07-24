﻿using System;
using Nancy;
using log4net;
using ReminderService.Router;
using ReminderService.API.HTTP.BootStrap;
using ReminderService.Messages;

namespace ReminderService.API.HTTP.BootStrap
{
	public class BootStrapper : DefaultNancyBootstrapper
	{
		private static readonly ILog Logger = LogManager.GetLogger("ReminderService.API.HTTP.Request");

		protected override void ApplicationStartup (Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
		{
			base.ApplicationStartup (container, pipelines);

			var bus = container.Resolve<IBus> ();
			bus.Publish (new SystemMessage.Start());
		}

		protected override void RequestStartup (Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines, NancyContext context)
		{
			pipelines.OnError.AddItemToEndOfPipeline((z, a) =>
				{
					Logger.Error("Unhandled error on request: " + context.Request.Url + " : " + a.Message, a);
					return ErrorResponse.FromException(a);
				});

			base.RequestStartup(container, pipelines, context);
		}


		protected override void ConfigureApplicationContainer (Nancy.TinyIoc.TinyIoCContainer container)
		{
			base.ConfigureApplicationContainer (container);

			var instance = (Bus)container.Resolve<IBusFactory> ().Build ();
			container
				.Register<IBus, Bus> (instance);
		}
	}
}

