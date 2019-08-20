using System;
using System.Collections.Generic;
using System.Text;

namespace Example.BT_Ôn_tập
{
    public class BT
    {
        static void Main()
        {
            var newCat = new Cat("Kitty","Nguyen Van A", "White", "4", "false", "red" );
            newCat.Input();
            newCat.Flying();

            Console.WriteLine("Enter Boss name cat");
            newCat.OwnerName = Console.ReadLine();
            newCat.Input();
        }
    }
}
