using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Ex3
{
    public class Circle : Shape
    {
        protected double radius;
        protected double pi = 3.14;

        public double Radius { get => radius; set => radius = value; }
        
        
        public override double Perimeter()
        {
            return 2*radius*pi;
        }
    }
}
