using System;
using System.Threading.Tasks;

namespace AtomicMarketApiClient.BuyOffers
{
    public class BuyOffersApi
    {
        private readonly string _requestUriBase;
        private readonly IHttpHandler _httpHandler;

        internal BuyOffersApi(string baseUrl, IHttpHandler httpHandler)
        {
            _requestUriBase = baseUrl;
            _httpHandler = httpHandler;
        }

        public async Task<BuyOffersDto> BuyOffers()
        {
            return await _httpHandler.GetJsonAsync<BuyOffersDto>(BuyOffersUri().OriginalString);
        }

        public async Task<BuyOffersDto> BuyOffers(BuyOffersUriParameterBuilder uriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<BuyOffersDto>(BuyOffersUri((IUriParameterBuilder)uriParametersBuilder).OriginalString);
        }

        public async Task<BuyOfferDto> BuyOffer(int id)
        {
            return await _httpHandler.GetJsonAsync<BuyOfferDto>(BuyOffersUri(id).OriginalString);
        }

        public async Task<LogsDto> BuyOffersLogs(int id)
        {
            return await _httpHandler.GetJsonAsync<LogsDto>(BuyOffersLogsUri(id).OriginalString);
        }

        public async Task<LogsDto> BuyOffersLogs(int id, BuyOffersUriParameterBuilder uriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<LogsDto>(BuyOffersLogsUri(id, uriParametersBuilder).OriginalString);
        }

        private Uri BuyOffersUri() => new Uri($"{_requestUriBase}/buyoffers");
        private Uri BuyOffersUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/buyoffers{uriParameterBuilder.Build()}");
        private Uri BuyOffersUri(int id) => new Uri($"{_requestUriBase}/buyoffers/{id}");
        private Uri BuyOffersLogsUri(int id) => new Uri($"{_requestUriBase}/buyoffers/{id}/logs");
        private Uri BuyOffersLogsUri(int id, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/buyoffers/{id}{uriParameterBuilder.Build()}");
    }
}