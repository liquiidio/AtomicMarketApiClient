using AtomicMarketApiClient.Core.Pricing;

namespace AtomicMarketApiClient.Unity3D.Pricing
{
    public class PricingApi : PricingApiBase
    {
        internal PricingApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}