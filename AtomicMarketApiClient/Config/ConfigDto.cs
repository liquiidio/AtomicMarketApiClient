using Newtonsoft.Json;

namespace AtomicMarketApiClient.Config
{
    public class ConfigDto
    {
        [JsonProperty("success")]
        /* Whether the Request was Successfull or not */
        public bool Success { get; set; }

        [JsonProperty("data")]
        /* The Data returned from the Api */
        public DataDto Data { get; set; }

        public class DataDto
        {
            [JsonProperty("atomicassets_contract")]
            /* The Name of the AtomicAssets Smart Contract */
            public string AtomicAssetsContract { get; set; }

            [JsonProperty("atomicmarket_contract")]
            /* The Name of the AtomicMarket Smart Contract */
            public string AtomicMarketContract { get; set; }

            [JsonProperty("delphioracle_contract")]
            /* The Name of the DelphiOracle Smart Contract */
            public string DelphioracleContract { get; set; }

            [JsonProperty("version")]
            /* The Current Version */
            public string Version { get; set; }

            [JsonProperty("maker_market_fee")]
            /* The Maker Market Fee */
            public string MakerMarketFee { get; set; }

            [JsonProperty("taker_market_fee")]
            /* The Taker Market Fee */
            public string TakerMarketFee { get; set; }

            [JsonProperty("minimum_auction_duration")]
            /* The minimum Auction Duration */
            public string MinimumAuctionDuration { get; set; }

            [JsonProperty("maximum_auction_duration")]
            /* The maximum Auction Duration */
            public string MaximumAuctionDuration { get; set; }

            [JsonProperty("minimum_bid_increase")]
            /* The minimum bid increase */
            public string MinimumBidIncrease { get; set; }

            [JsonProperty("auction_reset_duration")]
            /* The auction reset duration */
            public string AuctionResetDuration { get; set; }

            [JsonProperty("supported_tokens")]
            /* Array of supported Tokens */
            public SupportedTokensDto[] SupportedTokens { get; set; }

            [JsonProperty("supported_pairs")]
            /* Array of supported Currency-/Token-Pairs */
            public SupportedPairsDto[] SupportedPairs { get; set; }

            [JsonProperty("query_time")]
            /* The time this Query took */
            public long QueryTime { get; set; }

            public class SupportedTokensDto
            {
                [JsonProperty("token_contract")]
                /* The Token Smart Contract */
                public string TokenContract { get; set; }

                [JsonProperty("token_symbol")]
                /* The Token Symbol */
                public string TokenSymbol { get; set; }

                [JsonProperty("token_precision")]
                /* The Precision of the Token */
                public string TokenPrecision { get; set; }
            }

            public class SupportedPairsDto
            {
                [JsonProperty("listing_symbol")]
                public string ListingSymbol { get; set; }

                [JsonProperty("settlement_symbol")]
                public string SettlementSymbol { get; set; }

                [JsonProperty("delphi_pair_name")]
                public string DelphiPairName { get; set; }

                [JsonProperty("invert_delphi_pair")]
                public bool InvertDelphiPair { get; set; }

                [JsonProperty("data")]
                public PairsDataDto Data { get; set; }

                public class PairsDataDto
                {
                    [JsonProperty("contract")]
                    /* The name of the Smart Contract */
                    public string Contract { get; set; }

                    [JsonProperty("delphi_pair_name")]
                    public string DelphiPairName { get; set; }

                    [JsonProperty("base_symbol")]
                    public string BaseSymbol { get; set; }

                    [JsonProperty("base_precision")]
                    public string BasePrecision { get; set; }

                    [JsonProperty("quote_symbol")]
                    public string QuoteSymbol { get; set; }

                    [JsonProperty("quote_precision")]
                    public string QuotePrecision { get; set; }

                    [JsonProperty("median")]
                    public string Median { get; set; }

                    [JsonProperty("median_precision")]
                    public string MedianPrecision { get; set; }

                    [JsonProperty("updated_at_time")]
                    /* Time this was last updated */
                    public string UpdatedAtTime { get; set; }

                    [JsonProperty("updated_at_block")]
                    /* Block-Number this was last updated */
                    public string UpdatedAtBlock { get; set; }
                }
            }
        }
    }
}
