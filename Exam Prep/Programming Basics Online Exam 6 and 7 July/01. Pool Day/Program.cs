using System;

namespace _01._Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            double taxesEnter = double.Parse(Console.ReadLine());
            double priceForShezlong = double.Parse(Console.ReadLine());
            double priceForUmbrela = double.Parse(Console.ReadLine());

            double alltaxesForAllPeople = countPeople * taxesEnter;
            double moneyFoShezlongs = Math.Ceiling(countPeople * 0.75) * priceForShezlong;
            double moneyforUbrelas = Math.Ceiling(countPeople * 0.5) * priceForUmbrela;

            double totalPrice = alltaxesForAllPeople + moneyforUbrelas + moneyFoShezlongs;

            Console.WriteLine($"{totalPrice:F2} lv.");

        }
    }
}
