using System.Runtime.InteropServices;

namespace Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaofShapes areaSquare = new AreaofShapes();
            double a = 10.00;
            double b = 10.00;
            double area = 0.0;
            area = areaSquare.Square(a, b);
            Console.WriteLine($"area of square: {area}");
            Console.ReadLine();
        }
    }
}
