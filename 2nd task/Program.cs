using System;

namespace _2nd_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 reqemli eded verilib.Bu ededin axirina 7 artir.Sonra cavabin 7 % tap;

            Console.WriteLine("3 reqemli eded daxil edin:");
            string b = Console.ReadLine();
            double a = Convert.ToDouble(b);
            double c = 0;
            double d = 0;
            if (a>=100 && a<1000)
            {
                c = a * 10 + 7;
                d = c * 0.7;
                Console.Clear();
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz 3 reqemli eded deyil!");
               
            }
           
        }
    }
}
