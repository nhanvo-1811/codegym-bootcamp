using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class LinkedList
    {
        public static void Main()
        {
            LinkedList<String> ll = new LinkedList<String>();

            ll.AddFirst("Nhan");
            var phong = ll.First;
            ll.AddAfter(phong, "Phong");

            var tu = ll.Find("Phong");
            ll.AddAfter(tu, "Tu");

            var findPhong = ll.Find("Phong");
            ll.AddAfter(findPhong, "Loc");

            foreach (var rel in ll)
            {
                Console.WriteLine("item: {0}", rel);
            }
        }
    }
}
