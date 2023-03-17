using AreaCalculators.Calculators.Interfaces;
using AreaCalculators.Figures;
using AreaCalculators.Figures.Interfaces;

namespace AreaCalculators.Calculators
{
    /// <summary>
    /// Contains methods for triangle area calculation.
    /// </summary>
    public class TriangleAreaCalculator : ITriangleAreaCalculator
    {
        /// <summary>
        /// Calculates triangle area by three sides (the Geron theorem).
        /// </summary>
        /// <param name="figure"></param>
        /// <returns>Triangle area in double type</returns>
        public double CalculateArea(ITriangleFigure figure)
        {
            if (figure is null)
            {
                throw new ArgumentNullException("Figure must not be null");
            }

            double halfP = (figure.SideA + figure.SideB + figure.SideC) / 2;

            return Math.Sqrt(halfP * (halfP - figure.SideA) * (halfP - figure.SideB) * (halfP - figure.SideC)); 
        }          
    }
}
