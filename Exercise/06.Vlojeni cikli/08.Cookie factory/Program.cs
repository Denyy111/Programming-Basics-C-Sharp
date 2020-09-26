using System;

namespace _08.Cookie_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batchCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < batchCount; i++)
            {
                string input = Console.ReadLine();
                bool hasFlour = false;
                bool hasSugar = false;
                bool hasEggs = false;
                bool hasAllIngrediens = false;

                while (input != "Bake!" || !hasAllIngrediens)
                {
                    if (input == "flour")
                    {
                        hasFlour = true;
                    }
                    else if (input == "sugar")
                    {
                        hasSugar = true;
                    }
                    else if (input == "eggs")
                    {
                        hasEggs = true;
                    }

                    hasAllIngrediens = hasEggs && hasFlour && hasSugar;

                    if (input == "Bake!")
                    {
                        Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    }

                    input = Console.ReadLine();
                }
                Console.WriteLine("Baking batch number {0}...", i + 1);
            }
        }
    }
}

