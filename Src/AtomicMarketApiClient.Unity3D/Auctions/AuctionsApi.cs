using AtomicMarketApiClient.Core.Auctions;

namespace AtomicMarketApiClient.Unity3D.Auctions
{
    public class AuctionsApi : AuctionsApiBase
    {
        internal AuctionsApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}