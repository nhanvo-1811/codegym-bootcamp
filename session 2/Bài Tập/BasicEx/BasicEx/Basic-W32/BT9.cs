using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT9
    {
        static void Main()
        {
            int a, b, c, d;
         
            Console.Write("Enter a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Enter c: ");
            c = int.Parse(Console.ReadLine());

            Console.Write("Enter d: ");
            d = int.Parse(Console.ReadLine());

            double result = (a + b + c + d) / 4;
            Console.Write("The average of {0}, {1}, {2}, {3} is {4}", a, b, c, d, result);

        }
    }
}
