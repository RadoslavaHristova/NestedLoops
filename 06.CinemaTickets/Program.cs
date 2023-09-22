using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0, standartTickets = 0, kidsTickets = 0, totalTickets = 0;
            
            string movieName=Console.ReadLine();

            while(movieName!="Finish")
            {
                int hallCapacity=int.Parse(Console.ReadLine());
                int soldSpaces = 0;

                string soldTicketType=Console.ReadLine();

                while(soldTicketType!="End")
                { if (soldTicketType == "student") { studentTickets++;  }
                    else if (soldTicketType == "standard") { standartTickets++;  }
                    else if (soldTicketType == "kid") { kidsTickets++;  }
                    soldSpaces++;
                    
                        if (soldSpaces >= hallCapacity) { break; }

                        soldTicketType = Console.ReadLine();
                }
                totalTickets += soldSpaces;

                double persentageFullHallPerMovie = 100.0 * soldSpaces / hallCapacity;

                Console.WriteLine($"{movieName} - {persentageFullHallPerMovie:f2}% full.");

                movieName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{100.0*studentTickets/totalTickets:f2}% student tickets.");
            Console.WriteLine($"{100.0 * standartTickets / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{100.0 * kidsTickets / totalTickets:f2}% kids tickets.");
        }
    }
}
