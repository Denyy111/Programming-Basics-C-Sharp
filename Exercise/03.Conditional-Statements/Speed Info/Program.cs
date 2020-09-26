using System;

namespace Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            if (speed <= 10)               // скорост до 10 и по малко
            {
                Console.WriteLine("slow");
            }

            else if (speed > 10 && speed <= 50)   // скорост над 10 до 50
            {
                Console.WriteLine("average");
            }

            else if (speed > 50 && speed <= 150)   // скорост над 50 до 150
            {
                Console.WriteLine("fast");
            }

            else if (speed > 150 && speed <= 1000)   // скорост над 150 до 1000
            {
                Console.WriteLine("ultra fast");
            }

            else
            {
                Console.WriteLine("extremely fast");   // за по- висока скорост 
            }

        }
    }
}
