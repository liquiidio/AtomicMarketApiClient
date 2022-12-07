using System;
using AtomicMarketApiClient.Core;
using AtomicMarketApiClient.Core.Stats;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Stats
{
    [TestFixture]
    public class StatsApiTest
    {
        private const string TEST_COLLECTION = "elementblobs";
        private const string TEST_ACCOUNT = "kaefer";

        [Test]
        public void Collections()
        {
            AtomicMarketApiFactory.Version1.StatsApi.Collections(new StatsUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithSymbol("WAX")).Should().BeOfType<CollectionsDto>();
            AtomicMarketApiFactory.Version1.StatsApi.Collections(new StatsUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithSymbol("WAX")).GetAwaiter().GetResult().Data.Results.Should().BeOfType<CollectionsDto.DataDto.ResultDto[]>();
            AtomicMarketApiFactory.Version1.StatsApi.Collections(new StatsUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithSymbol("WAX").WithLimit(1)).GetAwaiter().GetResult().Data.Results.Should().HaveCount(1);
            AtomicMarketApiFactory.Version1.StatsApi.Collections(new StatsUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithSymbol("WAX").WithOrder(SortStrategy.Ascending)).Should().BeOfType<CollectionsDto>();
            AtomicMarketApiFactory.Version1.StatsApi.Collections(new StatsUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithSymbol("WAX").WithOrder(SortStrategy.Ascending)).GetAwaiter().GetResult().Data.Results.Should().BeOfType<CollectionsDto.DataDto.ResultDto[]>();
        }

        [Test]
        public void Collection()
        {
            AtomicMarketApiFactory.Version1.StatsApi.Collection(TEST_COLLECTION, new StatsUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithSymbol("WAX")).Should().BeOfType<CollectionDto>();
            AtomicMarketApiFactory.Version1.StatsApi.Collection(TEST_COLLECTION, new StatsUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithSymbol("WAX")).GetAwaiter().GetResult().Data.Results.Should().BeOfType<CollectionDto.DataDto.ResultDto>();
        }

        [Test]
        [Ignore("Test Ignored")]
        public void Accounts()
        {
            int after = (int)DateTimeOffset.Now.AddMinutes(-10).ToUnixTimeSeconds();
            AtomicMarketApiFactory.Version1.StatsApi.Accounts(new StatsUriParameterBuilder().WithAfter(after).WithSymbol("WAX").WithLimit(1)).Should().BeOfType<AccountsDto>();
            AtomicMarketApiFactory.Version1.StatsApi.Accounts(new StatsUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithSymbol("WAX").WithLimit(1)).GetAwaiter().GetResult().Data.Results.Should().BeOfType<AccountsDto.DataDto.ResultDto[]>();
            AtomicMarketApiFactory.Version1.StatsApi.Accounts(new StatsUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithSymbol("WAX").WithLimit(1)).GetAwaiter().GetResult().Data.Results.Should().HaveCount(1);
            AtomicMarketApiFactory.Version1.StatsApi.Accounts(new StatsUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithSymbol("WAX").WithLimit(1).WithOrder(SortStrategy.Ascending)).Should().BeOfType<AccountsDto>();
            AtomicMarketApiFactory.Version1.StatsApi.Accounts(new StatsUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithSymbol("WAX").WithLimit(1).WithOrder(SortStrategy.Ascending)).GetAwaiter().GetResult().Data.Results.Should().BeOfType<AccountsDto.DataDto.ResultDto[]>();
        }

        [Test]
        public void Account()
        {
            AtomicMarketApiFactory.Version1.StatsApi.Account(TEST_ACCOUNT, new StatsUriParameterBuilder().WithSymbol("WAX")).Should().BeOfType<AccountDto>();
            var res = AtomicMarketApiFactory.Version1.StatsApi.Account(TEST_ACCOUNT, new StatsUriParameterBuilder().WithSymbol("WAX")).GetAwaiter().GetResult().Data.Result;
            res.Should().BeOfType<AccountDto.DataDto.ResultDto>();
        }
    }
}