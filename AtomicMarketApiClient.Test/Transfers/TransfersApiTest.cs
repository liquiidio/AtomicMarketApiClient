using AtomicMarketApiClient.Core;
using AtomicMarketApiClient.Core.Transfers;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Transfers
{
    [TestFixture]
    public class TransfersApiTest
    {
        [Test]
        public void Transfers()
        {
            AtomicMarketApiFactory.Version1.TransfersApi.Transfers().Should().BeOfType<TransfersDto>();
            AtomicMarketApiFactory.Version1.TransfersApi.Transfers().GetAwaiter().GetResult().Data.Should().BeOfType<TransfersDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.TransfersApi.Transfers().GetAwaiter().GetResult().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.TransfersApi.Transfers(new TransfersUriParameterBuilder().WithLimit(1)).GetAwaiter().GetResult().Data.Should().HaveCount(1);

            AtomicMarketApiFactory.Version1.TransfersApi.Transfers(new TransfersUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Should().BeOfType<TransfersDto>();
            AtomicMarketApiFactory.Version1.TransfersApi.Transfers(new TransfersUriParameterBuilder().WithOrder(SortStrategy.Ascending)).GetAwaiter().GetResult().Data.Should().BeOfType<TransfersDto.DataDto[]>();
        }
    }
}