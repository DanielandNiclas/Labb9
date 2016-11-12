using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb9
{
    public class Node 
    {
        private int position;

        public bool Taken { get; set; }

        public int Player { get; set; }

        public int Position
        {
            get
            {
                return position;
            }
            set
            {
                if (value > 0 && value < 10)
                {
                    position = value;
                }
            }
        }
        #region Node
        public Node(int position)
        {
            this.Position = position;
            this.Taken = false;

            //if(position == 4)
            //{
            //    Taken = true;
            //    Player = 2;
            //}
         }
        #endregion
        //public bool ReserveNode(int player)
        //{
        //    Taken = true;
        //    Player 
        //}
        #region PlaceMarker
        public bool PlaceMarker(int player)
        {
            if(Taken)
            {
                return false;
            } else
            {
                Taken = true;
                Player = player;
                return true;
            }
        #endregion
        }
    }
}