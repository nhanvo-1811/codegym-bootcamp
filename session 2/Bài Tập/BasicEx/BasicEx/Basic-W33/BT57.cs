using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT57
    {
        static void Main()
        {
       
            Console.WriteLine(array_adjacent_max_array(new int[] { 2, 4, 2, 6, 9, 3 }));
        }
            public static int array_adjacent_max_array(int[] array)
            {
                int max = 0;
                for (int i = 1; i < array.Length - 1; i++)
                {
                    max = Math.Max(max, array[i-1] * array[i]);
                   // max = (array[i] * array[i + 1]) > max ? max = (array[i] * array[i + 1]) : max;
                }
                return max;
            }
        }
    }

