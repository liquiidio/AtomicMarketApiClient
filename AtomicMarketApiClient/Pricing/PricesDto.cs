using Newtonsoft.Json;

namespace AtomicMarketApiClient.Pricing
{
    public class PricesDto
    {
        [JsonProperty("success")]
        // Whether the Request was Successfull or not
        public bool Success { get; set; }

        [JsonProperty("data")]
        // The Data returned from the API
        public DataDto[] Data { get; set; }

        [JsonProperty("query_time")]
        // The time this Query took
        public long QueryTime { get; set; }

        public class DataDto
        {
            [JsonProperty("sale_id")]
            public string SaleId { get; set; }

            [JsonProperty("auction_id")]
            // The unique Identifier of the auction
            public string AuctionId { get; set; }

            [JsonProperty("buyoffer_id")]
            public string BuyOfferId { get; set; }

            [JsonProperty("template_mint")]
            // The Mint-Number of this Template
            public string TemplateMint { get; set; }

            [JsonProperty("price")]
            public string Price { get; set; }

            [JsonProperty("token_symbol")]
            public string TokenSymbol { get; set; }

            [JsonProperty("token_precision")]
            public string TokenPrecision { get; set; }

            [JsonProperty("token_contract")]
            public string TokenContract { get; set; }

            [JsonProperty("block_time")]
            public string BlockTime { get; set; }
        }
    }
}
