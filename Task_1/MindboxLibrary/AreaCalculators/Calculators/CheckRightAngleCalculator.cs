using AreaCalculators.Calculators.Interfaces;
using AreaCalculators.Figures.Interfaces;

namespace AreaCalculators.Calculators
{
    public class CheckRightAngleCalculator : ICheckRightAngleCalculator
    {
        public bool CheckIsRightTriangle(ITriangleFigure triangle)
        {
            if (triangle is null)
            {
                throw new ArgumentNullException();
            }
            double[] temp = new double[] { triangle.SideA, triangle.SideB, triangle.SideC };
            double perimetr = temp.Sum();
            double hypotenuse = temp.Max();
            double katetA = temp.Min();
            double katetB = perimetr - hypotenuse - katetA;

            return hypotenuse * hypotenuse == katetA * katetA + katetB * katetB ? true : false;
        }
    }
}
