using System;

namespace _07.Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string grade = Console.ReadLine();

            int nights = days - 1;
            double totalPrice = 0;

            if (roomType == "apartment")
            {
                totalPrice = nights * 25;
                if (days < 10)
                {
                    totalPrice *= 0.7;
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
            else if (roomType == "president apartment")
            {
                totalPrice = nights * 35;
                if (days < 10)
                {
                    totalPrice *= 0.9;
                }
                else if (days > 15)
                {
                    totalPrice *= 0.8;
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

            Console.WriteLine("{0:F2}" , totalPrice);  // Console.WriteLine ($"{totalPrice:f2}");

        }
    }
}
