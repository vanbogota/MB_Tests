using AreaCalculators.Calculators;
using AreaCalculators.Calculators.Interfaces;
using AreaCalculators.Figures;
using AreaCalculators.Figures.Interfaces;

namespace AreaCalculatorsTests.Calculators
{
    public class TriangleAreaCalculatorUnitTests
    {
        [Fact]
        public void CalculateArea_InputIs20_Returns_Double()
        {
            ITriangleFigure triangle = new TriangleFigure(20, 20, 20);
            ITriangleAreaCalculator calculator = new TriangleAreaCalculator();

            var result = calculator.CalculateArea(triangle);

            Assert.IsType<double>(result);
            Assert.Equal(173.20508075688772, result);
        }

        [Fact]
        public void CalculateArea_InputIsEmpty_Throws_ArgumentNullException()
        {
            ITriangleFigure triangle = null;
            ITriangleAreaCalculator calculator = new TriangleAreaCalculator();

            Assert.Throws<ArgumentNullException>(() => calculator.CalculateArea(triangle));
        }
    }
}
