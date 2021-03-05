using System;
using System.Net.Http;
using System.Threading.Tasks;
using EntityHttp.Json.Abstractions;

namespace EntityHttp.Json.Client
{
    /// <summary>
    /// 
    /// </summary>
    public class StandardHttpClient : IHttpClientWrapper
    {
        private readonly HttpClient Client;
        /// <summary>
        /// 
        /// </summary>
        public StandardHttpClient()
        {
            Client = new HttpClient();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            var response = await Client.SendAsync(request).ConfigureAwait(false);
			return response;
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