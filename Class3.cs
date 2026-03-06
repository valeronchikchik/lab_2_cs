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

            if(Math.sqrt(x1*x1 + x2*x2) > Math.sqrt(y1*y1 + y2*y2) || Math.sqrt(x1*x1 + x2*x2) > Math.sqrt(z1*z1 + z2*z2))
            {
                result = "Сторона x найбільша";
            }
            else if(Math.sqrt(y1*y1 + y2*y2) > Math.sqrt(x1*x1 + x2*x2) || Math.sqrt(y1*y1 + y2*y2) > Math.sqrt(z1*z1 + z2*z2))
            {
                result = "Сторона y найбільша";
            }
            else
            {
                result = "Сторона z найбільша";
            }
        }
    }   
}

