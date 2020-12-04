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
    public partial class LearningCardsForm : Form
    {
        public List<Cars> carslist = new List<Cars>();
        public List<Cars> ellenor = new List<Cars>();
        Random rnd = new Random();



        public LearningCardsForm()
        {
            InitializeComponent();
            XmlRead();
            
            
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

        private void NewCardBtn_Click(object sender, EventArgs e)
        {
            int x=carslist.Count;
            int szam = rnd.Next(0, x);
            MovingCards card = new MovingCards();            
            card.Text = carslist[szam].Name + " " + carslist[szam].Model + ": " + carslist[szam].Price.ToString();          
          
            Controls.Add(card);
            ellenor.Add(carslist[szam]);
        }
    }
}
