using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace DBMSproject
{
    public partial class insertseries : Form
    {
        public insertseries()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Sname.Text == "" || Network.Text == "" || Production.Text == "")
            {

                MessageBox.Show("Empty field", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;User Id=SYSTEM;Password=system;OLEDB.NET=True";

                OleDbConnection obj1 = new OleDbConnection(connection);
                obj1.Open();
                String q1 = "insert into series values ('"+Sname.Text +"','"+Network.Text+"')";
                String q2 = "insert into pcompany values('"+Sname.Text+"','"+Production.Text+"')";

                try
                {
                    OleDbCommand cm1 = new OleDbCommand(q1, obj1);
                    OleDbCommand cm2 = new OleDbCommand(q2, obj1);
                    cm1.ExecuteNonQuery();
                    cm2.ExecuteNonQuery();
                    obj1.Close();
                    DialogResult d;
                    d = MessageBox.Show("Record Entered successfully\nwould you like to Insert episode?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d == DialogResult.Yes)
                    {
                        Close();
                        Form obj = new episode();
                        obj.Show();
                    }
                    if (d == DialogResult.No)
                    {
                        d = d = MessageBox.Show("would you like to Insert one more record?", "Nofification", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (d == DialogResult.Yes)
                        {
                            Close();
                            Form obj = new insertseries();
                            obj.Show();
                        }
                        else
                        {
                            Close();
                            Form obj = new insertmain();
                            obj.Show();
                        }
                    }
                }

                catch
                {
                    MessageBox.Show("Error...","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }





        }
    }
}
