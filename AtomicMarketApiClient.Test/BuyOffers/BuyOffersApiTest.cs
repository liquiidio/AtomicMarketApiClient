using System;
using System.Linq;
using AtomicMarketApiClient.Core;
using AtomicMarketApiClient.Core.BuyOffers;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.BuyOffers
{
    [TestFixture]
    public class BuyOffersApiTest
    {
        private const string TEST_COLLECTION = "elementblobs";

        [Test]
        public void BuyOffers()
        {
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffers(new BuyOffersUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithLimit(1)).Should().BeOfType<BuyOffersDto>();
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffers(new BuyOffersUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithLimit(1)).GetAwaiter().GetResult().Data.Should().BeOfType<BuyOffersDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffers(new BuyOffersUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithLimit(1)).GetAwaiter().GetResult().Data.Should().HaveCount(1);

            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffers(new BuyOffersUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithOrder(SortStrategy.Ascending)).Should().BeOfType<BuyOffersDto>();
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffers(new BuyOffersUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithOrder(SortStrategy.Ascending)).GetAwaiter().GetResult().Data.Should().BeOfType<BuyOffersDto.DataDto[]>();
        }

        [Test]
        public void BuyOffer()
        {
            var buyOfferIdToFind = Convert.ToInt32(AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffers(new BuyOffersUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithLimit(1)).GetAwaiter().GetResult().Data.First().BuyOfferId);
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffer(buyOfferIdToFind).Should().BeOfType<BuyOfferDto>();
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffer(buyOfferIdToFind).GetAwaiter().GetResult().Data.Should().BeOfType<BuyOfferDto.DataDto>();
        }

        [Test]
        public void BuyOfferLogs()
        {
            var buyOfferIdToFind = Convert.ToInt32(AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffers(new BuyOffersUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithLimit(1)).GetAwaiter().GetResult().Data.First().BuyOfferId);
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffersLogs(buyOfferIdToFind).Should().BeOfType<LogsDto>();
            AtomicMarketApiFactory.Version1.BuyOffersApi.BuyOffersLogs(buyOfferIdToFind).GetAwaiter().GetResult().Data.Should().BeOfType<LogsDto.DataDto[]>();
        }
    }
}