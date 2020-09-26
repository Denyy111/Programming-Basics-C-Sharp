using System;

namespace _05._PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            double gameH = 0.00;
            double gameF = 0.0;
            double gameO = 0.00;
            double otherGame = 0.00;
                    
            for (int i = 0; i < n; i++)
            {
                string game = Console.ReadLine();
               
                if (game == "Hearthstone")  // 3
                {
                    gameH++;    
                   
                }
                else if (game == "Fornite") // 2
                {
                    gameF++;           
                }
                else if (game == "Overwatch")
                {
                    gameO++;
                }
                else 
                {
                    otherGame++;
                }
            }
            double percentPerGame = 100 / (n * 1.0 );        
            double H = gameH * percentPerGame;
            double F = gameF * percentPerGame;
            double O = gameO * percentPerGame;
            double other = otherGame * percentPerGame;
        

            Console.WriteLine($"Hearthstone - {H:F2}%");
            Console.WriteLine($"Fornite - {F:F2}%");
            Console.WriteLine($"Overwatch - {O:F2}%");
            Console.WriteLine($"Others - {other:F2}%");
        }
    }
}
