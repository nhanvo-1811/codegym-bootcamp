using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT37
    {
        static void Main()
        {
            string str = "PHP Tutorial";
            string str1 = "HP";

            if(str.Contains(str1))// kiểm tra chuỗi str1 tồn tại trong str k.
            {
                Console.WriteLine(str.Remove(str.IndexOf(str1),str1.Length));
            }
        }
    }
}
