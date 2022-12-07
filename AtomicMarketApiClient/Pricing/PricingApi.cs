using AtomicMarketApiClient.Core.Pricing;

namespace AtomicMarketApiClient.Pricing
{
    public class PricingApi : PricingApiBase
    {
        internal PricingApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}