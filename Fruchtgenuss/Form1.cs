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

        Fruchtgenuss fruchtgenuss;
        public Form1()
        {
            InitializeComponent();

             fruchtgenuss = new Fruchtgenuss(this);


        }
        
        //Test
        //Hallo
        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void button25_Click(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            fruchtgenuss.saveProducts();
        }
    }
}
