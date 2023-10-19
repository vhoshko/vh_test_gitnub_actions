using SuperMath;
using Microsoft.Extensions.Configuration;

namespace Tests.SuperMath.Tests
{
    public class TestSuperMathInt
    {
        [Fact]
        public void TestNoParameters()
        {
            Assert.Equal(0, SuperMathInt.Add());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(77)]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]
        public void TestOneParameter(int value)
        {
            Assert.Equal(value, SuperMathInt.Add(value));
        }

        [Fact]
        public void TestSecrets()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);
            var configuration = configurationBuilder.Build();

            Assert.NotNull(configuration["API:Key"]);
            Assert.Equal("!!!!!!!!", configuration["Test:Key"]);
        }
    }
}