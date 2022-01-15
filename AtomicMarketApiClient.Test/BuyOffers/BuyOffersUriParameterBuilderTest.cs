using AtomicMarketApiClient.BuyOffers;
using AtomicMarketApiClient.Core;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.BuyOffers
{
    [TestFixture]
    public class BuyOffersUriParameterBuilderTest
    {
        [Test]
        public void Build()
        {
            new BuyOffersUriParameterBuilder()
                .Build()
                .Should()
                .BeEquivalentTo("?");

            new BuyOffersUriParameterBuilder()
                .WithState(State.Cancelled, State.Listed)
                .WithMatch("match")
                .WithCollectionBlacklist(new []{"one", "two"})
                .WithCollectionWhitelist(new []{"three", "four"})
                .WithMaxAssets(4)
                .WithMinAssets(1)
                .WithShowSellerContracts(true)
                .WithContractWhitelist(true)
                .WithSellerBlacklist(false)
                .WithAssetId(2)
                .WithMakerMarketplace("maker")
                .WithMarketplace("marketplace")
                .WithTakerMarketplace("taker")
                .WithSymbol("symbol")
                .WithIds(new []{"id1", "id2"})
                .WithLowerBound("1")
                .WithUpperBound("5")
                .WithPage(2)
                .WithLimit(2)
                .WithSort("sort")
                .WithOrder(SortStrategy.Ascending)
                .Build()
                .Should()
                .BeEquivalentTo("?&state=2,1&max_assets=4&min_assets=1&show_seller_contracts=True&contract_whitelist=True&seller_blacklist=False&asset_id=2&marketplace=marketplace&maker_marketplace=maker&taker_marketplace=taker&symbol=symbol&match=match&collection_blacklist=one,two&collection_whitelist=three,four&ids=id1,id2&lower_bound=1&upper_bound=5&page=2&limit=2&order=asc&sort=sort");
        }
    }
}
