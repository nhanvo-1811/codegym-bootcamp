using System;


namespace BasicEx.Basic_W33
{
    class BT39
    {
        static void Main()
        {
            Console.WriteLine("\nInput first integer:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Input third integer:");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));
            Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, z)));
        }
    }
}
