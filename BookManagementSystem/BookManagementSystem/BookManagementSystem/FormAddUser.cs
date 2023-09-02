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
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

     
     

     


        //1
        string connectionStr = "Data Source=DELL\\SQLEXPRESS; Integrated Security=True; Initial Catalog=BookMgmtSystem;";
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter an username.");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter a password.");
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionStr);
                string sql = "select * from Table_Login where Username = @username";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds, "a");
                DataTable dt = ds.Tables["a"];
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This username already in use.");
                    txtUsername.Focus();
                }
                else
                {
                    SqlConnection con2 = new SqlConnection(connectionStr);
                    string sql2 = "insert into Table_Login(Username,Password,Role) values(@a,@b,@c)";
                    SqlCommand cmd2 = new SqlCommand(sql2, con2);
                    cmd2.Parameters.AddWithValue("@a", txtUsername.Text);
                    cmd2.Parameters.AddWithValue("@b", txtPassword.Text);
                    cmd2.Parameters.AddWithValue("@c", cbxUserType.Text);

                    con2.Open();
                    int i = cmd2.ExecuteNonQuery();
                    con2.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("User Created Successfully");
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                        cbxUserType.Text = "";
                        txtUsername.Focus();
                    }
                    else
                    {
                        MessageBox.Show("User Creation Unsuccessful");
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                        cbxUserType.Text = "";
                        txtUsername.Focus();
                    }
                }
            }
        }

        //2
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
