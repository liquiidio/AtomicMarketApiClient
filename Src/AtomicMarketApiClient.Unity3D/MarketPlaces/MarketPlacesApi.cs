using AtomicMarketApiClient.Core.MarketPlaces;

namespace AtomicMarketApiClient.Unity3D.MarketPlaces
{
    public class MarketPlacesApi : MarketPlacesApiBase
    {
        internal MarketPlacesApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}