using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    public class Array
    {
        public int[,] arr =
            {
                {1,2 },
                {3,2 },
                {4,5 }
            };
        //public Array()
        //{
        //    arr = new int[3, 3];
        //    for (int i = 0; i < arr.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < arr.GetLength(1); j++)
        //        {
        //            Console.WriteLine("Enter array [{0} , {1}]", i, j);
        //            arr[i, j] = int.Parse(Console.ReadLine());
        //            // return arr[i, j];
        //        }
        //        Console.WriteLine();
        //    }

        //}

        public int SumArray(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "  ");
                    sum += arr[i, j];
                }
                Console.WriteLine();
            }
            return sum;
        }
    }
}
