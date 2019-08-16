using System;
using System.Collections.Generic;
using System.Text;
using Example.Ex3;
namespace Example
{
    public class Exam3
    {
        static void Main()
        {
            var rec = new Rectangle();
            rec.Side1 = 5;
            rec.Side2 = 7;
            rec.set();
            Console.WriteLine(rec.Perimeter());

            var cir = new Circle();
            cir.Radius = 10;
            Console.WriteLine(cir.Perimeter());
        }
    }
}
