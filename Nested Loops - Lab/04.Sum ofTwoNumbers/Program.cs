using System;

namespace _04.Sum_ofTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum=int.Parse(Console.ReadLine());
            int stopNum=int.Parse(Console.ReadLine());
            int magicNum=int.Parse(Console.ReadLine());
            int counter = 0;
            bool isFound=false;
            
            for(int i=startNum; i<=stopNum; i++) 
            {
            for (int j=startNum; j<=stopNum; j++) 
                {
                    counter++;
                int sum=i+j;
                    if (sum==magicNum) 
                    { isFound = true;
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNum})");
                        break;
                    }
                }
            if(isFound) { break; }
            }
            if(!isFound)
            { Console.WriteLine($"{counter} combinations - neither equals {magicNum}"); }


        }
    }
}
