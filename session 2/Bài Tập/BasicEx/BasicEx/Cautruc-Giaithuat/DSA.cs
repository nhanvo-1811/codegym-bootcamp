using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEx.Cautruc_Giaithuat
{
    //Data Structure and Algorithms: Cấu trúc dữ liệ và giải thuật
    public class DSA
    {
        public static void Main()
        {
            //Console.Write("Input n = ");
            //var n = int.Parse(Console.ReadLine());
            ////Console.WriteLine("n= {0}, Giai thua:{1}", n, GiaiThua(n));
            //Console.WriteLine("n= {0}, Giai thua:{1}", n, Fibonaci(n));
            //Console.WriteLine("Sum {0}", SumArr(B, B.Length));

            //Selection Sort
            //int[] B = { 5, 7, 9, 8, 4, 8, 6, 5, 9, 2, 1, 3, 6 };
            //Console.WriteLine(string.Join(",", B));
            //Console.WriteLine("----------------------");
            //SelectionSort(B);
            //Console.WriteLine(string.Join(",", B));

            //Insertion Sort
            //int[] C = new int[5];
            //for (int i = 0; i < C.Length; i++)
            //{
            //    Console.WriteLine("input Array {0}:", i + 1);
            //    C[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine(String.Join(",", C));
            //Console.WriteLine("----------------------");
            //Console.WriteLine(String.Join(",", C));

            //Bubble Sort
            //int[] D = { 5, 7, 9, 8, 4, 8, 6, 5, 9, 2, 1, 3, 6 };
            //Console.WriteLine(string.Join(",", D));
            //Console.WriteLine("----------------------");
            //BubbleSort(D);
            //Console.WriteLine(string.Join(",", D));

            //Quick Sort
            //int[] D = { 5, 7, 9, 8, 4, 8, 6, 5, 9};
            //Console.WriteLine(string.Join(",", D));
            //Console.WriteLine("----------------------");

            //    int left = 0;
            //    int right = D.Length - 1;

            //QuickSort(D, left, right);
            //Console.WriteLine(string.Join(",", D));


            // BinarySearch 

            int[] F = { 5, 7, 9, 10, 4, 8, 6, 5, 9 };
            Show(F);
            Console.WriteLine();
            Console.WriteLine("----------------------");

            BubbleSort(F);
            Show(F);

            Console.WriteLine();
            Console.WriteLine("Input number search: ");
            var num = int.Parse(Console.ReadLine());

            Console.WriteLine("number position to search for: {0}", string.Join(",", binarySearch(F, num)));
        }
        #region 
        //public static long GiaiThua(int n)
        //{
        //    if (n == 1 || n==0)
        //        return 1;
        //    return n * GiaiThua(n - 1);
        //}

        //public static long Fibonaci(int n)
        //{
        //    //if (n == 1 || n == 2)
        //    //    return 1;
        //    //return Fibonaci(n - 1) + Fibonaci(n - 2);

        //    var sum = 0;

        //    for (int i = 2; i < n; i++)
        //    {
        //        sum = (i - 1) + (i - 2);
        //    }
        //    return sum;
        //}

        //public static long SumArr(int[] A, int n)
        //{
        //    if (n == 0)
        //        return 0;
        //    return SumArr(A, n - 1) + A[n - 1];
        //}
        #endregion

        #region SelectionSort
        //public static void SelectionSort(int[] A)
        //{
        //    for (int i = 0; i < A.Length - 1; i++)
        //    {
        //        var min = A[i];
        //        for (int j = i + 1; j < A.Length; j++)
        //        {
        //            if (A[j] < min)
        //            {
        //                min = A[j];
        //                var tem = A[i];
        //                A[i] = A[j];
        //                A[j] = tem;
        //            }
        //        }

        //    }
        //}
        #endregion

        #region InsertSort
        //public static void InsertionSort(int[] A)
        //{
        //    for (int i = 1; i < A.Length; i++)
        //    {
        //        var value = A[i];
        //        var index = i;
        //        while (index > 0 && A[index - 1] > value)
        //        {
        //            A[index] = A[index - 1];
        //            index--;
        //        }
        //        A[index] = value;
        //    }
        //}
        #endregion
        public static void BubbleSort(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = 0; j < A.Length - i - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        swap(ref A[j], ref A[j + 1]);
                        #region swap 
                        //var temp = A[j];
                        //A[j] = A[j + 1];
                        //A[j + 1] = temp;
                        #endregion 
                    }

                }
            }

        }
        #region QuickSort
        //  public static void QuickSort(int[] A, int left, int right)
        //{
        //    int middle = left + (right - left) / 2;
        //    int pivot = A[middle];
        //    int i = left;
        //    int j = right;

        //    while (i <= j)
        //    {
        //        while (A[i] < pivot)
        //        {
        //            i++;
        //        }
        //        while (A[j] > pivot)
        //        {
        //            j--;
        //        }
        //        if (i <= j)
        //        {
        //            swap(ref A[i], ref A[j])
        //            i++;
        //            j--;
        //        }
        //    }
        //    if (left < j)
        //        QuickSort(A, left, j);
        //    if (right > i)
        //        QuickSort(A, i, right);
        //}
        #endregion


        public static int binarySearch(int[] A, int n)
        {
            int min = 0;
            int max = A.Length - 1;
            int mid = 0;

            while (min <= max)
            {
                mid = (max + min) / 2;
                if (A[mid] == n)
                {
                    return mid;
                }
                else if (A[mid] < n)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            return -1;
        }
        public static void Show(int[] Arr)
        {
            foreach (int item in Arr)
            {
                Console.Write(" {0} ", item);
            }

        }

        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}


