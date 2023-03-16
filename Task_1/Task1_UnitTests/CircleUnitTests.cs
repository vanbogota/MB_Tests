using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1;

namespace Task1_UnitTests
{
    public class CircleUnitTests
    {
        [Fact]
        public void If_Radius_Below_Zero_Throws_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { new Circle(-1); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { new Circle(0); });
        }

        [Fact]
        public void CalculateArea_InputIs10_Returns_DoubleType()
        {
            Circle circle = new(10);
            var result = circle.CalclateArea();

            Assert.IsType<double>(result);
            Assert.Equal(314.1592653589793, result);
        }
    }
}
