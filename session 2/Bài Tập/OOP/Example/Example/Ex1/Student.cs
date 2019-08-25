using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Ex1
{
    public class Student : Person
    {
  
        public void GoToClasses()
        {
            Console.WriteLine("I’m going to class.");
        }

       public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", GetAge());
        }
    }
}
