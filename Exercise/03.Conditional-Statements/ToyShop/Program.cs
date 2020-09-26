using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacancionPrice = double.Parse(Console.ReadLine());
            double countPuzzel = double.Parse(Console.ReadLine());
            double countDolls = double.Parse(Console.ReadLine());
            double countTeddyBears = double.Parse(Console.ReadLine());
            double countMinions = double.Parse(Console.ReadLine());
            double countTrucks = double.Parse(Console.ReadLine());

            double totalToyCount = countPuzzel + countDolls + countTeddyBears + countMinions + countTrucks;

            double totalPrice = countPuzzel * 2.60 + countDolls * 3 + countTeddyBears * 4.10 + countMinions * 8.20 + countTrucks * 2;

            if (totalToyCount >= 50)
            {
                double discount = totalPrice * 0.25;
                totalPrice = totalPrice - discount;

              //totalPrice = totalPrice * 0.75;
              //totalPrice = totalPrice * (1 - 0.25);
            }

            double rent = totalPrice * 0.1;
            totalPrice = totalPrice - rent;

            //totalPrice = totalPrice * (1 - 0.1);
            //totalPrice *= (1 - 0.1);

            if (totalPrice >= vacancionPrice)
            {
                double difference = totalPrice - vacancionPrice;

               //Console.WriteLine("Yes! " + difference + " lv left.");
                Console.WriteLine("Yes! {0:F2} lv left.", difference);
                //Console.WriteLine($"Yes! {difference} lv left");
             }

            else
            {
                double difference = vacancionPrice - totalPrice;
                Console.WriteLine("Not enough money! {0:F2} lv needed.", difference);   
            }
        }
    }
}
