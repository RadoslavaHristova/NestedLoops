using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalScoreSum = 0;
            int juryQty=int.Parse(Console.ReadLine());
            int presentationQty = 0;
            string presenationName=Console.ReadLine();
            
            while (presenationName!="Finish")
            {
                double sumOfEachScorePerPresentation = 0;

                for (int i=0;i<juryQty;i++) 
                {
                double score=double.Parse(Console.ReadLine());
                    sumOfEachScorePerPresentation += score;
                    
                }
                double averageScore = sumOfEachScorePerPresentation/juryQty;
                Console.WriteLine($"{presenationName} - {averageScore :f2}.");
                presentationQty++;
                totalScoreSum += sumOfEachScorePerPresentation;
                presenationName = Console.ReadLine();
            }
            double finalSum=totalScoreSum/(juryQty*presentationQty);
            Console.WriteLine($"Student's final assessment is {finalSum:f2}.");

        }
    }
}
