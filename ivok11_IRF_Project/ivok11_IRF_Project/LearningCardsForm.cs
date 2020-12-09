using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            int szam;
            MovingCards card;
            CardGenerate(out szam, out card);
            int hossz = ellenor.Count;
            int létezik = 0;
            for (int i = 0; i < hossz; i++)
            {
                if (ellenor[i] == carslist[szam])
                {
                    létezik++;
                }
            }

            if (létezik == 1)
            {
                CardGenerate(out szam, out card);
            }
            else
            {
                Controls.Add(card);
                ellenor.Add(carslist[szam]);
            }
           
        }

        private void CardGenerate(out int szam, out MovingCards card)
        {
            int x = carslist.Count;
            szam = rnd.Next(0, x);
            card = new MovingCards();
            card.Value = carslist[szam].Price;
            card.Text = carslist[szam].Name + " " + carslist[szam].Model + ": " + carslist[szam].Price.ToString();
        }

        private void filewritingbtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath; 
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";  
            sfd.DefaultExt = "csv"; 
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                
                foreach (var el in ellenor)
                {                    
                    sw.Write(el.Name);
                    sw.Write(";");
                    sw.Write(el.Model);
                    sw.Write(";");
                    sw.Write(el.Color);
                    sw.Write(";");
                    sw.Write(el.Price.ToString());                  
                    sw.WriteLine(); 
                }
            }
        }
    }
}
