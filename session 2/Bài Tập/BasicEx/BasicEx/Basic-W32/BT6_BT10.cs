using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT6_BT10
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter c:");
            c = Convert.ToInt32(Console.ReadLine());

            int x = (a + b) * c;
            int z = a * b + b * c;
            int y = a * b * c;
            Console.WriteLine("Result {0}, {1} and {2}, (a+b)*c is {3} and a*b + b*c is {4}", Math.Abs(a), Math.Abs(b), Math.Abs(c), x, z);
            Console.WriteLine("Sum {0} x {1} x {2} = {3}", Math.Abs(a), Math.Abs(b), Math.Abs(c), Math.Abs(y));


        }
    }
}
