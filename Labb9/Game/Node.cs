using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb9
{
    public class Node 
    {
        private int position;
        private bool taken;
        private int player;

        public bool Taken { get { return taken; } }

        public int Player { get { return player; } }

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
        #region Constructor
        public Node(int position)
        {
            this.Position = position;
            this.taken = false;

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
                this.taken = true;
                this.player = player;
                return true;
            }
        #endregion
        }
    }
}