using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fruchtgenuss
{
    class GeldBeutelButton : Button
    {
        public double value = 0.0;

        public GeldBeutelButton()
        {
            this.Click += this.click;
        }

        private void click(object sender, EventArgs e)
        {
            ((GeldBeutel)Parent).addGuthaben(value);
        }
    }

    class GeldBeutel : PictureBox
    {
        private double guthaben = 0.0;
        Label preisAnzeige;


        public GeldBeutel()
        {
            double[] coins = { 0.5, 1.0, 2.0, 5.0, 10.0 };
            int offset = 10;
            for (int i = 0; i < coins.Length; i++)
            {
                var taste = new GeldBeutelButton();
                taste.Parent = this;
                taste.value = coins[i];
                var size = coins[i] >= 5 ? 100 : 50;
                taste.Width = size;
                taste.Height = 50;
                taste.Left = offset;
                offset += size + 10;
                Console.WriteLine(offset);
                taste.Top = 40;

                switch (coins[i])
                {
                    case 0.5:
                        taste.BackgroundImage = Properties.Resources._0_5er;
                        
                        break;

                    case 1.0:
                        taste.BackgroundImage = Properties.Resources._1er;
                        break;
                    case 2.0:
                        taste.BackgroundImage = Properties.Resources._2er;
                        break;
                    case 5.0:
                        taste.BackgroundImage = Properties.Resources._5er;
                        break;

                    case 10.0:
                        taste.BackgroundImage = Properties.Resources._10er;
                        break;
                }
                taste.BackColor = Color.Transparent;
                taste.BackgroundImageLayout = ImageLayout.Stretch;
            }

            preisAnzeige = new Label();
            preisAnzeige.Parent = this;
            preisAnzeige.Width = 90;
            preisAnzeige.Left = 10;
            preisAnzeige.Top = 20;
            preisAnzeige.Text = String.Format("Guthaben: {0}", guthaben);

            this.Image = Properties.Resources.beuuutel;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void updateGuthaben()
        {
            preisAnzeige.Text = String.Format("Guthaben: {0:n}", guthaben);
        }

        public void addGuthaben(double val)
        {
            guthaben += val;
            updateGuthaben();
        }

        public double getGuthaben(double val)
        {
            return guthaben;
        }

        public bool minusGuthaben(double val)
        {
            if (val > guthaben)
                return false;

            guthaben -= val;
            updateGuthaben();
            return true;
        }
    }
}
