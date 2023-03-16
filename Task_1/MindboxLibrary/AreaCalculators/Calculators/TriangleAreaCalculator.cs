using AreaCalculators.Calculators.Interfaces;
using AreaCalculators.Figures;
using AreaCalculators.Figures.Interfaces;

namespace AreaCalculators.Calculators
{
    public class TriangleAreaCalculator : ITriangleAreaCalculator
    {
        public double CalculateArea(ITriangleFigure figure)
        {
            double halfP = figure.Perimetr / 2;

            return Math.Sqrt(halfP * (halfP - figure.SideA) * (halfP - figure.SideB) * (halfP - figure.SideC)); 
        }          
    }
}
