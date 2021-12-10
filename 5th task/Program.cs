using System;

namespace _5th_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap
            Console.WriteLine("1-ci 5 reqemli ededi daxil edin: ");
            double a= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2-ci 5 reqemli ededi daxil edin: ");
            double b= Convert.ToDouble(Console.ReadLine());
            double x = 0;
            if (a>=10000 && a<100000 && b>=10000 && b<100000)
            {
                x = a + b;
                x = x + 500000;
                x = x * 10 + 5;
                x = x * 0.5;
                Console.WriteLine(x);
            }

            else
            {
                Console.WriteLine("ededleri duzgun daxil edin");
            }
        }
    }
}
