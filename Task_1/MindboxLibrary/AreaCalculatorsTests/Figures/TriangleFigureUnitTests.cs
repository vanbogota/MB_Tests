
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
            Assert.Equal(20, triangle.SideA);
            Assert.IsType<double>(triangle.SideB);
            Assert.Equal(20, triangle.SideB);
            Assert.IsType<double>(triangle.SideC);  
            Assert.Equal(20, triangle.SideC);
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
