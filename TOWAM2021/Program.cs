using System;

namespace TOWAM2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1, b = -5, c = -10;
            double x1, x2;

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {

                x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                x2 = (-b + Math.Sqrt(delta)) / 2 * a;

                Console.WriteLine("Pierwiastki to: {0} i {1}", x1, x2);
            } else if (delta == 0)
            {
                x1 = (-b) / 2 * a;
                Console.WriteLine("Jeden podwójny pierwiastek to: {0}", x1);
            }
            else
            {
                Console.WriteLine("brak pierwiastków");
            }

        }
    }
}
