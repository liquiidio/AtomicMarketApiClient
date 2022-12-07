using AtomicMarketApiClient.Core.Config;

namespace AtomicMarketApiClient.Config
{
    public class ConfigApi : ConfigApiBase
    {
        internal ConfigApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}