﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Triangle : IShape
    {
        public double height { get; set; }
        public double width { get; set; }

        public double Area()
        {
            return (height * width)/2;
        }

        public double perimeter() 
        {
            return 0.0;
        }
    }
}
