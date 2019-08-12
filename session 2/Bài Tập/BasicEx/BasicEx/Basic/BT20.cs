using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT20
    {
        static void Main()
        {
            Console.WriteLine("Enter number first ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number first ");
            int num2 = int.Parse(Console.ReadLine());

            //int result = (num1 > num2) ? ((num1 - num2) * 2) : (num1 - num2);
            //Console.WriteLine("Result: {0} ", result);
            if (num1 > num2)
            {
                Console.WriteLine("Sub*2: " +(num1 - num2) * 2);
            }
            else
            {
                Console.WriteLine("Sub" + (num1 - num2));
            }
           
        }
    }
}
