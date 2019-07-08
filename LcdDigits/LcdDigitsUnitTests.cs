namespace LcdDigits
{
    using FluentAssertions;
    using Xunit;

    public class LcdDigitsUnitTests
    {
        [Fact]
        public void Test1()
        {
            new LcdDigits().Should().NotBeNull();
        }
    }
}
