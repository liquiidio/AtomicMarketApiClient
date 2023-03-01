using AtomicMarketApiClient.Sales;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Sales
{
    [TestFixture]
    public class SalesApiTest
    {
        private const string TEST_COLLECTION = "elementblobs";

        [Test]
        public void Sales()
        {
            AtomicMarketApiFactory.Version1.SalesApi.Sales(new SalesUriParameterBuilder().WithCollectionName(TEST_COLLECTION)).GetAwaiter().GetResult().Should().BeOfType<SalesDto>();
            AtomicMarketApiFactory.Version1.SalesApi.Sales(new SalesUriParameterBuilder().WithCollectionName(TEST_COLLECTION)).GetAwaiter().GetResult().Data.Should().BeOfType<SalesDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.SalesApi.Sales(new SalesUriParameterBuilder().WithCollectionName(TEST_COLLECTION)).GetAwaiter().GetResult().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.SalesApi.Sales(new SalesUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithLimit(1)).GetAwaiter().GetResult().Data.Should().HaveCount(1);
            AtomicMarketApiFactory.Version1.SalesApi.Sales(new SalesUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithOrder(SortStrategy.Ascending)).GetAwaiter().GetResult().Should().BeOfType<SalesDto>();
            AtomicMarketApiFactory.Version1.SalesApi.Sales(new SalesUriParameterBuilder().WithCollectionName(TEST_COLLECTION).WithOrder(SortStrategy.Ascending)).GetAwaiter().GetResult().Data.Should().BeOfType<SalesDto.DataDto[]>();
        }

        [Test]
        public void SalesByTemplate()
        {
            AtomicMarketApiFactory.Version1.SalesApi.SalesByTemplate(new SalesUriParameterBuilder().WithSymbol("WAX").WithCollectionName(TEST_COLLECTION)).GetAwaiter().GetResult().Should().BeOfType<SalesDto>();
            AtomicMarketApiFactory.Version1.SalesApi.SalesByTemplate(new SalesUriParameterBuilder().WithSymbol("WAX").WithCollectionName(TEST_COLLECTION)).GetAwaiter().GetResult().Data.Should().BeOfType<SalesDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.SalesApi.SalesByTemplate(new SalesUriParameterBuilder().WithSymbol("WAX").WithCollectionName(TEST_COLLECTION).WithLimit(1)).GetAwaiter().GetResult().Data.Should().HaveCount(1);
            AtomicMarketApiFactory.Version1.SalesApi.SalesByTemplate(new SalesUriParameterBuilder().WithSymbol("WAX").WithCollectionName(TEST_COLLECTION).WithOrder(SortStrategy.Ascending)).GetAwaiter().GetResult().Should().BeOfType<SalesDto>();
            AtomicMarketApiFactory.Version1.SalesApi.SalesByTemplate(new SalesUriParameterBuilder().WithSymbol("WAX").WithCollectionName(TEST_COLLECTION).WithOrder(SortStrategy.Ascending)).GetAwaiter().GetResult().Data.Should().BeOfType<SalesDto.DataDto[]>();
        }

        [Test]
        public void Sale()
        {
            AtomicMarketApiFactory.Version1.SalesApi.Sale(1).GetAwaiter().GetResult().Should().BeOfType<SaleDto>();
            AtomicMarketApiFactory.Version1.SalesApi.Sale(1).GetAwaiter().GetResult().Data.Should().BeOfType<SaleDto.DataDto>();
        }

        [Test]
        public void SalesLog()
        {
            AtomicMarketApiFactory.Version1.SalesApi.SalesLogs(1).GetAwaiter().GetResult().Should().BeOfType<LogsDto>();
            AtomicMarketApiFactory.Version1.SalesApi.SalesLogs(1).GetAwaiter().GetResult().Data.Should().BeOfType<LogsDto.DataDto[]>();
        }
    }
}