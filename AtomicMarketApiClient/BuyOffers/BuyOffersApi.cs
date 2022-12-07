using AtomicMarketApiClient.Core.BuyOffers;

namespace AtomicMarketApiClient.BuyOffers
{
    public class BuyOffersApi : BuyOffersApiBase
    {
        internal BuyOffersApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}