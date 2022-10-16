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

        public PricesDto Sales()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SalesUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<PricesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public PricesDto Sales(PricingUriParametersBuilder uriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SalesUri(uriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<PricesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public PricesDto Days()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(DaysUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<PricesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public PricesDto Days(PricingUriParametersBuilder uriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(DaysUri(uriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<PricesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public TemplatesDto Templates()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(TemplatesUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<TemplatesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public TemplatesDto Templates(PricingUriParametersBuilder uriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(TemplatesUri(uriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<TemplatesDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public AssetsDto Assets()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AssetsUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AssetsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public AssetPricingDto Assets(PricingUriParametersBuilder uriParametersBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AssetsUri(uriParametersBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AssetPricingDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        private Uri SalesUri() => new Uri($"{_requestUriBase}/prices/sales");
        private Uri SalesUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/prices/sales{uriParameterBuilder.Build()}");
        private Uri DaysUri() => new Uri($"{_requestUriBase}/prices/sales/days");
        private Uri DaysUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/prices/sales/days{uriParameterBuilder.Build()}");
        private Uri TemplatesUri() => new Uri($"{_requestUriBase}/prices/templates");
        private Uri TemplatesUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/prices/templates{uriParameterBuilder.Build()}");
        private Uri AssetsUri() => new Uri($"{_requestUriBase}/prices/assets");
        private Uri AssetsUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/prices/assets{uriParameterBuilder.Build()}");
    }
}