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
    public partial class FormStudentDetails : Form
    {
        public FormStudentDetails()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

     



        //1
        string connectionStr = "Data Source=DELL\\SQLEXPRESS; Integrated Security=True; Initial Catalog=BookMgmtSystem;";
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtStudentName.Text == "")
            {
                MessageBox.Show("Any of the above fields cannot be empty");

            }

            else if (Convert.ToInt32(txtPhone.Text.Length.ToString()) <= 9)
            {
                MessageBox.Show("Invalid NUMBER");
            }

            else
            {
                SqlConnection con = new SqlConnection(connectionStr);
                string sql = "select * from Table_StudentDetail where Phone=@a";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@a", txtPhone.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "a");
                DataTable dt = ds.Tables["a"];

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("The Student with This Phone Number already Exists");
                    txtAddress.Text = "";
                    txtEmail.Text = "";
                    txtPhone.Text = "";
                    txtStudentName.Text = "";
                    txtStudentName.Focus();

                }

                else
                {
                    SqlConnection con2 = new SqlConnection(connectionStr);
                    string sql2 = "insert into Table_StudentDetail(Name,Phone,Address,Email) values(@a,@b,@c,@d)";
                    SqlCommand cmd2 = new SqlCommand(sql2, con2);
                    cmd2.Parameters.AddWithValue("@a", txtStudentName.Text);
                    cmd2.Parameters.AddWithValue("@b", txtPhone.Text);
                    cmd2.Parameters.AddWithValue("@c", txtAddress.Text);
                    cmd2.Parameters.AddWithValue("@d", txtEmail.Text);

                    con2.Open();
                    int i = cmd2.ExecuteNonQuery();
                    con2.Close();

                    if (i > 0)
                    {
                        MessageBox.Show("Student Details Entered Successfully");
                        txtAddress.Text = "";
                        txtEmail.Text = "";
                        txtPhone.Text = "";
                        txtStudentName.Text = "";
                        txtStudentName.Focus();
                    }

                    else
                    {

                        MessageBox.Show("Student Details Entered Unsuccessful");
                        txtAddress.Text = "";
                        txtEmail.Text = "";
                        txtPhone.Text = "";
                        txtStudentName.Text = "";
                        txtStudentName.Focus();
                    }
                }
            }
            }

        //2
        private void btnCancel_Click(object sender, EventArgs e)
        {
        this.Close();
        }
        

       
    }
}
            
        
            
   