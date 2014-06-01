using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace solarapp
{
    public partial class createsolar1 : Form
    {
        public createsolar1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=solar;Integrated Security=True");
        SqlDataAdapter sd;
        DataTable dt;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            output p = new output();
            p.Show();
            string s = "select power from PowerLED where size='" + comboBox1.Text + "' ";
            sd = new SqlDataAdapter(s, con);
            dt = new DataTable();
            sd.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                p.label9.Text = dt.Rows[0][i].ToString();
            }

            string s1 = "select LEDNumber from PowerLED where size='" + comboBox1.Text + "'";
            sd = new SqlDataAdapter(s1, con);
            dt = new DataTable();
            sd.Fill(dt);
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                p.label10.Text = dt.Rows[0][j].ToString();
            }

            int k;

            // registor
            string s3 = "select Register from PowerLED where size='" + comboBox1.Text + "'";
            sd = new SqlDataAdapter(s3, con);
            dt = new DataTable();
            sd.Fill(dt);
            for (k = 0; k < dt.Rows.Count; k++)
            {
                p.label12.Text = dt.Rows[0][k].ToString();
            }

            if (radioButton1.Checked == true)
            {
                p.label13.Text = "Lithiumion";
                p.label15.Visible = false;
                p.label8.Visible = false;
            }
            if (radioButton2.Checked == true)
                p.label13.Text = "Lead Acid";

            string s4 = "select * from BatteryCalc where Hours='" + comboBox2.Text + "'";
            sd = new SqlDataAdapter(s4, con);
            dt = new DataTable();
            sd.Fill(dt);
            for (k = 0; k < dt.Rows.Count; k++)
            {
                p.label14.Text = dt.Rows[0][k].ToString();
            }

            // LDE Connection type
            string s5 = "select LEDConnectionType from PowerLED where size='" + comboBox1.Text + "'";
            sd = new SqlDataAdapter(s5, con);
            dt = new DataTable();
            sd.Fill(dt);
            for (k = 0; k < dt.Rows.Count; k++)
            {
                p.label11.Text = dt.Rows[0][k].ToString();
            }

            // wires
            string s6 = "select thickness from wires where length='" + comboBox3.Text + "'";
            sd = new SqlDataAdapter(s6, con);
            dt = new DataTable();
            sd.Fill(dt);
            for (k = 0; k < dt.Rows.Count; k++)
            {
                p.label15.Text = dt.Rows[0][k].ToString();
            }

            // for watts
            string s7 = "select (convert(decimal(18,2),tablelampcurrent)*convert(decimal(18,2),tablelampvoltage))from BatteryCalc";
            sd = new SqlDataAdapter(s7, con);
            dt = new DataTable();
            sd.Fill(dt);
            for (k = 0; k < dt.Rows.Count; k++)
            {
                p.label21.Text = dt.Rows[k][0].ToString();
            }

            // for volts
            switch (comboBox1.SelectedItem.ToString().ToUpper())
            {
                case "TABLE LAMP":
                    p.label20.Text = Convert.ToString(6);
                    break;
                case "SMALL ROOM":
                    p.label20.Text = Convert.ToString(9);
                    break;
                case "MEDIUM ROOM":
                    p.label20.Text = Convert.ToString(9);
                    break;
                case "LARGE ROOM":
                    p.label20.Text = Convert.ToString(9);
                    break;

            }
        }

        private void createsolar1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            comboBox3.Visible = false;
            con.Open();
            string s = "select size from PowerLED";
            sd = new SqlDataAdapter(s, con);
            dt = new DataTable();
            sd.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][0].ToString());
            }


            string s1 = "select Hours from BatteryCalc";
            SqlDataAdapter sd1 = new SqlDataAdapter(s1, con);
            DataTable dt1 = new DataTable();
            sd1.Fill(dt1);
            for (int j = 0; j < dt1.Rows.Count; j++)
            {
                comboBox2.Items.Add(dt1.Rows[j][0].ToString());
            }

            string s5 = "select length from wires";
            sd = new SqlDataAdapter(s5, con);
            dt = new DataTable();
            sd.Fill(dt);
            for (int k = 0; k < dt.Rows.Count; k++)
            {
                comboBox3.Items.Add(dt.Rows[k][0].ToString());
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            comboBox3.Visible = true;

        }

    }
}
