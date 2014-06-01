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
    public partial class Inforamtion1 : Form
    {
        public Inforamtion1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Information f = new Information();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Benefits b = new Benefits();
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Advantages a = new Advantages();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Information2 f = new Information2();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Working w = new Working();
            w.Show();
        }
    }
}
