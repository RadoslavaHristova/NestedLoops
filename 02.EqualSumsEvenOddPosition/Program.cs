using System;

namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum=int.Parse(Console.ReadLine());
            int stopNum=int.Parse(Console.ReadLine());

            for (int i= startNum; i <= stopNum; i++)
            {
                int evenNumbers = 0, oddNumbers = 0;
                bool isEven = true;
                int currentNumber = i;
                while(currentNumber!=0)
                {
                    int lastDigit=currentNumber%10;
                    if (isEven) { evenNumbers += lastDigit; }
                    else { oddNumbers += lastDigit; }

                    isEven = !isEven;
                    currentNumber /= 10;
                }
                if (evenNumbers==oddNumbers) { Console.Write($"{i} "); }


            }
            
        }
    }
}
