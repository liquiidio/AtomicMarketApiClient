using System;
using System.Net.Http;
using AtomicMarketApiClient.Core;

namespace AtomicMarketApiClient.Auctions
{
    public class AuctionsApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal AuctionsApi(string baseUrl) => _requestUriBase = baseUrl;

        public AuctionsDto Auctions()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AuctionsUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AuctionsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public AuctionsDto Auctions(AuctionsUriParameterBuilder uriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AuctionsUri(uriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AuctionsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public AuctionDto Auction(int id)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AuctionUri(id)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AuctionDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public LogsDto AuctionLogs(int id)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AuctionsLogsUri(id)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public LogsDto AuctionLogs(int id, AuctionsUriParameterBuilder auctionsUriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AuctionsLogsUri(id, auctionsUriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        private Uri AuctionsUri() => new Uri($"{_requestUriBase}/auctions");
        private Uri AuctionsUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/auctions{uriParameterBuilder.Build()}");
        private Uri AuctionUri(int id) => new Uri($"{_requestUriBase}/auctions/{id}");
        private Uri AuctionsLogsUri(int id) => new Uri($"{_requestUriBase}/auctions/{id}/logs");
        private Uri AuctionsLogsUri(int id, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/auctions/{id}{uriParameterBuilder.Build()}");
    }
}