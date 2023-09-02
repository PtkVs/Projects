using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class FormDetailsChangeStudentDetailsLUpdate : Form
    {
        public FormDetailsChangeStudentDetailsLUpdate()
        {
            InitializeComponent();
        }
        //1
        string connectionStr = "data source=DELL\\SQLEXPRESS; integrated security=true; initial catalog=BookMgmtSystem;";
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_StudentDetail where Phone=@a and Student_ID=@b ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtNewPhoneNoChangeStudentDetailsUpdate.Text);
            cmd.Parameters.AddWithValue("@b", lblStudentIdChangeStudentDetailsUpdate.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "a");
            DataTable dt = ds.Tables["a"];
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The New Phone no. cannot be same as the Old Phone no.");
                txtNewPhoneNoChangeStudentDetailsUpdate.Text = "";
                txtNewPhoneNoChangeStudentDetailsUpdate.Focus();
            }
            else
            {
                SqlConnection con2 = new SqlConnection(connectionStr);
                string sql2 = "update Table_StudentDetail set Phone=@a,Email=@b where Student_ID=@c";
                SqlCommand cmd2 = new SqlCommand(sql2, con2);
                cmd2.Parameters.AddWithValue("@a", txtNewPhoneNoChangeStudentDetailsUpdate.Text);
                cmd2.Parameters.AddWithValue("@b", txtNewEmailChangeStudentDetailsUpdate.Text);
                cmd2.Parameters.AddWithValue("@c", lblStudentIdChangeStudentDetailsUpdate.Text);

                con2.Open();
                cmd2.ExecuteNonQuery();
                con2.Close();
                MessageBox.Show("Updated Successfully");
                this.Close();
               
                
                


            }

        }


        //2
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(connectionStr);
                string sql = "delete from Table_StudentDetail where Student_ID=@a";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@a", lblStudentIdChangeStudentDetailsUpdate.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully");
                this.Close();

            }
        }

        //3
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
