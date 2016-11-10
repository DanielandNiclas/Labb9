using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb9.Game
{
    class GameLogic
    {
        #region FreeNodePosition
        public static bool FreeNodePosition(string userInput, GameBoard gb)
        {
            int userInputInt;

            if (int.TryParse(userInput, out userInputInt))
            {
                if (userInputInt >= 1 && userInputInt <= 9)
                {
                    if (!gb.GetNodeStatus(userInputInt))
                    {
                        return true;
                    }
                }
            }
            return false;

        }
        #endregion
    }
}
