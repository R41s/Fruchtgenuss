using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fruchtgenuss
{
    class TreueKarte : GroupBox
    {
        private int points = 0;
        private List<PictureBox> picturePoints;

        public TreueKarte()
        {
            picturePoints = new List<PictureBox>;
            CreatePoints();
        }

        public void Update()
        {
            for (int i = 0; i < picturePoints.Length; i++)
                picturePoints[i].Visible = points >= i; 
        }

        public void AddPoint()
        {
            points++;
            Update();
        }

        public void RemPoint()
        {
            points--;
            Update();
        }

        public void ClearPoints()
        {
            points = 0;
            Update();
        }

        public bool isFilled()
        {
            return points >= 10;
        }

        private void CreatePoints()
        {
            for (int y = 0; y < 1; y++) {
                for (int x = 0; x < 5; x++) {
                    point = new PictureBox();
                    point.Parent = this;
                    point.Width = 50;
                    point.Height = 50;
                    point.Left = 10 + 60 * x;
                    point.Top = 10 + 60 * y;
                    point.Image = Properties.Resources.SmilePoint; // TODO: Add a Texture!
                    point.SizeMode = PictureBoxSizeMode.StretchImage;
                    point.Visible = false;
                    picturePoints.Add(point);
                }
            }
        }
    }
}
