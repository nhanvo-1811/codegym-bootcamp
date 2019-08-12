using System;

namespace BasicEx.Basic_W33
{
    class BT34
    {
        static void Main()
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter string: ");
            string str1 = Console.ReadLine();

            Console.WriteLine(str.StartsWith(str1));
        }
    }
}
