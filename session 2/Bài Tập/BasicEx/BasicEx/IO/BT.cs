using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BasicEx.IO
{
    public class BT
    {

        public static void Main()
        {
            int sum = 0;

            Console.WriteLine("Input n: ");
            int n = int.Parse(Console.ReadLine());

            FileStream file = new FileStream("E:\\input.txt", FileMode.Create);
            int[] arr = new int[n];
            int[] sort = new int[n];

            using (StreamWriter writer = new StreamWriter(file))
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Input arr: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                writer.WriteLine(n);
                writer.WriteLine(string.Join(",", arr));

            }

            FileStream open = new FileStream("E:\\input.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(open))
            {
                var ctx = reader.ReadLine();
                var ctx2 = reader.ReadLine();
                var str = ctx2.Split(",");
                int number = 0;

                foreach (string item in str)
                {

                    if (int.TryParse(item, out number))
                    {
                        
                        sum += number;
                    }
                }
                Console.WriteLine("sum: {0} ", sum);

                FileStream output = new FileStream("E:\\output.txt", FileMode.Create);
                using (StreamWriter writer = new StreamWriter(output))
                {
                    writer.WriteLine("Sum: {0}", sum);
                    
                    writer.Write("Even number:");
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (int.TryParse(str[i], out number))
                        {
                            sort[i] = number;
                            if (number % 2 == 0)
                            {
                                writer.Write(" {0} ",str[i]);
                  
                            }
                        }
                    }

                    writer.WriteLine();
                    BubbleSort(sort);
                    writer.WriteLine("Sort: {0}", string.Join("  ", sort));
                }
            }
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
                        #region swap 
                        //var temp = A[j];
                        //A[j] = A[j + 1];
                        //A[j + 1] = temp;
                        #endregion 
                    }

                }
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
