using System;

namespace _07._Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxSum = 0;
            string winer = "";

            while (name != "STOP")
            {
                int sum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    sum += (int)name[i];
                }
                if (sum > maxSum )
                {
                    maxSum = sum;
                    winer = name;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winer} - {maxSum}!");
        }
    }
}
