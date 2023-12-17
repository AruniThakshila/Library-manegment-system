using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login
{
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm","Alert",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
            }
            

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSName.Clear();
            txtEnrolNo.Clear();
            txtDepartment.Clear();
            txtSSemester.Clear();
            txtSSemester.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if((txtSName.Text!="")&&(txtEnrolNo.Text!="")&&(txtDepartment.Text!="")&&(txtSSemester.Text!="")&&(txtContact.Text!="")&&(txtEmail.Text!=""))
            {
                String name = txtSName.Text;
                String enroll = txtEnrolNo.Text;
                String dep = txtDepartment.Text;
                String sem = txtSSemester.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                String email = txtEmail.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-MUKB763;database=master;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewStudent(sname,enroll,dep,sem,contact,email) values('" + name + "','" + enroll + "','" + dep + "','" + sem + "','" + mobile + "','" + email + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Fill Empty fields", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
