using AtomicMarketApiClient.Core.BuyOffers;

namespace AtomicMarketApiClient.Unity3D.BuyOffers
{
    public class BuyOffersApi : BuyOffersApiBase
    {
        internal BuyOffersApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}