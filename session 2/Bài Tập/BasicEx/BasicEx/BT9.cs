using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT9
    {
        static void Main()
        {
            double a, b, c, d;
         
            Console.Write("Enter a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Enter c: ");
            c = double.Parse(Console.ReadLine());

            Console.Write("Enter d: ");
            d = double.Parse(Console.ReadLine());

            double result = (a + b + c + d) / 4;
            Console.Write("The average of {0}, {1}, {2}, {3} is {4}", a, b, c, d, result);

        }
    }
}
