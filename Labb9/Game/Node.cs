using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb9
{
    public class Node :IGame
    {
        private int position;

        bool Taken { get; set; }

        int Position
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
         }
        public void PlaceMarker(int row, int col, int player)
        {

        }
    }
}