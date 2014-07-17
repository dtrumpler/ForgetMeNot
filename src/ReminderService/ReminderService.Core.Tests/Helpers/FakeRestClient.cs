﻿using System;
using System.Net;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;


namespace ReminderService.Core.Tests
{
	public class FakeRestClient : IRestClient
	{
		private readonly IRestResponse _response;

		public FakeRestClient (IRestResponse response)
		{
			_response = response;
		}

		public RestRequestAsyncHandle ExecuteAsync (IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback)
		{
			var handle = new RestRequestAsyncHandle ();
			callback (_response, handle);
			return handle;
		}

		public RestRequestAsyncHandle ExecuteAsync<T> (IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback)
		{
			throw new NotImplementedException ();
		}

		public IRestResponse Execute (IRestRequest request)
		{
			throw new NotImplementedException ();
		}

		public IRestResponse<T> Execute<T> (IRestRequest request) where T : new()
		{
			throw new NotImplementedException ();
		}

		public Uri BuildUri (IRestRequest request)
		{
			throw new NotImplementedException ();
		}

		public RestRequestAsyncHandle ExecuteAsyncGet (IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback, string httpMethod)
		{
			throw new NotImplementedException ();
		}

		public RestRequestAsyncHandle ExecuteAsyncPost (IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback, string httpMethod)
		{
			throw new NotImplementedException ();
		}

		public RestRequestAsyncHandle ExecuteAsyncGet<T> (IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback, string httpMethod)
		{
			throw new NotImplementedException ();
		}

		public RestRequestAsyncHandle ExecuteAsyncPost<T> (IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback, string httpMethod)
		{
			throw new NotImplementedException ();
		}

		public IRestResponse ExecuteAsGet (IRestRequest request, string httpMethod)
		{
			throw new NotImplementedException ();
		}

		public IRestResponse ExecuteAsPost (IRestRequest request, string httpMethod)
		{
			throw new NotImplementedException ();
		}

		public IRestResponse<T> ExecuteAsGet<T> (IRestRequest request, string httpMethod) where T : new()
		{
			throw new NotImplementedException ();
		}

		public IRestResponse<T> ExecuteAsPost<T> (IRestRequest request, string httpMethod) where T : new()
		{
			throw new NotImplementedException ();
		}

		public Task<IRestResponse<T>> ExecuteTaskAsync<T> (IRestRequest request, System.Threading.CancellationToken token)
		{
			throw new NotImplementedException ();
		}

		public Task<IRestResponse<T>> ExecuteTaskAsync<T> (IRestRequest request)
		{
			throw new NotImplementedException ();
		}

		public Task<IRestResponse<T>> ExecuteGetTaskAsync<T> (IRestRequest request)
		{
			throw new NotImplementedException ();
		}

		public Task<IRestResponse<T>> ExecuteGetTaskAsync<T> (IRestRequest request, System.Threading.CancellationToken token)
		{
			throw new NotImplementedException ();
		}

		public Task<IRestResponse<T>> ExecutePostTaskAsync<T> (IRestRequest request)
		{
			throw new NotImplementedException ();
		}

		public Task<IRestResponse<T>> ExecutePostTaskAsync<T> (IRestRequest request, System.Threading.CancellationToken token)
		{
			throw new NotImplementedException ();
		}

		public Task<IRestResponse> ExecuteTaskAsync (IRestRequest request, System.Threading.CancellationToken token)
		{
			throw new NotImplementedException ();
		}

		public Task<IRestResponse> ExecuteTaskAsync (IRestRequest request)
		{
			throw new NotImplementedException ();
		}

		public Task<IRestResponse> ExecuteGetTaskAsync (IRestRequest request)
		{
			throw new NotImplementedException ();
		}

		public Task<IRestResponse> ExecuteGetTaskAsync (IRestRequest request, System.Threading.CancellationToken token)
		{
			throw new NotImplementedException ();
		}

		public Task<IRestResponse> ExecutePostTaskAsync (IRestRequest request)
		{
			throw new NotImplementedException ();
		}

		public Task<IRestResponse> ExecutePostTaskAsync (IRestRequest request, System.Threading.CancellationToken token)
		{
			throw new NotImplementedException ();
		}

		public CookieContainer CookieContainer {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public string UserAgent {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public int Timeout {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public bool UseSynchronizationContext {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public IAuthenticator Authenticator {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public string BaseUrl {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public IList<Parameter> DefaultParameters {
			get {
				throw new NotImplementedException ();
			}
		}

		public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public IWebProxy Proxy {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}
	}
}

