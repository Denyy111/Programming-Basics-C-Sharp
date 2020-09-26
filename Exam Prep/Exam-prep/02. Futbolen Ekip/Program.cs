using System;

namespace _02._Futbolen_Ekip
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceTshirt = double.Parse(Console.ReadLine());
            double maxMoneyForBall = double.Parse(Console.ReadLine());

            double priceJeans = priceTshirt * 0.75;
            double priceSocs = priceJeans * 0.20;
            double priceButonki = (priceTshirt + priceJeans) * 2;

            double allMoney = priceTshirt + priceJeans + priceSocs + priceButonki;
            double discountMoney = allMoney - (allMoney * 15) / 100;

            if (discountMoney >= maxMoneyForBall)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {(discountMoney):F2} lv.");
            }
            else
            {
                double needMoney = Math.Abs(discountMoney - maxMoneyForBall);
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {needMoney:F2} lv. more.");
            }
        }
    }
}
