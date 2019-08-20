using System;
using System.Collections.Generic;
using System.Text;
using Example.BT_Java.Models;

namespace Example.BT_Java
{
    public class News : INews
    {
        private int id;
        private string title;
        private string publishDate;
        private string author;
        private string content;
        private double averageRate;
        private int[] rateList = new int[3];

        public NewsItem[] ArrayList = new NewsItem[100];

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string PublishDate { get => publishDate; set => publishDate = value; }
        public string Author { get => author; set => author = value; }
        public string Content { get => content; set => content = value; }
        public double AverageRate { get => averageRate; }
        public int[] RateList { get => rateList; set => rateList = value; }

        //public void Display()
        //{
        //    foreach (var newsItem in ArrayList)
        //    {
        //        if (newsItem != null)
        //        {
        //            Console.WriteLine("+ Id: {0} \n " +
        //                "               Title {1} \n " +
        //                "               PublishDate {2} \n" +
        //                "               Author {3} \n" +
        //                "               Content {4} \n ",
        //                                  newsItem.Id, newsItem.Title, newsItem.PublishDate,
        //                                                newsItem.Author, newsItem.Content);
        //        }

        //    }
        //    for (var i = 0; i < RateList.Length; i++)
        //    {
        //        Console.WriteLine("Rare {0}: {1} ", (i+1), RateList[i]);
        //    }
        //}
        public void Display()
        {
            foreach (var newsItem in ArrayList)
            {
                if (newsItem != null)
                {
                    Console.WriteLine("+ Id: {0} \t\t " +
                        "               Title {1} \t\t " +
                        "               PublishDate {2} \t\t" +
                        "               Author {3} \t\t " +
                        "               Content {4} \t\t " +
                        "               AverageRate {5}", newsItem.Id, newsItem.Title, newsItem.PublishDate,
                                                        newsItem.Author, newsItem.Content, newsItem.AverageRate);
                }
            }
        }

        //public void Calculate()
        //{
        //    foreach(var newsItem in ArrayList)
        //    {
        //        if(newsItem != null)
        //        {
        //            var total = 0;
        //            for (int i = 0; i < newsItem.RateList.Length; i++)
        //            {
        //                total += RateList[i];
        //            }
        //            newsItem.AverageRate = (double)(total / newsItem.RateList.Length);
        //        }
        //    }            
        //}

        public void Calculate()
        {
            foreach (var newsItem in ArrayList)
            {
                if (newsItem != null)
                {
                    newsItem.AverageRate = CalculateRate(newsItem);
                }
            }
        }

        private double CalculateRate(NewsItem newsItem)
        {
            var total = 0;
            for (int i = 0; i < newsItem.RateList.Length; i++)
            {
                total += RateList[i];
            }
            return (double)(total / newsItem.RateList.Length);
        }

        public void InsertNews(int index)
        {
            var newsItem = new NewsItem()
            {
                Id = id,
                Title = title,
                PublishDate = publishDate,
                Content = content,
                Author = author,
                AverageRate = averageRate,
                RateList = rateList
            };
            ArrayList[index] = newsItem;
            
        }
    }
}




