using System;
using System.Linq;
using AtomicMarketApiClient.BuyOffers;
using AtomicMarketApiClient.Core;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.BuyOffers
{
    [TestFixture]
    public class BuyOffersApiTest
    {
        [Test]
        public void BuyOffers()
        {
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffers().Should().BeOfType<BuyOffersDto>();
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffers().Data.Should().BeOfType<BuyOffersDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffers().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffers(new BuyOffersUriParameterBuilder().WithLimit(1)).Data.Should().HaveCount(1);

            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffers(new BuyOffersUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Should().BeOfType<BuyOffersDto>();
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffers(new BuyOffersUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Data.Should().BeOfType<BuyOffersDto.DataDto[]>();
        }

        [Test]
        public void BuyOffer()
        {
            var buyOfferIdToFind = Convert.ToInt32(AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffers().Data.First().BuyOfferId);
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffer(buyOfferIdToFind).Should().BeOfType<BuyOfferDto>();
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffer(buyOfferIdToFind).Data.Should().BeOfType<BuyOfferDto.DataDto>();
        }

        [Test]
        public void BuyOfferLogs()
        {
            var buyOfferIdToFind = Convert.ToInt32(AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffers().Data.First().BuyOfferId);
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffersLogs(buyOfferIdToFind).Should().BeOfType<LogsDto>();
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffersLogs(buyOfferIdToFind).Data.Should().BeOfType<LogsDto.DataDto[]>();
        }
    }
}