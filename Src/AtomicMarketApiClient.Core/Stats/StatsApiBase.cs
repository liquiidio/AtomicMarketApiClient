using System;
using System.Threading.Tasks;

namespace AtomicMarketApiClient.Core.Stats
{
    public class StatsApiBase
    {
        private readonly string _requestUriBase;
        private readonly IHttpHandler _httpHandler;

        protected StatsApiBase(string baseUrl, IHttpHandler httpHandler)
        {
            _requestUriBase = baseUrl;
            _httpHandler = httpHandler;
        }

        public async Task<CollectionsDto> Collections()
        {
            return await _httpHandler.GetJsonAsync<CollectionsDto>(CollectionsUri().OriginalString);
        }

        public async Task<CollectionsDto> Collections(StatsUriParameterBuilder uriParameterBuilder)
        {
            return await _httpHandler.GetJsonAsync<CollectionsDto>(CollectionsUri(uriParameterBuilder).OriginalString);
        }

        public async Task<CollectionDto> Collection(string collectionName, StatsUriParameterBuilder uriParameterBuilder)
        {
            return await _httpHandler.GetJsonAsync<CollectionDto>(CollectionUri(collectionName, uriParameterBuilder).OriginalString);
        }

        public async Task<AccountsDto> Accounts()
        {
            return await _httpHandler.GetJsonAsync<AccountsDto>(AccountsUri().OriginalString);
        }

        public async Task<AccountsDto> Accounts(StatsUriParameterBuilder uriParameterBuilder)
        {
            return await _httpHandler.GetJsonAsync<AccountsDto>(AccountsUri(uriParameterBuilder).OriginalString);
        }

        public async Task<AccountDto> Account(string accountName, StatsUriParameterBuilder uriParameterBuilder)
        {
            return await _httpHandler.GetJsonAsync<AccountDto>(AccountUri(accountName, uriParameterBuilder).OriginalString);
        }

        public async Task<SchemaDto> Schema(string collectionName)
        {
            return await _httpHandler.GetJsonAsync<SchemaDto>(SchemasUri(collectionName).OriginalString);
        }

        public async Task<SchemaDto> Schema(string collectionName, StatsUriParameterBuilder uriParameterBuilder)
        {
            return await _httpHandler.GetJsonAsync<SchemaDto>(SchemasUri(collectionName, uriParameterBuilder).OriginalString);
        }

        public async Task<GraphDto> Graph()
        {
            return await _httpHandler.GetJsonAsync<GraphDto>(GraphUri().OriginalString);
        }

        public async Task<SalesDto> Sales()
        {
            return await _httpHandler.GetJsonAsync<SalesDto>(SalesUri().OriginalString);
        }

        private Uri CollectionsUri() => new Uri($"{_requestUriBase}/stats/collections");
        private Uri CollectionsUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/stats/collections{uriParameterBuilder.Build()}");
        private Uri CollectionUri(string collectionName, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/stats/collections/{collectionName}{uriParameterBuilder.Build()}");
        private Uri AccountsUri() => new Uri($"{_requestUriBase}/stats/accounts");
        private Uri AccountsUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/stats/accounts{uriParameterBuilder.Build()}");
        private Uri AccountUri(string accountName, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/stats/accounts/{accountName}{uriParameterBuilder.Build()}");
        private Uri SchemasUri(string collectionName) => new Uri($"{_requestUriBase}/stats/schemas/{collectionName}");
        private Uri SchemasUri(string collectionName, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/stats/schemas/{collectionName}{uriParameterBuilder.Build()}");
        private Uri GraphUri() => new Uri($"{_requestUriBase}/stats/graph");
        private Uri SalesUri() => new Uri($"{_requestUriBase}/stats/sales");

    }
}