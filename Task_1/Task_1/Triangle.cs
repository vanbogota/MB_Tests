namespace Task_1
{
    public class Triangle : IFigure
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;
        private readonly double _perimetr;

        public Triangle(double sideA,
                        double sideB,
                        double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Three sides must be over 0");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            _perimetr = _sideA+_sideB+_sideC;
        }
        /// <summary>
        /// Calculate the triangle area.
        /// </summary>
        /// <returns>Area of triangle in double type</returns>
        public double CalclateArea()
        {          

            double halfP = _perimetr/2;

            return Math.Sqrt(halfP*(halfP-_sideA)*(halfP-_sideB)*(halfP-_sideC));
        }
        /// <summary>
        /// Check if figure is right triangle
        /// </summary>
        /// <returns>True or false</returns>
        public bool IsRightTriangle()
        {
            double[] temp = new double[] {_sideA, _sideB, _sideC};
            double hypotenuse = temp.Max();
            double katetA = temp.Min();
            double katetB = _perimetr - hypotenuse - katetA;

            return hypotenuse * hypotenuse == katetA * katetA + katetB * katetB ? true : false;

        }
    }
}
