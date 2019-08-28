using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class StackQueue
    {
        public static void Main()
        {
            Stack<int> money = new Stack<int>();

            money.Push(500);
            money.Push(300);
            money.Push(400);

            foreach (var item in money)
            {
                Console.WriteLine("item: {0}", item);
            }
            Console.WriteLine("item on top : {0}", money.Peek());
        }


    }
}
