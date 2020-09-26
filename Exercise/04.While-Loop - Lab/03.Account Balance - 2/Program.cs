using System;

namespace _03.Account_Balance___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int transactionCount = int.Parse(Console.ReadLine());

            double counter = 0;
            double balance = 0.0;

            while (counter < transactionCount)
            {

                double amount = double.Parse(Console.ReadLine());

                if (amount < 0 )
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine("Increase: {0:F2}" , amount);

                balance += amount;

                counter++;               
            }

            Console.WriteLine("Total: {0:F2}" , balance);
        }
    }
}
