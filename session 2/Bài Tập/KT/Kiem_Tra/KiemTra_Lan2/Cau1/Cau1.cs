using System;
using System.Collections.Generic;
using System.Text;

namespace KiemTra_Lan2.Cau1
{
    public static class Cau1
    {
        public static void Main()
        {
            int n = KtInput("row");
            int m = KtInput("column");
            int[,] array = CreateMatrix(n, m);

            Console.WriteLine("Max: {0}", FindMax(array, n, m));
            ShowMatrix(array,n,m);
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

        public static int[,] CreateMatrix(int row, int column)
        {
            int[,] A = new int[row, column];
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
                            A[i, j] = number;
                            kt = true; ;
                        }
                    }
                    while (!kt);
                }
            }
            return A;
        }

        public static int FindMax(int[,] A, int row, int column)
        {
            var max = A[0, 0];
            for (int i = 1; i < row; i++)
            {
                for (int j = 1; j < column; j++)
                {
                    if (max < A[i, j])
                    {
                        max = A[i, j];
                    }
                }
            }
            return max;
        }
        public static void ShowMatrix(int[,] A, int row, int column)
        {

            for (int i = 0; i < row; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < column; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("{0}  ", A[i, j]);
                    }
                    else
                    {
                        Console.Write("{0}  ", " ");
                    }
                }
                Console.Write("\n\n");
            }
        }
    }
}
