using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT52
    {
        static void Main()
        {
            int[] array1 = { 1, 2, 5 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", array1));
            int[] array2 = { 0, 3, 8 };
            Console.WriteLine("Array2: [{0}]", string.Join(", ", array2));
            int[] array3 = { -1, 0, 2 };
            Console.WriteLine("Array3: [{0}]", string.Join(", ", array3));
            if (array1.Length % 2 == 1 && array1.Length % 2 == 1 && array1.Length % 2 == 1)
            {
                int[] new_array = { array1[array1.Length / 2], array2[array2.Length / 2], array3[array3.Length / 2] };
                Console.WriteLine("New array: [{0}]", string.Join(", ", new_array));
            }
            

        }
    }
}
