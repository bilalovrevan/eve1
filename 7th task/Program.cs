using System;

namespace _7th_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap
            Console.WriteLine("1ci 6 reqemli ededi daxil edin: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2ci 6 reqemli ededi daxil edin: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3cu 6 reqemli eded daxil edin");
            double c = Convert.ToDouble(Console.ReadLine());
            double x = 0;
            if (a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c>=100000 && c<1000000)
            {
                a = a * 0.1;
                b = b * 0.1;
                c= c * 0.1;
                x = a + b+c;
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
