using System;

namespace Example.Ex3
{
    public class Rectangle : Shape
    {
        protected double side1;
        protected double side2;
        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }

        public void set()
        {
            C.X = side1;
            C.Y = side2;
        }
    }
}
