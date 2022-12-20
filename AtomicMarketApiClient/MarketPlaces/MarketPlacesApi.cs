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

/// <summary>
/// This function will return a list of marketplaces that are available to the user
/// </summary>
/// <returns>
/// A list of marketplaces.
/// </returns>
        public MarketplacesDto Marketplaces()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(MarketplacesUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<MarketplacesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

/// <summary>
/// This function will return a `MarketplaceDto` object from the API
/// </summary>
/// <param name="name">The name of the marketplace you want to retrieve.</param>
/// <returns>
/// A MarketplaceDto object
/// </returns>
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