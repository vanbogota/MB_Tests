using AreaCalculators.Calculators;
using AreaCalculators.Calculators.Interfaces;
using AreaCalculators.Figures;

namespace AreaCalculatorsTests.Calculators
{
    public class AnyFigureAreaCalculatorUnitTests
    {
        [Fact]
        public void CalculateArea_Input3Points_Returns_Double()
        {
            List<Point> points = new List<Point>()
            {
                new Point(1,1),
                new Point(11,21),
                new Point(21,1),
            };

            IAnyFigureAreaCalculator calculator = new AnyFigureAreaCalculator();
            var result = calculator.CalculateArea(points);

            Assert.IsType<double>(result);
            Assert.Equal(200, result);
        }

        [Fact]
        public void CalculateArea_Input4Points_Returns_Double()
        {
            List<Point> points = new List<Point>()
            {
                new Point(1,1),
                new Point(1,5),                
                new Point(5,5),
                new Point(5,1)
            };

            IAnyFigureAreaCalculator calculator = new AnyFigureAreaCalculator();
            var result = calculator.CalculateArea(points);

            Assert.IsType<double>(result);
            Assert.Equal(16, result);
        }

        [Fact]
        public void CalculateArea_InputIsEmpty_Throws_ArgumentOutOfRangeException()
        {
            List<Point> points = new List<Point>();            ;

            IAnyFigureAreaCalculator calculator = new AnyFigureAreaCalculator();

            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateArea(points));
        }
    }
}
