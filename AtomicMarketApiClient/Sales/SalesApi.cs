using System;
using System.Net.Http;
using AtomicMarketApiClient.Core;

namespace AtomicMarketApiClient.Sales
{
    public class SalesApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal SalesApi(string baseUrl) => _requestUriBase = baseUrl;

/// <summary>
/// > It builds an HTTP request, sends it to the API, and returns the response as a SalesDto object
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
/// > This function will return a `SaleDto` object from the API
/// </summary>
/// <param name="id">The id of the sale you want to retrieve.</param>
/// <returns>
/// A SaleDto object
/// </returns>
        public SaleDto Sale(int id)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SaleUri(id)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<SaleDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

/// <summary>
/// It returns a SalesDto object.
/// </summary>
/// <param name="SalesUriParameterBuilder">This is a class that contains all the parameters that you
/// want to pass to the API.</param>
/// <returns>
/// A SalesDto object.
/// </returns>
        public SalesDto Sales(SalesUriParameterBuilder uriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SalesUri(uriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<SalesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

/// <summary>
/// It returns a list of sales.
/// </summary>
/// <param name="SalesUriParameterBuilder">This is a class that contains the parameters that will be
/// used to build the URI.</param>
/// <returns>
/// A SalesDto object.
/// </returns>
        public SalesDto SalesByTemplate(SalesUriParameterBuilder uriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SaleTemplatesUri(uriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<SalesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

/// <summary>
/// This function will return a list of logs for a specific sales order
/// </summary>
/// <param name="id">The id of the sales order you want to get the logs for.</param>
/// <returns>
/// A list of logs for a specific sale.
/// </returns>
        public LogsDto SalesLogs(int id)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SalesLogsUri(id)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

/// <summary>
/// This function returns a list of logs for a specific sales order
/// </summary>
/// <param name="id">The id of the sales order</param>
/// <param name="SalesUriParameterBuilder">This is a class that contains all the parameters that can be
/// passed to the API.</param>
/// <returns>
/// A LogsDto object
/// </returns>
        public LogsDto SalesLogs(int id, SalesUriParameterBuilder salesUriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SalesLogsUri(id, salesUriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }


        private Uri SalesUri() => new Uri($"{_requestUriBase}/sales");
        private Uri SalesUri(IUriParameterBuilder salesUriParameterBuilder) => new Uri($"{_requestUriBase}/sales{salesUriParameterBuilder.Build()}");
        private Uri SaleUri(int saleId) => new Uri($"{_requestUriBase}/sales/{saleId}");
        private Uri SaleTemplatesUri(IUriParameterBuilder salesUriParameterBuilder) => new Uri($"{_requestUriBase}/sales/templates{salesUriParameterBuilder.Build()}");
        private Uri SalesLogsUri(int saleId) => new Uri($"{_requestUriBase}/sales/{saleId}/logs");
        private Uri SalesLogsUri(int saleId, IUriParameterBuilder salesUriParameterBuilder) => new Uri($"{_requestUriBase}/sales/{saleId}{salesUriParameterBuilder.Build()}");
    }
}
