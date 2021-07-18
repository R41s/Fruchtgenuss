using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Fruchtgenuss
{
    class TreueKarte : GroupBox
    {
        private int points = 0;
        private List<PictureBox> picturePoints;
        private bool frozen = true;

        public TreueKarte()
        {
            picturePoints = new List<PictureBox>();
            CreatePoints();
            var btn = new Button();
            btn.Parent = this;
            btn.Top = 120;
            btn.Left = 10;
            btn.Width = 250;
            btn.Height = 20;
            btn.Text = "Reinschieben";
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            frozen = !frozen;
            b.Text = frozen ? "Reinschieben" : "Rausnehemen";
        }

        public void Update()
        {
            for (int i = 0; i < picturePoints.Count; i++)
                picturePoints[i].Visible = points >= i + 1; 
        }

        public void AddPoint()
        {
            if (frozen)
                return;
            points++;
            Update();
        }

        public void RemPoint()
        {
            if (frozen)
                return;
            points--;
            Update();
        }

        public void ClearPoints()
        {
            if (frozen)
                return;
            points = 0;
            Update();
        }

        public bool isFilled()
        {
            if (frozen)
                return false;
            return points >= 10;
        }

        private void CreatePoints()
        {
            for (int y = 0; y <= 1; y++) {
                for (int x = 0; x < 5; x++) {
                    var point = new PictureBox();
                    point.Parent = this;
                    point.Width = 50;
                    point.Height = 50;
                    point.Left = 10 + 50 * x;
                    point.Top = 10 + 50 * y;
                    point.Image = Properties.Resources.smile;
                    point.SizeMode = PictureBoxSizeMode.StretchImage;
                    point.Visible = false;
                    picturePoints.Add(point);
                }
            }
        }

        public void LoadPoints()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"TreueKarte.txt"))
                {
                    points = sr.Read() - '0';
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                points = 0;
            }
            Update();
        }

        public void SavePoints()
        {
            StreamWriter sw = new StreamWriter(@"TreueKarte.txt", false);
            sw.Write(points);
            sw.Close();
            Update();
        }
    }
}
