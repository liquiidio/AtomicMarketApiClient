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
using NUnit.Framework;

namespace AtomicMarketApiClient.Test
{
    [TestFixture]
    public class AtomicMarketApiFactoryTest
    {
        [Test]
        public void SalesApi() => Assert.AreEqual(typeof(SalesApi),AtomicMarketApiFactory.Version1.SalesApi.GetType());

        [Test]
        public void AuctionsApi() => Assert.AreEqual(typeof(AuctionsApi),AtomicMarketApiFactory.Version1.AuctionsApi.GetType());

        [Test]
        public void BuyOffersApi() => Assert.AreEqual(typeof(BuyOffersApi),AtomicMarketApiFactory.Version1.BuyOffersApi.GetType());

        [Test]
        public void MarketPlacesApi() => Assert.AreEqual(typeof(MarketPlacesApi),AtomicMarketApiFactory.Version1.MarketPlacesApi.GetType());

        [Test]
        public void OffersApi() => Assert.AreEqual(typeof(OffersApi),AtomicMarketApiFactory.Version1.OffersApi.GetType());

        [Test]
        public void StatsApi() => Assert.AreEqual(typeof(StatsApi),AtomicMarketApiFactory.Version1.StatsApi.GetType());

        [Test]
        public void ConfigApi() => Assert.AreEqual(typeof(ConfigApi),AtomicMarketApiFactory.Version1.ConfigApi.GetType());

        [Test]
        public void AssetsApi() => Assert.AreEqual(typeof(AssetsApi),AtomicMarketApiFactory.Version1.AssetsApi.GetType());

        [Test]
        public void TransfersApi() => Assert.AreEqual(typeof(TransfersApi),AtomicMarketApiFactory.Version1.TransfersApi.GetType());
        
        [Test]
        public void PricingApi() => Assert.AreEqual(typeof(PricingApi),AtomicMarketApiFactory.Version1.PricingApi.GetType());
    }
}
