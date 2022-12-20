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

        /// <summary>
        /// This function will return a list of buy offers for a given market
        /// </summary>
        /// <returns>
        /// A list of buy offers.
        /// </returns>
        public BuyOffersDto BuyOffers()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(BuyOffersUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<BuyOffersDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// It takes a `BuyOffersUriParameterBuilder` object as a parameter, builds a `HttpRequestMessage`
        /// object, sends it to the API, and returns a `BuyOffersDto` object
        /// </summary>
        /// <param name="BuyOffersUriParameterBuilder">This is a class that inherits from the
        /// IUriParameterBuilder interface. This interface is used to build the query string parameters for the
        /// API call.</param>
        /// <returns>
        /// A BuyOffersDto object.
        /// </returns>
        public BuyOffersDto BuyOffers(BuyOffersUriParameterBuilder uriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(BuyOffersUri((IUriParameterBuilder) uriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<BuyOffersDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// This function will return a BuyOfferDto object from the API
        /// </summary>
        /// <param name="id">The id of the buy offer you want to retrieve.</param>
        /// <returns>
        /// A BuyOfferDto object
        /// </returns>
        public BuyOfferDto BuyOffer(int id)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(BuyOffersUri(id)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<BuyOfferDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// This function returns a list of logs for a specific buy offer
        /// </summary>
        /// <param name="id">The id of the buy offer.</param>
        /// <returns>
        /// A list of logs for the buy offer with the given id.
        /// </returns>
        public LogsDto BuyOffersLogs(int id)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(BuyOffersLogsUri(id)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// This function returns a list of logs for a specific buy offer
        /// </summary>
        /// <param name="id">The id of the buy offer</param>
        /// <param name="BuyOffersUriParameterBuilder">This is a class that contains all the parameters that can
        /// be passed to the API.</param>
        /// <returns>
        /// A list of logs for the buy offer.
        /// </returns>
        public LogsDto BuyOffersLogs(int id, BuyOffersUriParameterBuilder uriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(BuyOffersLogsUri(id, uriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// It returns a URI that points to the buy offers endpoint
        /// </summary>
        private Uri BuyOffersUri() => new Uri($"{_requestUriBase}/buyoffers");
        /// <summary>
        /// It returns a URI for the buy offers endpoint
        /// </summary>
        /// <param name="IUriParameterBuilder">This is an interface that is used to build the query
        /// string parameters for the request.</param>
        private Uri BuyOffersUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/buyoffers{uriParameterBuilder.Build()}");
        /// <summary>
        /// It returns a URI for a specific buy offer
        /// </summary>
        /// <param name="id">The id of the buy offer you want to get.</param>
        private Uri BuyOffersUri(int id) => new Uri($"{_requestUriBase}/buyoffers/{id}");
        /// <summary>
        /// It returns a URI for the buy offer logs endpoint
        /// </summary>
        /// <param name="id">The id of the buy offer you want to get the logs for.</param>
        private Uri BuyOffersLogsUri(int id) => new Uri($"{_requestUriBase}/buyoffers/{id}/logs");
        /// <summary>
        /// > This function returns a URI for the BuyOffersLogs endpoint
        /// </summary>
        /// <param name="id">The id of the buy offer you want to get the logs for.</param>
        /// <param name="IUriParameterBuilder">This is an interface that is used to build the query
        /// string parameters.</param>
        private Uri BuyOffersLogsUri(int id, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/buyoffers/{id}{uriParameterBuilder.Build()}");
        }
}