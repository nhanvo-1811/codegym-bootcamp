using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT61
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 1, -6, 2, 9, -20, -5, 1, 8, 5, 7, 9 };

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == -5 || array[i + 1] == -5)
                {
                    continue;
                }

                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            Console.Write("Sorted array: {0}", string.Join(",", array));
            Console.ReadKey();
        }

    }
}

