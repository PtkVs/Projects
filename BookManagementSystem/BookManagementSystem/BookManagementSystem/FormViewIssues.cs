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
    public partial class FormViewIssues : Form
    {
        public FormViewIssues()
        {
            InitializeComponent();
        }

        //1
        string connectionStr = "data source=DELL\\SQLEXPRESS; Integrated Security=True; Initial catalog=BookMgmtSystem;";
        private void FormViewIssues_Load(object sender, EventArgs e)
        {
          loadgrid();

        }
        //2
        public void loadgrid()
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "SELECT  Table_Issue.Issue_ID, Table_Book.Book_Name, Table_Issue.Issued_Date, Table_Login.Username, Table_Issue.Expiry_Date, Table_StudentDetail.Name FROM Table_Book INNER JOIN Table_Issue ON Table_Book.Book_ID = Table_Issue.Book_ID INNER JOIN Table_StudentDetail ON Table_Issue.Student_ID = Table_StudentDetail.Student_ID INNER JOIN Table_Login ON Table_Issue.Issued_By = Table_Login.User_ID where Table_Issue.Received='False'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "a");
            datagridViewIssues.DataSource = ds.Tables["a"];
        }

        //2
        private void datagridViewIssues_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Issue_ID = Convert.ToInt32(datagridViewIssues.CurrentRow.Cells[0].Value.ToString());
            
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select Expiry_Date from Table_Issue where Issue_ID=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", Issue_ID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "a");
            DataTable dt = ds.Tables["a"];

            DateTime expiredDate = Convert.ToDateTime(dt.Rows[0][0].ToString());
            int Expired = expiredDate.CompareTo(DateTime.Now);
            if (Expired == -1)
            {
                int fine;
                int leftDays =( DateTime.Now - expiredDate).Days;

                if (leftDays < 8)
                    fine = 100;
                else if (leftDays < 15)
                    fine = 150;
                else if (leftDays < 22)
                    fine = 200;
                else
                    fine = 300;

                        if (MessageBox.Show("This issue has been expired and the fine is Rs."+fine+". Paid?", "Book Return", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                            //update
                    SqlConnection con2 = new SqlConnection(connectionStr);
                    string sql2 = "Update Table_Issue set Received_By=@a,Received_Date=@b,Received='True' where Issue_ID=@c";
                    SqlCommand cmd2 = new SqlCommand(sql2,con2);
                    cmd2.Parameters.AddWithValue("@a", Program.User_ID);
                    cmd2.Parameters.AddWithValue("@b", DateTime.Now);
                    cmd2.Parameters.AddWithValue("@c", Issue_ID);

                    con2.Open();
                   int i= cmd2.ExecuteNonQuery();
                    con2.Close();
                        
                            //insert
                            SqlConnection con3 = new SqlConnection(connectionStr);
                            string sql3 = "Insert into Table_Fine(Issue_ID,Fine) values(@a,@b)";
                            SqlCommand cmd3 = new SqlCommand(sql3, con3);
                            cmd3.Parameters.AddWithValue("@a", Issue_ID);
                            cmd3.Parameters.AddWithValue("@b", fine);

                            con3.Open();
                          int j=  cmd3.ExecuteNonQuery();
                          con3.Close();
                          if (i > 0 && j > 0)
                          {
                              MessageBox.Show("Book Received successfully");
                              loadgrid();
                          }


                   }
            }
            else
            {
                if (MessageBox.Show("Returned?", "Book Return", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SqlConnection con2 = new SqlConnection(connectionStr);
                    string sql2 = "Update Table_Issue set Received_By=@a,Received_Date=@b,Received='True' where Issue_ID=@c";
                    SqlCommand cmd2 = new SqlCommand(sql2, con2);
                    cmd2.Parameters.AddWithValue("@a", Program.User_ID);
                    cmd2.Parameters.AddWithValue("@b", DateTime.Now);
                    cmd2.Parameters.AddWithValue("@c", Issue_ID);

                    con2.Open();
                    int i = cmd2.ExecuteNonQuery();
                    con2.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Book Received successfully");
                        loadgrid();
                    }

                }
            }

        }

        //3
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "SELECT  Table_Issue.Issue_ID, Table_Book.Book_Name, Table_Issue.Issued_Date, Table_Login.Username, Table_Issue.Expiry_Date, Table_StudentDetail.Name FROM Table_Book INNER JOIN Table_Issue ON Table_Book.Book_ID = Table_Issue.Book_ID INNER JOIN Table_StudentDetail ON Table_Issue.Student_ID = Table_StudentDetail.Student_ID INNER JOIN Table_Login ON Table_Issue.Issued_By = Table_Login.User_ID where Table_Issue.Received='False' and Table_Book.Book_Name=@a or Table_StudentDetail.Name=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtSearch.Text);
           // cmd.Parameters.AddWithValue("@b", Convert.ToInt32(txtSearchId.Text.ToString()));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "a");

            if (ds.Tables["a"].Rows.Count > 0)
            {
                datagridViewIssues.DataSource = ds.Tables["a"];
            }

            else
            {
                MessageBox.Show("No Issue Found");
            }

        }

        //4
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "SELECT  Table_Issue.Issue_ID, Table_Book.Book_Name, Table_Issue.Issued_Date, Table_Login.Username, Table_Issue.Expiry_Date, Table_StudentDetail.Name FROM Table_Book INNER JOIN Table_Issue ON Table_Book.Book_ID = Table_Issue.Book_ID INNER JOIN Table_StudentDetail ON Table_Issue.Student_ID = Table_StudentDetail.Student_ID INNER JOIN Table_Login ON Table_Issue.Issued_By = Table_Login.User_ID where Table_Issue.Received='False' and Table_Book.Book_Name like @a or Table_StudentDetail.Name like @a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtSearch.Text + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "t");
            datagridViewIssues.DataSource = ds.Tables["t"];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
