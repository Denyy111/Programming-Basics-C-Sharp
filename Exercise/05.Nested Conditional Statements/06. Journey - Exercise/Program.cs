using System;

namespace _06._Journey___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seasons = Console.ReadLine();
            double totalSpendMoney = 0;


            if (budget <= 100)
            {

                if (seasons == "summer")
                {
                    totalSpendMoney += budget * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {totalSpendMoney:F2}");
                }
                else if (seasons == "winter")
                {
                    totalSpendMoney += budget * 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {totalSpendMoney:F2}");
                }
            }
            else if (budget <= 1000)
            {
                if (seasons == "summer")
                {
                    totalSpendMoney += budget * 0.40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {totalSpendMoney:F2}");
                }
                else if (seasons == "winter")
                {
                    totalSpendMoney += budget * 0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {totalSpendMoney:F2}");
                }                
            }
            else if (budget > 1000)
            {
                totalSpendMoney += budget * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {totalSpendMoney:F2}");
            }
            
        }
    }
}
