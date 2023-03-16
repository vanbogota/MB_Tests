namespace Task_1
{
    public interface IAreaCalculator
    {
        /// <summary>
        /// Calculate the figure area.
        /// </summary>
        /// <param name="figure"></param>
        /// <returns>Area in double type</returns>
        static abstract double Result(IFigure figure);
    }
}
