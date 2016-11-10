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

            switch (ValidInput.Integer(1, 9, "Number: "))
            {
                case 1:
                    GameBoard.Board();
                    Console.ReadKey(true);
                    break;
            }
        }
    }
}