﻿namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class and create an object
            Calculator calc = new Calculator();
            // Create a local variable to hold the answer
            int x = 3;
            int y = 5;
            int sum = 0;
            sum = calc.Add(x, y);
            Console.WriteLine("sum of {0} + {1} = {2}", x, y, sum);
            Console.WriteLine("sub of {0} + {1} = {2}", x, y, calc.Subtract(x, y));
            Console.WriteLine("mult of {0} + {1} = {2}", x, y, calc.Multiply(x, y));
            double a = 3;
            double b = 5;
            Console.WriteLine($"division of {a} + {b} = {calc.Divide(a, b)}");
            Console.ReadLine();
        }
    }
}
