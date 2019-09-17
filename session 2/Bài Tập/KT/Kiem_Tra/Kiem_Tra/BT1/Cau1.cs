using System;
using System.Collections.Generic;
using System.Text;

namespace Kiem_Tra.BT1
{
    public class Cau1
    {
        static void Main(string[] args)
        {
            int n = KtInput("row");
            int m = KtInput("column");
            int[,] array = InitMatrix(n, m);
            ShowMaxRow(array);
        }
        public static int KtInput(string a)
        {
            int size = -1;
            do
            {
                Console.Write("Input {0}: ", a);
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    size = number;
                }
            }
            while (size <= 0);
            return size;
        }
        public static int[,] InitMatrix(int row, int column)
        {
            int[,] array = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    var number = 0;
                    var kt = false;
                    do
                    {
                        Console.Write("Input Array[{0}, {1}]: ", i, j);
                        if (int.TryParse(Console.ReadLine(), out number))
                        {
                            array[i, j] = number;
                            kt = true; ;
                        }
                    }
                    while (!kt);
                }
            }
            return array;
        }
        public static int Sum(int[,] array, int row)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                sum += array[row, i];
            }
            return sum;
        }
        public static void ShowMaxRow(int[,] array)
        {
       
            int maxRow = 0;
            for (int i = 1; i < array.GetLength(0); i++)
            {
                if (Sum(array, i) > Sum(array, maxRow))
                {
                    maxRow = i;
                }
            }
            Console.WriteLine("Max Row: ");
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.Write(array[maxRow, i] + " ");
            }
        }
    }
}
