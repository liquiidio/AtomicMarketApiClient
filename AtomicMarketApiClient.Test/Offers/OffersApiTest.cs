using System.Linq;
using AtomicMarketApiClient.Offers;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Offers
{
    [TestFixture]
    public class OffersApiTest
    {
        [Test]
        public void Offers()
        {
            AtomicMarketApiFactory.Version1.OffersApi.Offers().GetAwaiter().GetResult().Should().BeOfType<OffersDto>();
            AtomicMarketApiFactory.Version1.OffersApi.Offers().GetAwaiter().GetResult().Data.Should().BeOfType<OffersDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.OffersApi.Offers().GetAwaiter().GetResult().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.OffersApi.Offers(new OffersUriParameterBuilder().WithLimit(1)).GetAwaiter().GetResult().Data.Should().HaveCount(1);

            AtomicMarketApiFactory.Version1.OffersApi.Offers(new OffersUriParameterBuilder().WithOrder(SortStrategy.Ascending)).GetAwaiter().GetResult().Should().BeOfType<OffersDto>();
            AtomicMarketApiFactory.Version1.OffersApi.Offers(new OffersUriParameterBuilder().WithOrder(SortStrategy.Ascending)).GetAwaiter().GetResult().Data.Should().BeOfType<OffersDto.DataDto[]>();
        }

        [Test]
        public void Offer()
        {
            var offerIdToFind = AtomicMarketApiFactory.Version1.OffersApi.Offers().GetAwaiter().GetResult().Data.First().OfferId;
            AtomicMarketApiFactory.Version1.OffersApi.Offer(offerIdToFind).GetAwaiter().GetResult().Should().BeOfType<OfferDto>();
            AtomicMarketApiFactory.Version1.OffersApi.Offer(offerIdToFind).GetAwaiter().GetResult().Data.Should().BeOfType<OfferDto.DataDto>();
        }

        [Test]
        public void OfferLogs()
        {
            var offerIdToFind = AtomicMarketApiFactory.Version1.OffersApi.Offers().GetAwaiter().GetResult().Data.First().OfferId;
            AtomicMarketApiFactory.Version1.OffersApi.OfferLogs(offerIdToFind).GetAwaiter().GetResult().Should().BeOfType<LogsDto>();
            AtomicMarketApiFactory.Version1.OffersApi.OfferLogs(offerIdToFind).GetAwaiter().GetResult().Data.Should().BeOfType<LogsDto.DataDto[]>();
        }
    }
}