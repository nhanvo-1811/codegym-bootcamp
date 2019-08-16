using Example.Ex1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    public class Exam1
    {
        public static void Main()
        {
            var nh = new Person();
            Person d = new Person();
            Student Stu = new Student();
            Console.WriteLine("Enter Age");
            var num = Console.ReadLine();

            if (int.TryParse(num, out var outnum))
            {   // kt neu num parse int dung thi gan gia tri cho outnum
                Stu.SetAge(outnum);
                Stu.ShowAge();
            }
            else Console.WriteLine("False");


        }
    }
}
