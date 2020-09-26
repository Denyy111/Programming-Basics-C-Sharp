using System;

namespace saving_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohodPerMounth = double.Parse(Console.ReadLine());
            double countMounth = double.Parse(Console.ReadLine());
            double needMoney = double.Parse(Console.ReadLine());

            double money = dohodPerMounth * 0.30;
            double spestenaSuma = dohodPerMounth - (needMoney + money);

            double moneyForMounth = spestenaSuma * countMounth;
            double percent = (spestenaSuma / dohodPerMounth) * 100;

            Console.WriteLine($"She can save {percent:F2}%");
            Console.WriteLine($"{moneyForMounth:F2}");

        }
    }
}
