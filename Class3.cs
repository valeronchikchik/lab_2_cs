using System;

namespace task3 
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1: ")
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter z1: ");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter z2: ");
            int z2 = Convert.ToInt32(Console.ReadLine());

            string result;
            double x = x1*x1 + x2*x2;
            double y = y1*y1 + y2*y2;
            double z = z1*z1 + z2*z2;

            if(x > y && x > z)
            {
                result = "Сторона x найбільша";
            }
            else if(y > x && y > z)
            {
                result = "Сторона y найбільша";
            }
            else
            {
                result = "Сторона z найбільша";
            }

            Console.WriteLine($"Результат: {result}")
        }
    }   
}

