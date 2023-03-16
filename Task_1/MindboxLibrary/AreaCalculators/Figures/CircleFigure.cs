using AreaCalculators.Figures.Interfaces;

namespace AreaCalculators.Figures
{
    public class CircleFigure : ICircleFugure
    {        
        public CircleFigure(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Radius must be over 0");
            }
            Radius = radius;
        }
        public double Radius { get; }

    }
}
