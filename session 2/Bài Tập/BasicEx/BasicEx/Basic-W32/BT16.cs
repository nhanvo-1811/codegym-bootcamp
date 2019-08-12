using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT16
    {
        static void Main()
        {
            Console.WriteLine("Enter String:");
            string str = Console.ReadLine();
            Console.WriteLine(Change(str));
        }

        public static string Change(string cstr)
        {
            return cstr.Length > 1 ?
                    cstr.Substring(cstr.Length - 1) + cstr.Substring(1, cstr.Length - 2) + cstr.Substring(0, 1) : cstr;
        }
    }
}
