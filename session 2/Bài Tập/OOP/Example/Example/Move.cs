using System;
using System.Collections.Generic;
using System.Text;
using Example.BT_P7_2;

namespace Example
{
    class Move : IMove
    {

        private int id;
        private string name;
        private DateTime publishDate;
        private string director;
        private string subtitle;
        private float averageRate;
        List<int> rateList = new List<int>(3); 

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime PublishDate { get => publishDate; set => publishDate = value; }
        public string Director { get => director; set => director = value; }
        public string Subtitle { get => subtitle; set => subtitle = value; }
        public float AverageRate { get => averageRate; set => averageRate = value; }

        public string Display()
        {
            return $"ID: {Id}  Name: {Name} PublishDate: {PublishDate}  Director: {Director} Subtitle: {Subtitle}" +
                  $"averageRate: {AverageRate}";
        }

        public float CalAverageRate()
        {
            var total = 0;
            foreach (int item in rateList)
            {
                total += item;
            }
            return averageRate = total / rateList.Count;

        }
    }
}
