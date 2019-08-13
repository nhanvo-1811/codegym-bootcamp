using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT51
    {
        static void Main()
        {
            int[] arr = new int[4];
            for(int i=0; i < 4; i ++)
            {
                Console.WriteLine("Mời nhập phần tử");
                arr[i] = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine(arr);
        }
    }
}
