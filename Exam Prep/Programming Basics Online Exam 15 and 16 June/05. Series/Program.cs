using System;

namespace _05._Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countSerials = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            double sum = 0;

            for (int i = 0; i < countSerials; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
              
                if (name == "Thrones")
                {
                    totalPrice = price - (price * 0.50); 
                }
                else if (name == "Lucifer")
                {
                    totalPrice = price - (price * 0.40);
                }
                else if (name == "Protector")
                {
                    totalPrice = price - (price * 0.30);
                }
                else if (name == "TotalDrama")
                {
                    totalPrice = price - (price * 0.20);
                }
                else if (name == "Area")
                {
                    totalPrice = price - (price * 0.10);
                }
                else
                {
                    totalPrice = price;
                }
                sum += totalPrice;
            }
          
            if (budget >= sum)
            {
                double leftMoney = budget - sum;
                Console.WriteLine($"You bought all the series and left with {leftMoney:F2} lv.");
            }
            else
            {
                double needMoney = sum - budget;
                Console.WriteLine($"You need {needMoney:F2} lv. more to buy the series!");
            }
        }
    }
}
