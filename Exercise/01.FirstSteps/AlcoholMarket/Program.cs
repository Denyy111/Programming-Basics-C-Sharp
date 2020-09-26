using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWiskyLv = double.Parse(Console.ReadLine());
            double BeerLirers = double.Parse(Console.ReadLine());
            double WineLiters = double.Parse(Console.ReadLine());
            double RakiaLiters = double.Parse(Console.ReadLine());
            double WiskyLiters = double.Parse(Console.ReadLine());

             double priceRakia = priceWiskyLv / 2;            
             double priceWine = priceRakia - (0.4 * priceRakia);
             double priceBeer = priceRakia - (0.8 * priceRakia);           
            
            double sumRakia = RakiaLiters * priceRakia;
            double sumWine = WineLiters * priceWine;
            double sumBeer = BeerLirers * priceBeer;
            double sumWisky = WiskyLiters * priceWiskyLv;
            

            double AllMonay = sumRakia + sumBeer + sumWine + sumWisky;
        
            Console.WriteLine("{0:F2}" , AllMonay);
        }
    }
}
