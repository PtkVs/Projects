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
    public partial class FormDetailsChangeUserDetailsUpdate : Form
    {
        public FormDetailsChangeUserDetailsUpdate()
        {
            InitializeComponent();
        }

     
        //1
        string connectionStr = "Data Source=DELL\\SQLEXPRESS; Integrated security=True; Initial Catalog=BookMgmtSystem;";
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_Login where Password=@a and User_ID=@b ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtPasswordChangeDetails.Text);
           cmd.Parameters.AddWithValue("@b", lblUserIdChangeUserDetailsUpdate.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "a");
            DataTable dt = ds.Tables["a"];

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The New Password cannot be same as the Old Password");
                txtPasswordChangeDetails.Text = "";
                txtRetypePasswordChangeDetails.Text = "";
                txtPasswordChangeDetails.Focus();
            }

            else if(txtPasswordChangeDetails.Text == txtRetypePasswordChangeDetails.Text)
            {



                SqlConnection con2 = new SqlConnection(connectionStr);
                string sql2 = "Update Table_Login set Password=@a where User_ID=@b";
                SqlCommand cmd2 = new SqlCommand(sql2, con2);
                cmd2.Parameters.AddWithValue("@a", txtPasswordChangeDetails.Text);
                cmd2.Parameters.AddWithValue("@b", lblUserIdChangeUserDetailsUpdate.Text);

                con2.Open();
                cmd2.ExecuteNonQuery();
                con2.Close();

               
                
                    MessageBox.Show("Updated Successfully");
                    this.Close();
                    
                    

                }

                else
                {
                    MessageBox.Show("The above Passwords did not matched");
                    txtPasswordChangeDetails.Text = "";
                    txtRetypePasswordChangeDetails.Text = "";
                    txtPasswordChangeDetails.Focus();
                }
            }

        //2
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //3
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(connectionStr);
                string sql = "delete from Table_Login where User_ID=@a";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@a", lblUserIdChangeUserDetailsUpdate.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully");
                this.Close();
               
            }

        }




        }

      
    }

            
        

