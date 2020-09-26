using System;

namespace _07._SkiTrip___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string grade = Console.ReadLine();

            int nights = days - 1;
            double totalPrice = 0;


            if (typeOfRoom == "apartment")
            {
                totalPrice = nights * 25;
                if (days < 10)
                {
                    totalPrice = totalPrice * (1 - 30 / 1 - 100);
                }
                else if (days > 15)
                {
                    totalPrice *= 0.5;
                }
                else
                {
                    totalPrice = totalPrice * 0.65;
                }
            }
            else if (typeOfRoom == "president apartment")
            {
                totalPrice = nights * 35;
                if (days < 10)
                {
                    totalPrice = totalPrice * 0.9;
                }
                else if (days > 15)
                {
                    totalPrice = totalPrice * 0.8;
                }
                else
                {
                    totalPrice = totalPrice * 0.85;
                }
            }
            else 
            {
                totalPrice = nights * 18;
            }
            if (grade == "positive")
            {
                totalPrice = totalPrice * 1.25;
            }
            else
            {
                totalPrice = totalPrice * 0.9;
            }

            Console.WriteLine("{0:F2}", totalPrice);                    
        }
    }
}
