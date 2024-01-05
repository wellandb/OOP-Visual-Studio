namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int a = 1;
            int b = 2;
            float c = 3.0f;
            float d = 4.0f;
            double e = 5.0d;
            double f = 6.0d;
            String firstName = "Joe";
            String lastName = "Bloggs";
            Console.WriteLine("Add int: {0}", calc.Add(a,b));
            Console.WriteLine("Add float: {0}", calc.Add(c, d));
            Console.WriteLine("Add double: {0}", calc.Add(e, f));
            Console.WriteLine("Add string: {0}", calc.Add(firstName, lastName));
            Console.ReadLine();
        }
    }
}
