using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double wordRecord = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double IvansTime = distanceInMeters * timeInSeconds;
            double numOfDelay = Math.Floor(distanceInMeters / 15);
            double totalDelay = numOfDelay * 12.5;
            double TotalTimeIvan = IvansTime + totalDelay;
            double notInafSecond = TotalTimeIvan - wordRecord;

            if (TotalTimeIvan < wordRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {(TotalTimeIvan):F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(notInafSecond):F2} seconds slower.");
            }

        }
    }
}
