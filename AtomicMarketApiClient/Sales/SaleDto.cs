﻿using Newtonsoft.Json;

namespace AtomicMarketApiClient.Sales
{
    public class SaleDto
    {
        [JsonProperty("success")]
        // Whether the Request was Successfull or not
        public bool Success { get; set; }

        [JsonProperty("data")]
        // The Data returned from the Api
        public DataDto Data { get; set; }

        public class DataDto
        {
            [JsonProperty("market_contract")]
            public string MarketContract { get; set; }

            [JsonProperty("assets_contract")]
            public string AssetsContract { get; set; }

            [JsonProperty("sale_id")]
            public string SaleId { get; set; }

            [JsonProperty("seller")]
            public string Seller { get; set; }

            [JsonProperty("buyer")]
            public string Buyer{ get; set; }

            [JsonProperty("offer_id")]
            // The unique identifier of an Offer
            public string OfferId { get; set; }

            [JsonProperty("price")]
            public PriceDto Price { get; set; }

            [JsonProperty("listing_price")]
            public string ListingPrice{ get; set; }

            [JsonProperty("listing_symbol")]
            public string ListingSymbol { get; set; }

            [JsonProperty("assets")]
            public AssetDto[] Assets { get; set; }

            [JsonProperty("maker_marketplace")]
            public string MakerMarketplace { get; set; }

            [JsonProperty("taker_marketplace")]
            public string TakerMarketplace { get; set; }

            [JsonProperty("collection")]
            // The Collection this belongs to
            public CollectionDto Collection { get; set; }

            [JsonProperty("state")]
            public int State { get; set; }

            [JsonProperty("updated_at_block")]
            // Block-Number this was last updated
            public string UpdatedAtBlock { get; set; }

            [JsonProperty("updated_at_time")]
            // Time this was last updated
            public string UpdatedAtTime { get; set; }

            [JsonProperty("created_at_block")]
            public string CreatedAtBlock { get; set; }

            [JsonProperty("created_at_time")]
            public string CreatedAtTime { get; set; }

            public class PriceDto
            {
                [JsonProperty("amount")]
                // The Amount
                public string Amount { get; set; }

                [JsonProperty("token_precision")]
                // The Token Precision
                public int TokenPrecision { get; set; }

                [JsonProperty("token_contract")]
                // The Token Smart Contract
                public string TokenContract { get; set; }

                [JsonProperty("token_symbol")]
                // The Token Symbol
                public string TokenSymbol { get; set; }
            }

            public class AssetDto
            {
                [JsonProperty("contract")]
                // The name of the Smart Contract
            public string Contract { get; set; }

                [JsonProperty("asset_id")]
                // The Unique Identifier of the Asset
            public string AssetId { get; set; }

                [JsonProperty("owner")]
                // The Owner
            public string Owner { get; set; }

                [JsonProperty("name")]
                // The Name
            public string Name { get; set; }

                [JsonProperty("is_transferable")]
                // Indicates if an Asset is transferable
            public bool Transferable { get; set; }

                [JsonProperty("is_burnable")]
                // Indicates if an Asset is burnable
            public bool Burnable { get; set; }

                [JsonProperty("template_mint")]
                // The Mint-Number of this Template
            public string TemplateMint { get; set; }

                [JsonProperty("collection")]
                // The Collection this belongs to
            public CollectionDto Collection { get; set; }

                [JsonProperty("schema")]
                // The Schema this belongs to
            public SchemaDto Schema { get; set; }

                [JsonProperty("template")]
                // The Template this belongs to
            public TemplateDto Template{ get; set; }

                [JsonProperty("mutable_data")]
                // The Mutable Data
            public object MutableData { get; set; }

                [JsonProperty("data")]
                public object Data { get; set; }

                [JsonProperty("immutable_data")]
                // The Immutable Data
            public object ImmutableData { get; set; }

                [JsonProperty("backed_tokens")]
                // Tokens by which this Asset is backed
            public BackedTokensDto[] BackedTokens { get; set; }

                [JsonProperty("burned_by_account")]
                public string BurnedByAccount { get; set; }

                [JsonProperty("burned_at_block")]
                public string BurnedAtBlock { get; set; }

                [JsonProperty("burned_at_time")]
                public string BurnedAtTime { get; set; }

