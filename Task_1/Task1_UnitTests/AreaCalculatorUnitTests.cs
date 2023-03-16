using Task_1;

namespace Task1_UnitTests
{
    public class AreaCalculatorUnitTests
    {
        [Fact]
        public void Result_of_TriangleArea_InputIs20_Returns_Double()
        {
            Triangle triangle = new Triangle(20, 20, 20);

            var result =  AreaCalculator.Result(triangle);

            Assert.IsType<double>(result);
            Assert.Equal(173.20508075688772, result);
        }

        [Fact]
        public void Result_of_CircleArea_InputIs10_Returns_Double()
        {
            Circle circle = new Circle(10);

            var result = AreaCalculator.Result(circle);

            Assert.IsType<double>(result);
            Assert.Equal(314.1592653589793, result);
        }

        [Fact]
        public void Result_Throws_ArgumnentNullException_When_Figure_is_Null()
        {
            IFigure figure = null;

            Action result = () => AreaCalculator.Result(figure);

            Assert.Throws<ArgumentNullException>(result);  
            
        }
    }
}