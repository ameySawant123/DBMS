using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBMSproject
{
    public partial class updatemain : Form
    {
        public updatemain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form obj;
            if (radioButton1.Checked == true)
            {
                this.Hide();
                obj = new updateNetwork();
                obj.Show();

            }
            else if (radioButton2.Checked == true)
            {
                this.Hide();
                obj = new updateProduction();
                obj.Show();
            }
            else if (radioButton3.Checked == true)
            {
                this.Hide();
                obj = new updateAgency();
                obj.Show();
            }
            else 
            {
                MessageBox.Show("No option selected..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
                obj = new updatemain();
                obj.Show();
            }
        }
    }
}
