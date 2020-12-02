using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ivok11_IRF_Project
{
    public class PlayingButton : Button
    {
        Random rnd = new Random(); 

        public int randomsorszam { get; set; }

        private int _value;

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                
                    int red = rnd.Next(0, 255);
                    int green = rnd.Next(0, 255);
                    int blue = rnd.Next(0, 255);
                    BackColor = Color.FromArgb(red, green, blue);                               
            }
        }

        public PlayingButton()
        {
            Height = 30;
            Width = 60;                                     
        }

     
   
    }
}
