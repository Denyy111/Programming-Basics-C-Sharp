using System;

namespace _4
{
    class Program
    {
        class Program
        {
            static void Main(string[] args)
            {
                double budget = double.Parse(Console.ReadLine());
                int numArticuls = int.Parse(Console.ReadLine());

                double price = 0;

                for (int i = 1; i <= numArticuls; i++)
                {
                    string nameOfArticuls = Console.ReadLine();

                    if (nameOfArticuls == "hoodie")
                    {
                        price += 30;
                    }
                    else if (nameOfArticuls == "keychain")
                    {
                        price += 4;
                    }
                    else if (nameOfArticuls == "T-shirt")
                    {
                        price += 20;
                    }
                    else if (nameOfArticuls == "flag")
                    {
                        price += 15;
                    }
                    else if (nameOfArticuls == "sticker")
                    {
                        price += 1;
                    }
                }

                if (budget >= price)
                {
                    Console.WriteLine($"You bought {numArticuls} items and left with {budget - price} lv.");
                }
                else
                {
                    Console.WriteLine($"Not enough money, you need {price - budget} more lv.");
                }

            }
        }
    }

}

