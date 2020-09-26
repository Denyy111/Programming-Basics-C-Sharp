using System;

namespace _13.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeFirst = int.Parse(Console.ReadLine());
            int timeSecond = int.Parse(Console.ReadLine());
            int timeThird = int.Parse(Console.ReadLine());

            int totalTime = timeFirst + timeSecond + timeThird;

            int minutes = totalTime / 60;   // получаваме , колко минути имаме
            int seconds = totalTime % 60;   // получаваме , секундите 

            if (seconds < 10 )
            {
                Console.WriteLine("{0}:0{1}", minutes, seconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minutes, seconds);
            }
        }
    }
}
