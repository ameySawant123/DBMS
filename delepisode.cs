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
    public partial class delepisode : Form
    {
        public delepisode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sCombo.Text == "" || epcombo.Text == "")
            {
                MessageBox.Show("Empty field", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    DialogResult d;
                    d = MessageBox.Show("Record deleted successfully\nwould you like to delete one more record?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d == DialogResult.Yes)
                    {
                        Close();
                        Form obj1 = new delepisode();
                        obj1.Show();
                    }
                    else
                    {
                        Close();
                        Form obj1 = new deletemain();
                        obj1.Show();
                    }
                }
                catch
                {
                }
            }
        }
    }
}
