using System;
using System.Threading.Tasks;

namespace AtomicMarketApiClient.Core.Sales
{
    public class SalesApiBase
    {
        private readonly string _requestUriBase;
        private readonly IHttpHandler _httpHandler;

        protected SalesApiBase(string baseUrl, IHttpHandler httpHandler)
        {
            _requestUriBase = baseUrl;
            _httpHandler = httpHandler;
        }

        public async Task<SalesDto> Sales()
        {
            return await _httpHandler.GetJsonAsync<SalesDto>(SalesUri().OriginalString);
        }

        public async Task<SaleDto> Sale(int id)
        {
            return await _httpHandler.GetJsonAsync<SaleDto>(SaleUri(id).OriginalString);
        }

        public async Task<SalesDto> Sales(SalesUriParameterBuilder uriParameterBuilder)
        {
            return await _httpHandler.GetJsonAsync<SalesDto>(SalesUri(uriParameterBuilder).OriginalString);
        }

        public async Task<SalesDto> SalesByTemplate(SalesUriParameterBuilder uriParameterBuilder)
        {
            return await _httpHandler.GetJsonAsync<SalesDto>(SaleTemplatesUri(uriParameterBuilder).OriginalString);
        }

        public async Task<LogsDto> SalesLogs(int id)
        {
            return await _httpHandler.GetJsonAsync<LogsDto>(SalesLogsUri(id).OriginalString);
        }

        public async Task<LogsDto> SalesLogs(int id, SalesUriParameterBuilder salesUriParameterBuilder)
        {
            return await _httpHandler.GetJsonAsync<LogsDto>(SalesLogsUri(id, salesUriParameterBuilder).OriginalString);
        }

        private Uri SalesUri() => new Uri($"{_requestUriBase}/sales");
        private Uri SalesUri(IUriParameterBuilder salesUriParameterBuilder) => new Uri($"{_requestUriBase}/sales{salesUriParameterBuilder.Build()}");
        private Uri SaleUri(int saleId) => new Uri($"{_requestUriBase}/sales/{saleId}");
        private Uri SaleTemplatesUri(IUriParameterBuilder salesUriParameterBuilder) => new Uri($"{_requestUriBase}/sales/templates{salesUriParameterBuilder.Build()}");
        private Uri SalesLogsUri(int saleId) => new Uri($"{_requestUriBase}/sales/{saleId}/logs");
        private Uri SalesLogsUri(int saleId, IUriParameterBuilder salesUriParameterBuilder) => new Uri($"{_requestUriBase}/sales/{saleId}{salesUriParameterBuilder.Build()}");
    }
}