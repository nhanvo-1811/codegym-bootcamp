using System;
using System.Collections.Generic;
using System.Text;

namespace KiemTra_Lan2.Cau3
{
    public class AccountList
    {

        public static Dictionary<int, Account> Accounts = new Dictionary<int, Account>();
        public static Account acc = new Account();
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
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Payinto");
                Console.WriteLine("3. Show Data");
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
                        Console.WriteLine("Create Account ................");
                        ID++;
                        CreateAccount();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Check Account ................");
                        PayInto();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Display ................");
                        ShowData();
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
        public static void CreateAccount()
        {
            acc.AccountId = ID;
            Console.WriteLine("Input FirstName:");
            acc.FirstName = Console.ReadLine();
            Console.WriteLine("Input LastName:");
            acc.LastName = Console.ReadLine();
            Console.WriteLine("Input Gender:");
            acc.Gender = Console.ReadLine();
            Accounts.Add(ID, acc);
        }
        public static void ShowData()
        {
            foreach (KeyValuePair<int, Account> item in Accounts)
            {
                Console.WriteLine(acc.ShowInfo());
            }
        }
        public static void PayInto()
        {
            Console.WriteLine("Nhap so tien can nhap");
            int pay = int.Parse(Console.ReadLine());
            acc.Balance += pay;
            acc.PayInto();
        }
    }
    
}
