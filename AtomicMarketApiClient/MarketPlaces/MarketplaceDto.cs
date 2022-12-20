using Newtonsoft.Json;

namespace AtomicMarketApiClient.MarketPlaces
{
    public class MarketplaceDto
    {
        [JsonProperty("success")]
        // Whether the Request was Successfull or not
        public bool Success { get; set; }

        [JsonProperty("data")]
        // The Data returned from the Api
        public DataDto Data { get; set; }

        [JsonProperty("query_time")]
        // The time this Query took
        public long QueryTime { get; set; }

        public class DataDto
        {
            [JsonProperty("marketplace_name")]
            // The Name of the Marketplace Account
            public string MarketplaceName { get; set; }

            [JsonProperty("creator")]
            // The Creator
            public string Creator { get; set; }

            [JsonProperty("created_at_block")]
            // The Bock Number this was created
            public string CreatedAtBlock { get; set; }

            [JsonProperty("created_at_time")]
            public string CreatedAtTime { get; set; }
        }
    }
}