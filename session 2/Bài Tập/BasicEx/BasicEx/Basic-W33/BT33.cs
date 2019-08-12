using System;

namespace BasicEx.Basic_W33
{
    class BT33
    {
        static void Main()
        {
            Console.WriteLine("\nInput first integer:");
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine(x % 3 == 0 || x % 7 == 0);
            }
        }
    }
}
