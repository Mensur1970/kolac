using System;

namespace kolac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite broj:");
            double x = double.Parse(Console.ReadLine());
            while (x > 1)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x /= 2);
                }
                else if (x % 2 != 0)
                {
                    Console.WriteLine(x = x * 3 + 1);
                   // amele 
                }
            }
            {
                Console.ReadKey();
            }
        }
    }
}
