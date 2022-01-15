using System;
using System.Net.Http;
using AtomicMarketApiClient.Core;

namespace AtomicMarketApiClient.MarketPlaces
{
    public class MarketPlacesApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal MarketPlacesApi(string baseUrl) => _requestUriBase = baseUrl;

        public MarketplacesDto Marketplaces()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(MarketplacesUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<MarketplacesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public MarketplaceDto Marketplace(string name)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(MarketplaceUri(name)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<MarketplaceDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }


        private Uri MarketplacesUri() => new Uri($"{_requestUriBase}/marketplaces");
        private Uri MarketplaceUri(string name) => new Uri($"{_requestUriBase}/marketplaces/{name}");
    }
}