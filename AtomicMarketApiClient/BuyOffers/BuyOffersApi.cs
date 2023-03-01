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

        //* <summary>
        //* This function will return a list of buy offers for a given market
        //* </summary>
        //* <returns>
        //* A list of buy offers.
        //* </returns>
        public async Task<BuyOffersDto> BuyOffers()
        {
            return await _httpHandler.GetJsonAsync<BuyOffersDto>(BuyOffersUri().OriginalString);
        }

        //* <summary>
        //* It takes a `BuyOffersUriParameterBuilder` object as a parameter, builds a `HttpRequestMessage`
        //* object, sends it to the API, and returns a `BuyOffersDto` object
        //* </summary>
        //* <param name="BuyOffersUriParameterBuilder">This is a class that inherits from the
        //* IUriParameterBuilder interface. This interface is used to build the query string parameters for the
        //* API call.</param>
        //* <returns>
        //* A BuyOffersDto object.
        //* </returns>
        public async Task<BuyOffersDto> BuyOffers(BuyOffersUriParameterBuilder uriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<BuyOffersDto>(BuyOffersUri((IUriParameterBuilder)uriParametersBuilder).OriginalString);
        }

        //* <summary>
        //* This function will return a BuyOfferDto object from the API
        //* </summary>
        //* <param name="id">The id of the buy offer you want to retrieve.</param>
        //* <returns>
        //* A BuyOfferDto object
        //* </returns>
        public async Task<BuyOfferDto> BuyOffer(int id)
        {
            return await _httpHandler.GetJsonAsync<BuyOfferDto>(BuyOffersUri(id).OriginalString);
        }

        //* <summary>
        //* This function returns a list of logs for a specific buy offer
        //* </summary>
        //* <param name="id">The id of the buy offer.</param>
        //* <returns>
        //* A list of logs for the buy offer with the given id.
        //* </returns>
        public async Task<LogsDto> BuyOffersLogs(int id)
        {
            return await _httpHandler.GetJsonAsync<LogsDto>(BuyOffersLogsUri(id).OriginalString);
        }

        //* <summary>
        //* This function returns a list of logs for a specific buy offer
        //* </summary>
        //* <param name="id">The id of the buy offer</param>
        //* <param name="BuyOffersUriParameterBuilder">This is a class that contains all the parameters that can
        //* be passed to the API.</param>
        //* <returns>
        //* A list of logs for the buy offer.
        //* </returns>
        public async Task<LogsDto> BuyOffersLogs(int id, BuyOffersUriParameterBuilder uriParametersBuilder)
        {
            return await _httpHandler.GetJsonAsync<LogsDto>(BuyOffersLogsUri(id, uriParametersBuilder).OriginalString);
        }

        //* <summary>
        //* It returns a URI that points to the buy offers endpoint
        //* </summary>
        private Uri BuyOffersUri() => new Uri($"{_requestUriBase}/buyoffers");
        //* <summary>
        //* It returns a URI for the buy offers endpoint
        //* </summary>
        //* <param name="IUriParameterBuilder">This is an interface that is used to build the query
        //* string parameters for the request.</param>
        private Uri BuyOffersUri(IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/buyoffers{uriParameterBuilder.Build()}");
        //* <summary>
        //* It returns a URI for a specific buy offer
        //* </summary>
        //* <param name="id">The id of the buy offer you want to get.</param>
        private Uri BuyOffersUri(int id) => new Uri($"{_requestUriBase}/buyoffers/{id}");
        //* <summary>
        //* It returns a URI for the buy offer logs endpoint
        //* </summary>
        //* <param name="id">The id of the buy offer you want to get the logs for.</param>
        private Uri BuyOffersLogsUri(int id) => new Uri($"{_requestUriBase}/buyoffers/{id}/logs");
        //* <summary>
        //* > This function returns a URI for the BuyOffersLogs endpoint
        //* </summary>
        //* <param name="id">The id of the buy offer you want to get the logs for.</param>
        //* <param name="IUriParameterBuilder">This is an interface that is used to build the query
        //* string parameters.</param>
        private Uri BuyOffersLogsUri(int id, IUriParameterBuilder uriParameterBuilder) => new Uri($"{_requestUriBase}/buyoffers/{id}{uriParameterBuilder.Build()}");
        }
}