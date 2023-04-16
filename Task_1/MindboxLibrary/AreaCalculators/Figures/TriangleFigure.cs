using AreaCalculators.Figures.Interfaces;

namespace AreaCalculators.Figures
{
    public class TriangleFigure : ITriangleFigure
    {
        public TriangleFigure(
            double sideA,
            double sideB,
            double sideC)
        {
            if (sideA <= 0 ||
                sideB <= 0 ||
                sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Three sides must be over 0");
            }
            if ((sideA+sideB)>sideC &&
                (sideB+sideC)>sideA &&
                (sideC+sideA)>sideB)
            {
                throw new Exception("It is not a triangle");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
    }
}
