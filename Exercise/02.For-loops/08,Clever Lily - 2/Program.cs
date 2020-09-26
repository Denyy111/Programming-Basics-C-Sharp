using System;

namespace _08_Clever_Lily___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashMashine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int totalGiftMoney = 0;
            int totalToyPrice = 0;
            int previosMoneyBdayGifts = 0;

            for (int i = 0; i < age; i++)
            {
              int  bday = i + 1;

                if (bday % 2 == 0)
                {
                    totalGiftMoney += 10 + previosMoneyBdayGifts - 1;
                    previosMoneyBdayGifts += 10;
                }
                else
                {
                    totalToyPrice += toyPrice;
                }
            }
            int totalMoney = totalToyPrice + totalGiftMoney;

            if (totalMoney >= priceWashMashine)
            {
                double left = totalMoney - priceWashMashine;
                Console.WriteLine($"Yes! {left:F2}");
            }
            else
            {
                double diff = priceWashMashine - totalMoney;
                Console.WriteLine($"No! {diff:F2}");
            }
        }
    }
}
