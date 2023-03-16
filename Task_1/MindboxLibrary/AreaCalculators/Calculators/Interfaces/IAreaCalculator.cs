using AreaCalculators.Figures.Interfaces;

namespace AreaCalculators.Calculators.Interfaces
{
    public interface IAreaCalculator<T,Tkey> where T : class where Tkey : struct
    {
        Tkey CalculateArea(T figure);
    }
}
