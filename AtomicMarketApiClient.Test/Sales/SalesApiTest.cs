using AtomicMarketApiClient.Core;
using AtomicMarketApiClient.Sales;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Sales
{
    [TestFixture]
    public class SalesApiTest
    {
        [Test]
        public void Sales()
        {
            AtomicMarketApiFactory.Version1.SalesApi.Sales().Should().BeOfType<SalesDto>();
            AtomicMarketApiFactory.Version1.SalesApi.Sales().Data.Should().BeOfType<SalesDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.SalesApi.Sales().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.SalesApi.Sales(new SalesUriParameterBuilder().WithLimit(1)).Data.Should().HaveCount(1);
            AtomicMarketApiFactory.Version1.SalesApi.Sales(new SalesUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Should().BeOfType<SalesDto>();
            AtomicMarketApiFactory.Version1.SalesApi.Sales(new SalesUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Data.Should().BeOfType<SalesDto.DataDto[]>();
        }

        [Test]
        public void SalesByTemplate()
        {
            AtomicMarketApiFactory.Version1.SalesApi.SalesByTemplate(new SalesUriParameterBuilder().WithSymbol("WAX").WithCollectionName("b1")).Should().BeOfType<SalesDto>();
            AtomicMarketApiFactory.Version1.SalesApi.SalesByTemplate(new SalesUriParameterBuilder().WithSymbol("WAX").WithCollectionName("b1")).Data.Should().BeOfType<SalesDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.SalesApi.SalesByTemplate(new SalesUriParameterBuilder().WithSymbol("WAX").WithCollectionName("b1")).Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.SalesApi.SalesByTemplate(new SalesUriParameterBuilder().WithSymbol("WAX").WithCollectionName("b1").WithLimit(1)).Data.Should().HaveCount(1);
            AtomicMarketApiFactory.Version1.SalesApi.SalesByTemplate(new SalesUriParameterBuilder().WithSymbol("WAX").WithCollectionName("b1").WithOrder(SortStrategy.Ascending)).Should().BeOfType<SalesDto>();
            AtomicMarketApiFactory.Version1.SalesApi.SalesByTemplate(new SalesUriParameterBuilder().WithSymbol("WAX").WithCollectionName("b1").WithOrder(SortStrategy.Ascending)).Data.Should().BeOfType<SalesDto.DataDto[]>();
        }

        [Test]
        public void Sale()
        {
            AtomicMarketApiFactory.Version1.SalesApi.Sale(1).Should().BeOfType<SaleDto>();
            AtomicMarketApiFactory.Version1.SalesApi.Sale(1).Data.Should().BeOfType<SaleDto.DataDto>();
        }

        [Test]
        public void SalesLog()
        {
            AtomicMarketApiFactory.Version1.SalesApi.SalesLogs(1).Should().BeOfType<LogsDto>();
            AtomicMarketApiFactory.Version1.SalesApi.SalesLogs(1).Data.Should().BeOfType<LogsDto.DataDto>();
        }
    }
}
