using System;

namespace _9th_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 dene 5 reqemli eded verilib.Her I ededin ustune III ededi gel.II ededin usutune IV eeddi gel. 
            //Sonra cavablari vur birbirine. Alinan neticeden III ededin 3 % -ni cix.
            Console.WriteLine("1ci 5 reqemli ededi daxil edin: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2ci 5 reqemli ededi daxil edin: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3cu 5 reqemli eded daxil edin");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("4cu 5 reqemli eded daxil edin");
            double d = Convert.ToDouble(Console.ReadLine());
            double x = 0;
            if (a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000 && d>=10000 && d<100000)
            {
                a = a+c;
                b = b + d;
                x = a * b;
                x = x - (c * 0.3);
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("ededleri duzgun daxil etmemisiniz");
            }
        }
    }
}
