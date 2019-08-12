using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT5
    {
        static void Main()
        {
            int a, b, temp;
            Console.WriteLine("Enter the number a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Number a: {0} - Number b: {1}", a, b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Number a: {0} - Number b: {1}", a, b);
        }
    }
}
