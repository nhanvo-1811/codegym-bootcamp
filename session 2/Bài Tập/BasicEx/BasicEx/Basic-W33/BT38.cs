using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT38
    {
        static void Main()
        {
            string str = "PHP Tutorial";

            if(str[0]=='P' && str[1]=='H')
            {
                Console.WriteLine(str.Substring(0,2));
            }
        }
    }
}
