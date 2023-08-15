namespace AreaCalculators.Implementation
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Radius must be over 0");
            }
            Radius = radius;
        }
        public double Radius { get; }

        /// <summary>
        /// Calculates circle area by radius.
        /// </summary>
        /// <returns>Circle area</returns>
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
