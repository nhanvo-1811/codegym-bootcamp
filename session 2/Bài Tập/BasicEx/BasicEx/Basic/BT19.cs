using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT19
    {
        static void Main()
        {
            Console.WriteLine("Enter number first ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number first ");
            int num2 = int.Parse(Console.ReadLine());

            //int sum = (num1 == num2) ? ((num1 + num2) * 3) : (num1 + num2);
            //Console.WriteLine("Sum: {0} ", sum);

            if (num1 == num2)
            {
                Console.WriteLine("SumTriple: " + (num1 + num2) * 3);
            }
            else
            {
                Console.WriteLine("Sum: " + (num1 + num2));
            }
        }
    }
}
