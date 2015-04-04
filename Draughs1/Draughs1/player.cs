using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draughs1
{
    class player
    {
        string playerName{
            get { return playerName; }
            set{playerName = value;}
        }

        public List<piece> playerPieces;



        public player(bool IsPlayerOne)
        {
            playerPieces = new List<piece>();
            piece toAdd;

            if (IsPlayerOne)
            {

                //TODO LOGIC CODE HERE
                for (int i = 0; i < 12; i ++)
                {
                    for (int j = 1; j < 3; j++)
                    {
                        toAdd = new piece(new Point(i, j),IsPlayerOne);
                        playerPieces.Add(toAdd);
                    }
                }
            }
            else {
                //TODO LOGIC CODE HERE
                for (int i = 0; i < 12; i += 2)
                {
                    for (int j = 1; j < 12; j += 2)
                    {
                        toAdd = new piece(new Point(i, j), IsPlayerOne);
                        playerPieces.Add(toAdd);
                    }
                }
            
            }
        
        }


        public bool hasLost()
        {
            return playerPieces.Count == 0;
        }
 
    }
}
