using System.Text;
using AtomicMarketApiClient.Core;

namespace AtomicMarketApiClient.Assets
{
    public class AssetsUriParameterBuilder
    {
/* A private variable that is used to store the value of the owner parameter. */
        private string _owner;
/* A private variable that is used to store the value of the collectionName parameter. */
        private string _collectionName;
/* A private variable that is used to store the value of the schemaName parameter. */
        private string _schemaName;
/* A nullable boolean specfying the templateId. */
        private int? _templateId;
/* A private variable that is used to store the value of the match parameter. */
        private string _match;
/* A private variable that is used to store the value of the CollectionBlacklist parameter. */
        private string _collectionBlacklist;
/* A private variable that is used to store the value of the collectionWhitelist parameter. */
        private string _collectionWhitelist;
/* A nullable boolean specfying if onlyDuplicatedTemplates should be shown. */
        private bool? _onlyDuplicateTemplates;
/* A private variable that is used to store the value of the authorisedAccount parameter. */
        private string _authorisedAccount;
/* A nullable boolean specfying if offers should be hidden. */
        private bool? _hideOffers;
/* A private variable that is used to store the value of the ids parameter. */
        private string _ids;
/* A private variable that is used to store the value of the lowerBound parameter. */
        private string _lowerBound;
/* A private variable that is used to store the value of the upperBound parameter. */
        private string _upperBound;
/* A nullable integer specifying the previous timestamp. */ 
        private int? _before;
/* A nullable integer specifying the after timestamp. */ 
        private int? _after;
/* A nullable integer specifying the page. */ 
        private int? _page;
/* A nullable integer specifying the limit of returned values. */
        private int? _limit;
/* A nullable enum specifying the sortStrategy. */
        private SortStrategy? _sortStrategy;

        private string _sort;

        public AssetsUriParameterBuilder WithOwner(string owner)
        {
            _owner = owner;
            return this;
        }

        public AssetsUriParameterBuilder WithCollectionName(string collectionName)
        {
            _collectionName = collectionName;
            return this;
        }

        public AssetsUriParameterBuilder WithSchemaName(string schemaName)
        {
            _schemaName = schemaName;
            return this;
        }

        public AssetsUriParameterBuilder WithTemplateId(int templateId)
        {
            _templateId = templateId;
            return this;
        }

        public AssetsUriParameterBuilder WithMatch(string match)
        {
            _match = match;
            return this;
        }

        public AssetsUriParameterBuilder WithCollectionBlacklist(string[] collectionBlacklist)
        {
            _collectionBlacklist = string.Join(",", collectionBlacklist);
            return this;
        }

        public AssetsUriParameterBuilder WithCollectionWhitelist(string[] collectionWhitelist)
        {
            _collectionWhitelist = string.Join(",", collectionWhitelist);
            return this;
        }

        public AssetsUriParameterBuilder WithOnlyDuplicateTemplate(bool onlyDuplicateTemplates)
        {
            _onlyDuplicateTemplates = onlyDuplicateTemplates;
            return this;
        }

        public AssetsUriParameterBuilder WithAuthorisedAccount(string authorisedAccount)
        {
            _authorisedAccount = authorisedAccount;
            return this;
        }

        public AssetsUriParameterBuilder WithHideOffers(bool hideOffers)
        {
            _hideOffers = hideOffers;
            return this;
        }

        public AssetsUriParameterBuilder WithIds(string[] ids)
        {
            _ids = string.Join(",", ids);
            return this;
        }

        public AssetsUriParameterBuilder WithLowerBound(string lowerBound)
        {
            _lowerBound = lowerBound;
            return this;
        }

        public AssetsUriParameterBuilder WithUpperBound(string upperBound)
        {
            _upperBound = upperBound;
            return this;
        }

        public AssetsUriParameterBuilder WithBefore(int before)
        {
            _before = before;
            return this;
        }

        public AssetsUriParameterBuilder WithAfter(int after)
        {
            _after = after;
            return this;
        }

        public AssetsUriParameterBuilder WithPage(int page)
        {
            _page = page;
            return this;
        }

        public AssetsUriParameterBuilder WithLimit(int limit)
        {
            _limit = limit;
            return this;
        }

        public AssetsUriParameterBuilder WithOrder(SortStrategy sorting)
        {
            _sortStrategy = sorting;
            return this;
        }

        public AssetsUriParameterBuilder WithSort(string sort)
        {
            _sort = sort;
            return this;
        }

        public string Build()
        {
            var parameterString = new StringBuilder("?");
            if (!string.IsNullOrEmpty(_owner))
            {
                parameterString.Append($"&owner={_owner}");
            }
            if (!string.IsNullOrEmpty(_collectionName))
            {
                parameterString.Append($"&collection_name={_collectionName}");
            }
            if (_templateId.HasValue)
            {
                parameterString.Append($"&template_id={_templateId}");
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
            if (_onlyDuplicateTemplates.HasValue)
            {
                parameterString.Append($"&only_duplicate_templates={_onlyDuplicateTemplates}");
            }
            if (!string.IsNullOrEmpty(_authorisedAccount))
            {
                parameterString.Append($"&authorized_account={_authorisedAccount}");
            }
            if (_hideOffers.HasValue)
            {
                parameterString.Append($"&hide_offers={_hideOffers}");
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
            if (!string.IsNullOrEmpty(_schemaName))
            {
                parameterString.Append($"&schema_name={_schemaName}");
            }

            return parameterString.ToString();
        }
    }
}
