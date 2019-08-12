using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class reveserArray
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 10, 4, 5 };
            Console.WriteLine(string.Join(",", array));
            var firt = 0;
            var last = array.Length - 1;
            while (firt < last)
            {
                var temp = array[firt];
                array[firt] = array[last];
                array[last] = temp;
                firt++;
                last--;
            }
            Console.WriteLine(string.Join(",", array));
        }
    }
}
