using System;
using System.Collections;
using System.Text;
using Example.BT4_Java;

namespace Example.BT4_Java
{

    public class BT4_Java
    {
        public static ArrayList markList = new ArrayList();
        public static int ID = 0;
        public static void Main()
        {
            InitMenu();
        }
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("1. Insert new Student ....");
                Console.WriteLine("2. View list of Student ...");
                Console.WriteLine("3. Average Mark ...");
                Console.WriteLine("4. Exit");
                Console.Write("Opition:  ");
               
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 4 || option <= 0);
            Process(option);
        }
        public static void Process(int selected)
        {
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Insert news ................");
                        ID++;
                        InsertStudent();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View list of student ................");
                        DisplayStudent();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Average Mark ................");
                        Average();
                        DisplayStudent();
                        break;
                    }
                case 4:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }
        public static void InsertStudent()
        {
            var student = new StudentMark();
            student.Id = ID;

            Console.WriteLine("Full name");
            student.FullName = Console.ReadLine();

            Console.WriteLine("Class name");
            student.Class= Console.ReadLine();

            Console.WriteLine("Sermester");
            student.Semester = int.Parse(Console.ReadLine());

            Console.WriteLine("Input SubjectMark: ");
            for (int i = 0; i < student.subjectMark.Length; i++)
            {
                Console.WriteLine("Input rate {0}", i + 1);
                student.subjectMark[i] = int.Parse(Console.ReadLine());
            }
           // student.AveCal();
            markList.Add(student);

        }
        public static void DisplayStudent()
        {
            foreach (StudentMark student in markList)
            {
                Console.WriteLine(student.Display());
            }
        }
        public static void Average()
        {
            foreach (StudentMark student in markList)
            {
                student.AveCal();
            }
        }


    }
}


