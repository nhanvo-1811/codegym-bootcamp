using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.OOP
{

    class BT1
    {
        static void Main()
        {
            Triangle Tri = new Triangle();
            Tri.arre();
        }
    }
    public class Shape
    {
        public double side1;
        public double side2;
        public double side3;
    }
    public class Triangle: Shape
    {
   

        public Triangle()
        {
            side1 = 1.0;
            side2 = 1.0;
            side3 = 1.0;
        }
        public Triangle(double sid1, double sid2, double sid3)
        {
            side1 = sid1;
            side1 = sid1;
            side1 = sid1;
        }

        public void arre()
        {
            Console.WriteLine("side1" + side1);
        }


    }
}
