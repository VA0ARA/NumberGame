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
        static char input;
        static void Main(string[] args)
        {
            Format();
            Console.WriteLine("please Enter number");
            input = char.Parse(Console.ReadLine());

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
        static void ChangeContentOfFirstList(char input,int player)
        {
            char charPlayer=' ';
            if (player == 1)
            {
                charPlayer = 'X';

            }else if(player==2)
            {
                charPlayer = 'O';
            }
            switch (input)
            {
                case '1':
                    firstList[0, 0] =charPlayer;
                    break;
                case '2':
                    firstList[0, 1] = charPlayer;
                    break;
                case '3':
                    firstList[0, 2] = charPlayer;
                    break;
                case '4':
                    firstList[1, 0] = charPlayer;
                    break;
                case '5':
                    firstList[1, 1] = charPlayer;
                    break;
                case '6':
                    firstList[1, 2] = charPlayer;
                    break;
                case '7':
                    firstList[2, 0] = charPlayer;
                    break;
                case '8':
                    firstList[2, 1] = charPlayer;
                    break;
                case '9':
                    firstList[2, 3] = charPlayer;
                    break;





            }
        }

    }

}
