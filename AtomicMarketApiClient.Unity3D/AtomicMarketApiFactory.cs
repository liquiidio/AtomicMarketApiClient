using AtomicMarketApiClient.Unity3D.Assets;
using AtomicMarketApiClient.Unity3D.Auctions;
using AtomicMarketApiClient.Unity3D.BuyOffers;
using AtomicMarketApiClient.Unity3D.Config;
using AtomicMarketApiClient.Unity3D.MarketPlaces;
using AtomicMarketApiClient.Unity3D.Offers;
using AtomicMarketApiClient.Unity3D.Pricing;
using AtomicMarketApiClient.Unity3D.Sales;
using AtomicMarketApiClient.Unity3D.Stats;
using AtomicMarketApiClient.Unity3D.Transfers;

namespace AtomicMarketApiClient.Unity3D
{
    public class AtomicMarketApiFactory
    {
        private readonly string _baseUrl;
        private const string Version1BaseUrl = "https://wax.api.atomicassets.io/atomicmarket/v1";

        private AtomicMarketApiFactory(string baseUrl) => _baseUrl = baseUrl;

        public static AtomicMarketApiFactory Version1 => new AtomicMarketApiFactory(Version1BaseUrl);

        public SalesApi SalesApi => new SalesApi(_baseUrl);
        public AuctionsApi AuctionsApi => new AuctionsApi(_baseUrl);
        public BuyOffersApi BuyOffersApi => new BuyOffersApi(_baseUrl);
        public MarketPlacesApi MarketPlacesApi => new MarketPlacesApi(_baseUrl);
        public OffersApi OffersApi => new OffersApi(_baseUrl);
        public StatsApi StatsApi => new StatsApi(_baseUrl);
        public ConfigApi ConfigApi => new ConfigApi(_baseUrl);
        public AssetsApi AssetsApi => new AssetsApi(_baseUrl);
        public TransfersApi TransfersApi => new TransfersApi(_baseUrl);
        public PricingApi PricingApi => new PricingApi(_baseUrl);
    }
}