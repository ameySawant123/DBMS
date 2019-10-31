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
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {   
                if (radioButton1.Checked)
                {
                    Form obj1 = new insertmain();
                    this.Hide();
                    obj1.Show();

                }
                else if (radioButton2.Checked)
                {
                    Form obj2 = new updatemain();
                    this.Hide();
                    obj2.Show();

                }
                else if (radioButton3.Checked)
                {
                    Form obj3 = new deletemain();
                    this.Hide();
                    obj3.Show();

                }
                else if (radioButton4.Checked)
                {
                    Form obj4 = new joinmain();
                    this.Hide();
                    obj4.Show();
                }
                else
                {
                    DialogResult d;
                    d = MessageBox.Show("Select one from above.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (d == DialogResult.OK)
                    {
                        Close();
                        Form obj1 = new form2();
                        obj1.Show();
                    }
                }
        }

          }
        
      }
        

     
    



