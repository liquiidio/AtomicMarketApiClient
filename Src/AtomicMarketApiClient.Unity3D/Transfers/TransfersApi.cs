using AtomicMarketApiClient.Core.Transfers;

namespace AtomicMarketApiClient.Unity3D.Transfers
{
    public class TransfersApi : TransfersApiBase
    {
        internal TransfersApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}