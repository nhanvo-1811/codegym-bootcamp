using System;
using System.Collections.Generic;
using System.Text;


namespace Example.BT_Java
{
    public class NewsTest
    {
        public static News news = new News();
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
                Console.WriteLine("Management News");
                Console.WriteLine("1. Insert news");
                Console.WriteLine("2. View list news");
                Console.WriteLine("3. Average news");
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
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Insert news ................");
                        ID++;
                        InsertNews();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View list news ................");
                        news.Display();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Average news ................");
                        news.Calculate();
                        news.Display();
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
        public static void InsertNews()
        {
            news.Id = ID;
            Console.Write("Input title: ");
            news.Title = Console.ReadLine();

            Console.Write("Input PublishDate: ");
            news.PublishDate = Console.ReadLine();

            Console.Write("Input Author: ");
            news.Author = Console.ReadLine();

            Console.Write("Input Content: ");
            news.Content = Console.ReadLine();

            Console.WriteLine("Input rate: ");
            for(int i = 0; i< news.RateList.Length; i++)
            {
                Console.WriteLine("Input rate {0}", i + 1);
                news.RateList[i] = int.Parse(Console.ReadLine());
            }
            news.InsertNews(ID);
           
        }
    }
}
