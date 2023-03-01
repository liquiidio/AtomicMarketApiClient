using AtomicMarketApiClient.Assets;
using AtomicMarketApiClient.Auctions;
using AtomicMarketApiClient.BuyOffers;
using AtomicMarketApiClient.Config;
using AtomicMarketApiClient.MarketPlaces;
using AtomicMarketApiClient.Offers;
using AtomicMarketApiClient.Pricing;
using AtomicMarketApiClient.Sales;
using AtomicMarketApiClient.Stats;
using AtomicMarketApiClient.Transfers;

namespace AtomicMarketApiClient
{
    public class AtomicMarketApiFactory
    {
        private readonly string _baseUrl;
        private const string Version1BaseUrl = "https://wax.api.atomicassets.io/atomicmarket/v1";

        private AtomicMarketApiFactory(string baseUrl) => _baseUrl = baseUrl;

        public static AtomicMarketApiFactory Version1 => new AtomicMarketApiFactory(Version1BaseUrl);

        /**
         * A shorthand for creating a new instance of the SalesApi class.
         */
        public SalesApi SalesApi => new SalesApi(_baseUrl, new HttpHandler());
        /**
         * A shorthand for creating a new instance of the AuctionsApi class.
         */
        public AuctionsApi AuctionsApi => new AuctionsApi(_baseUrl, new HttpHandler());
        /**
         * A shorthand for creating a new instance of the BuyOffersApi class.
         */
        public BuyOffersApi BuyOffersApi => new BuyOffersApi(_baseUrl, new HttpHandler());
        /**
         * A shorthand for creating a new instance of the MarketPlacesApi class.
         */
        public MarketPlacesApi MarketPlacesApi => new MarketPlacesApi(_baseUrl, new HttpHandler());
        /**
         * A shorthand for creating a new instance of the OffersApi class.
         */
        public OffersApi OffersApi => new OffersApi(_baseUrl, new HttpHandler());
        /**
         * A shorthand for creating a new instance of the StatsApi class.
         */
        public StatsApi StatsApi => new StatsApi(_baseUrl, new HttpHandler());
        /**
         * A shorthand for creating a new instance of the ConfigApi class.
         */
        public ConfigApi ConfigApi => new ConfigApi(_baseUrl, new HttpHandler());
        /**
         * A shorthand for creating a new instance of the AssetsApi class.
         */
        public AssetsApi AssetsApi => new AssetsApi(_baseUrl, new HttpHandler());
        /**
         * A shorthand for creating a new instance of the TransfersApi class.
         */
        public TransfersApi TransfersApi => new TransfersApi(_baseUrl, new HttpHandler());
        /**
         * A shorthand for creating a new instance of the PricingApi class.
         */
        public PricingApi PricingApi => new PricingApi(_baseUrl, new HttpHandler());
    }
}