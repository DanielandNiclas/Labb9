using Labb9.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb9
{
    public class UI
    {
        #region MainMenu
        public void MainMenu()
        {
            Console.WriteLine("1 - Start game");
            Console.WriteLine("2 - Quit game");
        }
        #endregion

        #region MainMenuInput
        public string MainMenuInput()
        {
            List<string> validOptions = new List<string>();
            validOptions.Add("1");
            validOptions.Add("2");

            string userChoice = Console.ReadLine();
            
            while(!validOptions.Exists(option => option.ToString() == userChoice))
            {
                Console.WriteLine("Invalid option. Try again: ");
                userChoice = Console.ReadLine();
            }
            return userChoice;
            
        }
        #endregion

        #region PlayerTurn
        public void PlayerTurn()
        {

            switch (ValidInput.Integer(1, 9, "Your choice: "))
            {
                case 1:
                    Console.Clear();
                    //GameBoard.Board();
                    //PrintBoard(gb);
                    Console.ReadKey(true);
                    break;

                case 2:
                    Environment.Exit(0);
                    break;
            }
        }
        #endregion

        #region PrintBoard
        public void PrintBoard(GameBoard gb)
        {
            string[] node = new string[10];

            for(int position = 1; position <= 9; position++)
            {
                 if(gb.GetNodeStatus(position))
                {
                    int player = gb.GetNodePlayer(position);

                    switch(player)
                    {
                        case 1:
                            node[position] = "X";
                            break;

                        case 2:
                            node[position] = "O";
                            break;
                    }
                }
                else
                {
                    node[position] = position.ToString();
                }
            }
            Console.WriteLine("Player 1: X | Player 2: O");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", node[1] , node[2], node[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", node[4], node[5], node[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", node[7], node[8], node[9]);
            Console.WriteLine("     |     |      ");
        }
        #endregion

        public int AskPlayerPosition(GameBoard gb)
        {
            Console.WriteLine("Please select a tile");
           string inputString = Console.ReadLine();
            while(!GameLogic.FreeNodePosition(inputString, gb))
            {
                Console.WriteLine("Invalid input, choose again");
                inputString = Console.ReadLine();
            }
            return int.Parse(inputString);
        }
    }
}