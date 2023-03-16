using AreaCalculators.Calculators.Interfaces;
using AreaCalculators.Figures.Interfaces;

namespace AreaCalculators.Calculators
{
    /// <summary>
    /// Contains methods for circle area calculation.
    /// </summary>
    public class CircleAreaCalculator : ICircleAreaCalculator
    {
        /// <summary>
        /// Calculates circle area by radius.
        /// </summary>
        /// <param name="figure"></param>
        /// <returns>Circle area in double type</returns>
        public double CalculateArea(ICircleFugure figure)
        {
            var area = Math.PI * figure.Radius * figure.Radius;
            return area;
        }        
    }
}
