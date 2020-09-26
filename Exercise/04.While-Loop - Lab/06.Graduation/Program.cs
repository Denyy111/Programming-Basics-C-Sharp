using System;

namespace _06.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            //            string name = Console.ReadLine();
            //            int counter = 0;
            //            double gradeSum = 0;

            //            while (counter < 12)
            //            {
            //                double grade = double.Parse(Console.ReadLine());

            //                if (grade < 4)                                 
            //                {
            //                    counter--;
            //                }
            //                else
            //                {
            //                    gradeSum += grade;
            //                }               

            //                counter++;
            //            }

            //            double averageGrade = gradeSum / 12;

            //            Console.WriteLine($"{name} graduated.Average grade: {averageGrade:F2}");
            //        }
            //    }
            //}


            string name = Console.ReadLine();
            int counter = 0;
            double gradesum = 0;

            while (counter < 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4)
                {
                    gradesum += grade;
                    counter++;
                }
            }

            double averagegrade = gradesum / 12;

            Console.WriteLine($"{name} graduated. Average grade: {averagegrade:f2}");
        }
    }
}
    