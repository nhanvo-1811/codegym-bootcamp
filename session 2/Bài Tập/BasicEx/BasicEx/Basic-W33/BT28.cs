using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT28
    {
        static void Main()
        {
            Console.WriteLine("Enter String: ");
            string str = Console.ReadLine();

            string[] strii = str.Split(" ");
            Console.WriteLine(String.Join(", ", strii));
            Array.Reverse(strii);
            Console.WriteLine(String.Join(", ", strii));

        }
    }
}
