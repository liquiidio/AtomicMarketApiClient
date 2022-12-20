using Newtonsoft.Json;

namespace AtomicMarketApiClient
{
    public class StatsDto
    {
        [JsonProperty("success")]
        // Whether the Request was Successfull or not
        public bool Success { get; set; }

        [JsonProperty("data")]
        // The Data returned from the Api
        public DataDto Data { get; set; }

        [JsonProperty("query_time")]
        public long QueryTime { get; set; }

        public class DataDto
        {
            [JsonProperty("template_mint")]
            public int TemplateMint { get; set; }
        }
    }
}