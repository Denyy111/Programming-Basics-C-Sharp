using System;

namespace _03._Film_Premiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string packet = Console.ReadLine();
            int countTickets = int.Parse(Console.ReadLine());
            double price = 0;

            if (name == "John Wick")
            {
                if (packet == "Drink")
                {
                    price = 12;
                    price = price * countTickets;
                }
                else if (packet == "Popcorn")
                {
                    price = 15;
                    price = price * countTickets;
                }
                else if (packet == "Menu")
                {
                    price = 19;
                    price = price * countTickets;
                }
            }
            else if (name == "Star Wars")
            {             
                if (packet == "Drink")
                {
                    price = 18;
                    price = price * countTickets;
                }
                else if (packet == "Popcorn")
                {
                    price = 25;
                    price = price * countTickets;
                }
                else if (packet == "Menu")
                {
                    price = 30;
                    price = price * countTickets;
                }
                if (countTickets >= 4)
                {
                    price = price - (price * 0.30);
                }
            }
            else if (name == "Jumanji")
            {
               
                if (packet == "Drink")
                {
                    price = 9;
                    price = price * countTickets;
                }
                else if (packet == "Popcorn")
                {
                    price = 11;
                    price = price * countTickets;
                }
                else if (packet == "Menu")
                {
                    price = 14;
                    price = price * countTickets;
                }
                if (countTickets == 2)
                {
                    price -= price* 0.15;
                }
            }
            Console.WriteLine($"Your bill is {price:F2} leva.");
        }
    }
}
