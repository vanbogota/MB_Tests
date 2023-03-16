using AreaCalculators.Figures;

namespace AreaCalculatorsTests.Figures
{
    public class PointUnitTests
    {
        [Fact]
        public void Properties_Returns_Int()
        {
            Point point = new(1, 20);

            Assert.IsType<int>(point.X);
            Assert.Equal(1, point.X);
            Assert.IsType<int>(point.Y);
            Assert.Equal(20, point.Y);
        }
    }
}
