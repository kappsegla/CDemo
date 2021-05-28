using GitDemo;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void MessageInSwedishReturnsHej()
        {
            var actualResult = Program.MessageInSwedish();

            Assert.Equal("Hej", actualResult);
        }

        [Fact]
        public void MessageInEnglishReturnsHello()
        {
            var actualResult = Program.MessageInEnglish();

            Assert.Equal("Hell0", actualResult);
        }
    }
}
