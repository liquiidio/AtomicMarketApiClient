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
        [Ignore("Test Ignored")]
        public void AssetStats()
        {
            var assetIdToFind = AtomicMarketApiFactory.Version1.AssetsApi.Assets().Data.First().AssetId;
            AtomicMarketApiFactory.Version1.AssetsApi.AssetStats(assetIdToFind).Should().BeOfType<StatsDto>();
            AtomicMarketApiFactory.Version1.AssetsApi.AssetStats(assetIdToFind).Data.Should().BeOfType<StatsDto.DataDto>();
        }

        [Test]
        [Ignore("Test Ignored")]
        public void AssetLogs()
        {
            var assetIdToFind = AtomicMarketApiFactory.Version1.AssetsApi.Assets().Data.First().AssetId;
            AtomicMarketApiFactory.Version1.AssetsApi.AssetLogs(assetIdToFind).Should().BeOfType<LogsDto>();
            AtomicMarketApiFactory.Version1.AssetsApi.AssetLogs(assetIdToFind).Data.Should().BeOfType<LogsDto.DataDto>();
        }
    }
}