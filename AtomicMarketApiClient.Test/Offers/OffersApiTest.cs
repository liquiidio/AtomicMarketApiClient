using System.Linq;
using AtomicMarketApiClient.Core;
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
            AtomicMarketApiFactory.Version1.OffersApi.Offers().Should().BeOfType<OffersDto>();
            AtomicMarketApiFactory.Version1.OffersApi.Offers().Data.Should().BeOfType<OffersDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.OffersApi.Offers().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.OffersApi.Offers(new OffersUriParameterBuilder().WithLimit(1)).Data.Should().HaveCount(1);

            AtomicMarketApiFactory.Version1.OffersApi.Offers(new OffersUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Should().BeOfType<OffersDto>();
            AtomicMarketApiFactory.Version1.OffersApi.Offers(new OffersUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Data.Should().BeOfType<OffersDto.DataDto[]>();
        }

        [Test]
        public void Offer()
        {
            var offerIdToFind = AtomicMarketApiFactory.Version1.OffersApi.Offers().Data.First().OfferId;
            AtomicMarketApiFactory.Version1.OffersApi.Offer(offerIdToFind).Should().BeOfType<OfferDto>();
            AtomicMarketApiFactory.Version1.OffersApi.Offer(offerIdToFind).Data.Should().BeOfType<OfferDto.DataDto>();
        }

        [Test]
        [Ignore("This test is failing at the moment as the AtomicMarkets endpoint is down. We always receive an Internal Server Error. Add this test back in when their endpoint is working again")]

        public void OfferLogs()
        {
            var offerIdToFind = AtomicMarketApiFactory.Version1.OffersApi.Offers().Data.First().OfferId;
            AtomicMarketApiFactory.Version1.OffersApi.OfferLogs(offerIdToFind).Should().BeOfType<LogsDto>();
            AtomicMarketApiFactory.Version1.OffersApi.OfferLogs(offerIdToFind).Data.Should().BeOfType<LogsDto.DataDto[]>();
        }
    }
}