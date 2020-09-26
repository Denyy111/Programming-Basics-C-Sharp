using System;

namespace _14.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        0{
            int bonusPoints = int.Parse(Console.ReadLine());



      double bonus = 0.0;


            if (bonusPoints <= 100)                  // числото е до 100
            {
                bonus = 5;                           // бонус точките са 5
                Console.WriteLine();
            }

            else if (bonusPoints > 100 && bonusPoints <= 1000)  //  числото е по - голямо от 100
            {
                bonus = bonusPoints * 0.20;                     // бонус 20% от числото
                Console.WriteLine();
            }
            else if (bonusPoints > 1000)                       // ако числото е по-голямо от 1000
            {
                bonus = bonusPoints * 0.10;                    // бонус точките са 10% от числото
               
            }

            if (bonusPoints % 2 == 0)                         // четно число остатък от 2 да няма остатък т.е = 0
            {
                bonus = bonus + 1;                                
            }

            else if ( bonusPoints % 10 == 5)                  // число завършващо на 5
            {
                bonus = bonus + 2;
            }

            double result = bonus + bonusPoints;   // общият брой на точките с бонусите

            Console.WriteLine(bonus);          
            Console.WriteLine(result);
        }
    }
}
