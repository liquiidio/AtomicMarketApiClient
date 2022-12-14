using AtomicMarketApiClient.Core.Stats;

namespace AtomicMarketApiClient.Unity3D.Stats
{
    public class StatsApi : StatsApiBase
    {
        internal StatsApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}