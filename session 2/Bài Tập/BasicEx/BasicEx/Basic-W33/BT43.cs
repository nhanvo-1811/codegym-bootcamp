using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT43
    {
        static void Main()
        {
            Console.Write("Input a string : ");
            string str = Console.ReadLine();
            Console.WriteLine(test(str));
        }
        public static bool test(string str)
        {
            // var ctr = 0;
            for (var i = 0; i < str.Length - 1; i++)
            {
                int ctr = 0;
                if (str[i].Equals('w')) ctr++;
                if (str.Substring(i, 2).Equals("ww") && ctr > 2)
                    return true;
            }
            return false;
        }


    }
}


