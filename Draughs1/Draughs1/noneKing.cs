using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draughs1
{
    class noneKing: piece
    {
        public bool move(int x, int y)
        {
            if (y - 2 == this.y)
            {

            }
            else
            {
                if (game.hasPiece(x, y)) return false;

                if (y - 1 != this.y) return false;

                if (x - 1 != this.x || x + 1 != this.x) return false;
            }
        }
    }
}
