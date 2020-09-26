using System;

namespace _02.SmallShop___2
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(count * 0.50);
                }
                else if (product == "water")
                {
                    Console.WriteLine(count * 0.80);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(count * 1.20);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(count * 1.45);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(count * 1.60);
                }

            }
            if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(count * 0.40);
                }
                else if (product == "water")
                {
                    Console.WriteLine(count * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(count * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(count * 1.30);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(count * 1.50);
                }
            }
            if (town == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(count * 0.45);
                }
                else if (product == "water")
                {
                    Console.WriteLine(count * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(count * 1.10);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(count * 1.35);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(count * 1.55);
                }
            }
        }
    }
}
