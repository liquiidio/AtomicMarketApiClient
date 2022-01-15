using System.Linq;
using AtomicMarketApiClient.Assets;
using AtomicMarketApiClient.Pricing;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Pricing
{
    [TestFixture]
    public class PricingApiTests
    {
        [Test]
        public void Sales()
        {
            AtomicMarketApiFactory.Version1.PricingApi.Sales().Should().BeOfType<PricesDto>();
            AtomicMarketApiFactory.Version1.PricingApi.Sales().Data.Should().BeOfType<PricesDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.PricingApi.Sales().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.PricingApi.Sales(new PricingUriParametersBuilder().WithSymbol("WAX")).Data.ToList().ForEach(d => Assert.True(d.TokenSymbol == "WAX"));
        }

        [Test]
        public void Days()
        {
            AtomicMarketApiFactory.Version1.PricingApi.Days().Should().BeOfType<PricesDto>();
            AtomicMarketApiFactory.Version1.PricingApi.Days().Data.Should().BeOfType<PricesDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.PricingApi.Days().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.PricingApi.Days(new PricingUriParametersBuilder().WithSymbol("WAX")).Data.ToList().ForEach(d => Assert.True(d.TokenSymbol == "WAX"));
        }

        [Test]
        public void Templates()
        {
            AtomicMarketApiFactory.Version1.PricingApi.Templates().Should().BeOfType<TemplatesDto>();
            AtomicMarketApiFactory.Version1.PricingApi.Templates().Data.Should().BeOfType<TemplatesDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.PricingApi.Templates().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.PricingApi.Templates(new PricingUriParametersBuilder().WithSymbol("WAX")).Data.ToList().ForEach(d => Assert.True(d.TokenSymbol == "WAX"));
        }

        [Test]
        public void Assets()
        {
            AtomicMarketApiFactory.Version1.PricingApi.Assets().Should().BeOfType<AssetsDto>();
            AtomicMarketApiFactory.Version1.PricingApi.Assets().Data.Should().BeOfType<AssetsDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.PricingApi.Assets().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.PricingApi.Assets(new PricingUriParametersBuilder().WithBurned(true)).Data.ToList().ForEach(d => Assert.True(d.Burnable));
        }
    }
}