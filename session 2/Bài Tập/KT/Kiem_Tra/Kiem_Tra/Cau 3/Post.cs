using System;
using System.Collections.Generic;
using System.Text;

namespace Kiem_Tra.Cau_3
{
    public class Post : IPost
    {
        private int id;
        private string tittle;
        private string content;
        private string author;
        private float AverageRate;

        public int Id { get => id; set => id = value; }
        public string Tittle { get => tittle; set => tittle = value; }
        public string Content { get => content; set => content = value; }
        public string Author { get => author; set => author = value; }
        public float AverageRate1 { get => AverageRate; private set => AverageRate = value; }

        public int[] Rates = new int[4];

        public string Display()
        {
            return $"Id: {Id}\tTitle: {Tittle}\tContent: {Content}\tAuthor: {Author}\tAverage Rate: {AverageRate}";
        }

        public void CalculatorRate()
        {
            int sum = 0;
            for (int i = 0; i < Rates.Length; i++)
            {
                sum += Rates[i];
            }
            AverageRate = (float)(sum / Rates.Length);
        }
    }
}
