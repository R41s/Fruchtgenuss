using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Fruchtgenuss
{
   

    class Fruchtgenuss : GroupBox
    {

        Box[,] Boxen = new Box[5, 7];
        Tastatur tastatur;
        Form1 form;
        Bildschirm bildschirm;
        
        public Fruchtgenuss(Form1 f)
        {

            Height = 2000;
            Width = 2000;

            
            form = f;
            Parent = f;


            int left = 30;
            int top = 35;
            int i = 1;
            for (int reihe = 0; reihe < 5; reihe++)
            {
                for (int box = 0; box < 7; box++)
                {
                    Boxen[reihe, box] = new Box(left, top);
                    Boxen[reihe, box].Parent = this;
                    Boxen[reihe, box].BackColor = Color.Red;
                    Boxen[reihe, box].Text = Convert.ToString(i);
                    left += 110;
                    i++;
                }

                top += 110;
                left = 30;
            }

            tastatur = new Tastatur();
            tastatur.Parent = this;
            tastatur.Width = 300;
            tastatur.Height = 300;
            tastatur.Left = 1000;
            tastatur.Top = 600;
            tastatur.Text = "Tastatur";


            bildschirm = new Bildschirm();
            bildschirm.Parent = this;
            bildschirm.Left = 1000;
            bildschirm.Top = 80;
            bildschirm.Width = 500;
            bildschirm.Height = 500;
            bildschirm.Text = "Bildschirm";

            Produkte[] produkte=new Produkte[5];
            produkte[0] = new Produkte(0,3.99,"Banane",@"C:\Users\ufuka\OneDrive\Desktop\11181763-Eine-Banane.jpg");
            produkte[1] = new Produkte(1, 3.99, "Apfel", @"C:\Users\ufuka\OneDrive\Desktop\100px-Artwork_Großer_Apfel_PMDDX.png");
            produkte[2] = new Produkte(2, 3.99, "Birne", @"C:\Users\ufuka\OneDrive\Desktop\11181763-Eine-Banane.jpg");
            produkte[3] = new Produkte(3, 3.99, "Traube", @"C:\Users\ufuka\OneDrive\Desktop\11181763-Eine-Banane.jpg");

            Boxen[1, 0].setproduct(produkte[1]);
            Boxen[2, 0].setproduct(produkte[1]);


        }

        public Box getboxen(int i, int y)
        {


            Box currentbox = Boxen[i, y];
            return currentbox;
        }

        public Bildschirm getDisplay()
        {
            return bildschirm;
        }
    }
}
