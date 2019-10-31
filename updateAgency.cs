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
    public partial class updateAgency : Form
    {
        public updateAgency()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form obj;
            if (anamecombo.Text == "" || aDob.Text == "" || agency.Text == "")
            {
                MessageBox.Show("Empty field", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                try
                {

                }
                catch
                {
                    MessageBox.Show("Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                DialogResult d;
                d = MessageBox.Show("Record updated successfuly\nWould you like to insert one more?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    Close();
                    obj = new updateAgency();
                    obj.Show();
                }
                else
                {
                    Close();
                    obj = new updatemain();
                    obj.Show();
                }
            }
        }

        private void anamecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (anamecombo.Text != "")
            {
                aDob.Enabled = true;
            }
            else
            {
                aDob.Enabled = false;
            }
        }
    }
}
