﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class AreaofShapes : AreaofSquare
    {
        public double Rectangle(double a, double b)
        {
            return a*b;
        }

        public override double Square(double a, double b)
        {
            Console.WriteLine("Area of shapes called a*b");
            return a*b;
        }
    }
}
