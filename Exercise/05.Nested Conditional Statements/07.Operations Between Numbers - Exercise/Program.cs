using System;

namespace _07.Operations_Between_Numbers___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int seconNumber = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double totalNumber = 0;
      

            if (symbol == '+')
            {
                totalNumber = firstNumber + seconNumber;
                if (totalNumber % 2 == 0)
                {
                    Console.WriteLine($"{firstNumber} + {seconNumber} = {totalNumber} - even");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} + {seconNumber} = {totalNumber} - odd");
                }
            }
            else if (symbol == '-')
            {
                totalNumber = firstNumber - seconNumber;
                if (totalNumber % 2 == 0)
                {
                    Console.WriteLine($"{firstNumber} - {seconNumber} = {totalNumber} - even");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} - {seconNumber} = {totalNumber} - odd");
                }
            }
            else if (symbol == '*')
            {
                totalNumber = firstNumber * seconNumber;
                if (totalNumber % 2 == 0)
                {
                    Console.WriteLine($"{firstNumber} * {seconNumber} = {totalNumber} - even");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} * {seconNumber} = {totalNumber} - odd");
                }

            }
            else if (symbol == '/')
            {
                if (seconNumber!=0)
                {
                    Console.WriteLine($"{firstNumber} / {seconNumber} = {firstNumber * 1.0 / seconNumber:F2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
               
            }
            else if (symbol == '%')
            {
                if (seconNumber!=0)
                {
                    Console.WriteLine($"{firstNumber} % {seconNumber} = {firstNumber % seconNumber}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }

            }
        }
    }
}
