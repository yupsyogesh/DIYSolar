using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace solarapp
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inforamtion1 i = new Inforamtion1();
            i.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Information2 e1 = new Information2();
            e1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Advantages a = new Advantages();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Benefits b = new Benefits();
            b.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Working w = new Working();
            w.Show();
        }
    }
}
