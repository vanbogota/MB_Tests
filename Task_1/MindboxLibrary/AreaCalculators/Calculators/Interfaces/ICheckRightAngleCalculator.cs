using AreaCalculators.Figures.Interfaces;

namespace AreaCalculators.Calculators.Interfaces
{
    public interface ICheckRightAngleCalculator
    {
        /// <summary>
        /// Calculates if triangle has right angle.
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns>If triangle has right angle returns true, otherwise false.</returns>
        bool CheckIsRightTriangle(ITriangleFigure triangle);
    }
}
