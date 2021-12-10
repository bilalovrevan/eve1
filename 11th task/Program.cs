using System;

namespace _11th_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 dene eded verilib.Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5 % tap ,neticeleri vur bir birine. 
            // Sonra 3 reqemli ededlerin 3 % tap ,neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla.
            Console.WriteLine("1ci 5 reqemli ededi daxil edin: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2ci 5 reqemli ededi daxil edin: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3cu 5 reqemli eded daxil edin");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("4cu 3 reqemli eded daxil edin");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("5ci 3 reqemli eded daxil edin");
            double e = Convert.ToDouble(Console.ReadLine());
            double x,y,z,a1,b1,c1,d1,e1 = 0;            
            if (a>=10000 && a<100000 && b>=10000 && b<100000 && c >= 10000 && c < 100000 && d>=100 && d<1000 && e>=100 && e<1000)
            {
                a1 = a * 0.05;
                b1 = b * 0.05;
                c1 = c * 0.05;
                d1 = d * 0.03;
                e1 = e * 0.03;
                x = (a1 * b1 * c1)*0.1;
                y = (d1 + e1)*0.1;
                z = (y + x);
                Console.WriteLine(z);
                Console.WriteLine(y);
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("ededleri duzgun daxil edin");
            }
        }
    }
}
