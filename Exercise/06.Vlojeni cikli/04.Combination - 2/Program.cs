using System;

namespace _04.Combination
    {
        class Program
        {
            static void Main(string[] args)
            {
                int number = int.Parse(Console.ReadLine());
                int result = 0;

                for (int i = 0; i <= number; i++)
                {
                    for (int j = 0; j <= number; j++)
                    {
                        for (int k = 0; k <= number; k++)
                        {
                            for (int l = 0; l <= number; l++)
                            {
                                for (int m = 0; m <= number; m++)
                                {
                                    int sum = i + j + k + l + m;
                                    if (sum == number)
                                    {
                                        result++;

                                    }
                                }

                            }
                        }

                    }

                }

                Console.WriteLine(result);
            }
        }
    }
