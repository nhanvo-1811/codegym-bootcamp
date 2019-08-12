using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT47
    {
        static void Main()
        {
            //int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] nums = new int[3];
            //Console.WriteLine("Array1: [{0}]", string.Join(", ", nums));
            var sum = 0;
            //for (var i = 0; i < nums.Length; i++)
            //{
            //    sum += nums[i];
            //}
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter num");
                nums[i] = int.Parse(Console.ReadLine());
                sum += nums[i];
            }
            Console.WriteLine("Array1: [{0}]", string.Join(", ", nums));
            Console.WriteLine("Sum: " + sum);
        }
    }
}
