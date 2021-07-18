﻿using System;
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

        Box[,] Boxen = new Box[7, 5];
        Tastatur tastatur;
        Form1 form;
        Bildschirm bildschirm;
        public GeldBeutel geldbeutel;
        private AdminPanel adminpanel;
        public Korb korb;

        private Produkte[] produkte = {
            null,
            new Produkte(1, 3.99,"Banane",@"C:\Users\ufuka\OneDrive\Desktop\11181763-Eine-Banane.jpg"),
            new Produkte(2, 3.99, "Apfel", "Properties.Resources.apfel"),
            new Produkte(3, 3.99, "Birne", @"C:\Users\ufuka\OneDrive\Desktop\11181763-Eine-Banane.jpg"),
            new Produkte(4, 3.99, "Traube", @"C:\Users\ufuka\OneDrive\Desktop\11181763-Eine-Banane.jpg"),
        };
        public Fruchtgenuss(Form1 f)
        {

            Height = 2000;
            Width = 2000;

            
            form = f;
            Parent = f;


            int left = 30;
            int top = 35;
            int i = 1;
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    Boxen[x, y] = new Box(left, top);
                    Boxen[x, y].Parent = this;
                    Boxen[x, y].BackColor = Color.Red;
                    Boxen[x, y].Text = Convert.ToString(i);
                    Boxen[x, y].Click += Box_Click;
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

            geldbeutel = new GeldBeutel();
            geldbeutel.Parent = this;
            geldbeutel.Left = 100;
            geldbeutel.Top = 600;
            geldbeutel.Width = 410;
            geldbeutel.Height = 100;
            geldbeutel.Text = "GeldBeutel";

            adminpanel = new AdminPanel();
            adminpanel.Parent = this;
            adminpanel.Left = 100;
            adminpanel.Top = 800;
            adminpanel.Width = 110;
            adminpanel.Height = 80;
            adminpanel.Text = "AdminPanel";

            korb = new Korb();
            korb.Parent = this;
            korb.Width = 300;
            korb.Height = 300;
            korb.Left = 1350;
            korb.Top = 600;
            korb.Text = "Korb";

            setProduct(2, 4, produkte[1]);
            setProduct(6, 4, produkte[2]);
            setProduct(0, 2, produkte[3]);
            setProduct(1, 1, produkte[4]);
        }

        private void setProduct(int x, int y, Produkte prod)
        {
            Boxen[x, y].setproduct(prod);
        }

        public Box getboxen(int x, int y)
        {
            return Boxen[x, y];
        }

        public Bildschirm getDisplay()
        {
            return bildschirm;
        }

        private void Box_Click(object sender, EventArgs e)
        {
            Box btn = (Box)sender;
            if (adminpanel.isLogged())
            {
                var prod = btn.getproduct();

                if (prod == null)
                {
                    btn.setproduct(produkte[1]);
                    return;
                }
                var id = (prod.getid() + 1) % produkte.Length;

                btn.setproduct(produkte[id]); 
            };
        }
    }
}
