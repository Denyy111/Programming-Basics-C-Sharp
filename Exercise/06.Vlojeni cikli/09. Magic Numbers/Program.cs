using System;

namespace _09._Magic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int magigNumber = int.Parse(Console.ReadLine());

            for (int firstNumber = 0; firstNumber < 10; firstNumber++)
            {
                for (int secondNumber = 0; secondNumber < 10; secondNumber++)
                {
                    for (int thirdNumber = 0; thirdNumber < 10; thirdNumber++)
                    {
                        for (int fourNumber = 0; fourNumber < 10; fourNumber++)
                        {
                            for (int fiveNumber = 0; fiveNumber < 10; fiveNumber++)
                            {
                                for (int sixNumber = 0; sixNumber < 10; sixNumber++)
                                {
                                    int product = firstNumber * secondNumber * thirdNumber * fourNumber * fiveNumber * sixNumber;
                                    if (product == magigNumber)
                                    {
                                        Console.Write($"{firstNumber}{secondNumber}{thirdNumber}{fourNumber}{fiveNumber}{sixNumber} ");
                                    }
                                }

                            }

                        }

                    }

                }

            }
        }
    }
}
