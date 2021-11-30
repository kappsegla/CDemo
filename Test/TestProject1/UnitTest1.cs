using System.Collections.Generic;
using GitDemo;
using Xunit;
using FluentAssertions;
using System;

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

            Assert.Equal("Hello", actualResult);
        }

        [Fact]
        public void GetSomeNamesReturnsTwoNames()
        {
            List<string> expected = getListWithNames();

            var result = Program.GetSomeNames();
            Assert.Equal(2, result.Count);
            Assert.Equal("Martin", result[0]);
            Assert.Equal("Kalle", result[1]);

            Assert.Equal(expected, result);

            result.Should<string>().HaveCount(2).And.Contain("Martin").And.Contain("Kalle");
        }

        private static List<string> getListWithNames()
        {
            return new List<string>() { "Martin", "Kalle" };
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(10)]
        [InlineData(100)]
        public void IsEvenIsTrueForNumberTwo(int value)
        {
            var result = Program.IsEven(value);

            Assert.True(result);
        }
    }
}
