using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ivok11_IRF_Project
{
    class MovingCards:Button
    {
        private int _value;

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;

                if (_value > 500000) BackColor = Color.Brown;
                if (_value < 500000) BackColor = Color.Red;
                if (_value < 400000) BackColor = Color.Orange;
                if (_value < 300000) BackColor = Color.Green;
                if (_value < 200000) BackColor = Color.Yellow;               
                
            }
        }
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
