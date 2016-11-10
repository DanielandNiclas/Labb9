using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb9
{
    public class GameBoard
    {
        private List<Node> nodes = new List<Node>();

        public static  char[] gameArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public GameBoard()
        {
            for(int i=1; i <= 9; i++)
            {
                Node node = new Node(i);
                nodes.Add(node);
            }
        }

        public bool GetNodeStatus(int position)
        {
            Node node = nodes.Find(listNode => listNode.Position == position);
            return node.Taken;
            
        }
        public string getGameBoardNodes()
        {
            string ret = "";
            foreach(Node node in nodes)
            {
                ret += "Node: " + node.Position.ToString() + Environment.NewLine;
            }
            return ret;
        }
        /*
        public static void Board()
        {

            Console.WriteLine("Player 1: X | Player 2: O");
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
        */

        private static int CheckWin()
        {

            // Winning condition for the first row 
            if (gameArray[1] == gameArray[2] && gameArray[2] == gameArray[3])
            {
                return 1;
            }
            //Winning condition for the second row  
            else if (gameArray[4] == gameArray[5] && gameArray[5] == gameArray[6])
            {
                return 1;
            }
            //Winning condition for the third row   
            else if (gameArray[6] == gameArray[7] && gameArray[7] == gameArray[8])
            {
                return 1;
            }

            //Winning condition for the first column      
            else if (gameArray[1] == gameArray[4] && gameArray[4] == gameArray[7])
            {
                return 1;
            }
            //Winning condition for the second column
            else if (gameArray[2] == gameArray[5] && gameArray[5] == gameArray[8])
            {
                return 1;
            }
            //Winning condition for the third column  
            else if (gameArray[3] == gameArray[6] && gameArray[6] == gameArray[9])
            {
                return 1;
            }

            else if (gameArray[1] == gameArray[5] && gameArray[5] == gameArray[9])
            {
                return 1;
            }
            else if (gameArray[3] == gameArray[5] && gameArray[5] == gameArray[7])
            {
                return 1;
            }

            // If all the cells or values filled with X or O then any player has won the match  
            else if (gameArray[1] != '1' && gameArray[2] != '2' && gameArray[3] != '3' && gameArray[4] != '4' && gameArray[5] != '5' && gameArray[6] != '6' && gameArray[7] != '7' && gameArray[8] != '8' && gameArray[9] != '9')
            {
                return -1;
            }

            else
            {
                return 0;
            }
        }

    }
}