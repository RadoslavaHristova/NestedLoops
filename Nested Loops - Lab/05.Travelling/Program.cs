using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination =Console.ReadLine();
            
           

            while (destination!="End")
            {
                
                double buget=double.Parse
                    (Console.ReadLine());
                double piggyBank = 0;
                while (piggyBank< buget ) 
                {
                double savedMoney=int.Parse(Console.ReadLine());
                    piggyBank += savedMoney;
                 }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
                
            }
        }
    }

