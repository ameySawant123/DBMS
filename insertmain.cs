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
    public partial class insertmain : Form
    {
        public insertmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form obj1;
                if (radioButton1.Checked )
                {
                    this.Hide();
                    obj1 = new insertseries();
                    obj1.Show();
                    
                }
                else if (radioButton4.Checked)
                {
                    this.Hide();
                    obj1 = new insertmovie();
                    obj1.Show();
                    
                }
                else
                {
                    DialogResult d;
                    d = MessageBox.Show("Select one from above.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (d == DialogResult.OK)
                    {
                        Close();
                        obj1 = new insertmain();
                        obj1.Show();
                    }
                }
            
        }
    }
}
