using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draughs1
{
    class game
    {
        public player player1;
        public player player2;
        public bool playerOneTurn = true;

        public game()
        {
            player1 = new player(true);
            player2 = new player(false);
        }


        public bool gameOver()
        {
            if (player1.hasLost()) { 
            return true;
            }

            if(player2.hasLost())
            {
                return true;
            }
            return false;
        }
    }
}
