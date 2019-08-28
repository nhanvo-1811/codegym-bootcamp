using System;
using System.Collections.Generic;
using System.Text;

namespace Example.BT_P7
{
    public class P7test
    {
        public static Dictionary<int, User> UserList = new Dictionary<int, User>();
        public static User use = new User();
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
                Console.WriteLine("User Management System");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Check User");
                Console.WriteLine("3. Display all User");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please select an opition");
                Console.WriteLine("Opition: ");
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
            Console.Clear();
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Add User ................");
                        ID++;
                        Add();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Check user ................");
                        Check();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Display ................");
                        info();
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
        public static void info()
        {

            foreach (KeyValuePair<int, User> item in UserList)
            {
                Console.WriteLine(item.Value.Display());
            }
        }
        public static void Add()
        {
            use.Id = ID;
            Console.WriteLine("Input name:");
            use.Name = Console.ReadLine();
            Console.WriteLine("Input Password:");
            use.Password = Console.ReadLine();
            var number = 0;
            do
            {
                number = 0;
                Console.WriteLine("Input phoneNumber: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0)
                        use.phonelist.Add(number);
                };
            }
            while (number >= 0);
            UserList.Add(ID, use);
        }
        public static void Check()
        {

            Console.WriteLine("Please Input user name:");
            string nameuser = Console.ReadLine();
            Console.WriteLine("Please input Password:");
            string passuser = Console.ReadLine();

            var ischeck = false;
            foreach (KeyValuePair<int, User> item in UserList)
            {
                if (item.Value.Name == nameuser && item.Value.Password == passuser)
                {
                    ischeck = true;
                    break;
                }
            }
            if (ischeck)
            {
                Console.WriteLine("User checked");
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }

    }
}
