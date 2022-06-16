using System;
using System.Text;
using AtomicMarketApiClient.Core;

namespace AtomicMarketApiClient.Auctions
{
    public class AuctionsUriParameterBuilder : IUriParameterBuilder
    {
/* A private variable that is used to store the value of the state parameter. */
        private string _state;
/* A nullable integer specfying max assets per listing. */
        private int? _maxAssets;
/* A nullable integer specfying min assets per listing */
        private int? _minAssets;
/* A nullable boolean specfying which sellerContracts to show. */
        private bool? _showSellerContracts;
/* A nullable boolean specfying accounts with contracts. */
        private bool? _contractWhitelist;
/* A nullable boolean specfying listing from sellers. */
        private bool? _sellerBlacklist;
/* A nullable integer specifying the assetId. */ 
        private int? _assetId;
/* A private variable that is used to store the value of the maketplace parameter. */
        private string _marketplace;
/* A private variable that is used to store the value of the makerMarketplace parameter. */
        private string _makerMarketplace;
/* A private variable that is used to store the value of the takerMarketplace parameter. */
        private string _takerMarketplace;
/* A private variable that is used to store the value of the symbol parameter. */
        private string _symbol;
/* A private variable that is used to store the value of the seller parameter. */
        private string _seller;
/* A private variable that is used to store the value of the buyer parameter. */
        private string _buyer;
/* A nullable integer specifying the min price. */ 
        private int? _minPrice;
/* A nullable integer specifying the max price. */ 
        private int? _maxPrice;
/* A nullable integer specifying the minTemplateMint. */ 
        private int? _minTemplateMint;
/* A nullable integer specifying the maxTemplateMint. */ 
        private int? _maxTemplateMint;
/* A private variable that is used to store the value of the owner parameter. */
        private string _owner;
/* A nullable boolean specfying burned assets. */
        private bool? _burned;
/* A private variable that is used to store the value of the collectionName parameter. */
        private string _collectionName;
/* A private variable that is used to store the value of the schemaName parameter. */
        private string _schemaName;
/* A private variable that is used to store the value of the templateId parameter. */
        private string _templateId;
/* A nullable boolean specfying transferable assets. */
        private bool? _isTransferable;
/* A nullable boolean specfying burnable assets. */
        private bool? _isBurnable;
/* A private variable that is used to store the value of the match parameter. */
        private string _match;
/* A private variable that is used to store the value of the collectionBlacklist parameter. */
        private string _collectionBlacklist;
/* A private variable that is used to store the value of the collectionWhitelist parameter. */
        private string _collectionWhitelist;
/* A private variable that is used to store the value of the ids parameter. */
        private string _ids;
/* A private variable that is used to store the value of the lowerBound parameter. */
        private string _lowerBound;
/* A private variable that is used to store the value of the upperBound parameter. */
        private string _upperBound;
/* A nullable integer specifying the previous timestamp. */ 
        private int? _before;
/* A nullable integer specifying the next timestamp. */ 
        private int? _after;
/* A nullable integer specifying the page. */ 
        private int? _page;
/* A nullable integer specifying the limit of returned values. */
        private int? _limit;
/* A nullable enum specifying the sortStrategy. */
        private SortStrategy? _sortStrategy;
        private string _sort;

        public AuctionsUriParameterBuilder WithState(params State[] states)
        {
            _state = string.Join(",", Array.ConvertAll(states, value => (int) value));
            return this;
        }


/// <summary>
/// `WithMaxAssets` sets the `_maxAssets` variable 
/// </summary>
/// <param name="maxAssets">Max assets per listing returns.</param>
/// <returns>
/// The AuctionsUriParameterBuilder object.
/// </returns>
        public AuctionsUriParameterBuilder WithMaxAssets(int maxAssets)
        {
            _maxAssets = maxAssets;
            return this;
        }


/// <summary>
/// `WithMinAssets` sets the `_minAssets` variable 
/// </summary>
/// <param name="minAssets">Min assets per listing returns.</param>
/// <returns>
/// The AuctionsUriParameterBuilder object.
/// </returns>
        public AuctionsUriParameterBuilder WithMinAssets(int minAssets)
        {
            _minAssets = minAssets;
            return this;
        }


/// <summary>
/// `WithShowSellerContracts` sets the `_showSellerContracts` field to the value of the `showSellerContracts` parameter
/// </summary>
/// <param name="showSellerContracts">If false,no seller contracts are shown except if they are in contract whitelist.</param>
/// <returns>
/// The AuctionsUriParameterBuilder object.
/// </returns>
        public AuctionsUriParameterBuilder WithShowSellerContracts(bool showSellerContracts)
        {
            _showSellerContracts = showSellerContracts;
            return this;
        }


/// <summary>
/// `WithContractWhitelist` sets the `_contractWhitelist` field to the value of the `contractWhitelist` parameter
/// </summary>
/// <param name="contractWhitelist">Shows accounts even if they are contracts.</param>
/// <returns>
/// The AuctionsUriParameterBuilder object.
/// </returns>
        public AuctionsUriParameterBuilder WithContractWhitelist(bool contractWhitelist)
        {
            _contractWhitelist = contractWhitelist;
            return this;
        }


/// <summary>
/// `WithSellerBlacklist` sets the `_sellerBlacklist` field to the value of the `sellerBlacklist` parameter
/// </summary>
/// <param name="sellerBlacklist">Doesnot show listing from sellers.</param>
/// <returns>
/// The AuctionsUriParameterBuilder object.
/// </returns>
        public AuctionsUriParameterBuilder WithSellerBlacklist(bool sellerBlacklist)
        {
            _sellerBlacklist = sellerBlacklist;
            return this;
        }


/// <summary>
/// `WithAssetId` sets the `_assetId` variable to the value of the `asset_id` parameter
/// </summary>
/// <param name="assetId">Shows the asset id in the offer.</param>
/// <returns>
/// The AuctionsUriParameterBuilder object.
/// </returns>
        public AuctionsUriParameterBuilder WithAssetId(int assetId)
        {
            _assetId = assetId;
            return this;
        }


/// <summary>
/// `WithMarketplace` sets the `marketplace` parameter
/// </summary>
/// <param name="marketplace">It filters by all sales where a certain marketplace is either taker or maker marketplace.</param>
/// <returns>
/// The AuctionsUriParameterBuilder object.
/// </returns>
        public AuctionsUriParameterBuilder WithMarketplace(string marketplace)
        {
            _marketplace = marketplace;
            return this;
        }


/// <summary>
/// `WithMakerMarketplace` sets the `makerMarketplace` parameter
/// </summary>
/// <param name="makerMarketplace">separate multiple with ",".</param>
/// <returns>
/// The AuctionsUriParameterBuilder object.
/// </returns>
        public AuctionsUriParameterBuilder WithMakerMarketplace(string makerMarketplace)
        {
            _makerMarketplace = makerMarketplace;
            return this;
        }


/// <summary>
/// `WithTakerMarketplace` sets the `takerMarketplace` parameter
/// </summary>
/// <param name="takerMarketplace">separate multiple with ",".</param>
/// <returns>
/// The AuctionsUriParameterBuilder object.
/// </returns>
        public AuctionsUriParameterBuilder WithTakerMarketplace(string takerMarketplace)
        {
            _takerMarketplace = takerMarketplace;
            return this;
        }


/// <summary>
/// `WithSymbol` sets the `symbol` parameter
/// </summary>
/// <param name="symbol">Filters by symbol.</param>
/// <returns>
/// The AuctionsUriParameterBuilder object.
/// </returns>
        public AuctionsUriParameterBuilder WithSymbol(string symbol)
        {
            _symbol = symbol;
            return this;
        }


/// <summary>
/// `WithSymbol` sets the `symbol` parameter
/// </summary>
/// <param name="symbol">Filters by symbol.</param>
/// <returns>
/// The AuctionsUriParameterBuilder object.
/// </returns>
        public AuctionsUriParameterBuilder WithSeller(string seller)
        {
            _seller = seller;
            return this;
        }

