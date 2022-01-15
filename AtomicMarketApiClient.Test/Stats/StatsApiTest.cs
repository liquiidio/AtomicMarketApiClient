using AtomicMarketApiClient.Core;
using AtomicMarketApiClient.Stats;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Stats
{
    [TestFixture]
    public class StatsApiTest
    {
        [Test]
        public void Collections()
        {
            AtomicMarketApiFactory.Version1.StatsApi.Collections(new StatsUriParameterBuilder().WithSymbol("WAX")).Should().BeOfType<CollectionsDto>();
            AtomicMarketApiFactory.Version1.StatsApi.Collections(new StatsUriParameterBuilder().WithSymbol("WAX")).Data.Results.Should().BeOfType<CollectionsDto.DataDto.ResultDto[]>();
            AtomicMarketApiFactory.Version1.StatsApi.Collections(new StatsUriParameterBuilder().WithSymbol("WAX")).Data.Results.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.StatsApi.Collections(new StatsUriParameterBuilder().WithSymbol("WAX").WithLimit(1)).Data.Results.Should().HaveCount(1);
            AtomicMarketApiFactory.Version1.StatsApi.Collections(new StatsUriParameterBuilder().WithSymbol("WAX").WithOrder(SortStrategy.Ascending)).Should().BeOfType<CollectionsDto>();
            AtomicMarketApiFactory.Version1.StatsApi.Collections(new StatsUriParameterBuilder().WithSymbol("WAX").WithOrder(SortStrategy.Ascending)).Data.Results.Should().BeOfType<CollectionsDto.DataDto.ResultDto[]>();
        }

        [Test]
        public void Collection()
        {
            AtomicMarketApiFactory.Version1.StatsApi.Collection("farmersworld", new StatsUriParameterBuilder().WithSymbol("WAX")).Should().BeOfType<CollectionDto>();
            AtomicMarketApiFactory.Version1.StatsApi.Collection("farmersworld",new StatsUriParameterBuilder().WithSymbol("WAX")).Data.Results.Should().BeOfType<CollectionDto.DataDto.ResultDto>();
        }

        [Test]
        public void Accounts()
        {
            AtomicMarketApiFactory.Version1.StatsApi.Accounts(new StatsUriParameterBuilder().WithSymbol("WAX")).Should().BeOfType<AccountsDto>();
            AtomicMarketApiFactory.Version1.StatsApi.Accounts(new StatsUriParameterBuilder().WithSymbol("WAX")).Data.Results.Should().BeOfType<AccountsDto.DataDto.ResultDto[]>();
            AtomicMarketApiFactory.Version1.StatsApi.Accounts(new StatsUriParameterBuilder().WithSymbol("WAX")).Data.Results.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.StatsApi.Accounts(new StatsUriParameterBuilder().WithSymbol("WAX").WithLimit(1)).Data.Results.Should().HaveCount(1);
            AtomicMarketApiFactory.Version1.StatsApi.Accounts(new StatsUriParameterBuilder().WithSymbol("WAX").WithOrder(SortStrategy.Ascending)).Should().BeOfType<AccountsDto>();
            AtomicMarketApiFactory.Version1.StatsApi.Accounts(new StatsUriParameterBuilder().WithSymbol("WAX").WithOrder(SortStrategy.Ascending)).Data.Results.Should().BeOfType<AccountsDto.DataDto.ResultDto[]>();
        }

        [Test]
        public void Account()
        {
            AtomicMarketApiFactory.Version1.StatsApi.Account("farmersworld", new StatsUriParameterBuilder().WithSymbol("WAX")).Should().BeOfType<AccountDto>();
            AtomicMarketApiFactory.Version1.StatsApi.Account("farmersworld",new StatsUriParameterBuilder().WithSymbol("WAX")).Data.Results.Should().BeOfType<AccountDto.DataDto.ResultDto>();
        }
    }
}