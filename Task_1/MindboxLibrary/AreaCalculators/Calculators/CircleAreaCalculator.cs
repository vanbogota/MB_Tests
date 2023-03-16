using AreaCalculators.Calculators.Interfaces;
using AreaCalculators.Figures.Interfaces;

namespace AreaCalculators.Calculators
{
    public class CircleAreaCalculator : ICircleAreaCalculator
    {
        public double CalculateArea(ICircleFugure figure)
        {
            var area = Math.PI * figure.Radius * figure.Radius;
            return area;
        }        
    }
}
