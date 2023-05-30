using System;

namespace TicTacToeGame
{
    class Program
    {
        public static char[,] firstList ={
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
                         };
        static void Main(string[] args)
        {
            Format();
        }

        static void Format()
        {
            Console.WriteLine("   |   |   |");
            Console.WriteLine("------------");
            Console.WriteLine($" {firstList[0, 0]} | {firstList[0, 1]} | {firstList[0, 2]} |");
            Console.WriteLine("------------");
            Console.WriteLine($" {firstList[1, 0]} | {firstList[1, 1]} | {firstList[1, 2]} |");
            Console.WriteLine("------------");
            Console.WriteLine($" {firstList[2, 0]} | {firstList[2, 1]} | {firstList[2, 2]} |");
            Console.WriteLine("------------");
        }

    }

}
