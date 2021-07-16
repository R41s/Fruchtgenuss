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


        Tastatur tastatur;
        Form1 form;
        Bildschirm bildschirm;

        public Fruchtgenuss(Form1 f)
        {

            Height = 2000;
            Width = 2000;

            Box[,] Boxen = new Box[5, 7];
            form = f;
            Parent = f;


            int left = 30;
            int top = 35;
            for (int reihe = 0; reihe < 5; reihe++)
            {
                for (int box = 0; box < 7; box++)
                {

                    Boxen[reihe, box] = new Box(left, top);
                    Boxen[reihe, box].Parent = this;
                    Boxen[reihe, box].BackColor = Color.Red;
                    left += 110;
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


        }

        public Bildschirm getDisplay()
        {
            return bildschirm;
        }
    }
}
