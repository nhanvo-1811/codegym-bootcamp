using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT12
    {
        static void Main()
        {
            int num;

            Console.WriteLine("Enter a Number: ");
            num = int.Parse(Console.ReadLine());

            // Row 1
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.WriteLine();

            // Row 2
            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine(num);
            Console.WriteLine();

            // Row 3 using {0}
            Console.WriteLine("{0} {0} {0} {0}", num);

            // Row 4 using {0}
            Console.WriteLine("{0}{0}{0}{0}", num);
        }
    }
}
