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

            if (n<0) 
            {
                y = 3;
            }
            else if (n>=5)
            {
                y = 1;
            }
            else if (n>=10)
            {
                y = 2;
            }
            else if(n>=15)
            {
                y = 3;
            }


             Console.WriteLine($"y: {y}");
             return 0;
        }
    }
}
