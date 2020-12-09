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
             

        private int _value;

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                
                
                                                             
            }
        }

        public PlayingButton()
        {
            Height = 30;
            Width = 60;           
            Value = 0;
          
        }

  
   
    }
}
