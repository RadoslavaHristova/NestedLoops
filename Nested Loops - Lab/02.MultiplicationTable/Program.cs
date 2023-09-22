using System;

namespace _02.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Отпечатайте на конзолата таблицата за умножение за числата от 1 до 10 във формат: 
            //"{първи множител} * {втори множител} = {резултат}".

            for(int x=1; x<=10; x++) 
            {
            for(int y=1; y<=10; y++)
                { Console.WriteLine($"{x} * {y} = {x*y}"); }
            }

        }
    }
}
