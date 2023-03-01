using Newtonsoft.Json;

namespace AtomicMarketApiClient.Stats
{
    public class CollectionDto
    {
        [JsonProperty("success")]
        //! Whether the Request was Successfull or not
        public bool Success { get; set; }

        [JsonProperty("data")]
        //! The Data returned from the Api
        public DataDto Data { get; set; }

        public class DataDto
        {
            [JsonProperty("symbol")]
            public SymbolDto Symbol { get; set; }

            [JsonProperty("result")]
            public ResultDto Results { get; set; }

            public class SymbolDto
            {
                [JsonProperty("token_symbol")]
                //! The Token Symbol
                public string TokenSymbol { get; set; }

                [JsonProperty("token_contract")]
                //! The Token Smart Contract
                public string TokenContract { get; set; }

                [JsonProperty("token_precision")]
                //! The Precision of the Token
                public string TokenPrecision { get; set; }
            }

            public class ResultDto
            {
                [JsonProperty("contract")]
                //! The name of the Smart Contract
                public string Contract { get; set; }

                [JsonProperty("collection_name")]
                //! The Name of the Collection
                public string CollectionName { get; set; }

                [JsonProperty("name")]
                //! The Name
                public string Name { get; set; }

                [JsonProperty("img")]
                //! The IPFS-CID of this Image 
                public string Img { get; set; }

                [JsonProperty("author")]
                //! The Author 
                public string Author { get; set; }

                [JsonProperty("allow_notify")]
                public bool? AllowNotify { get; set; }

                [JsonProperty("authorized_accounts")]
                public string[] AuthorisedAccounts { get; set; }

                [JsonProperty("notify_accounts")]
                //! The Accounts being notified when minting 
                public string[] NotifyAccounts { get; set; }

                [JsonProperty("market_fee")]
                public double MarketFee { get; set; }

                [JsonProperty("data")]
                public object Data { get; set; }

                [JsonProperty("created_at_time")]
                //! The Time this was created 
                public string CreatedAtTime { get; set; }

                [JsonProperty("created_at_block")]
                //! The Block Number this was created 
                public string CreatedAtBlock { get; set; }

                [JsonProperty("volume")]
                public string Volume { get; set; }

                [JsonProperty("listings")]
                public string Listings { get; set; }

                [JsonProperty("sales")]
                public string Sales { get; set; }
            }
        }
    }
}