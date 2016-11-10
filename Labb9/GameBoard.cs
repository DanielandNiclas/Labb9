using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb9
{
    public class GameBoard
    {
        static char[] gameArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", gameArray[1], gameArray[2], gameArray[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", gameArray[4], gameArray[5], gameArray[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", gameArray[7], gameArray[8], gameArray[9]);
            Console.WriteLine("     |     |      ");
        }
    }
}