using System;
using System.Threading.Tasks;

namespace AtomicMarketApiClient.MarketPlaces
{
    public class MarketPlacesApi
    {
        private readonly string _requestUriBase;
        private readonly IHttpHandler _httpHandler;

        internal MarketPlacesApi(string baseUrl, IHttpHandler httpHandler)
        {
            _requestUriBase = baseUrl;
            _httpHandler = httpHandler;
        }

        public async Task<MarketplacesDto> Marketplaces()
        {
            return await _httpHandler.GetJsonAsync<MarketplacesDto>(MarketplacesUri().OriginalString);
        }

        public async Task<MarketplaceDto> Marketplace(string name)
        {
            return await _httpHandler.GetJsonAsync<MarketplaceDto>(MarketplaceUri(name).OriginalString);
        }


        private Uri MarketplacesUri() => new Uri($"{_requestUriBase}/marketplaces");
        private Uri MarketplaceUri(string name) => new Uri($"{_requestUriBase}/marketplaces/{name}");
    }
}