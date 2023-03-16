using AreaCalculators.Calculators;
using AreaCalculators.Calculators.Interfaces;
using AreaCalculators.Figures;
using AreaCalculators.Figures.Interfaces;

namespace AreaCalculatorsTests.Calculators
{
    public class CircleAreaCalculatorUnitTests
    {
        [Fact]
        public void CalculateArea_InputIs10_Returns_Double()
        {
            ICircleFugure circle = new CircleFigure(10);
            ICircleAreaCalculator calculator = new CircleAreaCalculator();

            var result = calculator.CalculateArea(circle);

            Assert.IsType<double>(result);
            Assert.Equal(314.1592653589793, result);
        }

        [Fact]
        public void CalculateArea_InputIsEmpty_Throws_ArgumentNullException()
        {
            ICircleFugure circle = null;
            ICircleAreaCalculator calculator = new CircleAreaCalculator();

            Assert.Throws<ArgumentNullException>(() => calculator.CalculateArea(circle));
        }        
    }
}
