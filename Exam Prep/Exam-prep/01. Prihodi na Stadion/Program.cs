using System;

namespace _01._Prihodi_na_Stadion
{
    class Program
    {
        static void Main(string[] args)
        {
            double sectorsInStadion = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());
            double priceOfTicket = double.Parse(Console.ReadLine());

            double totalInkome = capacity * priceOfTicket;
            double totalIncomeOfSector = totalInkome / sectorsInStadion;
            double moneyOfCharity = (totalInkome - (totalIncomeOfSector * 0.75)) / 8;
            

            Console.WriteLine($"Total income - {totalInkome:F2} BGN");
            Console.WriteLine($"Money for charity - {moneyOfCharity:F2} BGN");
        }
    }
}
