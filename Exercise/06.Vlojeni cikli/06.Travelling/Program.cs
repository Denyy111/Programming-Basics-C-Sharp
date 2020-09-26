using System;

namespace _06.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                double sum = 0;

                while (sum < minBudget)
                {
                    double number = double.Parse(Console.ReadLine());
                    sum += number;                  
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }

            
        }
     
    }
}
