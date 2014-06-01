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
    public partial class output : Form
    {
        public output()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionDiagram c = new ConnectionDiagram();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectionDiagram1 c1 = new ConnectionDiagram1();
            c1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConnectionDiagram2 c2 = new ConnectionDiagram2();
            c2.Show();
        }
    }
}