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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

      
         private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        //1
        //For both Login form and Added user form,Table_Login of data base is used
        string connectionStr = "data source=DELL\\SQLEXPRESS; Integrated Security=true; Initial Catalog=BookMgmtSystem;";
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == "" && password == "")
            {
                MessageBox.Show("No Username or Password");
            }
            else if (username == "")
            {
                MessageBox.Show("Please enter a Username");
            }
            else if (password == "")
            {
                MessageBox.Show("Please enter a Password");

            }
            else
            {
                SqlConnection con = new SqlConnection(connectionStr);
                string sql = "select * from Table_Login where Username=@a and Password=@b";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@a", txtUsername.Text);
                cmd.Parameters.AddWithValue("@b", txtPassword.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "t");
                DataTable dt = ds.Tables["t"];
                if (dt.Rows.Count > 0 && dt.Rows[0][3].ToString() == "admin")
                {
                    MDIAdmin frm = new MDIAdmin();
                    Program.User_ID = Convert.ToInt32(dt.Rows[0][0].ToString());
                    Program.Username = dt.Rows[0][1].ToString();
                    Program.Usertype = "admin";
                    frm.Show();
                    this.Hide();
                }
                else if (dt.Rows.Count > 0 && dt.Rows[0][3].ToString() == "user")
                {
                    MDIUser frmUser = new MDIUser();
                    Program.User_ID = Convert.ToInt32(dt.Rows[0][0].ToString());
                    Program.Username = dt.Rows[0][1].ToString();
                    Program.Usertype = "user";
                    frmUser.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                   txtUsername.Focus();
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
