using System;
using System.Collections.Generic;
namespace BasicEx.Basic_W33
{
    class BT31
    {
        static void Main()
        {
            int[] a = { 1, 3, -5, 4 };
            int[] b = { 1, 4, -5, -2 };

            Console.WriteLine("Array1: [{0}]", string.Join(", ", a));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", b));

            Console.WriteLine("Multiply corresponding elements of two arrays: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] * b[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
