using System;

namespace TicTacToeGame
{
    class Program
    {
        public static string Player1 = "X";
        public static string Player2 = "O";
        public static int counter = 0;
        public static string[,] matrics = {
        { "1","2","3"},
        {"4","5","6" },
        {"7","8","9" }
        };
        static void Main(string[] args)
        {
            Console.WriteLine("***WellCome****");
            Display();

        }

        public static void Display()
        {
            //create table
            for (int i = 0; i < matrics.GetLength(0); i++)
            {

                for (int j = 0; j < matrics.GetLength(0); j++)
                {
                    Console.Write(" " + matrics[i, j] + " " + "|");
                }
                Console.WriteLine("");
                Console.WriteLine("------------");

            }
        }
        public static void ChangeContent(string Content,string player )
        {
    

            if (Content == matrics[0,0] )
            {
                matrics[0,0]= player;
            }
            else if (Content == matrics[0, 1])
            {
                matrics[0, 1] = player;
            }
            else if (Content == matrics[0, 2])
            {
                matrics[0, 2] = player;
            }
            else if (Content == matrics[1,0])
            {
                matrics[1, 0] = player;
            }
            else if (Content == matrics[1,1])
            {
                matrics[1, 1] = player;
            }
            else if (Content == matrics[1,2])
            {
                matrics[1, 2] = player;
            }
            else if (Content == matrics[2,0])
            {
                matrics[2, 0] = player;
            }
            else if (Content == matrics[2,1])
            {
                matrics[2, 1] = player;
            }
            else if (Content == matrics[2, 2])
            {
                matrics[2,2] = player;
            }


        }
        public static void CheckOut(string palyer)
        {
            if (matrics[0, 0] == matrics[0, 1] && matrics[0, 1]== matrics[0, 2] ||
                matrics[1, 0] == matrics[1, 1] && matrics[1, 0] == matrics[1, 2] ||
                matrics[2, 0] == matrics[2, 1] && matrics[2, 0] == matrics[2, 2] ||
                matrics[0, 0] == matrics[1, 0] && matrics[0, 0] == matrics[2, 0] ||
                matrics[0, 1] == matrics[1, 1] && matrics[0, 1] == matrics[2, 1] ||
                matrics[0, 2] == matrics[1, 2] && matrics[0, 2] == matrics[2, 2] ||
                matrics[0, 0] == matrics[1, 1] && matrics[0, 0] == matrics[2, 2] ||
                matrics[0, 2] == matrics[1, 1] && matrics[0,2] == matrics[2, 1]

                 )
            {
                Console.WriteLine("you are win {0}", palyer);
            }
            else
            {

            }
    }
    }

}
