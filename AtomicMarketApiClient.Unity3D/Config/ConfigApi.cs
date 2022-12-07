using AtomicMarketApiClient.Core.Config;

namespace AtomicMarketApiClient.Unity3D.Config
{
    public class ConfigApi : ConfigApiBase
    {
        internal ConfigApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}