        public AuctionsUriParameterBuilder WithBuyer(string buyer)
        {
            _buyer = buyer;
            return this;
        }

        public AuctionsUriParameterBuilder WithMinPrice(int minPrice)
        {
            _minPrice = minPrice;
            return this;
        }

        public AuctionsUriParameterBuilder WithMaxPrice(int maxPrice)
        {
            _maxPrice = maxPrice;
            return this;
        }

        public AuctionsUriParameterBuilder WithMinTemplateMint(int minTemplateMint)
        {
            _minTemplateMint = minTemplateMint;
            return this;
        }

        public AuctionsUriParameterBuilder WithMaxTemplateMint(int maxTemplateMint)
        {
            _maxTemplateMint = maxTemplateMint;
            return this;
        }

        public AuctionsUriParameterBuilder WithOwner(string owner)
        {
            _owner = owner;
            return this;
        }

        public AuctionsUriParameterBuilder WithBurned(bool burned)
        {
            _burned = burned;
            return this;
        }

        public AuctionsUriParameterBuilder WithCollectionName(string collectionName)
        {
            _collectionName = collectionName;
            return this;
        }

        public AuctionsUriParameterBuilder WithSchemaName(string schemaName)
        {
            _schemaName = schemaName;
            return this;
        }

        public AuctionsUriParameterBuilder WithTemplateId(string templateId)
        {
            _templateId = templateId;
            return this;
        }

        public AuctionsUriParameterBuilder WithIsTransferable(bool isTransferable)
        {
            _isTransferable = isTransferable;
            return this;
        }

        public AuctionsUriParameterBuilder WithIsBurnable(bool isBurnable)
        {
            _isBurnable = isBurnable;
            return this;
        }

        public AuctionsUriParameterBuilder WithMatch(string match)
        {
            _match = match;
            return this;
        }

        public AuctionsUriParameterBuilder WithCollectionBlacklist(string[] collectionBlacklist)
        {
            _collectionBlacklist = string.Join(",", collectionBlacklist);
            return this;
        }

        public AuctionsUriParameterBuilder WithCollectionWhitelist(string[] collectionWhitelist)
        {
            _collectionWhitelist = string.Join(",", collectionWhitelist);
            return this;
        }

        public AuctionsUriParameterBuilder WithIds(string[] ids)
        {
            _ids = string.Join(",", ids);
            return this;
        }

        public AuctionsUriParameterBuilder WithLowerBound(string lowerBound)
        {
            _lowerBound = lowerBound;
            return this;
        }

        public AuctionsUriParameterBuilder WithUpperBound(string upperBound)
        {
            _upperBound = upperBound;
            return this;
        }

        public AuctionsUriParameterBuilder WithBefore(int before)
        {
            _before = before;
            return this;
        }

        public AuctionsUriParameterBuilder WithAfter(int after)
        {
            _after = after;
            return this;
        }

        public AuctionsUriParameterBuilder WithPage(int page)
        {
            _page = page;
            return this;
        }

        public AuctionsUriParameterBuilder WithLimit(int limit)
        {
            _limit = limit;
            return this;
        }

        public AuctionsUriParameterBuilder WithOrder(SortStrategy sorting)
        {
            _sortStrategy = sorting;
            return this;
        }

        public AuctionsUriParameterBuilder WithSort(string sort)
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
