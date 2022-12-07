using AtomicMarketApiClient.Core.Stats;

namespace AtomicMarketApiClient.Stats
{
    public class StatsApi : StatsApiBase
    {
        internal StatsApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}