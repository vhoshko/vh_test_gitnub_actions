using SuperMath;

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
    }
}