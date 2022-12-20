using System;
using System.Net.Http;
using AtomicMarketApiClient.Assets;
using AtomicMarketApiClient.Core;

namespace AtomicMarketApiClient.Pricing
{
    public class PricingApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal PricingApi(string baseUrl) => _requestUriBase = baseUrl;

        /// <summary>
        /// This function will return a list of prices for all the sales that have been made
        /// </summary>
        /// <returns>
        /// A list of prices for the sales of the product.
        /// </returns>
        public PricesDto Sales()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SalesUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<PricesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// This function will return a list of prices for a given product, based on the parameters passed in
        /// the uriParametersBuilder
        /// </summary>
        /// <param name="PricingUriParametersBuilder">This is a class that contains the parameters that will be
        /// passed to the API.</param>
        /// <returns>
        /// A list of prices for the given parameters.
        /// </returns>
        public PricesDto Sales(PricingUriParametersBuilder uriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SalesUri(uriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<PricesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// This function will return a list of prices for the last 30 days
        /// </summary>
        /// <returns>
        /// A list of prices for the last 30 days.
        /// </returns>
        public PricesDto Days()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(DaysUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<PricesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// This function will return a `PricesDto` object that contains the prices for the specified date
        /// range
        /// </summary>
        /// <param name="PricingUriParametersBuilder">This is a class that contains the parameters that are
        /// required to make the request.</param>
        /// <returns>
        /// A list of prices for the given date range.
        /// </returns>
        public PricesDto Days(PricingUriParametersBuilder uriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(DaysUri(uriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<PricesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// This function will return a list of templates that are available for use
        /// </summary>
        /// <returns>
        /// A list of templates
        /// </returns>
        public TemplatesDto Templates()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(TemplatesUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<TemplatesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// This function will return a list of templates that are available for the given parameters
        /// </summary>
        /// <param name="PricingUriParametersBuilder">This is a class that contains the parameters that are
        /// required to make the request.</param>
        /// <returns>
        /// A TemplatesDto object.
        /// </returns>
        public TemplatesDto Templates(PricingUriParametersBuilder uriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(TemplatesUri(uriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<TemplatesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// This function will return a list of all the assets that are available for trading on the exchange
        /// </summary>
        /// <returns>
        /// A list of assets.
        /// </returns>
        public AssetsDto Assets()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AssetsUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AssetsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// This function will return a list of assets that are available for pricing
        /// </summary>
        /// <param name="PricingUriParametersBuilder">This is a class that contains all the parameters that can
        /// be passed to the API.</param>
        /// <returns>
        /// A list of assets.
        /// </returns>
        public AssetsDto Assets(PricingUriParametersBuilder uriParametersBuilder)
        public AssetPricingDto Assets(PricingUriParametersBuilder uriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AssetsUri(uriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AssetPricingDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        /// <summary>
        /// It returns a `Uri` object that is the base URI for the sales endpoint
        /// </summary>
        private Uri SalesUri() => new Uri($"{_requestUriBase}/prices/sales");
        /// <summary>
        /// It returns a URI for the sales endpoint
        /// </summary>
        /// <param name="IUriParameterBuilder">This is an interface that is used to build the query
        /// string parameters for the request.</param>
        private Uri SalesUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/prices/sales{uriParameterBuilder.Build()}");
        /// <summary>
        /// It returns a `Uri` object that represents the URL for the API endpoint that returns the
        /// sales data for the last 30 days
        /// </summary>
        private Uri DaysUri() => new Uri($"{_requestUriBase}/prices/sales/days");
        /// <summary>
        /// It returns a URI for the `/prices/sales/days` endpoint
        /// </summary>
        /// <param name="IUriParameterBuilder">This is an interface that is used to build the query
        /// string parameters for the request.</param>
        private Uri DaysUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/prices/sales/days{uriParameterBuilder.Build()}");
        /// <summary>
        /// It returns a `Uri` object that represents the URL of the API endpoint that returns the list
        /// of templates
        /// </summary>
        private Uri TemplatesUri() => new Uri($"{_requestUriBase}/prices/templates");
        /// <summary>
        /// > It returns a URI for the `/prices/templates` endpoint
        /// </summary>
        /// <param name="IUriParameterBuilder">This is a class that is used to build the query string
        /// parameters for the request.</param>
        private Uri TemplatesUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/prices/templates{uriParameterBuilder.Build()}");
        /// <summary>
        /// It returns a `Uri` object that points to the `/prices/assets` endpoint
        /// </summary>
        private Uri AssetsUri() => new Uri($"{_requestUriBase}/prices/assets");
        /// <summary>
        /// It returns a URI for the `/prices/assets` endpoint
        /// </summary>
        /// <param name="IUriParameterBuilder">This is a class that is used to build the query string
        /// parameters for the request.</param>
        private Uri AssetsUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/prices/assets{uriParameterBuilder.Build()}");
    }
}