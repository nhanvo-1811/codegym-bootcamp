using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT55
    {
        static void Main()
        {

            Console.WriteLine("Enter product");
            int product = int.Parse(Console.ReadLine());
            Console.WriteLine(array_adjacent_max_array(new int[] { 2, 4, 2, 6, 9, 3 })== product);
        }
        public static int array_adjacent_max_array(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                //max = Math.Max(max, array[i] * array[i+1]);
                max = (array[i] * array[i + 1]) > max ? max = (array[i] * array[i + 1]) : max;
            }
            return max;
        }
    }
}
