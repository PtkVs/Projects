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

    public partial class FormDoIssue : Form
    {
        public FormDoIssue()
        {
            InitializeComponent();
        }

        //m

        string connectionStr = "Data Source=DELL\\SQLEXPRESS; Integrated Security=True; Initial Catalog=BookMgmtSystem;";



        private void FormDoIssue_Load(object sender, EventArgs e)
        {

        }


        //3
        private void txtStudentID_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_StudentDetail where Student_ID=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtStudentID.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "t");
            DataTable dt = ds.Tables["t"];
            if (dt.Rows.Count > 0)
            {
                lblStudentName.Text = "Student Name : " + dt.Rows[0][1].ToString();
            }
            else
            {
                lblStudentName.Text = "There is no student with id.";
            }
        }

        //1
        private void btnIssue_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_Issue where Student_ID=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtStudentID.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "a");
            DataTable dt = ds.Tables["a"];
            if (dt.Rows.Count > 3)
            {
                MessageBox.Show("The Student With This Id already exceeded 3 Books.");
            }


            else
            {
                DateTime issueDate = DateTime.Today.Date;
                DateTime expiryDate = issueDate.AddDays(20).Date;
                SqlConnection con2 = new SqlConnection(connectionStr);
                string sql2 = "insert into Table_Issue (Book_ID,Student_ID,Issued_By,Issued_Date,Expiry_Date,Received) values(@g,@a,@b,@c,@d,'false')";
                SqlCommand cmd2 = new SqlCommand(sql2, con2);
                cmd2.Parameters.AddWithValue("@g", Convert.ToInt32(lblBookIdDoIssue.Text));
                cmd2.Parameters.AddWithValue("@a", txtStudentID.Text);
                cmd2.Parameters.AddWithValue("@b", Program.User_ID);

                cmd2.Parameters.AddWithValue("@c", issueDate);
                cmd2.Parameters.AddWithValue("@d", expiryDate);

                con2.Open();
                int i = cmd2.ExecuteNonQuery();
                con2.Close();
                if (i > 0)
                {
                    MessageBox.Show("Book Issued Successfully");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Book Issue Unsuccessful");
                }
            }
        }

        //2
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_Issue where Book_ID=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", lblBookIdDoIssue.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "a");
            DataTable dt = ds.Tables["a"];
            if (dt.Rows.Count > 5)
            {
                MessageBox.Show("Book Out Of Stock.");
            }
            else
            {

                MessageBox.Show("Book available");

            }
        }
    }
}


      
                

