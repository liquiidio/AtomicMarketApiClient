using System;
using System.Text;

namespace AtomicMarketApiClient.Core.Stats
{
    public class StatsUriParameterBuilder : IUriParameterBuilder
    {
        private string _state;
        private int? _maxAssets;
        private int? _minAssets;
        private bool? _showSellerContracts;
        private bool? _contractWhitelist;
        private bool? _sellerBlacklist;
        private int? _assetId;
        private string _marketplace;
        private string _makerMarketplace;
        private string _takerMarketplace;
        private string _symbol;
        private string _seller;
        private string _buyer;
        private int? _minPrice;
        private int? _maxPrice;
        private int? _minTemplateMint;
        private int? _maxTemplateMint;
        private string _owner;
        private bool? _burned;
        private string _collectionName;
        private string _schemaName;
        private string _templateId;
        private bool? _isTransferable;
        private bool? _isBurnable;
        private string _match;
        private string _collectionBlacklist;
        private string _collectionWhitelist;
        private string _ids;
        private string _lowerBound;
        private string _upperBound;
        private int? _before;
        private int? _after;
        private int? _page;
        private int? _limit;
        private SortStrategy? _sortStrategy;
        private string _sort;

        public StatsUriParameterBuilder WithState(params State[] states)
        {
            _state = string.Join(",", Array.ConvertAll(states, value => (int) value));
            return this;
        }

        public StatsUriParameterBuilder WithMaxAssets(int maxAssets)
        {
            _maxAssets = maxAssets;
            return this;
        }

        public StatsUriParameterBuilder WithMinAssets(int minAssets)
        {
            _minAssets = minAssets;
            return this;
        }

        public StatsUriParameterBuilder WithShowSellerContracts(bool showSellerContracts)
        {
            _showSellerContracts = showSellerContracts;
            return this;
        }

        public StatsUriParameterBuilder WithContractWhitelist(bool contractWhitelist)
        {
            _contractWhitelist = contractWhitelist;
            return this;
        }

        public StatsUriParameterBuilder WithSellerBlacklist(bool sellerBlacklist)
        {
            _sellerBlacklist = sellerBlacklist;
            return this;
        }

        public StatsUriParameterBuilder WithAssetId(int assetId)
        {
            _assetId = assetId;
            return this;
        }

        public StatsUriParameterBuilder WithMarketplace(string marketplace)
        {
            _marketplace = marketplace;
            return this;
        }

        public StatsUriParameterBuilder WithMakerMarketplace(string makerMarketplace)
        {
            _makerMarketplace = makerMarketplace;
            return this;
        }

        public StatsUriParameterBuilder WithTakerMarketplace(string takerMarketplace)
        {
            _takerMarketplace = takerMarketplace;
            return this;
        }

        public StatsUriParameterBuilder WithSymbol(string symbol)
        {
            _symbol = symbol;
            return this;
        }

        public StatsUriParameterBuilder WithSeller(string seller)
        {
            _seller = seller;
            return this;
        }

        public StatsUriParameterBuilder WithBuyer(string buyer)
        {
            _buyer = buyer;
            return this;
        }

        public StatsUriParameterBuilder WithMinPrice(int minPrice)
        {
            _minPrice = minPrice;
            return this;
        }

        public StatsUriParameterBuilder WithMaxPrice(int maxPrice)
        {
            _maxPrice = maxPrice;
            return this;
        }

        public StatsUriParameterBuilder WithMinTemplateMint(int minTemplateMint)
        {
            _minTemplateMint = minTemplateMint;
            return this;
        }

        public StatsUriParameterBuilder WithMaxTemplateMint(int maxTemplateMint)
        {
            _maxTemplateMint = maxTemplateMint;
            return this;
        }

        public StatsUriParameterBuilder WithOwner(string owner)
        {
            _owner = owner;
            return this;
        }

        public StatsUriParameterBuilder WithBurned(bool burned)
        {
            _burned = burned;
            return this;
        }

        public StatsUriParameterBuilder WithCollectionName(string collectionName)
        {
            _collectionName = collectionName;
            return this;
        }

        public StatsUriParameterBuilder WithSchemaName(string schemaName)
        {
            _schemaName = schemaName;
            return this;
        }

        public StatsUriParameterBuilder WithTemplateId(string templateId)
        {
            _templateId = templateId;
            return this;
        }

        public StatsUriParameterBuilder WithIsTransferable(bool isTransferable)
        {
            _isTransferable = isTransferable;
            return this;
        }

        public StatsUriParameterBuilder WithIsBurnable(bool isBurnable)
        {
            _isBurnable = isBurnable;
            return this;
        }

        public StatsUriParameterBuilder WithMatch(string match)
        {
            _match = match;
            return this;
        }

        public StatsUriParameterBuilder WithCollectionBlacklist(string[] collectionBlacklist)
        {
            _collectionBlacklist = string.Join(",", collectionBlacklist);
            return this;
        }

        public StatsUriParameterBuilder WithCollectionWhitelist(string[] collectionWhitelist)
        {
            _collectionWhitelist = string.Join(",", collectionWhitelist);
            return this;
        }

        public StatsUriParameterBuilder WithIds(string[] ids)
        {
            _ids = string.Join(",", ids);
            return this;
        }

        public StatsUriParameterBuilder WithLowerBound(string lowerBound)
        {
            _lowerBound = lowerBound;
            return this;
        }

        public StatsUriParameterBuilder WithUpperBound(string upperBound)
        {
            _upperBound = upperBound;
            return this;
        }

