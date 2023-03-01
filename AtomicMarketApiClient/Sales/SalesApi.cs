using System;
using System.Threading.Tasks;

namespace AtomicMarketApiClient.Sales
{
    public class SalesApi
    {
        private readonly string _requestUriBase;
        private readonly IHttpHandler _httpHandler;

        internal SalesApi(string baseUrl, IHttpHandler httpHandler)
        {
            _requestUriBase = baseUrl;
            _httpHandler = httpHandler;
        }

        /// <summary>
        /// It builds an HTTP request, sends it to the API, and returns the response as a SalesDto object
        /// </summary>
        /// <returns>
        /// A SalesDto object
        /// </returns>
        public async Task<SalesDto> Sales()
        {
            return await _httpHandler.GetJsonAsync<SalesDto>(SalesUri().OriginalString);
        }

        /// <summary>
        /// This function will return a `SaleDto` object from the API
        /// </summary>
        /// <param name="id">The id of the sale you want to retrieve.</param>
        /// <returns>
        /// A SaleDto object
        /// </returns>
        public async Task<SaleDto> Sale(int id)
        {
            return await _httpHandler.GetJsonAsync<SaleDto>(SaleUri(id).OriginalString);
        }

        /// <summary>
        /// It returns a SalesDto object.
        /// </summary>
        /// <param name="SalesUriParameterBuilder">This is a class that contains all the parameters that you
        /// want to pass to the API.</param>
        /// <returns>
        /// A SalesDto object.
        /// </returns>
        public async Task<SalesDto> Sales(SalesUriParameterBuilder uriParameterBuilder)
        {
            return await _httpHandler.GetJsonAsync<SalesDto>(SalesUri(uriParameterBuilder).OriginalString);
        }

        /// <summary>
        /// It returns a list of sales.
        /// </summary>
        /// <param name="SalesUriParameterBuilder">This is a class that contains the parameters that will be
        /// used to build the URI.</param>
        /// <returns>
        /// A SalesDto object.
        /// </returns>
        public async Task<SalesDto> SalesByTemplate(SalesUriParameterBuilder uriParameterBuilder)
        {
            return await _httpHandler.GetJsonAsync<SalesDto>(SaleTemplatesUri(uriParameterBuilder).OriginalString);
        }

        /// <summary>
        /// This function will return a list of logs for a specific sales order
        /// </summary>
        /// <param name="id">The id of the sales order you want to get the logs for.</param>
        /// <returns>
        /// A list of logs for a specific sale.
        /// </returns>
        public async Task<LogsDto> SalesLogs(int id)
        {
            return await _httpHandler.GetJsonAsync<LogsDto>(SalesLogsUri(id).OriginalString);
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
        public async Task<LogsDto> SalesLogs(int id, SalesUriParameterBuilder salesUriParameterBuilder)
        {
            return await _httpHandler.GetJsonAsync<LogsDto>(SalesLogsUri(id, salesUriParameterBuilder).OriginalString);
        }

        private Uri SalesUri() => new Uri($"{_requestUriBase}/sales");
        /// <summary>
        /// It takes a `IUriParameterBuilder` as a parameter and returns a `Uri` that is the base
        /// request URI with the `/sales` path and the URI parameters built by the
        /// `IUriParameterBuilder` appended to it.
        /// </summary>
        /// <param name="IUriParameterBuilder">This is an interface that is used to build the query
        /// string parameters for the request.</param>
        private Uri SalesUri(IUriParameterBuilder salesUriParameterBuilder) => new Uri($"{_requestUriBase}/sales{salesUriParameterBuilder.Build()}");
        /// <summary>
        /// It returns a URI for a sale
        /// </summary>
        /// <param name="saleId">The id of the sale to be retrieved.</param>
        private Uri SaleUri(int saleId) => new Uri($"{_requestUriBase}/sales/{saleId}");
        /// <summary>
        /// It returns a URI for the `/sales/templates` endpoint
        /// </summary>
        /// <param name="IUriParameterBuilder">This is a class that is used to build the query string
        /// parameters for the request.</param>
        private Uri SaleTemplatesUri(IUriParameterBuilder salesUriParameterBuilder) => new Uri($"{_requestUriBase}/sales/templates{salesUriParameterBuilder.Build()}");
        /// <summary>
        /// It returns a URI for the sales logs endpoint
        /// </summary>
        /// <param name="saleId">The id of the sale you want to get the logs for.</param>
        private Uri SalesLogsUri(int saleId) => new Uri($"{_requestUriBase}/sales/{saleId}/logs");
        /// <summary>
        /// It returns a URI for the sales logs endpoint
        /// </summary>
        /// <param name="saleId">The id of the sale you want to get the logs for.</param>
        /// <param name="IUriParameterBuilder">This is an interface that is used to build the query
        /// string parameters for the request.</param>
        private Uri SalesLogsUri(int saleId, IUriParameterBuilder salesUriParameterBuilder) => new Uri($"{_requestUriBase}/sales/{saleId}{salesUriParameterBuilder.Build()}");
    }
}