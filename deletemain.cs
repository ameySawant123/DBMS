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
    public partial class deletemain : Form
    {
        public deletemain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form obj;
            if (radioButton1.Checked)
            {
                this.Hide();
                obj = new delseries();
                obj.Show();
            }
            else if (radioButton2.Checked)
            { 
                this.Hide();
                obj = new delMovie();
                obj.Show();
            }
            else if (radioButton3.Checked)
            {
                this.Hide();
                obj = new delWriter();
                obj.Show();

            }
            else if (radioButton4.Checked)
            {
                this.Hide();
                obj = new delActor();
                obj.Show();
            }
            else if (radioButton5.Checked)
            {
                this.Hide();
                obj = new delepisode();
                obj.Show();
            }
            else
            {
                MessageBox.Show("No option selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     
    }
}
