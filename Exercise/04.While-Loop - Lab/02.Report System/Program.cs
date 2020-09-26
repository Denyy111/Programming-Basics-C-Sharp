using System;

namespace _02.Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int expectMoney = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int counter = 0;
            int totalSum = 0;
            double averageInCash = 0;
            double averageInCreditsCards = 0;
            double sumCreditCars = 0;
            double sumCash = 0;
            int counterInCash = 0;
            int counterInCraditsCards = 0;

            while (input != "End")
            {
                int money = int.Parse(input);
                counter++;

                if (counter % 2 == 1)
                {
                    if (money > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        totalSum += money;
                        sumCash += money;
                        counterInCash++;
                    }
                }
                else
                {
                    if (money < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        totalSum += money;
                        sumCreditCars += money;
                        counterInCraditsCards++;
                    }
                }
                if (totalSum >= expectMoney)
                {
                    averageInCash = sumCash / counterInCash;
                    averageInCreditsCards = sumCreditCars / counterInCraditsCards;
                    Console.WriteLine($"Average CS: {averageInCash:F2}");
                    Console.WriteLine($"Average CC: {averageInCreditsCards:F2}");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "End")
            {
                Console.WriteLine($"Failed to collect required money for charity.");
            }
        }
    }
}
