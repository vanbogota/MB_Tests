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
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public double Perimetr { 
            get { 
                return SideA + SideB + SideC; 
            } 
        }
        public bool IsRightTriangle {
            get {
                return CheckIsRightTriangle();
            }
        }

        private bool CheckIsRightTriangle()
        {
            double[] temp = new double[] { SideA, SideB, SideC };
            double hypotenuse = temp.Max();
            double katetA = temp.Min();
            double katetB = Perimetr - hypotenuse - katetA;

            return hypotenuse * hypotenuse == katetA * katetA + katetB * katetB ? true : false;
        }
    }
}
