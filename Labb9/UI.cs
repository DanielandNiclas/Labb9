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

        public void PlayerTurn()
        {

            switch (ValidInput.Integer(1, 9, "Your choice: "))
            {
                case 1:
                    Console.Clear();
                    GameBoard.Board();
                    Console.ReadKey(true);
                    break;

                case 2:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}