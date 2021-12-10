using System;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 reqemli eded verilib.Bu ededin evvel  18 % sonra ise 3 % tap
            Console.WriteLine("5 reqemli eded daxil edin:");
            string b = Console.ReadLine();
            double a = Convert.ToDouble(b);
            double c = 0;
            double d = 0;
            double e = 0;
            if (a >= 10000 && a < 100000)
            {
                Console.Clear();
                c = a * 0.18;
                Console.WriteLine($"ededin 18 faizi:{ c} ");
                d = a * 0.03;
                Console.Write($"ededin 3 faizi :{ d}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Daxil etdiyiniz eded 5 reqemli deyil");

                return;

            }
            Console.ReadKey();
        }
    }
}
