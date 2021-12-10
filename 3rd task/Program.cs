using System;

namespace _3rd_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 reqemli eded verilib.Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap.
           Console.WriteLine("4 reqemli eded daxil edin:");
            string b = Console.ReadLine();
            double a = Convert.ToDouble(b);
            double c = 0;
            double d = 0;
            double e = 0;
            if (a >= 1000 && a < 10000)
            {
                c = a  + 40000;
                d = (c *100)+44;
                e = d * 0.44;
                Console.Clear();
                Console.WriteLine($"cavab: {e}");
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz 4 reqemli eded deyil!");

            }
            Console.ReadKey();
        }
    }
}
