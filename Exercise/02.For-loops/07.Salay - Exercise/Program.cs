using System;


class Salary
{
    static void Main()
    {
        int openedBrowsers = int.Parse(Console.ReadLine());
        double salary = double.Parse(Console.ReadLine());

        for (int i = 0; i < openedBrowsers; i++)
        {
            string websiteName = Console.ReadLine();
            if (websiteName == "Facebook")
            {
                salary -= 150;
            }
            if (websiteName == "Instagram")
            {
                salary -= 100;
            }
            if (websiteName == "Reddit")
            {
                salary -= 50;
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
                return;
            }
        }
        Console.WriteLine(salary);
    }
}





//using System;

//namespace _07.Salay___Exercise
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int countOpenTabs = int.Parse(Console.ReadLine());
//           double salary = double.Parse(Console.ReadLine());

//            for (int i = 0; i < countOpenTabs; i++)
//            {
//                string website = Console.ReadLine();

//                if (website == "Facebook")
//                {
//                    salary -= 150;                  
//                }
//                if (website == "Instagram")
//                {
//                    salary -= 100;                  
//                }
//                if (website == "Rebbit")
//                {
//                    salary -= 50;                 
//                }
//                if (salary <= 0)
//                {
//                    Console.WriteLine("You have lost your salary.");
//                    break;
//                }
//            }
//            Console.WriteLine(salary);            
//        }
//    }
//}
