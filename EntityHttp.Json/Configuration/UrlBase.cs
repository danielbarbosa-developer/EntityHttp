namespace EntityHttp.Json.Configuration
{
    /// <summary>
    /// This class provides Url configurations
    /// </summary>
    public class UrlBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        public UrlBase(string url)
        {
            Url = url;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="urlStag"></param>
        public UrlBase(string url, string urlStag)
        {
            Url = url;
            UrlStag = urlStag;
        }
        /// <summary>
		/// Prod Url
		/// </summary>
		public string Url {get; private set;} = null!;

		/// <summary>
		/// Stag Url
		/// </summary>
		public string? UrlStag {get; private set;}
    }
}