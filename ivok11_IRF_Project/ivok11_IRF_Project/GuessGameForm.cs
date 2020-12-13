﻿using System;
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
            GameGenerate();
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
            car1btn.Text = carslist[q].Price.ToString();
            int w = randomszamok[1];
            car2btn.Text = carslist[w].Price.ToString();
            int r = randomszamok[2];
            car3btn.Text = carslist[r].Price.ToString();
            int t = randomszamok[3];
            car4btn.Text = carslist[t].Price.ToString();

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

        private void car1btn_Click(object sender, EventArgs e)
        {
           
            

            if (car1btn.Text==carslist[megoldas2].Price.ToString())
            {
                MessageBox.Show("Helyes válasz");
                car1btn.Enabled = false;
                car2btn.Enabled = false;
                car3btn.Enabled = false;
                car4btn.Enabled = false;
                nextbtn.Enabled = true;
                pontok++;
                pontoklabel.Refresh();
                pontoklabel.Text = pontok.ToString();
            }
            else
            {
                MessageBox.Show("Rossz válasz, a játék véget ért");
                car1btn.Enabled = false;
                car2btn.Enabled = false;
                car3btn.Enabled = false;
                car4btn.Enabled = false;
                nextbtn.Enabled = false;
            }
        }

        private void car2btn_Click(object sender, EventArgs e)
        {
            
          

            if (car2btn.Text == carslist[megoldas2].Price.ToString())
            {
                MessageBox.Show("Helyes válasz");
                car1btn.Enabled = false;
                car2btn.Enabled = false;
                car3btn.Enabled = false;
                car4btn.Enabled = false;
                nextbtn.Enabled = true;
                pontok++;
                pontoklabel.Refresh();
                pontoklabel.Text = pontok.ToString();
            }
            else
            {
                MessageBox.Show("Rossz válasz, a játék véget ért");
                car1btn.Enabled = false;
                car2btn.Enabled = false;
                car3btn.Enabled = false;
                car4btn.Enabled = false;
                nextbtn.Enabled = false;
            }
        }

        private void car3btn_Click(object sender, EventArgs e)
        {
       
           

            if (car3btn.Text == carslist[megoldas2].Price.ToString())
            {
                MessageBox.Show("Helyes válasz");
                car1btn.Enabled = false;
                car2btn.Enabled = false;
                car3btn.Enabled = false;
                car4btn.Enabled = false;
                nextbtn.Enabled = true;
                pontok++;
                pontoklabel.Refresh();
                pontoklabel.Text = pontok.ToString();
            }
            else
            {
                MessageBox.Show("Rossz válasz, a játék véget ért");
                car1btn.Enabled = false;
                car2btn.Enabled = false;
                car3btn.Enabled = false;
                car4btn.Enabled = false;
                nextbtn.Enabled = false;
            }
        }

        private void car4btn_Click(object sender, EventArgs e)
        {
            
           

            if (car4btn.Text == carslist[megoldas2].Price.ToString())
            {
                MessageBox.Show("Helyes válasz");
                car1btn.Enabled = false;
                car2btn.Enabled = false;
                car3btn.Enabled = false;
                car4btn.Enabled = false;
                nextbtn.Enabled = true;
                pontok++;
                pontoklabel.Refresh();
                pontoklabel.Text = pontok.ToString();

            }
            else
            {
                MessageBox.Show("Rossz válasz, a játék véget ért");
                car1btn.Enabled = false;
                car2btn.Enabled = false;
                car3btn.Enabled = false;
                car4btn.Enabled = false;
                nextbtn.Enabled = false;
            }
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            car1btn.Enabled = true;
            car2btn.Enabled = true;
            car3btn.Enabled = true;
            car4btn.Enabled = true;
            nextbtn.Enabled = false;
            randomszamok.Clear();
            GameGenerate();
        }

        private void newgamebtn_Click(object sender, EventArgs e)
        {
            car1btn.Enabled = true;
            car2btn.Enabled = true;
            car3btn.Enabled = true;
            car4btn.Enabled = true;
            nextbtn.Enabled = true;
            randomszamok.Clear();
            pontok = 0;
            pontoklabel.Refresh();
            pontoklabel.Text = pontok.ToString();
            GameGenerate();
        }
    }
}
