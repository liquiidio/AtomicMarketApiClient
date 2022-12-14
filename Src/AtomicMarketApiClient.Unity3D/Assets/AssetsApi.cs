using AtomicMarketApiClient.Core.Assets;

namespace AtomicMarketApiClient.Unity3D.Assets
{
    public class AssetsApi : AssetsApiBase
    {
        internal AssetsApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}