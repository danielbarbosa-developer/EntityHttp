using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using EntityHttp.Json.Abstractions;
using EntityHttp.Json.Client;

namespace EntityHttp.Json
{
    /// <summary>
    /// This class contains all Http methods 
    /// </summary>
    public class EntityHttpResource : IEntityHttpResource
    {
        private readonly IHttpClientWrapper Client;
        private string? Url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        public EntityHttpResource(IHttpClientWrapper client)
		{
			this.Client = client;
		}
        /// <summary>
        /// Initializes an EntityHttpResource class with a standard http client
        /// </summary>
        /// <returns></returns>
		public EntityHttpResource() : this(new StandardHttpClient())
		{
		}
        /// <summary>
        /// Optional method that includes a additional path to base url
        /// </summary>
        /// <param name="path"></param>
        public void SetPath(string path)
		{
			Url = Url + path;
		}
        /// <summary>
        /// Gets the current url
        /// </summary>
        /// <returns>The current url that is being used</returns>
		public string GetUrl()
		{
			return Url ?? throw new NullReferenceException();
		}
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">The response object expected</typeparam>
        /// <returns>The response defined as T Value</returns>
        public async Task<T> GetAsync<T>()
        {
            var response = await SendRequestAsync(HttpMethod.Get, GetUri()).ConfigureAwait(false);
			return await ProcessResponse<T>(response).ConfigureAwait(false);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Task<T> GetAsync<T>(object data)
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="headers"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Task<T> GetAsync<T>(object data, Dictionary<string, string> headers)
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetUri()
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Task<T> PostAsync<T>()
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Task<T> PostAsync<T>(object data)
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="headers"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Task<T> PostAsync<T>(object data, Dictionary<string, string> headers)
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Task<T> PutAsync<T>()
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Task<T> PutAsync<T>(object data)
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="headers"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Task<T> PutAsync<T>(object data, Dictionary<string, string> headers)
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="method"></param>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <param name="customToken"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        private async Task<HttpResponseMessage> SendRequestAsync(HttpMethod method, string url, object? data = null, string? customToken = null, Dictionary<string, string>? headers = null)
		{
			using var requestMessage = new HttpRequestMessage(method, url);

			//await SetUrlContent(requestMessage);

			return await Client.SendAsync(requestMessage).ConfigureAwait(false);

		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private async Task<T> ProcessResponse<T>(HttpResponseMessage response)
		{
			var data = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

			if (response.IsSuccessStatusCode)
			{
				var result = await Task.FromResult(JsonSerializer.Deserialize<T>(data)).ConfigureAwait(false);
				if(result != null)
				{
					return result;
				}
			}

			throw new ArgumentException(data);
		}
        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Client.Dispose();
			GC.SuppressFinalize(this);
        }
    }
}