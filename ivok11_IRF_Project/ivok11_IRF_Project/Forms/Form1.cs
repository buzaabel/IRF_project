using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ivok11_IRF_Project
{
    public partial class Form1 : Form
    {
       
               
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Brown;
            LCardsBtn.BackColor = Color.LightGreen;
            GuessGamebtn.BackColor = Color.Green;
            game1btn.BackColor = Color.Green;
        }

              
        private void LCardsBtn_Click(object sender, EventArgs e)
        {
            LearningCardsForm uj = new LearningCardsForm();
            uj.Show();
            
        }

        private void GuessGamebtn_Click(object sender, EventArgs e)
        {
            GuessGameForm gmf = new GuessGameForm();
            gmf.Show();
           
        }

        private void game1btn_Click(object sender, EventArgs e)
        {
            Game1 g1 = new Game1();
            g1.Show();
            
        }
    }
}
