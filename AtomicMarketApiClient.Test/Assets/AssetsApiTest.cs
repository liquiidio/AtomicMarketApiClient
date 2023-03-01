using System.Linq;
using AtomicMarketApiClient.Assets;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Assets
{
    [TestFixture]
    public class AssetsApiTest
    {
        [Test]
        [Ignore("Assets endpoint seems to be down at the moment")]
        public void Assets()
        {
            AtomicMarketApiFactory.Version1.AssetsApi.Assets().GetAwaiter().GetResult().Should().BeOfType<AssetsDto>();
            AtomicMarketApiFactory.Version1.AssetsApi.Assets().GetAwaiter().GetResult().Data.Should().BeOfType<AssetsDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.AssetsApi.Assets().GetAwaiter().GetResult().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.AssetsApi.Assets(new AssetsUriParameterBuilder().WithLimit(1)).GetAwaiter().GetResult().Data.Should().HaveCount(1);

            AtomicMarketApiFactory.Version1.AssetsApi.Assets(new AssetsUriParameterBuilder().WithOrder(SortStrategy.Ascending)).GetAwaiter().GetResult().Should().BeOfType<AssetsDto>();
            AtomicMarketApiFactory.Version1.AssetsApi.Assets(new AssetsUriParameterBuilder().WithOrder(SortStrategy.Ascending)).GetAwaiter().GetResult().Data.Should().BeOfType<AssetsDto.DataDto[]>();
        }

        [Test]
        public void Asset()
        {
            //var assetIdToFind = AtomicMarketApiFactory.Version1.AssetsApi.Assets().GetAwaiter().GetResult().Data.First().AssetId;
            var assetIdToFind = "1099849109724";
            AtomicMarketApiFactory.Version1.AssetsApi.Asset(assetIdToFind).GetAwaiter().GetResult().Should().BeOfType<AssetDto>();
            AtomicMarketApiFactory.Version1.AssetsApi.Asset(assetIdToFind).GetAwaiter().GetResult().Data.Should().BeOfType<AssetDto.DataDto>();
        }

        [Test]
        [Ignore("Test Ignored")]
        public void AssetStats()
        {
            var assetIdToFind = AtomicMarketApiFactory.Version1.AssetsApi.Assets().GetAwaiter().GetResult().Data.First().AssetId;
            AtomicMarketApiFactory.Version1.AssetsApi.AssetStats(assetIdToFind).GetAwaiter().GetResult().Should().BeOfType<StatsDto>();
            AtomicMarketApiFactory.Version1.AssetsApi.AssetStats(assetIdToFind).GetAwaiter().GetResult().Data.Should().BeOfType<StatsDto.DataDto>();
        }

        [Test]
        public void AssetLogs()
        {
            //var assetIdToFind = AtomicMarketApiFactory.Version1.AssetsApi.Assets().GetAwaiter().GetResult().Data.First().AssetId;
            var assetIdToFind = "1099849109724";
            AtomicMarketApiFactory.Version1.AssetsApi.AssetLogs(assetIdToFind).GetAwaiter().GetResult().Should().BeOfType<LogsDto>();
            AtomicMarketApiFactory.Version1.AssetsApi.AssetLogs(assetIdToFind).GetAwaiter().GetResult().Data.Should().BeOfType<LogsDto.DataDto[]>();
        }
    }
}