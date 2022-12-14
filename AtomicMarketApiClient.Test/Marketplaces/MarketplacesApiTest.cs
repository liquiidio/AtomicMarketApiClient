﻿using AtomicMarketApiClient.MarketPlaces;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Marketplaces
{
    [TestFixture]
    public class MarketplacesApiTest
    {
        [Test]
        public void Marketplaces()
        {
            AtomicMarketApiFactory.Version1.MarketPlacesApi.Marketplaces().Should().BeOfType<MarketplacesDto>();
            AtomicMarketApiFactory.Version1.MarketPlacesApi.Marketplaces().GetAwaiter().GetResult().Data.Should().BeOfType<MarketplacesDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.MarketPlacesApi.Marketplaces().GetAwaiter().GetResult().Data.Should().HaveCountGreaterThan(1);
        }

        [Test]
        public void Marketplace()
        {
            var marketplaceNameToFind = AtomicMarketApiFactory.Version1.MarketPlacesApi.Marketplaces().GetAwaiter().GetResult().Data[1].MarketplaceName;
            AtomicMarketApiFactory.Version1.MarketPlacesApi.Marketplace(marketplaceNameToFind).Should().BeOfType<MarketplaceDto>();
            AtomicMarketApiFactory.Version1.MarketPlacesApi.Marketplace(marketplaceNameToFind).GetAwaiter().GetResult().Data.Should().BeOfType<MarketplaceDto.DataDto>();
        }
    }
}