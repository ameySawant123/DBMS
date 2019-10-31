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
    public partial class episode : Form
    {
        public episode()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form obj = new insertseries();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (eno.Text == "" || etitle.Text == "" || elength.Text == "" || eSeries.Text == "")
            {
                MessageBox.Show("Empty field", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult d;
                    d = MessageBox.Show("Record Entered successfully\nwould you like to Insert one more record?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d == DialogResult.Yes)
                    {
                        Close();
                        Form obj1 = new episode();
                        obj1.Show();
                    }
                    else
                    {  
                          Close();
                          Form obj1 = new insertmain();
                          obj1.Show();
                    }
                }

                catch
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form obj = new insertactor();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form obj = new insertwriter();
            obj.Show();
        }
    }
}
