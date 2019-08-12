using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT35
    {
        static void Main()
        {

            Console.Write("Input a first number(<100): ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number(>200): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((m < 100 && n > 200));

        }
    }
}
