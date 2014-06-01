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
    public partial class SupplierDetails : Form
    {
        public SupplierDetails()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Browser b = new Browser();
            b.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SunPawar sp = new SunPawar();
            sp.Show();
        }
    }
}
