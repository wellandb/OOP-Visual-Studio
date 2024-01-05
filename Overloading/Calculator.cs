using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Calculator : Arithmetic
    {
        public float Add(float x, float y)
        {
            Console.WriteLine("Add floats called");
            return x + y;
        }

        public string Add(string x, string y)
        {
            Console.WriteLine("Add strings called");
            return "Hello " + x + " " + y;
        }
    }
}
