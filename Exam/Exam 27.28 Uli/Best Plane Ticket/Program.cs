using System;

namespace Best_Plane_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberTicket = Console.ReadLine();           
            int min = int.MaxValue;
            string poletaSnaiMalkoMinuti = "";
            double biletaSNaiMalkoMinuti = 0;
         
            while (numberTicket != "End")
            {
                double priceTicket = double.Parse(Console.ReadLine());
                int minutes = int.Parse(Console.ReadLine());
                double inLv = priceTicket * 1.96;

                if (minutes < min)
                {
                    min = minutes;
                    poletaSnaiMalkoMinuti = numberTicket;
                    biletaSNaiMalkoMinuti = inLv;

                }                             
                numberTicket = Console.ReadLine();
            }
            int minutes1 = min % 60;
            int ours = min / 60;

            Console.WriteLine($"Ticket found for flight {poletaSnaiMalkoMinuti} costs {biletaSNaiMalkoMinuti:F2} leva with {ours}h {minutes1}m stay");            
        }
    }
}
