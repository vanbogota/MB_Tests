namespace Task_1
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Radius must be over 0");
            }
            _radius = radius;
        }
        /// <summary>
        /// Calculate the circle area.
        /// </summary>
        /// <returns>Area in double type</returns>
        public double CalclateArea()
        {
            var area = Math.PI * _radius * _radius;
            return area;
        }
    }
}
