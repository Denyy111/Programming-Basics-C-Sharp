using System;

namespace _08.Hotel_Room__Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numOfNights = int.Parse(Console.ReadLine());

            double priceOfStidio = 0.0;
            double priceOfApartment = 0.0;

            if (month == "May" || month == "October")
            {
                priceOfStidio = numOfNights * 50;
                priceOfApartment = numOfNights * 65;

                if (numOfNights > 7 && numOfNights <= 14)
                {
                    priceOfStidio = priceOfStidio - (priceOfStidio * 0.05);
                }
                else if (numOfNights > 14)
                {
                    priceOfStidio = priceOfStidio - (priceOfStidio * 0.3);
                }
            }
            else if (month == "June" || month == "September")
            {
                priceOfStidio = numOfNights * 75.20;
                priceOfApartment = numOfNights * 68.70;

                if (numOfNights > 14)
                {
                    priceOfStidio = priceOfStidio - (priceOfStidio * 0.20);
                }
            }
            else if (month == "July" || month == "August")
            {
                priceOfStidio = numOfNights * 76;
                priceOfApartment = numOfNights * 77;
            }

            if (numOfNights > 14)
            {
                priceOfApartment = priceOfApartment - (priceOfApartment * 0.1);
            }

            Console.WriteLine($"Apartment: {priceOfApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceOfStidio:f2} lv.");

        }
    }
}
