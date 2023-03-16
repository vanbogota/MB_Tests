using AreaCalculators.Figures.Interfaces;

namespace AreaCalculators.Calculators.Interfaces
{
    public interface IAreaCalculator<T,Tkey> where T : class where Tkey : struct
    {
        /// <summary>
        /// Calculates the area of specified figure or of several points.
        /// </summary>
        /// <param name="figure"></param>
        /// <returns>Calculation result in struct type</returns>
        Tkey CalculateArea(T figure);
    }
}
