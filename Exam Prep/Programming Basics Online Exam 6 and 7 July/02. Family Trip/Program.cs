using System;

namespace _02._Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            double nNights = double.Parse(Console.ReadLine());
            double priceForNights = double.Parse(Console.ReadLine());
            double percentRazhodi = double.Parse(Console.ReadLine());

            if (nNights > 7)
            {
                priceForNights = priceForNights - (priceForNights * 0.05);
                
                priceForNights *= nNights;
            }
            else if (nNights < 7)
            {
                priceForNights = priceForNights * nNights;
            }
            
            percentRazhodi = (percentRazhodi * 0.01) * buget; // 

            double allMonyForVacancion = priceForNights + percentRazhodi;

            if (allMonyForVacancion <= buget)
            {
                double leftMoney = buget - allMonyForVacancion;
                Console.WriteLine($"Ivanovi will be left with {(leftMoney):F2} leva after vacation.");
            }
            else if (allMonyForVacancion > buget)
            {
                double diff = allMonyForVacancion - buget;
                Console.WriteLine($"{(diff):F2} leva needed.");
            }
        }
    }
}
