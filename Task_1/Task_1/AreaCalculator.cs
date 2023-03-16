namespace Task_1
{
    public class AreaCalculator : IAreaCalculator
    {
        /// <summary>
        /// Calculate the figure area.
        /// </summary>
        /// <param name="figure"></param>
        /// <returns>The figure area in double type</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static double Result(IFigure figure)
        {
            if (figure is null)
            {
                throw new ArgumentNullException("Figure must not be null");
            }
            return figure.CalclateArea();        
        }
    }
}
