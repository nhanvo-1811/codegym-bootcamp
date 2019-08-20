using System;
using System.Collections.Generic;
using System.Text;
using Example.BT1_Java.Models;

namespace Example.BT1_Java
{
    public class ManagePhoneBook
    {
        public static PhoneBook phonebook = new PhoneBook();
        public static void Main()
        {
            InitMenu();

        }
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("PhoneBook Management System");
                Console.WriteLine("1. Insert Phone");
                Console.WriteLine("2. Remove Phone");
                Console.WriteLine("3. Update Phone");
                Console.WriteLine("4. Search Phone");
                Console.WriteLine("5. Sort");
                Console.WriteLine("6. Display");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Please select an opition");

                Console.WriteLine("Opition: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 7 || option <= 0);
            Process(option);
        }
        public static void Process(int selected)
        {
            Console.Clear();
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Insert Phone ................");
                        Console.Write("Input name: ");
                        var name = Console.ReadLine();

                        Console.Write("Input phone: ");
                        var phone = Console.ReadLine();
                        phonebook.insertPhone(name, phone);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Remove Phone ................");
                        Console.Write("Input name: ");
                        var name = Console.ReadLine();
                        phonebook.removePhone(name);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Update Phone ................");
                        Console.Write("Input name: ");
                        var name = Console.ReadLine();

                        Console.Write("Input phone: ");
                        var phone = Console.ReadLine();
                        phonebook.updatePhone(name, phone);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Search Phone ................");
                        Console.Write("Input name: ");
                        var name = Console.ReadLine();
                        phonebook.searchPhone(name);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Sort ................");
                        phonebook.sort();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Display ................");
                        Display();
                        break;
                    }
                case 7:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }

        public static void input()
        {
            Console.Write("Input name: ");
            var name = Console.ReadLine();

            Console.Write("Input phone: ");
            var phone = Console.ReadLine();
        }

        public static void Display()
        {
            Console.WriteLine("Name\t\t\tPhoneNumber");
            if (phonebook.PhoneList != null && phonebook.PhoneList.Count > 0)
            {
                foreach (PhoneItem phoneItem in phonebook.PhoneList)
                {
                    Console.WriteLine("{0}\t\t\t{1}", phoneItem.name, phoneItem.phoneNumber) ;
                }
            }
        }
    }
}
