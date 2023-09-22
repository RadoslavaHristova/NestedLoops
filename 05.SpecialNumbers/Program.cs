using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());

            for(int i1=1;i1<=9;i1++)
            {
                if (number % i1 != 0) continue;
                for (int i2 = 1; i2 <= 9; i2++)
                {
                    if (number % i2 != 0) continue;
                    for (int i3 = 1; i3 <= 9; i3++)
                    {
                        if (number % i3 != 0) continue;
                        for (int i4 = 1; i4 <= 9; i4++)
                        {
                            if (number % i4 == 0)
                            { Console.Write($"{i1}{i2}{i3}{i4} "); }

                        }
                    }
                }
            }
        }
    }
}
