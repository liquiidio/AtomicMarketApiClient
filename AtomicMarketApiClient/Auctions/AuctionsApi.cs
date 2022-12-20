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

        /// <summary>  
        /// It returns a list of auctions.
        /// </summary>
        /// <return>
        /// AuctionsDto
        /// </return> 
        public AuctionsDto Auctions()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AuctionsUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AuctionsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// It returns a list of auctions.
        /// </summary>
        /// <param name = "AuctionsUriParameterBuilder" >This is a class that contains all the parameters that can
        /// be passed to the API.</param>
        /// <return>
        /// AuctionsDto
        /// </return>
        public AuctionsDto Auctions(AuctionsUriParameterBuilder uriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AuctionsUri(uriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AuctionsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// > This function will make a GET request to the Auction API and return the AuctionDto object
        /// </summary>
        /// <param name="id">The id of the auction you want to retrieve</param>
        /// <returns>
        /// An AuctionDto object
        /// </returns>
        public AuctionDto Auction(int id)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AuctionUri(id)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AuctionDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// It gets the logs of an auction.
        /// </summary>
        /// <param name="id">The id of the auction you want to get the logs for.</param>
        /// <returns>
        /// A list of logs for the auction.
        /// </returns>
        public LogsDto AuctionLogs(int id)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AuctionsLogsUri(id)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// It gets the logs for an auction.
        /// </summary>
        /// <param name="id">The id of the auction you want to get the logs for.</param>
        /// <param name="AuctionsUriParameterBuilder">This is a class that contains all the parameters
        /// that can be passed to the API.</param>
        /// <returns>
        /// A LogsDto object.
        /// </returns>
        public LogsDto AuctionLogs(int id, AuctionsUriParameterBuilder auctionsUriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AuctionsLogsUri(id, auctionsUriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// It returns a new Uri object that is the base request URI with the /auctions path appended to
        /// it
        /// </summary>
        private Uri AuctionsUri() => new Uri($"{_requestUriBase}/auctions");
        /// <summary>
        /// It takes a `IUriParameterBuilder` and returns a `Uri` that is the base URI for the auctions
        /// endpoint with the parameters built by the `IUriParameterBuilder` appended to the end.
        /// </summary>
        /// <param name="IUriParameterBuilder">This is an interface that is used to build the query
        /// string parameters for the request.</param>
        private Uri AuctionsUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/auctions{uriParameterBuilder.Build()}");
        /// <summary>
        /// It returns a URI for the auction with the given ID
        /// </summary>
        /// <param name="id">The id of the auction you want to get.</param>
        private Uri AuctionUri(int id) => new Uri($"{_requestUriBase}/auctions/{id}");
        /// <summary>
        /// > It returns a `Uri` object that represents the URL for the auction logs endpoint
        /// </summary>
        /// <param name="id">The id of the auction you want to get the logs for.</param>
        private Uri AuctionsLogsUri(int id) => new Uri($"{_requestUriBase}/auctions/{id}/logs");
        /// <summary>
        /// > It returns a URI for the auctions logs endpoint
        /// </summary>
        /// <param name="id">The id of the auction you want to get the logs for.</param>
        /// <param name="IUriParameterBuilder">This is an interface that is used to build the query
        /// string parameters.</param>
        private Uri AuctionsLogsUri(int id, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/auctions/{id}{uriParameterBuilder.Build()}");
    }
}