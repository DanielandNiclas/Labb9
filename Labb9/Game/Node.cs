using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb9
{
    public class Node :IGame
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

        public Node(int position)
        {
            this.Position = position;
            this.Taken = false;
         }
        public void PlaceMarker(int row, int col, int player)
        {

        }
    }
}