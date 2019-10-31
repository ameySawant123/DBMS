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
    public partial class insertactor : Form
    {
        public insertactor()
        {
            InitializeComponent();
        }

        private void mCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (sCheck.Checked)
            {
                sCombo.Enabled = true;
                epCombo.Enabled = true;
            }
            else
            {
                sCombo.Enabled = true;
                epCombo.Enabled = false;
            }
        }

        private void sCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (mCheck.Checked)
                mCombo.Enabled = true;
            else
                mCombo.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (aName.Text == "" || aNation.Text == "" || mCheck.Checked == false && sCheck.Checked == false)
            {
                MessageBox.Show("Empty field", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (mCheck.Checked == true)
                    { 
                    }
                    else if (sCheck.Checked == true)
                    {
                    }
                    else
                    { 
                    }
                    DialogResult d;
                    d = MessageBox.Show("Record Entered successfully\nwould you like to Insert one more record?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d == DialogResult.Yes)
                    {
                        Close();
                        Form obj1 = new insertactor();
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
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void insertactor_Load(object sender, EventArgs e)
        {

        }

    
    }
}
