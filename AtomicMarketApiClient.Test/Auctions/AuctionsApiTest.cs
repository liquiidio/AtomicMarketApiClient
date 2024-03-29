﻿using System;
using System.Linq;
using AtomicMarketApiClient.Auctions;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Auctions
{
    [TestFixture]
    public class AuctionsApiTest
    {
        [Test]
        public void Assets()
        {
            AtomicMarketApiFactory.Version1.AuctionsApi.Auctions().GetAwaiter().GetResult().Should().BeOfType<AuctionsDto>();
            AtomicMarketApiFactory.Version1.AuctionsApi.Auctions().GetAwaiter().GetResult().Data.Should().BeOfType<AuctionsDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.AuctionsApi.Auctions().GetAwaiter().GetResult().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.AuctionsApi.Auctions(new AuctionsUriParameterBuilder().WithLimit(1)).GetAwaiter().GetResult().Data.Should().HaveCount(1);

            AtomicMarketApiFactory.Version1.AuctionsApi.Auctions(new AuctionsUriParameterBuilder().WithOrder(SortStrategy.Ascending)).GetAwaiter().GetResult().Should().BeOfType<AuctionsDto>();
            AtomicMarketApiFactory.Version1.AuctionsApi.Auctions(new AuctionsUriParameterBuilder().WithOrder(SortStrategy.Ascending)).GetAwaiter().GetResult().Data.Should().BeOfType<AuctionsDto.DataDto[]>();
        }

        [Test]
        public void Asset()
        {
            AtomicMarketApiFactory.Version1.AuctionsApi.Auction(1).GetAwaiter().GetResult().Should().BeOfType<AuctionDto>();
            AtomicMarketApiFactory.Version1.AuctionsApi.Auction(1).GetAwaiter().GetResult().Data.Should().BeOfType<AuctionDto.DataDto>();
        }

        [Test]
        public void AssetLogs()
        {
            var auctionIdToFind = Convert.ToInt32(AtomicMarketApiFactory.Version1.AuctionsApi.Auctions().GetAwaiter().GetResult().Data.First().AuctionId);
            AtomicMarketApiFactory.Version1.AuctionsApi.AuctionLogs(auctionIdToFind).GetAwaiter().GetResult().Should().BeOfType<LogsDto>();
            AtomicMarketApiFactory.Version1.AuctionsApi.AuctionLogs(auctionIdToFind).GetAwaiter().GetResult().Data.Should().BeOfType<LogsDto.DataDto[]>();
        }
    }
}