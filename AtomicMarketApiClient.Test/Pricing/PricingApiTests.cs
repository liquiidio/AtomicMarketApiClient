using System.Linq;
using AtomicMarketApiClient.Core.Pricing;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Pricing
{
    [TestFixture]
    public class PricingApiTests
    {
        private const string TEST_COLLECTION = "elementblobs";

        [Test]
        public void Sales()
        {
            AtomicMarketApiFactory.Version1.PricingApi.Sales().Should().BeOfType<PricesDto>();
            AtomicMarketApiFactory.Version1.PricingApi.Sales().GetAwaiter().GetResult().Data.Should().BeOfType<PricesDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.PricingApi.Sales().GetAwaiter().GetResult().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.PricingApi.Sales(new PricingUriParametersBuilder().WithSymbol("WAX")).GetAwaiter().GetResult().Data.ToList().ForEach(d => Assert.True(d.TokenSymbol == "WAX"));
        }

        [Test]
        public void Days()
        {
            AtomicMarketApiFactory.Version1.PricingApi.Days(new PricingUriParametersBuilder().WithCollectionName(TEST_COLLECTION)).Should().BeOfType<PricesDto>();
            AtomicMarketApiFactory.Version1.PricingApi.Days(new PricingUriParametersBuilder().WithCollectionName(TEST_COLLECTION)).GetAwaiter().GetResult().Data.Should().BeOfType<PricesDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.PricingApi.Days(new PricingUriParametersBuilder().WithCollectionName(TEST_COLLECTION).WithSymbol("WAX")).GetAwaiter().GetResult().Data.ToList().ForEach(d => Assert.True(d.TokenSymbol == "WAX"));
        }

        [Test]
        public void Templates()
        {
            AtomicMarketApiFactory.Version1.PricingApi.Templates().Should().BeOfType<TemplatesDto>();
            AtomicMarketApiFactory.Version1.PricingApi.Templates().GetAwaiter().GetResult().Data.Should().BeOfType<TemplatesDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.PricingApi.Templates().GetAwaiter().GetResult().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.PricingApi.Templates(new PricingUriParametersBuilder().WithSymbol("WAX")).GetAwaiter().GetResult().Data.ToList().ForEach(d => Assert.True(d.TokenSymbol == "WAX"));
        }

        [Test]
        public void Assets()
        {
            AtomicMarketApiFactory.Version1.PricingApi.Assets(new PricingUriParametersBuilder().WithCollectionName(TEST_COLLECTION)).Should().BeOfType<AssetPricingDto>();
            AtomicMarketApiFactory.Version1.PricingApi.Assets(new PricingUriParametersBuilder().WithCollectionName(TEST_COLLECTION)).GetAwaiter().GetResult().Data.Should().BeOfType<AssetPricingDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.PricingApi.Assets(new PricingUriParametersBuilder().WithCollectionName(TEST_COLLECTION)).GetAwaiter().GetResult().Data.Should().HaveCount(1);
        }
    }
}