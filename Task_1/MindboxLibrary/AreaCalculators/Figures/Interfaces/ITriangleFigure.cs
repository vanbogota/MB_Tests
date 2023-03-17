namespace AreaCalculators.Figures.Interfaces
{
    public interface ITriangleFigure : IFigure
    {
        double SideA { get; }
        double SideB { get; }
        double SideC { get; }        
    }
}
