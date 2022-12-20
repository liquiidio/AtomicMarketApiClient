﻿using System;
using System.Net.Http;
using AtomicMarketApiClient.Core;

namespace AtomicMarketApiClient.Transfers
{
    public class TransfersApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal TransfersApi(string baseUrl) => _requestUriBase = baseUrl;

/// <summary>
/// This function will return a list of all transfers for the current user
/// </summary>
/// <returns>
/// A list of transfers
/// </returns>
        public TransfersDto Transfers()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(TransfersUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<TransfersDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

/// <summary>
/// It returns a list of transfers.
/// </summary>
/// <param name="TransfersUriParameterBuilder">This is a class that contains all the parameters that can
/// be passed to the API.</param>
/// <returns>
/// A TransfersDto object.
/// </returns>
        public TransfersDto Transfers(TransfersUriParameterBuilder transfersUriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(TransfersUri(transfersUriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<TransfersDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        private Uri TransfersUri() => new Uri($"{_requestUriBase}/transfers");
        private Uri TransfersUri(TransfersUriParameterBuilder transfersUriParameterBuilder) => new Uri($"{_requestUriBase}/transfers{transfersUriParameterBuilder.Build()}");
    }
}