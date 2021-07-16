using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fruchtgenuss
{
    class Box : System.Windows.Forms.Button
    {
        Produkte produkt;
        public Box(int left, int top)
        {
            this.Height = 100;
            this.Width = 100;
            this.Left = left;
            this.Top = top;
            this.Image = System.Drawing.Image.FromFile(@"C:\Users\ufuka\OneDrive\Desktop\iu.jpg");
        }

        public void setproduct(Produkte p)
        {
            produkt = p;
            string path = produkt.getPath();
            this.Image = System.Drawing.Image.FromFile(path);
        }
        
    }
}
