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
    public partial class insertmovie : Form
    {
        public insertmovie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mName.Text == "" || mStudio.Text == "")
            {

                MessageBox.Show("Empty field", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                   DialogResult d;
                   d=MessageBox.Show("Record Entered successfully\nwould you like to Insert one more record?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                   if (d == DialogResult.Yes)
                   {
                       Close();
                       Form obj = new insertmovie();
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
                    MessageBox.Show("" + e.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form obj1 = new insertwriter();
            obj1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form obj1 = new insertactor();
            obj1.Show();
        }
    }
}
