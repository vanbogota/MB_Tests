using Task_1;

namespace Task1_UnitTests
{
    public class TriangleUnitTests
    {
        [Fact]
        public void If_Side_Below_Zero_Throws_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -1, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 1, 1));
        }

        [Fact]
        public void CalculateArea_InputIs20_Returns_DoubleType()
        {
            Triangle triangle = new(20,20,20);
            var result = triangle.CalclateArea();
            Assert.IsType<double>(result);
            Assert.Equal(173.20508075688772, result);
        }

        [Fact]
        public void IsRightTriangle_InputIsOver0_Returns_BooleanType()
        {
            Triangle triangle = new(3, 4, 5);
            var result = triangle.IsRightTriangle();
            Assert.IsType<bool>(result);
            Assert.Equal(6, triangle.CalclateArea());
            Assert.True(result);
        }
    }
}
