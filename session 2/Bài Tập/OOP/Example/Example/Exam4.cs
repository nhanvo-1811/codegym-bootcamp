using Example.Ex4;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    public class Exam4
    {
        public static void Main()
        {
            Console.WriteLine("-----------Chicken-----------");
            var chip = new Chicken();
            Console.WriteLine("chip say: {0}", chip.MakeSound());
            Console.WriteLine("chip eat: {0}", chip.HowToEat());

            Console.WriteLine("-----------Tiger-----------");
            var simba = new Chicken();
            Console.WriteLine("simba say: {0}", simba.MakeSound());
            Console.WriteLine("simba eat: {0}", simba.HowToEat());

            Console.WriteLine("-----------Apple-----------");
            var iphone = new Chicken();
            Console.WriteLine("iphone say: {0}", iphone.MakeSound());
            Console.WriteLine("iphone eat: {0}", iphone.HowToEat());

            Console.WriteLine("-----------Orange-----------");
            var green = new Chicken();
            Console.WriteLine("green say: {0}", iphone.MakeSound());
            Console.WriteLine("green eat: {0}", iphone.HowToEat());
            Console.ReadKey();
        }
        
    }
}
