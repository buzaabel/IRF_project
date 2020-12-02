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
       public List<Cars> carslist = new List<Cars>();
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            XmlRead();
            var x=  carslist.Count();
            var randomszam=  rnd.Next(0, x);                      
            dataGridView1.DataSource = carslist;
            PlayingButton play = new PlayingButton();
            
            Controls.Add(play);
            
           
            
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

 
    }
}
