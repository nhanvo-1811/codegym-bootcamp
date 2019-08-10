using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx
{
    class deleteWhileArray
    {
        static void Main()
        {
            string str = "    BBB  vvv     f  fsasdssa   fffssad    ";
            int c = 0;
            str = str.Trim() + ' ';

            Console.WriteLine(str);
            for (var i = 0; i < str.Length - 1; i++)
            {
                //if (str[i] == ' ' && !str[i + 1].Equals(" "))
                if (str[i] != ' ' && str[i + 1] == ' ')
                {
                    //c++;
                    str.Trim();
                    Console.WriteLine(str);
                }
            }
            //Console.WriteLine("soos " + c);

        }
    }
}
