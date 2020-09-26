using System;

namespace Cruise_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeExscutsion = Console.ReadLine();
            string typeKauta = Console.ReadLine();
            int countNights = int.Parse(Console.ReadLine());

            double price = 0.00;
            double totalPrice = 0.00;



            if (typeExscutsion == "Mediterranean")
            {
                if (typeKauta == "standard cabin")
                {
                    price = 27.50;
                    price = price * 4 * countNights;

                }
                else if (typeKauta == "cabin with balcony")
                {
                    price = 30.20;
                    price = price * 4 * countNights;
                }
                else if (typeKauta == "apartment")
                {
                    price = 40.50;
                    price = price * 4 * countNights;
                }

            }
            else if (typeExscutsion == "Adriatic")
            {
                if (typeKauta == "standard cabin")
                {
                    price = 22.99;
                    price = price * 4 * countNights;
                }
                else if (typeKauta == "cabin with balcony")
                {
                    price = 25.00;
                    price = price * 4 * countNights;
                }
                else if (typeKauta == "apartment")
                {
                    price = 34.99;
                    price = price * 4 * countNights;
                }
            }
            else if (typeExscutsion == "Aegean")
            {
                if (typeKauta == "standard cabin")
                {
                    price = 23.00;
                    price = price * 4 * countNights;
                }
                else if (typeKauta == "cabin with balcony")
                {
                    price = 26.60;
                    price = price * 4 * countNights;
                }
                else if (typeKauta == "apartment")
                {
                    price = 39.80;
                    price = price * 4 * countNights;
                }
            }

            if (countNights > 7)
            {
               price = price - (price * 0.25);              
            }

            Console.WriteLine($"Annie's holiday in the {typeExscutsion} sea costs {price:F2} lv.");
        }
    }
}
