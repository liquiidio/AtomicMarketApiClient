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

        public SalesDto Sales()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SalesUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<SalesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public SaleDto Sale(int id)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SaleUri(id)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<SaleDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public SalesDto Sales(SalesUriParameterBuilder uriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SalesUri(uriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<SalesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public SalesDto SalesByTemplate(SalesUriParameterBuilder uriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SaleTemplatesUri(uriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<SalesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public LogsDto SalesLogs(int id)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SalesLogsUri(id)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

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