                [JsonProperty("updated_at_block")]
                // Block-Number this was last updated
            public string UpdatedAtBlock { get; set; }

                [JsonProperty("updated_at_time")]
                // Time this was last updated
            public string UpdatedAtTime { get; set; }

                [JsonProperty("transferred_at_block")]
                // Block this was last transferred
            public string TransferredAtBlock { get; set; }

                [JsonProperty("transferred_at_time")]
                // Time this was last transferred
            public string TransferredAtTime { get; set; }

                [JsonProperty("minted_at_block")]
                // Block this Asset was minted
            public string MintedAtBlock { get; set; }

                [JsonProperty("minted_at_time")]
                // Time this Asset was minted
            public string MintedAtTime { get; set; }

                public class BackedTokensDto
                {
                    [JsonProperty("token_contract")]
                    // The Token Smart Contract
                public string TokenContract { get; set; }

                    [JsonProperty("token_symbol")]
                    // The Token Symbol
                public string TokenSymbol { get; set; }

                    [JsonProperty("token_precision")]
                    // The Token Precision
                public int TokenPrecision { get; set; }

                    [JsonProperty("amount")]
                    // The Amount
                public string Amount { get; set; }
                }

                public class TemplateDto
                {
                    [JsonProperty("template_id")]
                    // The unique Identifier of a Template
                public string TemplateId { get;set; }

                    [JsonProperty("max_supply")]
                    // The Maximum Supply
                public string MaxSupply { get;set; }

                    [JsonProperty("is_transferable")]
                    // Indicates if an Asset is transferable
            public bool Transferable { get; set; }

                    [JsonProperty("is_burnable")]
                    // Indicates if an Asset is burnable
            public bool Burnable { get; set; }

                    [JsonProperty("issued_supply")]
                    // The issued Supply
                public string IssuedSupply { get; set; }

                    [JsonProperty("created_at_block")]
                    // The Block Number this was created
                public string CreatedAtBlock { get; set; }

                    [JsonProperty("created_at_time")]
                    // The Time this was created
                public string CreatedAtTime { get; set; }

                    [JsonProperty("immutable_data")]
                    // The immutable Data
                public ImmutableDataDto ImmutableData { get; set; }

                    public class ImmutableDataDto
                    {
                        [JsonProperty("img")]
                        // The IPFS-CID of the Image
                    public string Image { get; set; }

                        [JsonProperty("name")]
                        // The Name
            public string Name { get; set; }
                    }
                }

                public class SchemaDto
                {
                    [JsonProperty("schema_name")]
                    // The Name of the Schema
                public string SchemaName { get; set; }

                    [JsonProperty("format")]
                    // The Format of the Schema
                public FormatDto[] Format { get; set; }

                    [JsonProperty("created_at_block")]
                    // The Block Number this was created
                public string CreatedAtBlock { get; set; }

                    [JsonProperty("created_at_time")]
                    // The Time this was created
                public string CreatedAtTime { get; set; }

                    public class FormatDto
                    {
                        [JsonProperty("name")]
                        // The Name
            public string Name { get; set; }

                        [JsonProperty("type")]
                        // The Type of an Attribute
                    public string Type { get; set; }
                    }
                }
            }

            public class CollectionDto
            {
                [JsonProperty("collection_name")]
                // The Name of the Collection
                public string CollectionName { get; set; }

                [JsonProperty("name")]
                // The Name
            public string Name { get; set; }

                [JsonProperty("author")]
                // The Author
                public string Author { get; set; }

                [JsonProperty("allow_notify")]
                // If this Collection allows notifications
                public bool AllowNotify { get; set; }

                [JsonProperty("authorized_accounts")]
                // The Accounts authorized to mint 
                public string[] AuthorizedAccounts { get; set; }

                [JsonProperty("notify_accounts")]
                // The Accounts being notified when minting
                public string[] NotifyAccounts { get; set; }

                [JsonProperty("market_fee")]
                // The Market Fee
                public float MarketFee { get; set; }

                [JsonProperty("created_at_block")]
                // The Block Number this was created
                public string CreatedAtBlock { get; set; }

                [JsonProperty("created_at_time")]
                // The Time this was created
                public string CreatedAtTime { get; set; }
            }
        }
    }
}
