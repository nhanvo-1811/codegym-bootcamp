using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.IO
{
    public class BT2
    {
        public static void Main()
        {

        }
        public static bool PrimeNumber(int a)
        {
            if (a < 2) return false;
            for (int i = 0; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;


        }
    }
}
