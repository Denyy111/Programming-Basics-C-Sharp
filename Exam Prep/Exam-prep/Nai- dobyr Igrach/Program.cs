using System;

namespace Nai__dobyr_Igrach
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string besPlayer = "";
            int maxGoals = 0;
            bool hatTrick = false;

            while (name != "END")
            {
                int goals = int.Parse(Console.ReadLine());

                if (goals > maxGoals)
                {
                    maxGoals = goals;
                    besPlayer = name;
                }            
                if (goals >= 3)
                {
                    hatTrick = true;
                }
                if (goals >= 10)
                {
                    break;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"{besPlayer} is the best player!");

            if (hatTrick)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}
