using Draughs1.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draughs1
{
    class piece : PictureBox
    {

        PictureBox pb = new PictureBox();
        



        public Point boardposition;
        

        //public pictureBox image;

        public piece(Point _position, bool LightPiece)
        {
            boardposition = _position;

            Size = new Size(56, 56);

            Location = new Point(56 * _position.X, 56 * _position.Y);

            if(LightPiece){

                object O = Resources.ResourceManager.GetObject("WhitePiece"); //Return an object from the image chan1.png in the project
                        Image = (Image)O;
            }else{
            object O = Resources.ResourceManager.GetObject("BlackPiece"); //Return an object from the image chan1.png in the project
            Image = (Image)O;
            }
        }

        public bool validMove(Point movedTo)
        {
            return true;
        }

    }
}
