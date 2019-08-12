using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT32
    {
        static void Main()
        {
            string str;

            Console.Write("Input a string : ");
            str = Console.ReadLine();
            string len = str.Substring(str.Length - 4);
            Console.WriteLine(str.Length < 4 ? str + str + str : len + len + len + len);
        }
    }
}

