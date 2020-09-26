using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double table = double.Parse(Console.ReadLine());
            double lengthTable = double.Parse(Console.ReadLine());
            double widthTable = double.Parse(Console.ReadLine());

           
            double coversArea = table * (lengthTable + (2 * 0.30)) * (widthTable + (2 * 0.30));
            double squareArea = table * (lengthTable / 2) * (lengthTable / 2);

            double tableClothPriceUsd = coversArea * 7;
            double tableTopperPriceUsd= squareArea * 9;

            double priceUSD = tableClothPriceUsd + tableTopperPriceUsd;
            double priceBGN = priceUSD * 1.85;

            

            Console.WriteLine("{0:F2} USD", priceUSD);
            Console.WriteLine($"{priceBGN:F2} BGN ");


        }
    }
}
