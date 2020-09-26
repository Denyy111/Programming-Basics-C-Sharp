using System;

namespace texts1
{
    class Program
    {
        static void Main(string[] args)
        {




        }
    }
}














// 06.Cake
//int lenth = int.Parse(Console.ReadLine());
//int width = int.Parse(Console.ReadLine());

//int allPieces = lenth * width;

//            while (allPieces > 0)
//            {
//                string input = Console.ReadLine(); // "10" kato string

//                if (input == "STOP")
//                {
//                    Console.WriteLine($"{allPieces} pieces are left.");
//                    break;
//                }
//                allPieces -= int.Parse(input);
//            }
//            if (allPieces <= 0)
//            {
//                Console.WriteLine($"No more cake left! You need {Math.Abs(allPieces)} pieces more.");
//            }

// -----------------------------------------

// 4.Walking
//string inputSteps = Console.ReadLine(); // 4000 kato stirng
//int totalSteps = 0;

//while (inputSteps != "Going home")
//{
//    totalSteps += int.Parse(inputSteps);

//if (totalSteps >= 10000)
//    {
//        Console.WriteLine("Goal reached! Good job!");
//        break;
//    }
//    inputSteps = Console.ReadLine();
//}
//if (inputSteps == "Going home")
//{
//    int goingHomeSteps = int.Parse(Console.ReadLine());
//    totalSteps += goingHomeSteps;
//    int diffSteps = 10000 - totalSteps;

//    if (totalSteps >= 10000)
//    {
//        Console.WriteLine("Goal reached! Good job!");
//    }
//    if (totalSteps < 10000)
//    {                   
//        Console.WriteLine($"{diffSteps} more steps to reach goal.");
//    }
//}

//-----------------------------------------------------------------------------

// 03.Vacantion
//double needMoneyForVacantion = double.Parse(Console.ReadLine());
//double avaylableMoney = double.Parse(Console.ReadLine());

//int counter = 0;
//int passDays = 0;


//            while (avaylableMoney < needMoneyForVacantion)
//            {
//                string action = Console.ReadLine();
//                int money = int.Parse(Console.ReadLine());

//                if (action == "spend")
//                {
//                    counter++;
//                    avaylableMoney -= money;

//                    if (avaylableMoney < 0)
//                    {
//                        counter = 0;
//                    }
//                }
//                if (action == "save")
//                {
//                    avaylableMoney += money;
//                    counter = 0;
//                }
//                passDays++;
//                if (counter == 5)
//                {
//                    Console.WriteLine($"You can't save the money.");
//                    Console.WriteLine($"{passDays}");
//                    break;
//                }
//            }
//                if (counter != 5)
//                {
//                    Console.WriteLine($"You saved the money for {passDays} days.");
//                }  
// ---------------------------------------------------------------------------

// 02.Exam Preparation 
//int badMarks = int.Parse(Console.ReadLine());
//string nameOfTask = Console.ReadLine();

//int countBedMarks = 0;
//int sumOfGrade = 0;
//string lastProblem = "";
//int countMarks = 0;
//bool isTheGradeBed = false;

//            while (nameOfTask != "Enough")
//            {
//                int grade = int.Parse(Console.ReadLine());
//sumOfGrade += grade;
//                countMarks++;

//                if (grade <= 4)
//                {
//                    countBedMarks++;

//                    if (countBedMarks == badMarks)
//                    {
//                        Console.WriteLine($"You need a break, {countBedMarks} poor grades.");
//                        isTheGradeBed = true;
//                        break;
//                    }
//                }
//                lastProblem = nameOfTask;
//                nameOfTask = Console.ReadLine();
//            }
//            if (isTheGradeBed == false)
//            {
//                double average = sumOfGrade * 1.0 / countMarks;
//Console.WriteLine($"Average score: {average:F2}");
//                Console.WriteLine($"Number of problems: {countMarks}");
//                Console.WriteLine($"Last problem: {lastProblem}");
//             }

// --------------------------------------------------------------------- 

//01.Old Books

//string favoriteBook = Console.ReadLine();  
//int capacity = int.Parse(Console.ReadLine()); 

//int counterOfBooks = 0;
//bool isFound = false;

//while (counterOfBooks < capacity)
//{
//    string newBook = Console.ReadLine();

//    if (newBook == favoriteBook )
//    {
//        isFound = true;
//        Console.WriteLine($"You checked {counterOfBooks} books and found it.");
//        break;
//    }
//    counterOfBooks++;
//}

//if (!isFound)
//{
//    Console.WriteLine($"The book you search is not here!");
//    Console.WriteLine($"You checked {counterOfBooks} books.");

//}    








