using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT22
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Result(n));
        }
        public static bool Result(int num)
        {
            if (Math.Abs(num - 100) <= 20 || Math.Abs(num - 200) <= 20)
                return true;
            return false;
        }
    }
}
