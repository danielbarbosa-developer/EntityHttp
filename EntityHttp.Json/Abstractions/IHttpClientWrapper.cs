using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EntityHttp.Json.Abstractions
{
    /// <summary>
    /// 
    /// </summary>
	public interface IHttpClientWrapper : IDisposable
	{
		/// <summary>
		/// Sends a request
		/// </summary>
		/// <param name="request">Request message data </param>
		/// <returns>Request response</returns>
		Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);
	}
}