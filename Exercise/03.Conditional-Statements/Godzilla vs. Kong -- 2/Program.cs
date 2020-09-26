using System;

namespace Godzilla_vs._Kong____2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double statists = double.Parse(Console.ReadLine());
            double priceCloths = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double totalPriceOutfit = statists * priceCloths;

            if (statists > 150)
            {
                totalPriceOutfit = totalPriceOutfit - (totalPriceOutfit * 0.1);
            }

            double moneyForAllFilm = decor + totalPriceOutfit;

            if (moneyForAllFilm <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs( budget- moneyForAllFilm):F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs { Math.Abs(budget - moneyForAllFilm):F2} leva more.");
            }


        }
    }
}
