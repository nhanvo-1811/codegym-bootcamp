using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class arrayMax
    {
        static void Main()
        {
            int[] array = { 1, 2, 10, 4, 5 };
            var max = array[0];
            for (var i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
            Console.WriteLine("Max array " + max);
        }
    }
}
    //class Sort
    //{
    //    static void sort()
    //    {
    //        var t = new arrayMax();
    //        for (var i = 1; i < Length; i++)
    //        {

    //        }
    //    }
    //}

