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
            this.Image = System.Drawing.Image.FromFile(@"C:\Users\ufuka\OneDrive\Desktop\korb.jpg");
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void Add(Produkte p)
        {
            var w = new PictureBox();
            w.Parent = this;
            w.Image = System.Drawing.Image.FromFile(p.getPath());
            w.SizeMode = PictureBoxSizeMode.StretchImage;
            w.Left = rand.Next(padding, Height - size - padding);
            w.Top = rand.Next(padding, Width - size - padding);
            w.Height = size;
            w.Width = size;
        }
    }
}
