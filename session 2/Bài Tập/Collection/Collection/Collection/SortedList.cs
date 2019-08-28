using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class SortedList
    {
        public static void Main()
        {
            //SortedList<string, string> exList = new SortedList<string, string>();
           // SortedList<string, List<string>> exList1 = new SortedList<string, List<string>>();
            Dictionary<string, string> exList = new Dictionary<string, string>();

            // add item

            exList.Add("Nhan", "Game lol");
            exList.Add("Loc", "Co vua");
            exList.Add("Bao", "Shopee");
            exList.Add("Baao", "Shopee");
            //exList1.Add("Nhan", new List<string> { "a", "b" });
            ////show all by value 
            //foreach (var item in exList.Values)
            //{

            //}
            ////show all by key
            //foreach (var key in exList1.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            // show all values by key
            //foreach (var item in exList.Keys)
            //{
            //    Console.WriteLine("key: {0}\t value: {1}", item, exList[item]);
            //}
            ////foreach (KeyValuePair<string, string> item in exList)
            ////{
            ////    Console.WriteLine("key: {0}\t value: {1}", item.Key, item.Value);
            ////}

            //exList.Remove("Baao");
            //Console.WriteLine("-----------------------");
            //// show all values by key
            //foreach (var item in exList.Keys)
            //{
            //    Console.WriteLine("key: {0}\t value: {1}", item, exList[item]);
            //}

            //string locvalue;
            //exList.Remove("Loc", out locvalue);
            //Console.WriteLine("-----------------------");
            //Console.WriteLine(locvalue);
            //Console.WriteLine("-----------------------");
            //// show all values by key
            //foreach (var item in exList.Keys)
            //{
            //    Console.WriteLine("key: {0}\t value: {1}", item, exList[item]);
            //}

            //exList.RemoveAt(exList.Count - 1);
            //Console.WriteLine("-----------------------");
            //// show all values by key
            //foreach (var item in exList.Keys)
            //{
            //    Console.WriteLine("key: {0}\t value: {1}", item, exList[item]);
            //}

            //Console.WriteLine("-----------------------"); 
            //// show all values by using Enumerator
            var enumnator = exList.GetEnumerator();
            while (enumnator.MoveNext())
            {
                Console.WriteLine("key: {0}\t value: {1}", enumnator.Current.Key, enumnator.Current.Value);
            }
            if(exList.ContainsKey("Nhan"))
            {
                Console.WriteLine("yes");
            }
            // kiem tra key xem neu co thi tra ve value duoc gan cho bien val 
            string val;
            exList.TryGetValue("Nhan", out val);
            Console.WriteLine(val);
        }
    }
}
