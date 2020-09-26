using System;

namespace Baking_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            double allsweets = 0;
            double allSum = 0;

            for (int i = 0; i < countPeople; i++)
            {
                string name = Console.ReadLine();
                string typeCake = Console.ReadLine();
                double price = 0;                           
                double countCookis = 0;
                double countCakes = 0;
                double countWaffles = 0;
                
                while (typeCake != "Stop baking!")
                {                  
                    int countSladki = int.Parse(Console.ReadLine());
                  
                    if (typeCake == "cookies")
                    {
                        price = 1.50;
                        price = countSladki * price;
                        countCookis += countSladki;
                    }
                    else if (typeCake == "cakes")
                    {
                        price = 7.80;
                        price = countSladki * price;
                        countCakes += countSladki;
                    }
                    else if (typeCake == "waffles")
                    {
                        price = 2.30;
                        price = countSladki * price;
                        countWaffles += countSladki;
                    }

                    allsweets += countSladki;
                    allSum += price;

                    typeCake = Console.ReadLine();
                }

                Console.WriteLine($"{name} baked {countCookis} cookies, {countCakes} cakes and {countWaffles} waffles.");
              
            }
            Console.WriteLine($"All bakery sold: {allsweets}");
            Console.WriteLine($"Total sum for charity: {allSum:f2} lv.");

        }

        }
    }

