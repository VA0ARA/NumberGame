using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {
        public static int number = 0;
        static void Main(string[] args)
        {
            bool i = true;
            do {

                Enter(number);
                print();

               
                    Console.WriteLine("please insert number");
                    number = Int32.Parse(Console.ReadLine());
                   

                
            } while (true);
 

            }
        static void Enter(int adad)
        {
            number = adad;

        }
        static void print()
        {
            Console.Clear();
            Console.WriteLine("print:{0}",number);
        }
    }

 
    }

