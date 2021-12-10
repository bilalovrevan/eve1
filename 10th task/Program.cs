using System;

namespace _10th_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla. 
            //Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap.
            Console.WriteLine("1ci 6 reqemli ededi daxil edin: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2ci 6 reqemli ededi daxil edin: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3cu 6 reqemli eded daxil edin");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("4cu 6 reqemli eded daxil edin");
            double d = Convert.ToDouble(Console.ReadLine());
            double x = 0;
            double y = 0;
            double z = 0;
            double a1 = 0;
            double b1 = 0;
            double c1 = 0;
            double d1 = 0;
            double a2 = 0;
            double b2 = 0;
            double c2 = 0;
            double d2 = 0;
            if (a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000 && d >= 10000 && d < 100000)
            {
                a1 = a *0.1;
                b1 = b*0.1;
                c1 = c *0.1;
                d1 = d *0.1;
                a2 = a * 0.15;
                b2 = b * 0.15;
                c2 = c * 0.15;
                d2 = d * 0.15;
                x = a1 +b1+c1+d1;
                y = a2 + b2 + c2 + d2;
                z = x * y;
                z = z * 0.1;
                z = z * 0.11;
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("ededleri duzgun daxil etmemisiniz");
            }
        }
    }
}
