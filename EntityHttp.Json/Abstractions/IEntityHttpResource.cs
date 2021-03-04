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
	public interface IEntityHttpResource : IDisposable
	{
		/// <summary>
		///
		/// </summary>
		string GetUri();
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T> GetAsync<T>();

		/// <summary>
		///
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="data"></param>
		/// <returns></returns>
		Task<T> GetAsync<T>(object data);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="headers"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T> GetAsync<T>(object data, Dictionary<string, string> headers);
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T> PostAsync<T>();

		/// <summary>
		///
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="data"></param>
		/// <returns></returns>
		Task<T> PostAsync<T>(object data);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="headers"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
		Task<T> PostAsync<T>(object data, Dictionary<string, string> headers);
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T> PutAsync<T>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T> PutAsync<T>(object data);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="headers"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T> PutAsync<T>(object data, Dictionary<string, string> headers);
	}
}