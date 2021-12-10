using System;

namespace _12th_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6 dene 6 reqemli eded verilib.Evvel hamisini topla.Sonra I ve III ededi bir birine yapishdir ve bir eded al.  
            //I neticeden II neticeni cix.Alinan cavabin 10 % tap.Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11 % tap.
            Console.WriteLine("1ci 6 reqemli ededi daxil edin: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2ci 6 reqemli ededi daxil edin: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3cu 6 reqemli eded daxil edin");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("4cu 6 reqemli eded daxil edin");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("5ci 6 reqemli eded daxil edin");
            double e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("6ci 6 reqemli eded daxil edin");
            double f = Convert.ToDouble(Console.ReadLine());
            double z,x,y = 0;
            if (a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000 && e >= 100000 && e < 1000000 && f >= 100000 && f < 1000000 )
            {
                z = a + b + c + d + e + f;
                x = (a * 1000000) + c;
                y = (z - x)*0.1;
                y = (y + e + f)*0.11;
                Console.WriteLine($"cavab: {y}");
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz ededler duzgun deyil");
            }
        }
    }
}
