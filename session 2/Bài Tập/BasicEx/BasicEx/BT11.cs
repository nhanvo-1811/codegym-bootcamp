using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT11
    {
        public static void Main()
        {
            int age;
            Console.Write("Enter your age ");
            age = int.Parse(Console.ReadLine());
        
            if (Math.Abs(age) < 23)
            {
                Console.Write("You look younger than 23");
            }else Console.Write("You look older than 23");
        }
    }
}
