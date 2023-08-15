using AreaCalculators.Implementation;

namespace AreaCalculatorsTests
{
    public class CircleFigureUnitTests
    {
        Circle circle = new(1);

        [Fact]
        public void Radius_InputIs1_Returns_DoubleType()
        {
            Assert.IsType<double>(circle.Radius);
            Assert.Equal(1, circle.Radius);
        }

        [Fact]
        public void Radius_InputIsBelowZero_Throws_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { new Circle(-1); });
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => { new Circle(0); });
            Assert.Contains("Radius must be over 0", ex.Message);
        }

        [Fact]
        public void CalculateArea_InputRadiusIs1_Returns_DoubleType()
        {
            Assert.IsType<double>(circle.CalculateArea());
        }

        [Fact]
        public void CalculateArea_InputRadiusIs1_Returns_RightValue()
        {
            Assert.Equal(Math.PI, circle.CalculateArea());
        }

    }
}