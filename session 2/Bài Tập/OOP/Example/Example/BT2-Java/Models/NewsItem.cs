﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Example.BT_Java.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PublishDate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }

        public double AverageRate { get; set; }

        public int[] RateList { get; set; }

    }
}
