using Newtonsoft.Json;

namespace AtomicMarketApiClient.Stats
{
    public class AccountDto
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
            public ResultDto Result { get; set; }

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
                [JsonProperty("account")]
                public string Account { get; set; }

                [JsonProperty("buy_volume")]
                public string BuyVolume { get; set; }

                [JsonProperty("sell_volume")]
                public string SellVolume { get; set; }
            }
        }
    }
}