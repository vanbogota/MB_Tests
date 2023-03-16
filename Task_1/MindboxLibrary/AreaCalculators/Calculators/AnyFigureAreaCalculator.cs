using AreaCalculators.Calculators.Interfaces;
using AreaCalculators.Figures;

namespace AreaCalculators.Calculators
{
    /// <summary>
    /// Contains methods for any figure area calculation.
    /// </summary>
    public class AnyFigureAreaCalculator : IAnyFigureAreaCalculator
    {
        /// <summary>
        /// Calculates arae of any figure by List of points with coordinates.
        /// </summary>
        /// <param name="points"></param>
        /// <returns>Calculated area in double type</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public double CalculateArea(IList<Point> points)
        {
            if (points.Count < 3)
            {
                throw new ArgumentOutOfRangeException("This figure doesn't have area. Must be at least 3 points");
            }
            int length = points.Count;
            int tempSum = 0; 
            for(int i=0; i< length-1; i++ )
            {
                tempSum += points[i].X * points[i + 1].Y - points[i].Y * points[i + 1].X; 
            }
            tempSum += points[length-1].X * points[0].Y - points[length-1].Y * points[0].X;

            return Math.Abs(tempSum / 2);
        }
    }
}
