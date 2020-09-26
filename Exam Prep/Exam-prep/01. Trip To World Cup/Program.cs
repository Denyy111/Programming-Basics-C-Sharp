using System;

namespace _01._Trip_To_World_Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            double ticketToGo = double.Parse(Console.ReadLine());
            double ticketToCome = double.Parse(Console.ReadLine());
            double priceForTicketForMach = double.Parse(Console.ReadLine());
            double countOfMach = double.Parse(Console.ReadLine());
            double percentCount = double.Parse(Console.ReadLine());

            double allPriceTickets = 6 * (ticketToGo + ticketToCome);
            double TichetAfterPercent = allPriceTickets - (allPriceTickets * percentCount / 100);

            double allPriceMaches = 6 * (priceForTicketForMach * countOfMach);

            double allMoneyNeed = TichetAfterPercent + allPriceMaches;

            double priceForPerson = allMoneyNeed / 6;

            Console.WriteLine($"Total sum: {(allMoneyNeed):F2} lv.");
            Console.WriteLine($"Each friend has to pay {(priceForPerson):F2} lv.");
        }
    }
}
