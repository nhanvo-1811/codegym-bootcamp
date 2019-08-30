using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BasicEx.Try_Catch
{
    public class Excep
    {
        int result;
        Excep()
        {
            result = 0;
        }
        public void phepChia(int num1, int num2)
        {
            FileStream file = new FileStream($"E:\\CodeGym\\module 1\\codegym-bootcamp\\session 2\\Bài Tập\\log_{DateTime.Now.ToString("dd_MM_yyyy")}.txt", FileMode.Append);

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.Write($"Error: {DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss_tt")} : {e.Message}");
                }
                Console.WriteLine("Bat Exception: {0}", e.Message);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Ket qua: {0}", result);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vi du minh hoa Exception trong C#");
            Console.WriteLine("---------------------------------");

            Excep d = new Excep();
            d.phepChia(25, 0);
            Console.ReadKey();
        }

    }
}
