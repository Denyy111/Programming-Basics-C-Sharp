using System;

namespace _20.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        //        {
        //            double moneyOfFamily = double.Parse(Console.ReadLine());
        //            double averageSuccess = double.Parse(Console.ReadLine());
        //            double minSalary = double.Parse(Console.ReadLine());


        //            double sizeSocStudentship = minSalary * 0.35;
        //            double exellantStudentship = averageSuccess * 25;

        //            if (averageSuccess < 4.50)
        //            {
        //                Console.WriteLine("You cannot get a scholarship!");
        //            }
        //            if (moneyOfFamily > minSalary)
        //            {
        //                Console.WriteLine("You cannot get a scholarship!");
        //            }
        //            if (moneyOfFamily < minSalary && averageSuccess > 4.50)
        //            {
        //                Console.WriteLine($"You get a Social scholarship {sizeSocStudentship} BGN", Math.Floor(sizeSocStudentship));
        //            }

        //            if (averageSuccess >= 5.50)
        //            {
        //                Console.WriteLine($"You get a scholarship for excellent results {exellantStudentship} BGN", Math.Floor(exellantStudentship));
        //            }
        //            if ((averageSuccess >= 5.50))
        //            {
        //                Console.WriteLine($"You get a Social scholarship {exellantStudentship} BGN", Math.Floor(exellantStudentship));
        //            }
        //        }
        //    }
        //}

           
        {
            double moneyGain = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minWage = double.Parse(Console.ReadLine());

            double social = Math.Floor(minWage * 0.35);
            double scolarship = Math.Floor(grade * 25);

            if (grade < 4.50)
            {
                Console.WriteLine("You cannot get a scholarship");
            }
            else if (grade >= 4.50 && grade < 5.50)
            {
                if (minWage < moneyGain)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else if (minWage >= moneyGain)
                {
                    Console.WriteLine($"You get a Social scholarship {social} BGN");
                }

            }
            else if (grade >= 5.50)
            {
                if (minWage < moneyGain)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scolarship} BGN");
                }
                else if (minWage >= moneyGain && social > scolarship)
                {
                    Console.WriteLine($"You get a Social scholarship {social} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scolarship} BGN");
                }
            }

        }
    }
}