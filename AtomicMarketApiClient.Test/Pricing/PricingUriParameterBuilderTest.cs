using AtomicMarketApiClient.Pricing;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Pricing
{
    [TestFixture]
    public class PricingUriParameterBuilderTest
    {
        [Test]
        public void Build()
        {
            new PricingUriParametersBuilder()
                .Build()
                .Should()
                .BeEquivalentTo("?");

            new PricingUriParametersBuilder()
                .WithCollectionName("collection")
                .WithSchemaName("schemaName")
                .WithBurned(true)
                .WithSymbol("WAX")
                .WithIsTransferable(true)
                .WithTemplateId("id")
                .Build()
                .Should()
                .BeEquivalentTo("?&symbol=WAX&burned=True&collection_name=collection&schema_name=schemaName&template_id=id&is_transferable=True");
        }
    }
}