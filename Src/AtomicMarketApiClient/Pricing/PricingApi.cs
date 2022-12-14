using AtomicMarketApiClient.Assets;
using System;
using System.Threading.Tasks;

namespace AtomicMarketApiClient.Pricing
{
    public class PricingApi
    {
        private readonly string _requestUriBase;
        private readonly IHttpHandler _httpHandler;

        internal PricingApi(string baseUrl, IHttpHandler httpHandler)
        {
            _requestUriBase = baseUrl;
            _httpHandler = httpHandler;
        }

        public async Task<PricesDto> Sales()
        {
            return await _httpHandler.GetJsonAsync<PricesDto>(SalesUri().OriginalString);
        }

        public async Task<PricesDto> Sales(PricingUriParametersBuilder uriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<PricesDto>(SalesUri(uriParametersBuilder).OriginalString);
        }

        public async Task<PricesDto> Days()
        {
            return await _httpHandler.GetJsonAsync<PricesDto>(DaysUri().OriginalString);
        }

        public async Task<PricesDto> Days(PricingUriParametersBuilder uriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<PricesDto>(DaysUri(uriParametersBuilder).OriginalString);
        }

        public async Task<TemplatesDto> Templates()
        {
            return await _httpHandler.GetJsonAsync<TemplatesDto>(TemplatesUri().OriginalString);
        }

        public async Task<TemplatesDto> Templates(PricingUriParametersBuilder uriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<TemplatesDto>(TemplatesUri(uriParametersBuilder).OriginalString);
        }

        public async Task<AssetsDto> Assets()
        {
            return await _httpHandler.GetJsonAsync<AssetsDto>(AssetsUri().OriginalString);
        }

        public async Task<AssetPricingDto> Assets(PricingUriParametersBuilder uriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<AssetPricingDto>(AssetsUri(uriParametersBuilder).OriginalString);
        }

        private Uri SalesUri() => new Uri($"{_requestUriBase}/prices/sales");
        private Uri SalesUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/prices/sales{uriParameterBuilder.Build()}");
        private Uri DaysUri() => new Uri($"{_requestUriBase}/prices/sales/days");
        private Uri DaysUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/prices/sales/days{uriParameterBuilder.Build()}");
        private Uri TemplatesUri() => new Uri($"{_requestUriBase}/prices/templates");
        private Uri TemplatesUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/prices/templates{uriParameterBuilder.Build()}");
        private Uri AssetsUri() => new Uri($"{_requestUriBase}/prices/assets");
        private Uri AssetsUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/prices/assets{uriParameterBuilder.Build()}");
    }
}