using System;

namespace _8th_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 dene 4 reqemli eded verilib.I ededin 1 % -ni, II ededin 2 % , III ededin 3 % tap.
            //Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7 % faizini gel
            Console.WriteLine("1ci 4 reqemli ededi daxil edin: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2ci 4 reqemli ededi daxil edin: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3cu 4 reqemli eded daxil edin");
            double c = Convert.ToDouble(Console.ReadLine());
            double x = 0;
            double y = 0;
            if (a >= 1000 && a < 10000 && b >= 1000 && b < 10000 && c >= 1000 && c < 10000)
            {
                a = a * 0.01;
                b = b * 0.02;
                c = y * 0.03;
                x = a - b - y;
                x = x + (c * 0.7);
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("ededleri duzgun daxil etmemisiniz");
            }
        }
    }
}
