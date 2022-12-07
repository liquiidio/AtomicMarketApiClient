using AtomicMarketApiClient.Core.Auctions;

namespace AtomicMarketApiClient.Auctions
{
    public class AuctionsApi : AuctionsApiBase
    {
        internal AuctionsApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}