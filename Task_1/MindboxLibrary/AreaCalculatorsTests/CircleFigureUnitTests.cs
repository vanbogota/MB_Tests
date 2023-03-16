using AreaCalculators.Figures;

namespace AreaCalculatorsTests
{
    public class CircleFigureUnitTests
    {
        [Fact]
        public void Radius_InputIs10_Returns_DoubleType()
        {
            CircleFigure circle = new(10);
            
            Assert.IsType<double>(circle.Radius);
            Assert.Equal(10, circle.Radius);
        }

        [Fact]
        public void Radius_InputIsBelowZero_Throws_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { new CircleFigure(-1); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { new CircleFigure(0); });
        }        
    }
}