﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Dynamic_RunTime_Polymorphism
{
    internal class Circle:Drawing
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 5;
        }
        public override double Area()
        {
            return (3.14) * Math.Pow(Radius, 2);
        }
    }
}
