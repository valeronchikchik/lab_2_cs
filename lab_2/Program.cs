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

            double result = (Math.Min(a, b) + Math.Pow(Math.Max(b, c), 2));

            Console.WriteLine($"Результат: {result}");

        }
    }
}