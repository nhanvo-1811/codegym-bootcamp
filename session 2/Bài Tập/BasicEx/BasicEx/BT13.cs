using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT13
    {
        static void Main()
        {
            int num, i, j;
            Console.WriteLine("Enter number: ");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <=5; i++)
            {
                for (j = 1; j <= 3; j++)
                {
                    if (i == 1 || i == 5 || j == 1 || j == 3)
                    {
                        Console.Write(Math.Abs(num));
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

        }

    }
}

