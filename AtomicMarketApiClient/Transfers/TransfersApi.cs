using AtomicMarketApiClient.Core.Transfers;

namespace AtomicMarketApiClient.Transfers
{
    public class TransfersApi : TransfersApiBase
    {
        internal TransfersApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}