using GitDemo;
using Xunit;

namespace TestProject1
{
    public class TriangleTest
    {
        [Fact]
        public void ConstructorTakingThreeDoublesSavesValuesIntoSides()
        {
            var expected = new[] { 1.0, 2.0, 3.0 };

            Triangle triangle = new Triangle(1.0, 2.0, 3.0);

            Assert.Equal(expected, triangle.sides);
        }




    }
}
