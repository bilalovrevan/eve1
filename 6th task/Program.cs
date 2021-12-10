using System;

namespace _6th_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
            //I ededin 4 % -ni tap.
            //Sonra II ededin 9 % ni tap.
            //Sonra Cavalari toplayib 10 % ni tap.
            Console.WriteLine("4 reqemli ededi daxil edin: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("7 reqemli ededi daxil edin: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double x = 0;
            if (a >= 1000 && a < 10000 && b >= 1000000 && b < 10000000) 
            {
                a = a * 0.4;
                b = b * 0.9;
                x = a + b;
                x = x * 0.1;
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("ededleri duzgun daxil etmemisiniz");
            }
        }
    }
}
