using Task_1;

namespace Test_Task_1
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            IFigure figure = new Circle(10);

            var sqC = figure.CalclateArea();

            IFigure figure1 = new Triangle(3, 4, 5);

            var sqT = figure1.CalclateArea();

            Console.WriteLine(sqC);
            Console.WriteLine(sqT);
        }
    }
}