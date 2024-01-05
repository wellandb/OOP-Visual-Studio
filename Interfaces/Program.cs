namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Circle circle = new Circle();
            double a = 10;
            double b = 20;
            double c = 1.0;
            double area = 0.0;
            double perimeter = 0.0;
            rec.height = a;
            rec.width = b;
            area = rec.Area();
            Console.WriteLine($"Area of rectange is {area}");
            perimeter = rec.perimeter();
            Console.WriteLine($"Perimeter of rectangle is {perimeter}");
            Console.ReadLine();
            Console.WriteLine("---------------");
            Console.WriteLine("Circle area and perimeter");
            circle.radius = c;
            area = circle.Area();
            Console.WriteLine($"Area of circle is {area:F}");
            perimeter = circle.perimeter();
            Console.WriteLine($"Perimeter of circle is {perimeter:F}");
            Console.ReadLine();
            Console.WriteLine("---------------");
            Triangle triangle = new Triangle();
            a = 10;
            b = 20;
            triangle.height = a;
            triangle.width = b;
            area = triangle.Area();
            Console.WriteLine($"Area of triangle is {area:F}");
            Console.ReadLine();
        }
    }
}
