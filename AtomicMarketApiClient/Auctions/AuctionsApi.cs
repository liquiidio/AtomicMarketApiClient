using System;
using System.Threading.Tasks;

namespace AtomicMarketApiClient.Auctions
{
    public class AuctionsApi
    {
        private readonly string _requestUriBase;
        private readonly IHttpHandler _httpHandler;

        internal AuctionsApi(string baseUrl, IHttpHandler httpHandler)
        {
            _requestUriBase = baseUrl;
            _httpHandler = httpHandler;
        }

        public async Task<AuctionsDto> Auctions()
        {
            return await _httpHandler.GetJsonAsync<AuctionsDto>(AuctionsUri().OriginalString);
        }

        public async Task<AuctionsDto> Auctions(AuctionsUriParameterBuilder uriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<AuctionsDto>(AuctionsUri(uriParametersBuilder).OriginalString);
        }

        public async Task<AuctionDto> Auction(int id)
        {
            return await _httpHandler.GetJsonAsync<AuctionDto>(AuctionUri(id).OriginalString);
        }

        public async Task<LogsDto> AuctionLogs(int id)
        {
            return await _httpHandler.GetJsonAsync<LogsDto>(AuctionsLogsUri(id).OriginalString);
        }

        public async Task<LogsDto> AuctionLogs(int id, AuctionsUriParameterBuilder auctionsUriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<LogsDto>(AuctionsLogsUri(id, auctionsUriParametersBuilder).OriginalString);
        }

        private Uri AuctionsUri() => new Uri($"{_requestUriBase}/auctions");
        private Uri AuctionsUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/auctions{uriParameterBuilder.Build()}");
        private Uri AuctionUri(int id) => new Uri($"{_requestUriBase}/auctions/{id}");
        private Uri AuctionsLogsUri(int id) => new Uri($"{_requestUriBase}/auctions/{id}/logs");
        private Uri AuctionsLogsUri(int id, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/auctions/{id}{uriParameterBuilder.Build()}");
    }
}