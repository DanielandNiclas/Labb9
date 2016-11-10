using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb9
{
    public class UI
    {
        public void MainMenu()
        {
            Console.WriteLine("1 - Start game");
            Console.WriteLine("2 - Quit game");
        }

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

        //public void PrintGameBoard()

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

        public void PrintBoard(GameBoard gb)
        {
            string[] node = new string[9];

            for(int i = 1; i <= 9; i++)
            {
                 if(gb.GetNodeStatus(i))
                {

                }
            }
            Console.WriteLine("Player 1: X | Player 2: O");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", gb.GetNodeStatus(1) , gb.GetNodeStatus(2), gb.GetNodeStatus(3));
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", gb.GetNodeStatus(4), gb.GetNodeStatus(5), gb.GetNodeStatus(6));
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", gb.GetNodeStatus(7), gb.GetNodeStatus(8), gb.GetNodeStatus(9));
            Console.WriteLine("     |     |      ");
        }
    }
}