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
    public partial class FormIndividualUserDetailsUpdate : Form
    {
        public FormIndividualUserDetailsUpdate()
        {
            InitializeComponent();
        }

        //1
        string connectionStr = "data source=DELL\\SQLEXPRESS; Integrated Security=true; Initial Catalog=BookMgmtSystem;";
        private void FormIndividualUserDetailsUpdate_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_Login ";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "t");
            DataTable dt = ds.Tables["t"];

            lblUserIdIndividualUserDetailsUpdate.Text = Program.User_ID.ToString();
            lblUsernameIdIndividualUserDetailsUpdate.Text = dt.Rows[0][1].ToString();
            lblUserTypeIndividualUserDetailsUpdate.Text = dt.Rows[0][3].ToString();
            txtOldPasswordIndividualUserDetailsUpdate.Text = dt.Rows[0][2].ToString();

        }

        //2
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_Login where Password=@a and User_ID=@b ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtPasswordIndividualUserDetailsUpdate.Text);
            cmd.Parameters.AddWithValue("@b", Program.User_ID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "a");
            DataTable dt = ds.Tables["a"];

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The New Password cannot be same as the Old Password");
                txtPasswordIndividualUserDetailsUpdate.Text = "";
                txtRetypePasswordIndividualUserDetailsUpdate.Text = "";
                txtPasswordIndividualUserDetailsUpdate.Focus();
            }

            else if (txtPasswordIndividualUserDetailsUpdate.Text == txtRetypePasswordIndividualUserDetailsUpdate.Text)
            {



                SqlConnection con2 = new SqlConnection(connectionStr);
                string sql2 = "Update Table_Login set Password=@a where User_ID=@b";
                SqlCommand cmd2 = new SqlCommand(sql2, con2);
                cmd2.Parameters.AddWithValue("@a", txtPasswordIndividualUserDetailsUpdate.Text);
                cmd2.Parameters.AddWithValue("@b", Program.User_ID);

                con2.Open();
                cmd2.ExecuteNonQuery();
                con2.Close();



                MessageBox.Show("Updated Successfully");
                this.Close();



            }

            else
            {
                MessageBox.Show("The above Passwords did not matched");
                txtPasswordIndividualUserDetailsUpdate.Text = "";
                txtRetypePasswordIndividualUserDetailsUpdate.Text = "";
                txtPasswordIndividualUserDetailsUpdate.Focus();
            }
        }
    }
}
