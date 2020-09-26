using System;

namespace _06._Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameTeam = Console.ReadLine();

            int countMaches = int.Parse(Console.ReadLine());

            int total = 0;
            int machPro = 0;
            int machDusp = 0;
           

            for (int i = 0; i < countMaches; i++)
            {
                int timeMaches = int.Parse(Console.ReadLine());

                total += timeMaches;
                
                if (timeMaches > 90 && timeMaches <= 120)
                {
                    machPro++;
                }
                else if (timeMaches > 120)
                {
                    machDusp++;
                }                     

            }

            Console.WriteLine($"{nameTeam} has played {(total * 1.0 )} minutes. Average minutes per game: {(total * 1.0/ countMaches):F2}");
            Console.WriteLine($"Games with penalties: {machDusp}");
            Console.WriteLine($"Games with additional time: {machPro}");
        }
    }
}
