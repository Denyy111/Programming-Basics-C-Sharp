using System;

namespace _01.Old_Books____Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBooks = Console.ReadLine();
            int allBooksInLaybraly = int.Parse(Console.ReadLine());

            double counter = 0;
            bool isFound = false;

            while (counter < allBooksInLaybraly)
            {
                string newBooks = Console.ReadLine();

                if (favoriteBooks == newBooks)
                {
                    isFound = true;
                    // Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                counter++;
            }
            if (!isFound)
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
            else
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }

        }
    }
}

