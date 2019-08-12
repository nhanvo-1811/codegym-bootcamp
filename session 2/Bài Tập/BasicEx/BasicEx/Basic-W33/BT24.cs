using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class BT24
    {
        static void Main()
        {
            Console.WriteLine("Enter String: ");
            string line = Console.ReadLine();
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            Console.WriteLine(line);
            Console.WriteLine(words);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);
        }
    }
}

