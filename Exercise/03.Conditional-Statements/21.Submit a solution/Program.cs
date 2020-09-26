using System;

namespace _21.Submit_a_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            double V = double.Parse(Console.ReadLine());
            double pipe1 = double.Parse(Console.ReadLine());
            double pipe2 = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine()); // chasovete v koito rabotnika otsystva 
            
            double timeP1 = pipe1 * H;
            double timeP2 = pipe2 * H;

            double totalTimeP1P2 = timeP1 + timeP2;
            double totalTimeP1P2Parsent = totalTimeP1P2 / V * 100;
            double p1Persent = pipe1 * H / totalTimeP1P2 * 100;
            double p2Persent = pipe2 * H / totalTimeP1P2 * 100;
            double waterMore = totalTimeP1P2 - V;



            if (totalTimeP1P2 <= V)

            {           
                Console.WriteLine($"The pool is {totalTimeP1P2Parsent:F2}% full. Pipe 1: {timeP1 / totalTimeP1P2 * 100:F2}%. Pipe 2: {timeP2 / totalTimeP1P2 * 100:F2}%.");
            }
            else if (totalTimeP1P2 >= V)
            {
                Console.WriteLine($"For {H:F2} hours the pool overflows with {(waterMore - V):F2} liters.");
            }
        }
    }
}


//        {
//            int v = int.Parse(Console.ReadLine());
//            int p1 = int.Parse(Console.ReadLine());
//            int p2 = int.Parse(Console.ReadLine());
//            double hours = double.Parse(Console.ReadLine());

//            double water = p1 * hours + p2 * hours;

//            if (water <= v)
//            {
//                double waterPersent = water / v * 100;
//                double p1Persent = p1 * hours / water * 100;
//                double p2Persent = p2 * hours / water * 100;


//                Console.WriteLine($"The pool is {waterPersent:F2}% full. Pipe 1: {p1Persent:F2}%. Pipe 2: {p2Persent:F2}%.");
//            }
//            else
//            {
//                double waterMore = water - v;

//                Console.WriteLine($"For {hours:F2} hours the pool overflows with {waterMore:F2} liters.");
//            }
//        }
//    }
//}
