using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT21
    {
        static void Main()
        {
            Console.Write("Enter num1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num1: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Result(num1,num2));
        }
        public static bool Result(int x, int y)
        {
            if ((x == 20) || (y == 20) || ((x + y) == 20))
                return true;
            return false;
        }
    }
}
