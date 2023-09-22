using System;
using System.Data;

namespace _01NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());

            int colums = 1;
            int rows = 1;

            for(int i=1;i<=n;i++)
            {
                Console.Write(i);
                if (colums==rows) { Console.WriteLine(); rows++; colums = 1; }
            else if(colums!=rows) { Console.Write(" "); colums++;}
            }
        }
    }
}
