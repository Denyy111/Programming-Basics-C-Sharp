using System;

namespace Bira_i_chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = int.Parse(Console.ReadLine());
            int botalOfBeer = int .Parse(Console.ReadLine());
            int packetChips = int.Parse(Console.ReadLine());

            double allPriceOfBeer = 1.20 * botalOfBeer;
            double PriceOfPacketCheeps = allPriceOfBeer * 0.45;
            double allpriceOfCheeps = Math.Ceiling(PriceOfPacketCheeps * packetChips);

            double allMoneyNeeded = allpriceOfCheeps + allPriceOfBeer;
           
            if (budget >=allMoneyNeeded)
            {              
                Console.WriteLine($"{name} bought a snack and has {Math.Abs(allMoneyNeeded-budget):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {Math.Abs(allMoneyNeeded - budget):F2} more leva!");
            }
            
        }
    }
}
