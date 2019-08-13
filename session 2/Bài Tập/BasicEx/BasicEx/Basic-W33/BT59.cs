using System;
using System.Linq;

namespace BasicEx.Basic_W33
{
    class BT59
    {
        static void Main()
        {
            Console.WriteLine(test_Increasing_Sequence(new int[] { 1, 3, 5, 6, 9 }));
            Console.WriteLine(test_Increasing_Sequence(new int[] { 0, 10, 10 }));
            Console.WriteLine(test_Increasing_Sequence(new int[] { 1, 3, 1, 3 }));
        }
        public static bool test_Increasing_Sequence(int[] intArray)
        {
            int[] tempArray = (int[])intArray.Clone();
            Array.Sort(tempArray);
            return intArray.SequenceEqual(tempArray);
        }
    }
}
