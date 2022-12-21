using AtomicMarketApiClient.Config;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Config
{
    [TestFixture]
    public class ConfigApiTest
    {
        [Test]
        public void Config()
        {
            AtomicMarketApiFactory.Version1.ConfigApi.Config().GetAwaiter().GetResult().Should().BeOfType<ConfigDto>();
            AtomicMarketApiFactory.Version1.ConfigApi.Config().GetAwaiter().GetResult().Data.Should().BeOfType<ConfigDto.DataDto>();
        }
    }
}