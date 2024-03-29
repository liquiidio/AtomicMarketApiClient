﻿using Newtonsoft.Json;

namespace AtomicMarketApiClient
{
    public class LogsDto
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
            [JsonProperty("log_id")]
            public string LogId{ get; set; }

            [JsonProperty("name")]
            public string Name{ get; set; }

            [JsonProperty("data")]
            public object Data{ get; set; }

            [JsonProperty("txid")]
            public string TxId{ get; set; }

            [JsonProperty("created_at_block")]
            public string CreatedAtBlock{ get; set; }

            [JsonProperty("created_at_time")]
            public string CreatedAtTime{ get; set; }
        }
    }
}