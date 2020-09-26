using System;

namespace _04._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int totalSum = 0;
           
         
            while (input != "Movie time!")
            {
                int coutPeople = int.Parse(input);
                capacity -=coutPeople;

                if (capacity < 0)
                {                 
                    break;
                }
                if (coutPeople % 3 == 0)
                {
                    totalSum += (coutPeople * 5) - 5;
                }
                else
                {
                    totalSum += coutPeople * 5;
                }
              
                input = Console.ReadLine();
            }
            
            if (capacity > 0 || capacity == 0)
            {

                Console.WriteLine($"There are {capacity} seats left in the cinema.");             
            }
            else
            {
                Console.WriteLine("The cinema is full.");
               
            }

            Console.WriteLine($"Cinema income - {totalSum} lv.");
        }
    }
}
