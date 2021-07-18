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
            this.Image = Properties.Resources.iu;
        }

        public void setproduct(Produkte p)
        {
            produkt = p;
            //string path = @"C:\Users\ufuka\OneDrive\Desktop\iu.jpg";
            if (p != null)
            
             /*   path = p.getPath();
            this.Image = System.Drawing.Image.FromFile(path);
             */
             
                
                    switch(p.getname())
                    {

                    case "Apfel":
                        this.Image = Properties.Resources.apfel;
                        
                        break;

                    case "Banane":
                        this.Image = Properties.Resources.banane;

                        break;

                    case "Traube":
                        this.Image = Properties.Resources.Traube;
                        
                        break;

                    case "Birne":
                        this.Image = Properties.Resources.Birne;
                        
                        break;


                }
            if(p == null)
            {
                this.Image = Properties.Resources.iu;
            }
        }
        
        public Produkte getproduct()
        {
            return this.produkt;
        }
    }
}
