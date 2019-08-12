using System;
using System.Collections.Generic;
using System.IO;

namespace BasicEx.Basic_W33
{
    class BT29
    {
        static void Main()
        {
            FileInfo f = new FileInfo("/home/students/abc.txt");
            Console.WriteLine("\nSize of a file: " + f.Length.ToString());
        }
    }
}
