using System;
using System.Net.Http;
using AtomicMarketApiClient.Core;

namespace AtomicMarketApiClient.Config
{
    public class ConfigApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal ConfigApi(string baseUrl) => _requestUriBase = baseUrl;

        public ConfigDto Config()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(ConfigUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<ConfigDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        private Uri ConfigUri() => new Uri($"{_requestUriBase}/config");
    }
}
