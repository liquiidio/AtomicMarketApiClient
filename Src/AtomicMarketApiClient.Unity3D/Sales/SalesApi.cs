using AtomicMarketApiClient.Core.Sales;

namespace AtomicMarketApiClient.Unity3D.Sales
{
    public class SalesApi : SalesApiBase
    {
        internal SalesApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}