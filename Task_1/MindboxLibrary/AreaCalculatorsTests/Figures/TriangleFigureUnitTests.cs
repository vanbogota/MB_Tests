
using AreaCalculators.Figures;

namespace AreaCalculatorsTests.Figures
{
    public class TriangleFigureUnitTests
    {

        [Fact]
        public void Sides_InputIs20_Returns_DoubleType()
        {
            TriangleFigure triangle = new(20, 20, 20);

            Assert.IsType<double>(triangle.SideA);
            Assert.IsType<double>(triangle.SideB);
            Assert.IsType<double>(triangle.SideC);
            Assert.IsType<double>(triangle.Perimetr);
            Assert.Equal(60, triangle.Perimetr);
        }

        [Fact]
        public void IsRightTriangle_Returns_BooleanType()
        {
            TriangleFigure triangle = new(3, 4, 5);

            Assert.Equal(3, triangle.SideA);
            Assert.Equal(4, triangle.SideB);
            Assert.Equal(5, triangle.SideC);
            Assert.IsType<bool>(triangle.IsRightTriangle);
            Assert.True(triangle.IsRightTriangle);
        }

        [Fact]
        public void If_Side_Below_Zero_Throws_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new TriangleFigure(-1, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new TriangleFigure(0, -1, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new TriangleFigure(0, 0, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new TriangleFigure(-1, -1, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new TriangleFigure(0, 1, 1));
        }
    }
}
