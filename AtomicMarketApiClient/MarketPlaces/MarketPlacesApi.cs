using AtomicMarketApiClient.Core.MarketPlaces;

namespace AtomicMarketApiClient.MarketPlaces
{
    public class MarketPlacesApi : MarketPlacesApiBase
    {
        internal MarketPlacesApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}