using System;

namespace _08.Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            firstWord = firstWord.ToUpper();
            secondWord = secondWord.ToUpper();


            if (firstWord == secondWord)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
