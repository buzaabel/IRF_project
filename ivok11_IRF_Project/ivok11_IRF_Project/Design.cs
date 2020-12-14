using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ivok11_IRF_Project
{
    class Design:Button
    {
        Random rnd = new Random();
        public Design()
        {
            MouseClick += Design_MouseClick;
        }
        
           

        private void Design_MouseClick(object sender, MouseEventArgs e)
        {
           int b = rnd.Next(0, 255);
           int g = rnd.Next(0, 255);
           int r = rnd.Next(0, 255);   
           
           
           
        }
    }
}
