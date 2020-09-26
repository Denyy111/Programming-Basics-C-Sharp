using System;

namespace _07.Sum_Of_Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int sumA = 0;
            int sumE = 0;
            int sumI = 0;
            int sumO = 0;
            int sumU = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    sumA += 1;
                }
                else if (text[i] == 'e')
                {
                    sumE += 2;
                }
                else if (text[i] == 'i')
                    {
                    sumI += 3;
                }
                else if (text[i] == 'o')
                {
                    sumO += 4;
                }
                else if (text[i] == 'u')
                {
                    sumU += 5;
                }               
            }
            int resultSum = sumA + sumE + sumI + sumO + sumU;
            Console.WriteLine(resultSum);
        }
    }
}
