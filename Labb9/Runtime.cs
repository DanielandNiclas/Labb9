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
                    int pos = ui.AskPlayerPosition(gb);
                    gb.ChangeNodeStatus(pos, 1);
                    ui.PrintBoard(gb);
                    //Console.WriteLine(gb.GetGameBoardNodes());
                    Console.ReadLine();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
            }
            
           
        }
    }
}