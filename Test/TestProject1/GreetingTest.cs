using GitDemo;
using Moq;
using Xunit;

namespace TestProject1
{
    public class GreetingTest
    {
        [Fact]
        public void GreetingReturnsGoodMorningBefore9()
        {
            var mock = new Mock<ITimeProvider>();
            mock.Setup(o => o.Time()).Returns(new System.DateTime(2021, 11, 15, 8, 0, 0));

            var greeting = new Greeting(mock.Object);

            Assert.Equal("Good morning", greeting.Greet());
        }
    }
}
