using System;
using System.Threading.Tasks;

namespace AtomicMarketApiClient.Core.MarketPlaces
{
    public class MarketPlacesApiBase
    {
        private readonly string _requestUriBase;
        private readonly IHttpHandler _httpHandler;

        protected MarketPlacesApiBase(string baseUrl, IHttpHandler httpHandler)
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