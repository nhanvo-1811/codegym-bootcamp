using System;
using System.Collections.Generic;
using System.Text;

namespace KT_L2.Cau2
{
    public class Cau2
    {
        public static int[] Arr;
        public static void main()
        {
            InitMenu();
        }
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("1. Create Array");
                Console.WriteLine("2. Is symmetry Array");
                Console.WriteLine("3. Sort Array");
                Console.WriteLine("4. Find array");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please select an option from 1 to 5");

                Console.WriteLine("Opition: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 7 || option <= 0);
            Process(option);
        }
        public static void Process(int selected)
        {

            Console.Clear();
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine(" Create Array .....");
                        CreateArray();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Is increase Array .....");
                        if (IsSymmetryArray(Arr))
                        {
                            Console.WriteLine(true);
                            break;
                        }
                        else
                        {
                            Console.WriteLine(false);
                        }

                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(" Sort Array .....");
                        BubbleSort(Arr);
                        Show(Arr);
                        Console.WriteLine();
                        Console.WriteLine("---------------------");
                        break;
                    }
                case 4:
                    {
                        if (IsIncreaseArray(Arr))
                        {
                            Console.WriteLine("Find array .....");
                            Console.WriteLine("Input number ");
                            int n;
                            do
                            {
                                int.TryParse(Console.ReadLine(), out n);
                                Console.WriteLine("Input number ");
                            }
                            while (n <= 0);
                            if (Find(Arr, n) == -1)
                            {
                                Console.WriteLine("Not find");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Number position to search for: {0}", string.Join(",", Find(Arr, n)));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Chuc nang khong kha dung moi su dung chuc nang 3 truoc ");
                            InitMenu();

                        }


                        break;
                    }
                case 5:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }
        public static void CreateArray()
        {
            Console.WriteLine("Input n must be greater than 0: ");
            int n;
            do
            {
                int.TryParse(Console.ReadLine(), out n);
                Console.WriteLine("Input n must be greater than 0: ");
            }
            while (n <= 0);

            Arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                var number = 0;
                var kt = false;
                do
                {
                    Console.WriteLine("Input array{0}: ", i + 1);
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        Arr[i] = number;
                        kt = true;
                    }
                }
                while (!kt);
            }
            Console.WriteLine("---------------------");
        }


        public static bool IsSymmetryArray(int[] A)
        {
            for (int i = 0; i < A.Length / 2; i++)
            {
                if (A[i] != A[A.Length - i - 1])
                {
                    return false;
                    break;
                }
            }
            return true;
        }

        public static void BubbleSort(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = 0; j < A.Length - i - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        swap(ref A[j], ref A[j + 1]);
                    }

                }
            }

        }

        public static bool IsIncreaseArray(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] > A[i + 1]) return false;
            }
            return true;
        }

        public static int Find(int[] A, int n)
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
