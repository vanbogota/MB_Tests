namespace AreaCalculators.Implementation
{
    public class Triangle : Shape
    {
        public Triangle(
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

            if (!(sideA + sideB > sideC &&
                sideB + sideC > sideA &&
                sideC + sideA > sideB))
            {
                throw new Exception("It is not a triangle");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        /// <summary>
        /// Calculates triangle area by three sides (the Geron theorem).
        /// </summary>
        /// <returns>Triangle area</returns>
        public override double CalculateArea()
        {
            double halfP = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(halfP * (halfP - SideA) * (halfP - SideB) * (halfP - SideC));
        }

        /// <summary>
        /// Check if triangle is right.
        /// </summary>
        /// <returns>true or false </returns>
        public bool CheckIsRightTriangle()
        {
            double[] temp = new double[] { SideA, SideB, SideC };
            double perimetr = temp.Sum();
            double hypotenuse = temp.Max();
            double katetA = temp.Min();
            double katetB = perimetr - hypotenuse - katetA;

            return (hypotenuse * hypotenuse).CompareTo(katetA * katetA + katetB * katetB) == 0 ? true : false;
        }
    }
}
