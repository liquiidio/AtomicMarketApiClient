using System;
using System.Net.Http;
using AtomicMarketApiClient.Core;

namespace AtomicMarketApiClient.Stats
{
    public class StatsApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal StatsApi(string baseUrl) => _requestUriBase = baseUrl;

        public CollectionsDto Collections()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionsUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<CollectionsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public CollectionsDto Collections(StatsUriParameterBuilder uriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionsUri(uriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<CollectionsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public CollectionDto Collection(string collectionName, StatsUriParameterBuilder uriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionUri(collectionName, uriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<CollectionDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public AccountsDto Accounts()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AccountsUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AccountsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public AccountsDto Accounts(StatsUriParameterBuilder uriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AccountsUri(uriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AccountsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public AccountDto Account(string accountName, StatsUriParameterBuilder uriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AccountUri(accountName, uriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AccountDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public SchemaDto Schema(string collectionName)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SchemasUri(collectionName)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<SchemaDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public SchemaDto Schema(string collectionName, StatsUriParameterBuilder uriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SchemasUri(collectionName, uriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<SchemaDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public GraphDto Graph()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(GraphUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<GraphDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public SalesDto Sales()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SalesUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<SalesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        private Uri CollectionsUri() => new Uri($"{_requestUriBase}/stats/collections");
        private Uri CollectionsUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/stats/collections{uriParameterBuilder.Build()}");
        private Uri CollectionUri(string collectionName, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/stats/collections/{collectionName}{uriParameterBuilder.Build()}");
        private Uri AccountsUri() => new Uri($"{_requestUriBase}/stats/accounts");
        private Uri AccountsUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/stats/accounts{uriParameterBuilder.Build()}");
        private Uri AccountUri(string accountName, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/stats/accounts/{accountName}{uriParameterBuilder.Build()}");
        private Uri SchemasUri(string collectionName) => new Uri($"{_requestUriBase}/stats/schemas/{collectionName}");
        private Uri SchemasUri(string collectionName, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/stats/schemas/{collectionName}{uriParameterBuilder.Build()}");
        private Uri GraphUri() => new Uri($"{_requestUriBase}/stats/graph");
        private Uri SalesUri() => new Uri($"{_requestUriBase}/stats/sales");

    }
}