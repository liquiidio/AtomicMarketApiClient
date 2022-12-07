using AtomicMarketApiClient.Core.Assets;

namespace AtomicMarketApiClient.Assets
{
    public class AssetsApi : AssetsApiBase
    {
        internal AssetsApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}