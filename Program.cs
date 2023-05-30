using System;

namespace TicTacToeGame
{
    class Program
    {

        static void Main(string[] args)
        {
            SetField();


        }
        public static void SetField()
        {
            
            Console.WriteLine("     |     |      ");
            //TODO replace numbers with variebles
            Console.WriteLine("  {0}  |  {1}  |  {2}", 1, 2, 3);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //TODO replace numbers with variebles
            Console.WriteLine("  {0}  |  {1}  |  {2}", 4, 5, 6);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //TODO replace numbers with variebles
            Console.WriteLine("  {0}  |  {1}  |  {2}", 7, 8, 9);
            Console.WriteLine("     |     |     ");
            
        }




    }

}
