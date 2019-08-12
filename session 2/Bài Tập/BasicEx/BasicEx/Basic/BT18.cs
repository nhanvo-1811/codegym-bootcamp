using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT18
    {
        static void Main()
        {
            Console.WriteLine("Enter number first ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number first ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine((num1 > 0 && num2 < 0) || (num1 < 0 && num2 > 0));
            Console.WriteLine(Checkk(num1, num2));
        }

        public static bool Checkk(int x, int y)
        {
            return ((x > 0 && y < 0) || (x < 0 && y > 0)) ? true : false;
        }
    }
}
