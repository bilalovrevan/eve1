using System;

namespace _4th_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 reqemli eded verilib.Bu ededin evvel 20 % -ni ,  sonra ise cavabin 10 % tap.Alinan  cavabin kvadratini tap.
             Console.WriteLine("4 reqemli ededi daxil edin:");
        
            string b = Console.ReadLine();
            double a = Convert.ToDouble(b);
            double c = 0;
            double d = 0;
            if (a>= 1000 && a<10000)
            {
                c = a * 0.2;
                d = c * 0.1;
                double z = d * d;
                Console.WriteLine($"Cavab :{z}");
            }
            else
            {
                Console.WriteLine("daxil etdiyiniz eded 4 reqemli deyil");
               

            }
            Console.ReadKey();


        }
    }
}
