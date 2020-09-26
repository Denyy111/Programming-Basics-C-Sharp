using System;

namespace _03.__Summer_Outfit_Exersis__3
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            string outfit = string.Empty;
            string shoes = string.Empty;

            if (degrees >= 10 && degrees <= 18)
            {
                if (partOfDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";

                }
                else if (partOfDay == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }

            }
            else if (degrees >= 18 && degrees <= 24)
            {
                if (partOfDay == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (partOfDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }

            }
            else if (degrees >= 25)
            {
                if (partOfDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (partOfDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";

                }
                else if (partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }

            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
