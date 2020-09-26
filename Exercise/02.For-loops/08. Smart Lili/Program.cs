using System;

namespace _08._Smart_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int totaltoyPrice = 0;
            int totalMonayGift = 0;
            int previousBdayMoneyGift = 0;

            for (int i = 0; i < age; i++)
            {
                int bday = i + 1;

                if (bday % 2 == 0)
                {
                    totalMonayGift += 10 + previousBdayMoneyGift - 1;
                    previousBdayMoneyGift += 10;
                }
               else
                {
                    totaltoyPrice += toyPrice;
                }
            }
            int totalMoney = totalMonayGift + totaltoyPrice;

            if (totalMoney >= washingMachinePrice)
            {
                double left = totalMoney - washingMachinePrice;

                Console.WriteLine($"Yes! {left:F2}");
            }
            else
            {
                double diff = washingMachinePrice - totalMoney;

                Console.WriteLine($"No! {diff:F2}");
            }
        }
    }
}
