﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb9
{
    public class GameBoard
    {
        private List<Node> nodes = new List<Node>();

        #region Constructor
        public GameBoard()
        {
            for(int i=1; i <= 9; i++)
            {
                Node node = new Node(i);
                nodes.Add(node);
            }
        }
        #endregion

        #region GetNodeStatus
        public bool GetNodeStatus(int position)
        {
            Node node = nodes.Find(listNode => listNode.Position == position);
            return node.Taken;
            
        }
        #endregion

        #region GetNodePlayer
        public int GetNodePlayer(int position)
        {
            Node node = nodes.Find(listNode => listNode.Position == position);
            return node.Player;
        }
        #endregion

        #region GetGameBoardNodes
        public string GetGameBoardNodes()
        {
            string ret = "";
            foreach(Node node in nodes)
            {
                ret += "Node: " + node.Position.ToString() + Environment.NewLine;
            }
            return ret;
        }
        #endregion

        #region ChangeNodeStatus
        public bool ChangeNodeStatus(int nodePosition, int player)
        {
            Node node = nodes.Find(findNode => findNode.Position == nodePosition);
            if(node.Taken == false)
            {
                node.PlaceMarker(player);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

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

        //private static int CheckWin()
        //{

        //    // Winning condition for the first row 
        //    if (gameArray[1] == gameArray[2] && gameArray[2] == gameArray[3])
        //    {
        //        return 1;
        //    }
        //    //Winning condition for the second row  
        //    else if (gameArray[4] == gameArray[5] && gameArray[5] == gameArray[6])
        //    {
        //        return 1;
        //    }
        //    //Winning condition for the third row   
        //    else if (gameArray[6] == gameArray[7] && gameArray[7] == gameArray[8])
        //    {
        //        return 1;
        //    }

        //    //Winning condition for the first column      
        //    else if (gameArray[1] == gameArray[4] && gameArray[4] == gameArray[7])
        //    {
        //        return 1;
        //    }
        //    //Winning condition for the second column
        //    else if (gameArray[2] == gameArray[5] && gameArray[5] == gameArray[8])
        //    {
        //        return 1;
        //    }
        //    //Winning condition for the third column  
        //    else if (gameArray[3] == gameArray[6] && gameArray[6] == gameArray[9])
        //    {
        //        return 1;
        //    }

        //    else if (gameArray[1] == gameArray[5] && gameArray[5] == gameArray[9])
        //    {
        //        return 1;
        //    }
        //    else if (gameArray[3] == gameArray[5] && gameArray[5] == gameArray[7])
        //    {
        //        return 1;
        //    }

        //    // If all the cells or values filled with X or O then any player has won the match  
        //    else if (gameArray[1] != '1' && gameArray[2] != '2' && gameArray[3] != '3' && gameArray[4] != '4' && gameArray[5] != '5' && gameArray[6] != '6' && gameArray[7] != '7' && gameArray[8] != '8' && gameArray[9] != '9')
        //    {
        //        return -1;
        //    }

        //    else
        //    {
        //        return 0;
        //    }
        // }

    }
}