using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ivok11_IRF_Project
{
    class MovingCards:Button
    {
        int ox, oy;
        bool move = false;
        public MovingCards()
        {
            Height = 40;
            Width = 100;
            MouseDown += MovingCards_MouseDown;
            MouseUp += MovingCards_MouseUp;
            MouseMove += MovingCards_MouseMove;
        }

        private void MovingCards_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                Left += e.X - ox;
                Top += e.Y - oy;
            }
        }

        private void MovingCards_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void MovingCards_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            ox = e.X;
            oy = e.Y;
        }
    }
}
