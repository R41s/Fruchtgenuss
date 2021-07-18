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
        Label lbl, preisAnzeige, guthaben;
        public ListBox lbx;

        double preis = 0.0f;
        private List<Box> Warenkorb = new List<Box>();
        private List<bool> checkList = new List<bool>();

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

            preisAnzeige = new Label();
            preisAnzeige.Parent = this;
            preisAnzeige.Width = 200;
            preisAnzeige.Left = 10;
            preisAnzeige.Top = 30;
            preisAnzeige.Text = String.Format("Preis: {0}", preis);

            guthaben = new Label();
            guthaben.Parent = this;
            guthaben.Width = 90;
            guthaben.Left = 400;
            guthaben.Top = 30;
            guthaben.Text = String.Format("Guthaben: {0}", 0.0);
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
        
        public void UpdatePreis()
        {
            if(((Fruchtgenuss)this.Parent).karte.isFilled())
                preisAnzeige.Text = String.Format("Preis: {0:n} -20% ({1:n})", preis, preis * 0.8);
            else
                preisAnzeige.Text = String.Format("Preis: {0:n}", preis);
        }
        public double getPreis()
        {
            return preis;
        }

        public void UpdateWarenkorb()
        {
            lbx.Items.Clear();
            preis = 0.0f;

            foreach (var ware in Warenkorb)
            {
                Produkte p = ware.getproduct();
                double warPreis = p.getpreis();
                string str = String.Format("{0}: {1:n}", p.getname(), warPreis);
                preis += warPreis;
                lbx.Items.Add(str);
            }

            UpdatePreis();
        }

        private void fillCheckList(int space)
        {
            if (space > checkList.Count())
                for (int i = checkList.Count(); i <= space; i++)
                    checkList.Add(false);
        }

        public void AddWarenkorb(Box prod, int index)
        {
            fillCheckList(index);

            if (checkList[index])
                return;

            Warenkorb.Add(prod);
            checkList[index] = true;
            UpdateWarenkorb();
        }

        public void ClearWarenkorb()
        {
            Warenkorb.Clear();
            checkList.Clear();
            UpdateWarenkorb();
        }

        public void RemWarenkorb(int index)
        {
            fillCheckList(index);
            Warenkorb.RemoveAt(index);
            checkList[index] = false;
            UpdateWarenkorb();
        }

        public List<Box> GetWarenkorb()
        {
            return Warenkorb;
        }

        public string getTextbox()
        {
            return tbx.Text;
        }

        public void ClearEingabe()
        {
            tbx.Clear();
        }

        public void UpdateGuthaben()
        {
            guthaben.Text = String.Format("Guthaben: {0:n}", ((Fruchtgenuss)this.Parent).geldbeutel.getGuthaben());
        }
    }
}
