using System;
using System.Linq;
using AtomicMarketApiClient.Auctions;
using AtomicMarketApiClient.Core;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Auctions
{
    [TestFixture]
    public class AuctionsApiTest
    {
        [Test]
        [Ignore("This test is failing at the moment as the AtomicMarkets endpoint is down. We always receive an Internal Server Error. Add this test back in when their endpoint is working again")]
        public void Assets()
        {
            AtomicMarketApiFactory.Version1.AuctionsApi.Auctions().Should().BeOfType<AuctionsDto>();
            AtomicMarketApiFactory.Version1.AuctionsApi.Auctions().Data.Should().BeOfType<AuctionsDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.AuctionsApi.Auctions().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.AuctionsApi.Auctions(new AuctionsUriParameterBuilder().WithLimit(1)).Data.Should().HaveCount(1);

            AtomicMarketApiFactory.Version1.AuctionsApi.Auctions(new AuctionsUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Should().BeOfType<AuctionsDto>();
            AtomicMarketApiFactory.Version1.AuctionsApi.Auctions(new AuctionsUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Data.Should().BeOfType<AuctionsDto.DataDto[]>();
        }

        [Test]
        public void Asset()
        {
            AtomicMarketApiFactory.Version1.AuctionsApi.Auction(1).Should().BeOfType<AuctionDto>();
            AtomicMarketApiFactory.Version1.AuctionsApi.Auction(1).Data.Should().BeOfType<AuctionDto.DataDto>();
        }

        [Test]
        [Ignore("This test is failing at the moment as the AtomicMarkets endpoint is down. We always receive an Internal Server Error. Add this test back in when their endpoint is working again")]
        public void AssetLogs()
        {
            var auctionIdToFind = Convert.ToInt32(AtomicMarketApiFactory.Version1.AuctionsApi.Auctions().Data.First().AuctionId);
            AtomicMarketApiFactory.Version1.AuctionsApi.AuctionLogs(auctionIdToFind).Should().BeOfType<LogsDto>();
            AtomicMarketApiFactory.Version1.AuctionsApi.AuctionLogs(auctionIdToFind).Data.Should().BeOfType<LogsDto.DataDto>();
        }
    }
}