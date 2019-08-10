using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT14
    {
        static void Main()
        {  
                Console.Write("Enter the amount of celsius: ");
                int celsius = int.Parse(Console.ReadLine());

                Console.WriteLine("Kelvin = {0}", celsius + 273);
                Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);  
        }
    }
}

