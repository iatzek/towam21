using System;

namespace TOWAM2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            
            Console.WriteLine("ax^2+bx+c=0");
            Console.WriteLine("Wprowadź a");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź b");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź c");
            c = Double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1,   x2;
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b +Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Pierwiastki to: {0} i {1}", x1, x2);
            } else if (delta == 0)
            {
                double x1;
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
