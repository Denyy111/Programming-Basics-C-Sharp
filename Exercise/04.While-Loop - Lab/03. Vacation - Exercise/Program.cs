using System;

namespace _03._Vacation___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacantion = double.Parse(Console.ReadLine()); // 2000
            double avaylableMoney = double.Parse(Console.ReadLine()); // 1000
          
            int spentCounter = 0;
            int pastDays = 0;
          

            while (avaylableMoney < moneyForVacantion)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    spentCounter++;
                    avaylableMoney -= money;

                    if (avaylableMoney < 0)
                    {
                        avaylableMoney = 0;
                    }                   
                }
                if (action == "save")
                {
                    avaylableMoney += money;
                    spentCounter = 0;
                    
                }
                pastDays++;
                if (spentCounter == 5)
                {
                    Console.WriteLine($"You can't save the money.");  // \n{pastDays}
                    Console.WriteLine(pastDays);
                    break;
                }                
            }
            if (spentCounter!=5)
            {
                Console.WriteLine($"You saved the money for {pastDays} days.");
            }
               
        }
    }
}
