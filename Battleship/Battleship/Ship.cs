using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Ship
    {
        public int Length { get; private set; }
        public bool IsSunk { get; private set; }
        public string Coordinates { get; set; }

        public Ship(int length)
        {
            Length = length;
            IsSunk = false;
        }

        public void Hit()
        {
            Length--;
            if (Length <= 0)
            {
                IsSunk = true;
            }
        }
    }
}
