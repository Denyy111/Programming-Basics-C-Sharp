using System;

namespace While_loop_more_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int botels = int.Parse(Console.ReadLine());
            int quantity = botels * 750;
            string input = Console.ReadLine();
            int pots = 0;
            int dishesh = 0;
            int counter = 0;
            int sumOFPots = 0;
            int sumOfDishesh = 0;
           

            while (input != "End")
            {
                int countContainers = int.Parse(input);
                counter++;

                if (counter % 3 == 0)
                {
                    pots = countContainers * 15;
                    quantity -= pots;
                    sumOFPots = sumOFPots + countContainers;
                }
                else
                {
                    dishesh = countContainers * 5;
                    quantity -= dishesh;
                    sumOfDishesh = sumOfDishesh + countContainers;
                }
                if (quantity < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(quantity)} ml. more necessary!");
                    break;

                }

                input = Console.ReadLine();
            }

            if (quantity >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{sumOfDishesh} dishes and {sumOFPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {quantity} ml.");
            }
           

        }
    }
}



































//int countBotels = int.Parse(Console.ReadLine()); //  2 broi botilki 
//int detergent = countBotels * 750;
//string numberContainers = string.Empty;

//int containers = 0; // vsichki sydove
//int counterTime = 0;
//int CounterPots = 0;
//int counterDishes = 0;

//while (countBotels > 0)     // 2 > 0
//{
//    numberContainers = Console.ReadLine(); // broi sydove

//    if (numberContainers == "End")
//    {
//        break;
//    }
//    counterTime++;
//    if (counterTime % 3 == 0)
//    {
//        containers = int.Parse(numberContainers);
//        CounterPots += containers;
//        detergent -= containers * 15;
//    }
//    else
//    {
//        containers = int.Parse(numberContainers);
//        counterDishes += containers;
//        detergent -= containers * 5;
//    }
//    if (detergent < 0)
//    {
//        Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
//        return;
//    }
//}

//Console.WriteLine($"Detergent was enough!");
//Console.WriteLine($"{counterDishes} dishes and {CounterPots} pots were washed.");
//Console.WriteLine($"Leftover detergent {detergent} ml.");














