﻿using Newtonsoft.Json;

namespace AtomicMarketApiClient.Pricing
{
    public class AssetPricingDto
    {
        [JsonProperty("success")]
        //! Whether the Request was Successfull or not 
        public bool Success { get; set; }

        [JsonProperty("data")]
        //! The Data returned from the API 
        public DataDto[] Data { get; set; }

        [JsonProperty("query_time")]
        //! The time this Query took 
        public long QueryTime { get; set; }

        public class DataDto
        {
            [JsonProperty("token_symbol")]
            public string TokenSymbol { get; set; }

            [JsonProperty("token_precision")]
            public int TokenPrecision { get; set; }

            [JsonProperty("token_contract")]
            public string TokenContract { get; set; }

            [JsonProperty("median")]
            public long Median { get; set; }

            [JsonProperty("average")]
            public long Average { get; set; }

            [JsonProperty("min")]
            public long Min { get; set; }

            [JsonProperty("max")]
            public long Max { get; set; }

            [JsonProperty("suggested_median")]
            public long SuggestedMedian { get; set; }

            [JsonProperty("suggested_average")]
            public long SuggestedAverage { get; set; }
        }
    }
}
