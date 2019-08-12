using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT17
    {
        static void Main()
        {
            Console.WriteLine("Enter String:");
            string str = Console.ReadLine();
            Console.WriteLine(Create(str));
        }

        public static string Create(string cstr)
        {
            return cstr.Length > 1 ?
                    cstr.Substring(0,1) + cstr + cstr.Substring(0, 1) : cstr;
        }
    }
}
