using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT8
    {
        static void Main()
        {
            int num;
            Console.Write("Enter number:");
            num = int.Parse(Console.ReadLine());

            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, (num * i));
            }
        }
    }
}
