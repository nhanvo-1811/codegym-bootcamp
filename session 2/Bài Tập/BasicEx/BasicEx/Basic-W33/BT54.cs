using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Basic_W33
{
    class BT54
    {
        public static int centuryFromYear(int year)
        {
            return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        }

        public static void Main()
        {
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter century : ");
            int century = int.Parse(Console.ReadLine());
            Console.WriteLine(centuryFromYear(year) == century);
            
        }
    }
}
