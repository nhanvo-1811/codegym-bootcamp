using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT53
    {
        static void Main()

        {
            int[] nums = { 2, 4, 7, 8, 6 };
            Console.WriteLine("Array: [{0}]", string.Join(", ", nums));
            Console.WriteLine("Check if an array contains an odd number? " + Check(nums));
        }

        public static bool Check(int[] nums)
        {
            foreach (var n in nums)
            {
                if (n % 2 == 1)
                    return true;
            }
            return false;
        }
    }
}
