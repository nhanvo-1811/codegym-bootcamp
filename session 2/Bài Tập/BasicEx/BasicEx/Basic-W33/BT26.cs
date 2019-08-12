using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT26
    {
        static void Main()
        {
           
            int sum = 0, count=0 , n = 2;
            
            while(count<500)
            {
                if (Check(n))
                {    
                    sum += n;
                    count++;
                    Console.WriteLine("Sum" + n);
                }
                n++;
               
            }

            Console.WriteLine("Sum" + sum);

        }

        public static bool Check(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
