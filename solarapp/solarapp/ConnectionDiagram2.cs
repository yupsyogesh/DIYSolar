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
    public partial class ConnectionDiagram2 : Form
    {
        public ConnectionDiagram2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SupplierDetails sd = new SupplierDetails();
            sd.Show();
        }
    }
}
