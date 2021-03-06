﻿using System;
using System.Net;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;


namespace ReminderService.Test.Common
{
	public class FakeRestClient : IRestClient
	{
		private readonly List<IRestResponse> _responses;
		private IRestRequest _lastRequest;
		private List<IRestRequest> _requests = new List<IRestRequest>();
		private int _requestCount = 0;

		public IRestRequest LastRequest {
			get { return _lastRequest; }
		}

		public List<IRestRequest> Requests {
			get { return _requests; }
		}

		public FakeRestClient (IEnumerable<IRestResponse> responses)
		{
			_responses = new List<IRestResponse>(responses);
		}

		public RestRequestAsyncHandle ExecuteAsync (IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback)
		{
			var handle = new RestRequestAsyncHandle ();
			_lastRequest = request;
			_requests.Add (request);
			callback (GetNextResponse(), handle);
			return handle;
		}

		private IRestResponse GetNextResponse()
		{
			if (_responses.Count == 1)
				return _responses [0];

			return _responses [_requestCount++];
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

