using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruchtgenuss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Box[,] Boxen = new Box[5, 7];
        //Test
        //Hallo
        private void Form1_Load(object sender, EventArgs e)
        {
            int left = 30;
            int top = 35;
            for (int reihe = 0; reihe < 5; reihe++)
            {
                for (int box = 0; box < 7; box++)
                {

                    Boxen[reihe, box] = new Box(left, top);
                    Boxen[reihe, box].Parent = this;
                    Boxen[reihe, box].BackColor = Color.Red;
                    left += 60;
                }

                top += 60;
                left = 30;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
