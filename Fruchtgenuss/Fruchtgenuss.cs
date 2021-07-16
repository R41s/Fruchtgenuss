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
        public Form1 f;

        public Fruchtgenuss(Form1 f)
        {

            Box[,] Boxen = new Box[5, 7];


            int left = 30;
            int top = 35;
            for (int reihe = 0; reihe < 5; reihe++)
            {
                for (int box = 0; box < 7; box++)
                {

                    Boxen[reihe, box] = new Box(left, top);
                    Boxen[reihe, box].Parent = f;
                    Boxen[reihe, box].BackColor = Color.Red;
                    left += 60;
                }

                top += 60;
                left = 30;
            }

            tastatur = new Tastatur();
            tastatur.Parent = this;
            tastatur.Width = 300;
            tastatur.Height = 300;
            tastatur.Left = 100;
            tastatur.Top = 100;
            tastatur.Text = "Tastatur";





        }
    }
}
