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
using System.Data.SqlClient;

namespace login
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if((textBoxName.Text!="")&&(textBoxAuthor.Text!="")&&(textBoxPublication.Text!="")&&(textBookPrice.Text!="")&&(textBoxQuantity.Text!=""))
            {
                String bname = textBoxName.Text;
                String bauthor = textBoxAuthor.Text;
                String publication = textBoxPublication.Text;
                String pdate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(textBookPrice.Text);
                Int64 quan = Int64.Parse(textBoxQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-MUKB763;database=master;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into A_book(bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values('" + bname + "','" + bauthor + "','" + publication + "','" + pdate + "','" + price + "','" + quan + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Save Succesess", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxName.Clear();
                textBoxAuthor.Clear();
                textBoxPublication.Clear();
                textBoxQuantity.Clear();
                textBookPrice.Clear();
            }
            else
            {
                MessageBox.Show("Empty field not allowed", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE youe unsaved Data", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)== DialogResult.OK);
            { this.Close(); }
        }
    }
}
