using GitDemo;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var actualResult = Program.MessageInSwedish();

            Assert.Equal("Hej", actualResult);
        }
    }
}
