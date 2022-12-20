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

        /// <summary>
        /// It returns a URI that points to the collections endpoint of the stats API
        /// </summary>
        private Uri CollectionsUri() => new Uri($"{_requestUriBase}/stats/collections");
        /// <summary>
        /// > It returns a URI for the collections endpoint
        /// </summary>
        /// <param name="IUriParameterBuilder">This is a class that is used to build the query string
        /// parameters for the request.</param>
        private Uri CollectionsUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/stats/collections{uriParameterBuilder.Build()}");
        /// <summary>
        /// > It returns a URI for the collection stats endpoint
        /// </summary>
        /// <param name="collectionName">The name of the collection you want to get stats for.</param>
        /// <param name="IUriParameterBuilder">This is an interface that is used to build the query
        /// string parameters for the request.</param>
        private Uri CollectionUri(string collectionName, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/stats/collections/{collectionName}{uriParameterBuilder.Build()}");
        /// <summary>
        /// It returns a `Uri` object that represents the URL for the `/stats/accounts` endpoint
        /// </summary>
        private Uri AccountsUri() => new Uri($"{_requestUriBase}/stats/accounts");
        /// <summary>
        /// > It returns a URI for the `/stats/accounts` endpoint
        /// </summary>
        /// <param name="IUriParameterBuilder">This is a class that will build the query string
        /// parameters for the request.</param>
        private Uri AccountsUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/stats/accounts{uriParameterBuilder.Build()}");
        /// <summary>
        /// > It returns a URI for the account stats endpoint
        /// </summary>
        /// <param name="accountName">The name of the account you want to get stats for.</param>
        /// <param name="IUriParameterBuilder">This is an interface that is used to build the query
        /// string parameters for the request.</param>
        private Uri AccountUri(string accountName, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/stats/accounts/{accountName}{uriParameterBuilder.Build()}");
        /// <summary>
        /// It returns a URI for the schemas endpoint
        /// </summary>
        /// <param name="collectionName">The name of the collection you want to get the stats
        /// for.</param>
        private Uri SchemasUri(string collectionName) => new Uri($"{_requestUriBase}/stats/schemas/{collectionName}");
        /// <summary>
        /// > It returns a URI for the `/stats/schemas/{collectionName}` endpoint
        /// </summary>
        /// <param name="collectionName">The name of the collection you want to get the schema
        /// for.</param>
        /// <param name="IUriParameterBuilder">This is a class that is used to build the query string
        /// parameters for the request.</param>
        private Uri SchemasUri(string collectionName, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/stats/schemas/{collectionName}{uriParameterBuilder.Build()}");
        /// <summary>
        /// It returns a new Uri object that is the base request URI with the /stats/graph path appended
        /// to it
        /// </summary>
        private Uri GraphUri() => new Uri($"{_requestUriBase}/stats/graph");
        /// <summary>
        /// It returns a new Uri object that is the base request Uri with the `/stats/sales` path
        /// appended to it.
        /// </summary>
        private Uri SalesUri() => new Uri($"{_requestUriBase}/stats/sales");

    }
}