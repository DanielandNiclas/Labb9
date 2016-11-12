using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb9
{
    public interface IUI
    {
        void MainMenu();
        string MainMenuInput();
        void PrintBoard(GameBoard gb);
        int AskPlayerPosition(GameBoard gb);

    }
}
