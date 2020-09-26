using System;

namespace _03.Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int transactionCount = int.Parse(Console.ReadLine());

            double currentTransactionCount = 0;
            double totalAmount = 0;


            while (currentTransactionCount < transactionCount)
            {
                double amount = double.Parse(Console.ReadLine());

                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine("Increase: {0:F2}", amount);

                totalAmount += amount;

               currentTransactionCount++;
            }

            Console.WriteLine("Total: {0:F2}", totalAmount);
        }
    }
}
