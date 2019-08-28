using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class List
    {
        public static void Main()
        {
            List<Dictionary<int, string>> exlist = new List<Dictionary<int, string>>();
            var to1 = new Dictionary<int, string>();
            to1.Add(1, "khoa");
            exlist.Add(to1);

            var ho = new Dictionary<int, string>();
            to1.Add(2, "ho");
            exlist.Add(to1);

            foreach (var to in exlist)
            {
                foreach (var member in to)
                {
                    Console.WriteLine("id: {0}, Name: {1} ", member.Key, member.Value);
                }
            }
        }
    }
}
