using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fruchtgenuss
{
        class Tastatur : GroupBox
        {
            Taste[] tasten;
            public Tastatur()
            {
                BackColor = Color.White;
                tasten = new Taste[13];
                for (int i = 0; i < 13; i++)
                {
                    tasten[i] = new Taste();
                    tasten[i].Parent = this;

                }
                tasten[0].Top = 30;
                tasten[0].Left = 30;
                tasten[1].Top = 30;
                tasten[1].Left = 80;
                tasten[2].Top = 30;
                tasten[2].Left = 130;
                tasten[3].Top = 80;
                tasten[3].Left = 30;
                tasten[4].Top = 80;
                tasten[4].Left = 80;
                tasten[5].Top = 80;
                tasten[5].Left = 130;
                tasten[6].Top = 130;
                tasten[6].Left = 30;
                tasten[7].Top = 130;
                tasten[7].Left = 80;
                tasten[8].Top = 130;
                tasten[8].Left = 130;
                tasten[9].Top = 180;
                tasten[9].Left = 80;

                tasten[10].Top = 30;
                tasten[10].Left = 200;
                tasten[11].Top = 80;
                tasten[11].Left = 200;
                tasten[12].Top = 130;
                tasten[12].Left = 200;
                tasten[0].Text = "1";
                tasten[1].Text = "2";
                tasten[2].Text = "3";
                tasten[3].Text = "4";
                tasten[4].Text = "5";
                tasten[5].Text = "6";
                tasten[6].Text = "7";
                tasten[7].Text = "8";
                tasten[8].Text = "9";
                tasten[9].Text = "0";
                tasten[10].Text = "Abbruch";
                tasten[11].Text = "Löschen";
                tasten[12].Text = "Bestätigen";

            }
        }
}
