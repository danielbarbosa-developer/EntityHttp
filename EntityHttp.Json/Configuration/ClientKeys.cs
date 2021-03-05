using System.Collections.Generic;

namespace EntityHttp.Json.Configuration
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientKeys
    {
        /// <summary>
        /// The production client Key
        /// </summary>
        /// <value></value>
        public string? ProductionKey {get; private set;}
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string? StagKey {get; private set;}
        /// <summary>
        /// 
        /// </summary>
        public ClientKeys()
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productionKey"></param>
        public ClientKeys(string productionKey)
        {
            ProductionKey = productionKey;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productionKey"></param>
        /// <param name="stagKey"></param>
        public ClientKeys(string productionKey, string stagKey)
        {
            ProductionKey = productionKey;
            StagKey = stagKey;
        }
    }
}