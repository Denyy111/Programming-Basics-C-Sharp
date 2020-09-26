using System;

namespace _04._New_House____Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            double buget = double.Parse(Console.ReadLine());
            double totalPrice = 0.00;

            if (flowers == "Roses")
            {
                totalPrice = numOfFlowers * 5;

                if (numOfFlowers > 80)
                {
                    totalPrice = totalPrice - (totalPrice * 0.10);
                }
            }
            else if (flowers == "Dahlias")
            {
                totalPrice = numOfFlowers * 3.80;

                if (numOfFlowers > 90)
                {
                    totalPrice = totalPrice - (totalPrice * 0.15);
                }
            }
            else if (flowers == "Tulips")
            {
                totalPrice = numOfFlowers * 2.80;

                if (numOfFlowers > 80)
                {
                    totalPrice = totalPrice - (totalPrice * 0.15);
                }
            }
            else if (flowers == "Narcissus")
            {
                totalPrice = numOfFlowers * 3;
                if (numOfFlowers < 120)
                {
                    totalPrice = totalPrice + (totalPrice * 0.15);
                }
            }
            else if (flowers == "Gladiolus")
            {
                totalPrice = numOfFlowers * 2.50;
                if (numOfFlowers < 80)
                {
                    totalPrice = totalPrice + (totalPrice * 0.2);
                }
            }

            if (buget >= totalPrice)
            {
                double moneyLeft = buget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {flowers} and {moneyLeft:F2} leva left.");
            }
            else 
            {
                double needMoney = totalPrice - buget;
                Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
            }        
        }
    }
}
