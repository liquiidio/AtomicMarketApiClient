using System.Linq;
using AtomicMarketApiClient.Assets;
using AtomicMarketApiClient.Core;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Assets
{
    [TestFixture]
    public class AssetsApiTest
    {
        [Test]
        public void Assets()
        {
            AtomicMarketApiFactory.Version1.AssetsApi.Assets().Should().BeOfType<AssetsDto>();
            AtomicMarketApiFactory.Version1.AssetsApi.Assets().Data.Should().BeOfType<AssetsDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.AssetsApi.Assets().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.AssetsApi.Assets(new AssetsUriParameterBuilder().WithLimit(1)).Data.Should().HaveCount(1);

            AtomicMarketApiFactory.Version1.AssetsApi.Assets(new AssetsUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Should().BeOfType<AssetsDto>();
            AtomicMarketApiFactory.Version1.AssetsApi.Assets(new AssetsUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Data.Should().BeOfType<AssetsDto.DataDto[]>();
        }

        [Test]
        public void Asset()
        {
            var assetIdToFind = AtomicMarketApiFactory.Version1.AssetsApi.Assets().Data.First().AssetId;
            AtomicMarketApiFactory.Version1.AssetsApi.Asset(assetIdToFind).Should().BeOfType<AssetDto>();
            AtomicMarketApiFactory.Version1.AssetsApi.Asset(assetIdToFind).Data.Should().BeOfType<AssetDto.DataDto>();
        }

        [Test]
        public void AssetStats()
        {
            var assetIdToFind = AtomicMarketApiFactory.Version1.AssetsApi.Assets().Data.First().AssetId;
            AtomicMarketApiFactory.Version1.AssetsApi.AssetStats(assetIdToFind).Should().BeOfType<StatsDto>();
            AtomicMarketApiFactory.Version1.AssetsApi.AssetStats(assetIdToFind).Data.Should().BeOfType<StatsDto.DataDto>();
        }

        [Test]
        [Ignore("This test is failing at the moment as the AtomicMarkets endpoint is down. We always receive an Internal Server Error. Add this test back in when their endpoint is working again")]
        public void AssetLogs()
        {
            var assetIdToFind = AtomicMarketApiFactory.Version1.AssetsApi.Assets().Data.First().AssetId;
            AtomicMarketApiFactory.Version1.AssetsApi.AssetLogs(assetIdToFind).Should().BeOfType<LogsDto>();
            AtomicMarketApiFactory.Version1.AssetsApi.AssetLogs(assetIdToFind).Data.Should().BeOfType<LogsDto.DataDto>();
        }
    }
}