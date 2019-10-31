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
    public partial class insertwriter : Form
    {
        public insertwriter()
        {
            InitializeComponent();
        }

        private void epcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (epcheck.Checked)
                epNo.Enabled = true;
            else
                epNo.Enabled = false;
            
        }

        private void moviecheck_CheckedChanged(object sender, EventArgs e)
        {
            if(moviecheck.Checked)
                mName.Enabled = true;
            else
               mName.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wName.Text == "" || aName.Text == "" || epcheck.Checked == false && moviecheck.Checked == false)
            {

                MessageBox.Show("Empty field", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {try{
                if(epcheck.Checked==true)
                {
                }
                else if (moviecheck.Checked == true)
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
                    Form obj = new insertwriter();
                    obj.Show();
                }
                else
                {
                    Close();
                    Form obj = new insertmain();
                    obj.Show();
                } 

                }
                catch
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }  
  
    }
}
