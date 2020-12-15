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
    public partial class GuessGameForm : Form
    {
        public List<Cars> carslist = new List<Cars>();
        public List<int> randomszamok = new List<int>();
        Random rnd = new Random();
        private int megoldas2;
        int pontok = 0;


        public GuessGameForm()
        {
            InitializeComponent();
            XmlRead();            
            this.BackColor = Color.Green;
            pontoklabel.Text = pontok.ToString();
        }

        private void GameGenerate()
        {
            int x = carslist.Count;
            int number;
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    number = rnd.Next(0, x);
                } while (randomszamok.Contains(number));
                randomszamok.Add(number);                
            }
            int q = randomszamok[0];
            Car1btn.Text = carslist[q].Price.ToString();
            int w = randomszamok[1];
            Car2btn.Text = carslist[w].Price.ToString();
            int r = randomszamok[2];
            Car3btn.Text = carslist[r].Price.ToString();
            int t = randomszamok[3];
            Car4btn.Text = carslist[t].Price.ToString();

            int megoldas = rnd.Next(0, 3);
            megoldas2 = randomszamok[megoldas];
            autotb.Text = carslist[megoldas2].Name + " " + carslist[megoldas2].Model;
            
        }
       

        private void XmlRead()
        {
            XmlDocument cars = new XmlDocument();
            cars.Load("Cars.xml");

            foreach (XmlElement element in cars.DocumentElement)
            {

                var car = new Cars();

                carslist.Add(car);

                car.Name = (element.GetAttribute("name"));
                car.Model = (element.GetAttribute("model"));
                car.Color = (element.GetAttribute("color"));
                car.Price = int.Parse(element.InnerText);
                

            }

        }

        private void Car1btn_Click(object sender, EventArgs e)
        {
           
            

            if (Car1btn.Text==carslist[megoldas2].Price.ToString())
            {
                MessageBox.Show("Helyes válasz");
                Car1btn.Enabled = false;
                Car2btn.Enabled = false;
                Car3btn.Enabled = false;
                Car4btn.Enabled = false;
                Nextbtn.Enabled = true;
                pontok++;
                pontoklabel.Refresh();
                pontoklabel.Text = pontok.ToString();
            }
            else
            {
                MessageBox.Show("Rossz válasz, a játék véget ért");
                Car1btn.Enabled = false;
                Car2btn.Enabled = false;
                Car3btn.Enabled = false;
                Car4btn.Enabled = false;
                Nextbtn.Enabled = false;
            }
        }

        private void Car2btn_Click(object sender, EventArgs e)
        {
            
          

            if (Car2btn.Text == carslist[megoldas2].Price.ToString())
            {
                MessageBox.Show("Helyes válasz");
                Car1btn.Enabled = false;
                Car2btn.Enabled = false;
                Car3btn.Enabled = false;
                Car4btn.Enabled = false;
                Nextbtn.Enabled = true;
                pontok++;
                pontoklabel.Refresh();
                pontoklabel.Text = pontok.ToString();
            }
            else
            {
                MessageBox.Show("Rossz válasz, a játék véget ért");
                Car1btn.Enabled = false;
                Car2btn.Enabled = false;
                Car3btn.Enabled = false;
                Car4btn.Enabled = false;
                Nextbtn.Enabled = false;
            }
        }

        private void Car3btn_Click(object sender, EventArgs e)
        {
       
           

            if (Car3btn.Text == carslist[megoldas2].Price.ToString())
            {
                MessageBox.Show("Helyes válasz");
                Car1btn.Enabled = false;
                Car2btn.Enabled = false;
                Car3btn.Enabled = false;
                Car4btn.Enabled = false;
                Nextbtn.Enabled = true;
                pontok++;
                pontoklabel.Refresh();
                pontoklabel.Text = pontok.ToString();
            }
            else
            {
                MessageBox.Show("Rossz válasz, a játék véget ért");
                Car1btn.Enabled = false;
                Car2btn.Enabled = false;
                Car3btn.Enabled = false;
                Car4btn.Enabled = false;
                Nextbtn.Enabled = false;
            }
        }

        private void Car4btn_Click(object sender, EventArgs e)
        {
            
           

            if (Car4btn.Text == carslist[megoldas2].Price.ToString())
            {
                MessageBox.Show("Helyes válasz");
                Car1btn.Enabled = false;
                Car2btn.Enabled = false;
                Car3btn.Enabled = false;
                Car4btn.Enabled = false;
                Nextbtn.Enabled = true;
                pontok++;
                pontoklabel.Refresh();
                pontoklabel.Text = pontok.ToString();

            }
            else
            {
                MessageBox.Show("Rossz válasz, a játék véget ért");
                Car1btn.Enabled = false;
                Car2btn.Enabled = false;
                Car3btn.Enabled = false;
                Car4btn.Enabled = false;
                Nextbtn.Enabled = false;
            }
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            Car1btn.Enabled = true;
            Car2btn.Enabled = true;
            Car3btn.Enabled = true;
            Car4btn.Enabled = true;
            Nextbtn.Enabled = false;
            randomszamok.Clear();
            GameGenerate();
        }

        private void Newgamebtn_Click(object sender, EventArgs e)
        {
            Car1btn.Enabled = true;
            Car2btn.Enabled = true;
            Car3btn.Enabled = true;
            Car4btn.Enabled = true;
            Nextbtn.Enabled = true;
            Nextbtn.Enabled = false;
            randomszamok.Clear();
            pontok = 0;
            pontoklabel.Refresh();
            pontoklabel.Text = pontok.ToString();            
            GameGenerate();
        }
    }
}
