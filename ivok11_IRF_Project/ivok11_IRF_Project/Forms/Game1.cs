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

            Car1.Text = carslist[randomszam1].Name + " " + carslist[randomszam1].Model;
            Car1.Value = carslist[randomszam1].Price;
            Car1.ForeColor = Color.FromName(carslist[randomszam1].Color);

            Car2.Text = carslist[randomszam2].Name + " " + carslist[randomszam2].Model;
            Car2.Value = carslist[randomszam2].Price;
            Car2.ForeColor = Color.FromName(carslist[randomszam2].Color);
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

        private void Btnnext_Click(object sender, EventArgs e)
        {
            GameCreating();
            Car1.Enabled = true;
            Car2.Enabled = true;
            tbresult.Text = "";
            labelpontok.Refresh();
            Btnnext.Enabled = false;
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            GameCreating();
            Car1.Enabled = true;
            Car2.Enabled = true;
            Btnnext.Enabled = true;
            tbresult.Text = "";
            pontok = 0;
            labelpontok.Text = pontok.ToString();
            Btnnext.Enabled = false;
        }

        private void Car2_Click(object sender, EventArgs e)
        {
            if (Car1.Value < Car2.Value)
            {
                tbresult.Text = "Helyes válasz";
                pontok++;
                labelpontok.Text = pontok.ToString();
                Btnnext.Enabled = true;

            }
            else
            {
                tbresult.Text = "Rossz válasz";
                Btnnext.Enabled = false;
            }
            Car1.Enabled = false;
            Car2.Enabled = false;
        }

        private void Car1_Click(object sender, EventArgs e)
        {
            if (Car1.Value > Car2.Value)
            {
                tbresult.Text = "Helyes válasz";
                pontok++;
                labelpontok.Text = pontok.ToString();
                Btnnext.Enabled = true;

            }
            else
            {
                tbresult.Text = "Rossz válasz";
                Btnnext.Enabled = false;
            }
            Car1.Enabled = false;
            Car2.Enabled = false;
        }
    }
}

