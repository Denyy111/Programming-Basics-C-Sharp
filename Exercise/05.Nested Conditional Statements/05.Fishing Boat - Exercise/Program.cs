using System;

namespace _05.Fishing_Boat___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int buget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int men = int.Parse(Console.ReadLine());

            double rent = 0;

            if (season == "Spring")
            {
                rent = 3000;

            }
            else if (season == "Summer" || season == "Autumn")
            {
                rent = 4200;
            }
            else if (season == "Winter")
            {
                rent = 2600;
            }

            if (men <= 6 )
            {
                rent *= 0.9;
            }
            else if (men > 7 && men <= 11)
            {
                rent *= 0.85;

            }
            else 
            {
                rent *= 0.75; 
            }

            if (men % 2 == 0 && season != "Autumn")
            {
                rent *= 0.95;
            }

            if (buget >= rent)
            {
                double  leftMoney = buget - rent;

              Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
            }
            else if (buget <= rent) 
            {
                double notEnough = rent - buget;
                Console.WriteLine($"Not enough money! You need {notEnough:f2} leva.");

            }

        }
    }
}
