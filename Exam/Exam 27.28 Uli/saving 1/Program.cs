using System;

namespace saving_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double priceHavliq = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double priceUmbrela = ((2 * 1.0) / (3 * 1.0)) * priceHavliq;
            double flipFlop = priceUmbrela * 0.75;
            double bag = ((1 * 1.0) / (3 * 1.0)) * (priceHavliq + flipFlop);
            double totalSum = priceHavliq + priceUmbrela + flipFlop + bag;

            double priceOtstypka = totalSum - (totalSum * (percent / (100 * 1.0)));

            if (budget >= priceOtstypka)
            {
                double leftSum = budget - priceOtstypka;
                Console.WriteLine($"Annie's sum is {priceOtstypka:F2} lv. She has {leftSum:F2} lv. left.");
            }
            else
            {
                double needMoney = Math.Abs(priceOtstypka - budget);
                Console.WriteLine($"Annie's sum is {priceOtstypka:F2} lv. She needs {needMoney:F2} lv. more.");
            }
        }
    }
}
