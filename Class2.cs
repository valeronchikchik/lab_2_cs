using System;

namespace task2
{
    class Program
    {
        static void main()
        {
            Console.WriteLine("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int y = 0;

            if (0<=n || n < 5) 
            {
                y = 0;
            }
            else if (5 <= n || n < 10)
            {
                y = 1;
            }
            else if (10 <= n || n < 15)
            {
                y = 2;
            }
            else
            {
                y = 3;
            }


             Console.WriteLine($"y: {y}");
             return 0;
        }
    }
}
