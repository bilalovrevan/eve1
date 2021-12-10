using System;

namespace Last_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
            //3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
            //Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
            // Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
            // Sonra alinan cavabin ustune gel 6 reqemli ededi.
            // Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
            // Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
            //  Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
            l1:
            Console.WriteLine("1ci 3 reqemli ededi daxil edin: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2ci 3 reqemli ededi daxil edin: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1ci 4 reqemli eded daxil edin");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2ci 4 reqemli eded daxil edin");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1ci 5 reqemli eded daxil edin");
            double e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2ci 5 reqemli eded daxil edin");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("6 reqemli eded daxil edin");
            double g = Convert.ToDouble(Console.ReadLine());
            double x1, x2, x3, x4, x5, x6, x7, final;
            if (a >= 100 && a < 1000 && b >= 100 && b < 1000 && c >= 1000 && c < 10000 && d >= 1000 && d < 10000 && e >= 10000 && e < 100000 && g >= 100000 && g < 1000000)

            {
                // 3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin
                // bir birine vurulmasindan alinan cavabi.
                 x1 = a + b + c * d;

                // Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
                 x2 = x1 * 10 + 7;

                // Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
                 x3 = x2 + e + f;

                // Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
                 x4 = x3 - (a * b * 10 + 1);

                // Sonra alinan cavabin ustune gel 6 reqemli ededi.
                 x5 = x4 + g;

                // Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
                 x6 = x5 - (a + b + c + d);

                // Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
                 x7 = x6 * 18 / 100 * 3 / 100 * 1 / 100;

                // Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
                 final = x7 + e + f;



                Console.Clear();
                Console.WriteLine($"Cavab:    {final}");


            }
            else
            {
                Console.Clear();
                goto l1;
            }
        }



    }
    }
