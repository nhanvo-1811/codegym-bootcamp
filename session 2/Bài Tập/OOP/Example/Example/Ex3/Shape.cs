using System;
using System.Collections.Generic;
using System.Text;
using Example.Ex3.Models;

namespace Example.Ex3
{
    public class Shape
    {
        private Location c = new Location();

        //public Shape(double x, double y)
        //{
        //    c.X = x;
        //    c.Y = y;
        //}
       public Location C { get => c; set => c = value; }
  
        public virtual double Perimeter()
        {
            return c.X * c.Y;
        }
    }
}
