using System;
using System.Collections.Generic;
using System.Text;

namespace Example.BT9
{
    public class Move : IMovie
    {
        public int id;
        public string name;
        public DateTime publishDate;
        public string director;
        public string subtitle;
        private float averageRate;
        public int[] rateList = new int[3];

        public float AverageRate { get => averageRate;}

        public string Display()
        {
            return $"Name: { name} ID: { id}  PublishDate { publishDate}  " +
                   $"Director: { director} Subtitle: { subtitle} AverageMark: { averageRate}";
        }

        public void CalRate()
        {
            var total = 0;
            for (int i = 0; i < rateList.Length; i++)
            {
                total += rateList[i];
            }
            averageRate = total / rateList.Length;
        }
    }
}
