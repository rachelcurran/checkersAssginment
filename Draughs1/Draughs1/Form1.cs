using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draughs1
    
{
    public partial class Form1 : Form

    {
        public Form1()
        {
          
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MenuForm frm = new MenuForm(this);
            frm.Show();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }



        Point mousePos;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                
                
                if(sender.valudMove()) {
                    pictureBox1.Location = new Point(pictureBox1.Left + dx, pictureBox1.Top + dy);
                }else{
                pictureBox1.Location = new Point(pictureBox1.Left + dx, pictureBox1.Top + dy);
                }



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game g = new game();

            foreach (piece p in g.player1.playerPieces) { }
            this.Controls.Add(p);
        }
            


            do
            {
                
             




//                int a = g.player1.playerPieces.Find((piece) sender);




                g.playerOneTurn = !g.playerOneTurn;
            } while (g.gameOver());





        }
    }
}
