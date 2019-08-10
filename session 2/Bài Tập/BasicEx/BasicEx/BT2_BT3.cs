using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT2_BT3
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum {0} + {1}: {2}", a, b, (a + b));
            Console.WriteLine("Diving {0} % {1}: {2} ", a, b, (a % b));

        }
    }
}
