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

/// <summary>
/// This function will return a list of all collections in the database
/// </summary>
/// <returns>
/// A list of collections
/// </returns>
        public CollectionsDto Collections()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionsUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<CollectionsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

/// <summary>
/// This function will return a `CollectionsDto` object that contains a list of `CollectionDto`
/// objects
/// </summary>
/// <param name="StatsUriParameterBuilder">This is a class that contains all the parameters that can be
/// passed to the API.</param>
/// <returns>
/// A CollectionsDto object.
/// </returns>
        public CollectionsDto Collections(StatsUriParameterBuilder uriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionsUri(uriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<CollectionsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

/// <summary>
/// This function will return a `CollectionDto` object that contains the collection's name, the number
/// of documents in the collection, the number of documents that have been deleted, the number of
/// documents that are new (i.e. have not been persisted to disk), the number of documents that have
/// been updated, the number of documents that have been replaced, the number of documents that have
/// been removed, the number of documents that have been inserted, the number of documents that have
/// been ignored, the number of documents that have been updated, the number of documents that have been
/// replaced, the number of documents that have been removed, the number of documents that have been
/// inserted, the number of documents that have been ignored, the number of documents that have been
/// updated, the number of documents that have been replaced, the number of documents that have been
/// removed, the number of documents that have been inserted, the number of documents that have been
/// ignored, the number of documents that have been
/// </summary>
/// <param name="collectionName">The name of the collection you want to get stats for.</param>
/// <param name="StatsUriParameterBuilder">This is a class that allows you to build the query string
/// parameters for the API call.</param>
/// <returns>
/// A collection of documents.
/// </returns>
        public CollectionDto Collection(string collectionName, StatsUriParameterBuilder uriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionUri(collectionName, uriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<CollectionDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

/// <summary>
/// This function will return a list of accounts for the current user
/// </summary>
/// <returns>
/// A list of accounts
/// </returns>
        public AccountsDto Accounts()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AccountsUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AccountsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

/// <summary>
/// This function will return a list of accounts that match the criteria specified in the
/// `uriParameterBuilder` parameter
/// </summary>
/// <param name="StatsUriParameterBuilder">This is a class that contains all the parameters that can be
/// passed to the API.</param>
/// <returns>
/// A list of accounts.
/// </returns>
        public AccountsDto Accounts(StatsUriParameterBuilder uriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AccountsUri(uriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AccountsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

/// <summary>
/// This function will return an AccountDto object that contains the account information for the
/// account name passed in
/// </summary>
/// <param name="accountName">The name of the account you want to get information about.</param>
/// <param name="StatsUriParameterBuilder">This is a class that allows you to build the query string
/// parameters for the API call.</param>
/// <returns>
/// An AccountDto object.
/// </returns>
        public AccountDto Account(string accountName, StatsUriParameterBuilder uriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AccountUri(accountName, uriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AccountDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

/// <summary>
/// This function will return the schema for the specified collection
/// </summary>
/// <param name="collectionName">The name of the collection you want to get the schema for.</param>
/// <returns>
/// A SchemaDto object
/// </returns>
        public SchemaDto Schema(string collectionName)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SchemasUri(collectionName)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<SchemaDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

/// <summary>
/// This function returns a schema for a given collection
/// </summary>
/// <param name="collectionName">The name of the collection you want to get the schema for.</param>
/// <param name="StatsUriParameterBuilder">This is a class that contains all the parameters that can be
/// passed to the API.</param>
/// <returns>
/// A SchemaDto object.
/// </returns>
        public SchemaDto Schema(string collectionName, StatsUriParameterBuilder uriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SchemasUri(collectionName, uriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<SchemaDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

/// <summary>
/// This function will return a `GraphDto` object that contains the graph data
/// </summary>
/// <returns>
/// A GraphDto object
/// </returns>
        public GraphDto Graph()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(GraphUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<GraphDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

/// <summary>
/// The function sends a GET request to the API and returns the response as a SalesDto object
/// </summary>
/// <returns>
/// A SalesDto object
/// </returns>
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