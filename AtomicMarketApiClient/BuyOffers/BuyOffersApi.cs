using System;
using System.Net.Http;
using AtomicMarketApiClient.Core;

namespace AtomicMarketApiClient.BuyOffers
{
    public class BuyOffersApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal BuyOffersApi(string baseUrl) => _requestUriBase = baseUrl;

        public BuyOffersDto BuyOffers()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(BuyOffersUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<BuyOffersDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public BuyOffersDto BuyOffers(BuyOffersUriParameterBuilder uriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(BuyOffersUri((IUriParameterBuilder) uriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<BuyOffersDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public BuyOfferDto BuyOffer(int id)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(BuyOffersUri(id)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<BuyOfferDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public LogsDto BuyOffersLogs(int id)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(BuyOffersLogsUri(id)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public LogsDto BuyOffersLogs(int id, BuyOffersUriParameterBuilder uriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(BuyOffersLogsUri(id, uriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        private Uri BuyOffersUri() => new Uri($"{_requestUriBase}/buyoffers");
        private Uri BuyOffersUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/buyoffers{uriParameterBuilder.Build()}");
        private Uri BuyOffersUri(int id) => new Uri($"{_requestUriBase}/buyoffers/{id}");
        private Uri BuyOffersLogsUri(int id) => new Uri($"{_requestUriBase}/buyoffers/{id}/logs");
        private Uri BuyOffersLogsUri(int id, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/buyoffers/{id}{uriParameterBuilder.Build()}");
    }
}