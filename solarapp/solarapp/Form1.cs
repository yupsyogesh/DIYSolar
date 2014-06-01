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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label2.Text = datetime.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            SupplierDetails sd = new SupplierDetails();
            sd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Information f = new Information();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            createsolar1 c = new createsolar1();
            c.Show();
        }
    }
}
