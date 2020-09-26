using System;

namespace _18.Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFilm = double.Parse(Console.ReadLine());
            int numOFStatists = int.Parse(Console.ReadLine());  // броя статисти
            double moneyForCloths = double.Parse(Console.ReadLine());  // колко струва облклото на един статист

            double decor = moneyForFilm * 0.1;
            double totalOutfit = moneyForCloths * numOFStatists;

            if (numOFStatists > 150)  
            {
                totalOutfit = totalOutfit - (totalOutfit * 0.01);
            }
            double expenses = decor + totalOutfit;   // колко ще ни струва целия филм

           
            if (expenses <= moneyForFilm)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs(moneyForFilm - expenses):F2} leva left.");

            }

            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs { Math.Abs(moneyForFilm - expenses):F2} leva more.");      
            }
           


        }
    }
}
