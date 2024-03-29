﻿using AtomicMarketApiClient.Assets;
using System;
using System.Threading.Tasks;

namespace AtomicMarketApiClient.Pricing
{
    public class PricingApi
    {
        private readonly string _requestUriBase;
        private readonly IHttpHandler _httpHandler;

        internal PricingApi(string baseUrl, IHttpHandler httpHandler)
        {
            _requestUriBase = baseUrl;
            _httpHandler = httpHandler;
        }

        /// <summary>
        /// This function will return a list of prices for all the sales that have been made
        /// </summary>
        /// <returns>
        /// A list of prices for the sales of the product.
        /// </returns>
        public async Task<PricesDto> Sales()
        {
            return await _httpHandler.GetJsonAsync<PricesDto>(SalesUri().OriginalString);
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
        public async Task<PricesDto> Sales(PricingUriParametersBuilder uriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<PricesDto>(SalesUri(uriParametersBuilder).OriginalString);
        }

        /// <summary>
        /// This function will return a list of prices for the last 30 days
        /// </summary>
        /// <returns>
        /// A list of prices for the last 30 days.
        /// </returns>
        public async Task<PricesDto> Days()
        {
            return await _httpHandler.GetJsonAsync<PricesDto>(DaysUri().OriginalString);
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
        public async Task<PricesDto> Days(PricingUriParametersBuilder uriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<PricesDto>(DaysUri(uriParametersBuilder).OriginalString);
        }


        /// <summary>
        /// This function will return a list of templates that are available for use
        /// </summary>
        /// <returns>
        /// A list of templates
        /// </returns>
        public async Task<TemplatesDto> Templates()
        {
            return await _httpHandler.GetJsonAsync<TemplatesDto>(TemplatesUri().OriginalString);
        }

        /// <summary>
        /// This function will return a list of templates that are available for the given parameters
        /// </summary>
        /// <param name="PricingUriParametersBuilder">This is a class that contains the parameters that are
        /// required to make the request.</param>
        /// <returns>
        /// A TemplatesDto object.
        /// </returns>
        public async Task<TemplatesDto> Templates(PricingUriParametersBuilder uriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<TemplatesDto>(TemplatesUri(uriParametersBuilder).OriginalString);
        }


        /// <summary>
        /// This function will return a list of all the assets that are available for trading on the exchange
        /// </summary>
        /// <returns>
        /// A list of assets.
        /// </returns>
        public async Task<AssetsDto> Assets()
        {
            return await _httpHandler.GetJsonAsync<AssetsDto>(AssetsUri().OriginalString);
        }


        /// <summary>
        /// This function will return a list of assets that are available for pricing
        /// </summary>
        /// <param name="PricingUriParametersBuilder">This is a class that contains all the parameters that can
        /// be passed to the API.</param>
        /// <returns>
        /// A list of assets.
        /// </returns>
        public async Task<AssetPricingDto> Assets(PricingUriParametersBuilder uriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<AssetPricingDto>(AssetsUri(uriParametersBuilder).OriginalString);
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