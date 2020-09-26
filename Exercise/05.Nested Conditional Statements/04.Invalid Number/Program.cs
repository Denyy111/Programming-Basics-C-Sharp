using System;

namespace _04.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool isValid = (number >= 100 && number <= 200) || number == 0;

            if (!isValid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}


        
//            int number = int.Parse(Console.ReadLine());

//            if (!((number >= 100 && number <= 200) || number == 0))
//            {
//                Console.WriteLine("invalid");
//            }
//        }
//    }
//}
