using System.Text;

namespace AtomicMarketApiClient.Pricing
{
    public class PricingUriParametersBuilder : IUriParameterBuilder
    {
        private string _symbol;
        private bool? _burned;
        private string _collectionName;
        private string _schemaName;
        private string _templateId;
        private bool? _isTransferable;
        private bool? _isBurnable;

        public PricingUriParametersBuilder WithSymbol(string symbol)
        {
            _symbol = symbol;
            return this;
        }
        
        public PricingUriParametersBuilder WithBurned(bool burned)
        {
            _burned = burned;
            return this;
        }

        public PricingUriParametersBuilder WithCollectionName(string collectionName)
        {
            _collectionName = collectionName;
            return this;
        }

        public PricingUriParametersBuilder WithSchemaName(string schemaName)
        {
            _schemaName = schemaName;
            return this;
        }

        public PricingUriParametersBuilder WithTemplateId(string templateId)
        {
            _templateId = templateId;
            return this;
        }

        public PricingUriParametersBuilder WithIsTransferable(bool isTransferable)
        {
            _isTransferable = isTransferable;
            return this;
        }

        public PricingUriParametersBuilder WithIsBurnable(bool isBurnable)
        {
            _isBurnable = isBurnable;
            return this;
        }

        public string Build()
        {
            var parameterString = new StringBuilder("?");
            if (!string.IsNullOrEmpty(_symbol))
            {
                parameterString.Append($"&symbol={_symbol}");
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
            return parameterString.ToString();
        }
    }
}