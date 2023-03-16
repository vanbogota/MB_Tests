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
            points.Add(points[0]);
            return Math.Abs(points
                .Take(points.Count - 1)
                .Select((p, i) => 
                    (p.X * points[i + 1].Y) - (p.Y * points[i + 1].X))
                .Sum() / 2);
        }
    }
}
