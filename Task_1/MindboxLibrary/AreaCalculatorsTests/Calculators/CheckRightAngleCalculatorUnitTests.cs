using AreaCalculators.Calculators;
using AreaCalculators.Calculators.Interfaces;
using AreaCalculators.Figures;
using AreaCalculators.Figures.Interfaces;

namespace AreaCalculatorsTests.Calculators
{
    public class CheckRightAngleCalculatorUnitTests
    {
        [Fact]
        public void IsRightTriangle_Returns_BooleanType()
        {
            ITriangleFigure triangle = new TriangleFigure(3, 4, 5);

            ICheckRightAngleCalculator calculator = new CheckRightAngleCalculator();
            
            var result = calculator.CheckIsRightTriangle(triangle);

            Assert.IsType<bool>(result);
            Assert.True(result);
        }

        [Fact]
        public void CheckIsRightTriangle_InputIsEmpty_Throws_ArgumentNullException()
        {
            ITriangleFigure triangle = null;
            ICheckRightAngleCalculator calculator = new CheckRightAngleCalculator();

            Assert.Throws<ArgumentNullException>(() => calculator.CheckIsRightTriangle(triangle));
        }
    }
}
