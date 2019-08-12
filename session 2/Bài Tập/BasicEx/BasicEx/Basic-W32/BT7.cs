using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT7
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum {0} + {1}: {2}", a, b, (a + b));
            Console.WriteLine("Sub {0} - {1}: {2}", a, b, (a - b));
            Console.WriteLine("Mul {0} x {1}: {2}", a, b, (a * b));
            Console.WriteLine("Diving {0} / {1}: {2}", a, b, (a / b));
            Console.WriteLine("Mod {0} mod {1}: {2} ", a, b, (a % b));

        }
    }
}
