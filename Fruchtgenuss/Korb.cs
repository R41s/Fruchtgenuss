using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fruchtgenuss
{
    class Korb : PictureBox
    {
        Random rand = new Random();

        int size = 80;
        int padding = 40;
        public Korb()
        {
            this.Image = Properties.Resources.korb;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void Add(Produkte p)
        {
            var w = new PictureBox();
            w.Parent = this;

            switch (p.getname())
            {

                case "Apfel":
                    w.Image = Properties.Resources.apfel;
                    w.BackColor = Color.Transparent;
                    
                    break;

                case "Banane":
                    w.Image = Properties.Resources.banane;
                    w.BackColor = Color.Transparent;
                    
                    break;

                case "Traube":
                    w.Image = Properties.Resources.Traube;
                    w.BackColor = Color.Transparent;
                    
                    break;

                case "Birne":
                    w.Image = Properties.Resources.Birne;
                    w.BackColor = Color.Transparent;
                    
                    break;
            }

            w.SizeMode = PictureBoxSizeMode.StretchImage;
            w.Left = rand.Next(padding, Height - size - padding);
            w.Top = rand.Next(padding, Width - size - padding);
            w.Height = size;
            w.Width = size;
        }
    }
}