        public StatsUriParameterBuilder WithBefore(int before)
        {
            _before = before;
            return this;
        }

        public StatsUriParameterBuilder WithAfter(int after)
        {
            _after = after;
            return this;
        }

        public StatsUriParameterBuilder WithPage(int page)
        {
            _page = page;
            return this;
        }

        public StatsUriParameterBuilder WithLimit(int limit)
        {
            _limit = limit;
            return this;
        }

        public StatsUriParameterBuilder WithOrder(SortStrategy sorting)
        {
            _sortStrategy = sorting;
            return this;
        }

        public StatsUriParameterBuilder WithSort(string sort)
        {
            _sort = sort;
            return this;
        }

        public string Build()
        {
            var parameterString = new StringBuilder("?");
            if (!string.IsNullOrEmpty(_state))
            {
                parameterString.Append($"&state={_state}");
            }
            if (_maxAssets.HasValue)
            {
                parameterString.Append($"&max_assets={_maxAssets}");
            }
            if (_minAssets.HasValue)
            {
                parameterString.Append($"&min_assets={_minAssets}");
            }
            if (_showSellerContracts.HasValue)
            {
                parameterString.Append($"&show_seller_contracts={_showSellerContracts}");
            }
            if (_contractWhitelist.HasValue)
            {
                parameterString.Append($"&contract_whitelist={_contractWhitelist}");
            }
            if (_sellerBlacklist.HasValue)
            {
                parameterString.Append($"&seller_blacklist={_sellerBlacklist}");
            }
            if (_assetId.HasValue)
            {
                parameterString.Append($"&asset_id={_assetId}");
            }
            if (!string.IsNullOrEmpty(_marketplace))
            {
                parameterString.Append($"&marketplace={_marketplace}");
            }
            if (!string.IsNullOrEmpty(_makerMarketplace))
            {
                parameterString.Append($"&maker_marketplace={_makerMarketplace}");
            }
            if (!string.IsNullOrEmpty(_takerMarketplace))
            {
                parameterString.Append($"&taker_marketplace={_takerMarketplace}");
            }
            if (!string.IsNullOrEmpty(_symbol))
            {
                parameterString.Append($"&symbol={_symbol}");
            }
            if (!string.IsNullOrEmpty(_seller))
            {
                parameterString.Append($"&seller={_seller}");
            }
            if (!string.IsNullOrEmpty(_buyer))
            {
                parameterString.Append($"&buyer={_buyer}");
            }
            if (_minPrice.HasValue)
            {
                parameterString.Append($"&min_price={_minPrice}");
            }
            if (_maxPrice.HasValue)
            {
                parameterString.Append($"&max_price={_maxPrice}");
            }
            if (_minPrice.HasValue)
            {
                parameterString.Append($"&min_template_mint={_minTemplateMint}");
            }
            if (_maxPrice.HasValue)
            {
                parameterString.Append($"&max_template_mint={_maxTemplateMint}");
            }
            if (!string.IsNullOrEmpty(_owner))
            {
                parameterString.Append($"&owner={_owner}");
            }
            if (_burned.HasValue)
            {
                parameterString.Append($"&burned={_burned}");
            }
            if (!string.IsNullOrEmpty(_collectionName))
            {
                parameterString.Append($"&collection_name={_collectionName}");
            }
            if (!string.IsNullOrEmpty(_schemaName))
            {
                parameterString.Append($"&schema_name={_schemaName}");
            }
            if (!string.IsNullOrEmpty(_templateId))
            {
                parameterString.Append($"&template_id={_templateId}");
            }
            if (_isTransferable.HasValue)
            {
                parameterString.Append($"&is_transferable={_isTransferable}");
            }
            if (_isBurnable.HasValue)
            {
                parameterString.Append($"&is_burnable={_isBurnable}");
            }
            if (!string.IsNullOrEmpty(_match))
            {
                parameterString.Append($"&match={_match}");
            }
            if (!string.IsNullOrEmpty(_collectionBlacklist))
            {
                parameterString.Append($"&collection_blacklist={_collectionBlacklist}");
            }
            if (!string.IsNullOrEmpty(_collectionWhitelist))
            {
                parameterString.Append($"&collection_whitelist={_collectionWhitelist}");
            }
            if (!string.IsNullOrEmpty(_ids))
            {
                parameterString.Append($"&ids={_ids}");
            }
            if (!string.IsNullOrEmpty(_lowerBound))
            {
                parameterString.Append($"&lower_bound={_lowerBound}");
            }
            if (!string.IsNullOrEmpty(_upperBound))
            {
                parameterString.Append($"&upper_bound={_upperBound}");
            }
            if (_before.HasValue)
            {
                parameterString.Append($"&before={_before}");
            }
            if (_after.HasValue)
            {
                parameterString.Append($"&after={_after}");
            }
            if (_page.HasValue)
            {
                parameterString.Append($"&page={_page}");
            }
            if (_limit.HasValue)
            {
                parameterString.Append($"&limit={_limit}");
            }
            if (_sortStrategy.HasValue)
            {
                switch (_sortStrategy)
                {
                    case SortStrategy.Ascending:
                        parameterString.Append("&order=asc");
                        break;
                    case SortStrategy.Descending:
                        parameterString.Append("&order=desc");
                        break;
                }
            }
            if (!string.IsNullOrEmpty(_sort))
            {
                parameterString.Append($"&sort={_sort}");
            }
            return parameterString.ToString();
        }
    }
}
