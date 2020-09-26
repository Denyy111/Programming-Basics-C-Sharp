//////////////////////////////////]\7/89/using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorOfMarks = int.Parse(Console.ReadLine());
            string inputNameOfTask = Console.ReadLine();
          
            int countPoorOfMarks = 0;
            int sumOfGrade = 0;
            int counterMarks = 0;
            string lastProblem = string.Empty;
            bool isTheGradeBed = false;
            
            while (inputNameOfTask != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                sumOfGrade += grade;
                counterMarks++;                

                if (grade <= 4)
                {
                    countPoorOfMarks++;

                    if (countPoorOfMarks == poorOfMarks)
                    {
                        Console.WriteLine($"You need a break, {countPoorOfMarks} poor grades.");
                        isTheGradeBed = true;
                        break;
                    }
                }
                lastProblem = inputNameOfTask;
                inputNameOfTask = Console.ReadLine();
            }
            if (isTheGradeBed == false)
            {
                double average = sumOfGrade * 1.0 / counterMarks;
                Console.WriteLine($"Average score: {average:F2}");
                Console.WriteLine($"Number of problems: {counterMarks}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}

