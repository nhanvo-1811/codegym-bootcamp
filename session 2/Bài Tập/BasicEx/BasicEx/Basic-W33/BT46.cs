using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT46
    {
        static void Main()
        {
            Console.WriteLine("Input an integer:");
            int x = int.Parse(Console.ReadLine());
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.WriteLine((nums[0] == x) || (nums[nums.Length - 1] == x));
        }
    }
}
