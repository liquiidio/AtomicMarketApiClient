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

        /// <summary>  
        /// It returns a list of auctions.
        /// </summary>
        /// <return>
        /// AuctionsDto
        /// </return> 
        public async Task<AuctionsDto> Auctions()
        {
            return await _httpHandler.GetJsonAsync<AuctionsDto>(AuctionsUri().OriginalString);
        }


        /// <summary>
        /// It returns a list of auctions.
        /// </summary>
        /// <param name = "AuctionsUriParameterBuilder" >This is a class that contains all the parameters that can
        /// be passed to the API.</param>
        /// <return>
        /// AuctionsDto
        /// </return>
        public async Task<AuctionsDto> Auctions(AuctionsUriParameterBuilder uriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<AuctionsDto>(AuctionsUri(uriParametersBuilder).OriginalString);
        }

        /// <summary>
        /// > This function will make a GET request to the Auction API and return the AuctionDto object
        /// </summary>
        /// <param name="id">The id of the auction you want to retrieve</param>
        /// <returns>
        /// An AuctionDto object
        /// </returns>
        public async Task<AuctionDto> Auction(int id)
        {
            return await _httpHandler.GetJsonAsync<AuctionDto>(AuctionUri(id).OriginalString);
        }

        /// <summary>
        /// It gets the logs of an auction.
        /// </summary>
        /// <param name="id">The id of the auction you want to get the logs for.</param>
        /// <returns>
        /// A list of logs for the auction.
        /// </returns>
        public async Task<LogsDto> AuctionLogs(int id)
        {
            return await _httpHandler.GetJsonAsync<LogsDto>(AuctionsLogsUri(id).OriginalString);
        }

        /// <summary>
        /// It gets the logs for an auction.
        /// </summary>
        /// <param name="id">The id of the auction you want to get the logs for.</param>
        /// <param name="AuctionsUriParameterBuilder">This is a class that contains all the parameters
        /// that can be passed to the API.</param>
        /// <returns>
        /// A LogsDto object.
        /// </returns>
        public async Task<LogsDto> AuctionLogs(int id, AuctionsUriParameterBuilder auctionsUriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<LogsDto>(AuctionsLogsUri(id, auctionsUriParametersBuilder).OriginalString);
        }

        /// <summary>
        /// It returns a new Uri object that is the base request URI with the /auctions path appended to
        /// it
        /// </summary>
        private Uri AuctionsUri() => new Uri($"{_requestUriBase}/auctions");
        /// <summary>
        /// It takes a `IUriParameterBuilder` and returns a `Uri` that is the base URI for the auctions
        /// endpoint with the parameters built by the `IUriParameterBuilder` appended to the end.
        /// </summary>
        /// <param name="IUriParameterBuilder">This is an interface that is used to build the query
        /// string parameters for the request.</param>
        private Uri AuctionsUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/auctions{uriParameterBuilder.Build()}");
        /// <summary>
        /// It returns a URI for the auction with the given ID
        /// </summary>
        /// <param name="id">The id of the auction you want to get.</param>
        private Uri AuctionUri(int id) => new Uri($"{_requestUriBase}/auctions/{id}");
        /// <summary>
        /// > It returns a `Uri` object that represents the URL for the auction logs endpoint
        /// </summary>
        /// <param name="id">The id of the auction you want to get the logs for.</param>
        private Uri AuctionsLogsUri(int id) => new Uri($"{_requestUriBase}/auctions/{id}/logs");
        /// <summary>
        /// > It returns a URI for the auctions logs endpoint
        /// </summary>
        /// <param name="id">The id of the auction you want to get the logs for.</param>
        /// <param name="IUriParameterBuilder">This is an interface that is used to build the query
        /// string parameters.</param>
        private Uri AuctionsLogsUri(int id, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/auctions/{id}{uriParameterBuilder.Build()}");
    }
}