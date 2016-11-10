using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb9
{
    public class Runtime
    {

        UI ui = new UI();

        public void Start()
        {
            ui.MainMenu();
            switch(ui.MainMenuInput())
            {
                case "1":
                    //ui.PlayerTurn();
                    GameBoard gb = new GameBoard();
                    ui.PrintBoard(gb);
                    Console.WriteLine(ui.AskPlayerPosition(gb));
                    //Console.WriteLine(gb.getGameBoardNodes());
                    Console.ReadLine();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
            }
            
           
        }
    }
}