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
            ui.PlayerTurn();
           
        }
    }
}