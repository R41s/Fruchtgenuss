using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fruchtgenuss
{
    

    class Bildschirm:GroupBox
    {
        TextBox tbx;
        Label lbl;
        public ListBox lbx;
        public Bildschirm()
        {
            BackColor = Color.White;

            lbl = new Label();
            lbl.Parent = this;
            lbl.Height = 20;
            lbl.Width = 140;
            lbl.Top = Height / 2;
            lbl.Left = 10;
            lbl.Text = "Produktnummer eingeben:";
            

            tbx = new TextBox();
            tbx.Parent = this;
            tbx.Width = 90;
            tbx.Left = 150;
            tbx.Top = Height / 2;

            lbx = new ListBox();
            lbx.Parent = this;
            lbx.Width = 300;
            lbx.Height = 375;
            lbx.Left = 150;
            lbx.Top = 100;

        }

        public void FuegeZifferHinzu(string s)
        {
            tbx.Text = tbx.Text + s;
        }
        public void LoescheLetzteZiffer()
        {
            string neu = "";
            for (int i = 0; i < tbx.Text.Length - 1; i++)
            {
                neu = neu + tbx.Text[i];
            }
            tbx.Text = neu;
        }

        public void AddlistboxItem()
        {
            lbx.Items.Add("hexy");
            tbx.Clear();
        }

        public string getTextbox()
        {
            return tbx.Text;
        }
    }
}
