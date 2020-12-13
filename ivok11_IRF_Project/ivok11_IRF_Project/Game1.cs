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
    public partial class Game1 : Form
    {
        public List<Cars> carslist = new List<Cars>();

        public Random rnd = new Random();
        int pontok;


        public Game1()
        {
            InitializeComponent();
            XmlRead();
            GameCreating();
            this.BackColor = Color.Green;
        }

        public void GameCreating()
        {
            var x = carslist.Count();
            var randomszam1 = rnd.Next(0, x);
            var randomszam2 = rnd.Next(0, x);

            if (randomszam1 == randomszam2)
            {
                while (randomszam1 == randomszam2)
                {
                    randomszam1 = rnd.Next(0, x);
                }
            }

            car1.Text = carslist[randomszam1].Name + " " + carslist[randomszam1].Model;
            car1.Value = carslist[randomszam1].Price;
            car1.ForeColor = Color.FromName(carslist[randomszam1].Color);

            car2.Text = carslist[randomszam2].Name + " " + carslist[randomszam2].Model;
            car2.Value = carslist[randomszam2].Price;
            car2.ForeColor = Color.FromName(carslist[randomszam2].Color);
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

        private void btnnext_Click(object sender, EventArgs e)
        {
            GameCreating();
            car1.Enabled = true;
            car2.Enabled = true;
            tbresult.Text = "";
            labelpontok.Refresh();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            GameCreating();
            car1.Enabled = true;
            car2.Enabled = true;
            btnnext.Enabled = true;
            tbresult.Text = "";
            pontok = 0;
            labelpontok.Text = pontok.ToString();
        }

        private void car2_Click(object sender, EventArgs e)
        {
            if (car1.Value < car2.Value)
            {
                tbresult.Text = "Helyes válasz";
                pontok++;
                labelpontok.Text = pontok.ToString();

            }
            else
            {
                tbresult.Text = "Rossz válasz";
                btnnext.Enabled = false;
            }
            car1.Enabled = false;
            car2.Enabled = false;
        }

        private void car1_Click(object sender, EventArgs e)
        {
            if (car1.Value > car2.Value)
            {
                tbresult.Text = "Helyes válasz";
                pontok++;
                labelpontok.Text = pontok.ToString();

            }
            else
            {
                tbresult.Text = "Rossz válasz";
                btnnext.Enabled = false;
            }
            car1.Enabled = false;
            car2.Enabled = false;
        }
    }
}

