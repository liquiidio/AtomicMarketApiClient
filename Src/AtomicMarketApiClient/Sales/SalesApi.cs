using AtomicMarketApiClient.Core.Sales;

namespace AtomicMarketApiClient.Sales
{
    public class SalesApi : SalesApiBase
    {
        internal SalesApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}