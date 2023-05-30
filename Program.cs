using System;

namespace TicTacToeGame
{
    class Program
    {
        //the playfield
        static char[,] playField =
            {
                {'1','2','3'},  //Row 0
                {'4','5','6'},  //Row 1
                {'7','8','9'}   //Row 2
            };

        static void Main(string[] args)
        {
            SetField();


        }
        public static void SetField()
        {

            Console.WriteLine("     |     |      ");
            //TODO replace numbers with variebles
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //TODO replace numbers with variebles
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //TODO replace numbers with variebles
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |     |     ");

        }




    }

}
