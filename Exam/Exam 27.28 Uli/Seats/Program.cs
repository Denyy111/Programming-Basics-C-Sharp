using System;

namespace Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTicket = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < countTicket; i++)
            {
                string ticket = Console.ReadLine(); /// 
                string newTicket = "";

                if (ticket.Length == 4 )
                {
                    if (ticket[0] >= 65 && ticket[0] <= 95)
                    {
                        newTicket = ticket[0] + "" + ticket[1] + ticket[2];
                    }
                    else
                    {
                        newTicket = ticket[3] + "" + ticket[1] + ticket[2];
                    }
                }
                else 
                {
                    int synbol = (int)ticket[1];
                    newTicket = ticket[0] + "" + synbol;                     
                }

                Console.WriteLine($"Seat decoded: {newTicket}");
            }
        }
    }
}
