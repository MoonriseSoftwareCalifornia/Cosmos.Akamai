
namespace CDT.Akamai.Cdn
{
    /// <summary>
    /// Akamai CDN Service
    /// </summary>
    public class AkamaiService
    {
        private readonly AkamaiCdnClient _client;
        private readonly string _cpCode;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="clientToken"></param>
        /// <param name="accessToken"></param>
        /// <param name="secret"></param>
        /// <param name="akamaiHost"></param>
        /// <param name="cpCode"></param>
        public AkamaiService(string clientToken, string accessToken, string secret, string akamaiHost, string cpCode)
        {
            _client = new AkamaiCdnClient(clientToken,
                accessToken,
                secret,
                akamaiHost);
            _cpCode = cpCode;
        }
        /// <summary>
        /// Purge an entire end point using CP Code
        /// </summary>
        /// <returns></returns>
        public string PurgeCdnByCpCode()
        {
            var purgeObjects = new AkamaiPurgeObjects
            { Objects = new[] { _cpCode } };
            return _client.Purge(purgeObjects,
                PurgeEndPoints.CpCodeProductionEndpoint);
        }
        /// <summary>
        /// Purge an array of absolute Uris
        /// </summary>
        /// <param name="hostName"></param>
        /// <param name="abosoluteUri"></param>
        /// <returns></returns>
        public string PurgeCdnByUrls(string hostName, string[] paths)
        {
            return _client.PurgeUrls(hostName, paths);
        }
    }
}