using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введіть a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введіть b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введіть c: ");
                double c = Convert.ToDouble(Console.ReadLine());

            double firstPart = 0;
            double secondPart = 0;

            if (a < b)
            {
                firstPart = a;
            }
            else
            {
                firstPart = b;
            }

            if (b > c)
            {
                secondPart = Math.Pow(b, 2);
            }
            else
            {
                secondPart = Math.Pow(c, 2);
            }

            double result = firstPart + secondPart;

            Console.WriteLine($"Результат: {result}");

        }
    }
}