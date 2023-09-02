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
    public partial class FormViewReceived : Form
    {
        public FormViewReceived()
        {
            InitializeComponent();
        }
        //1
        string connectionstr = "data source=DELL\\SQLEXPRESS; Integrated Security=True; Initial catalog=BookMgmtSystem;";
        private void FormViewReceived_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(connectionstr);
            string sql = "SELECT Table_Issue.Issue_ID, Table_Issue.Book_ID, Table_Book.Book_Name, Table_Issue.Received_By, Table_Login.Username, Table_Issue.Received_Date, Table_Issue.Received,Table_StudentDetail.Student_ID, Table_StudentDetail.Name FROM Table_Book INNER JOIN Table_Issue ON Table_Book.Book_ID = Table_Issue.Book_ID INNER JOIN Table_StudentDetail ON Table_Issue.Student_ID = Table_StudentDetail.Student_ID INNER JOIN Table_Login ON Table_Issue.Received_By = Table_Login.User_ID";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "a");
            datagridViewReceived.DataSource = ds.Tables["a"];
        }

        //2
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            string sql = "SELECT Table_Issue.Issue_ID, Table_Issue.Book_ID, Table_Book.Book_Name, Table_Issue.Received_By, Table_Login.Username, Table_Issue.Received_Date, Table_Issue.Received,Table_StudentDetail.Student_ID, Table_StudentDetail.Name FROM Table_Book INNER JOIN Table_Issue ON Table_Book.Book_ID = Table_Issue.Book_ID INNER JOIN Table_StudentDetail ON Table_Issue.Student_ID = Table_StudentDetail.Student_ID INNER JOIN Table_Login ON Table_Issue.Received_By = Table_Login.User_ID where Table_Book.Book_Name=@a or Table_StudentDetail.Name=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtSearch.Text);
           
           

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "a");

            if (ds.Tables["a"].Rows.Count > 0)
            {
                datagridViewReceived.DataSource = ds.Tables["a"];
            }

            else
            {
                MessageBox.Show("No Such Received Found");
            }
        }


        //3
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            string sql = "SELECT Table_Issue.Issue_ID, Table_Issue.Book_ID, Table_Book.Book_Name, Table_Issue.Received_By, Table_Login.Username, Table_Issue.Received_Date, Table_Issue.Received,Table_StudentDetail.Student_ID, Table_StudentDetail.Name FROM Table_Book INNER JOIN Table_Issue ON Table_Book.Book_ID = Table_Issue.Book_ID INNER JOIN Table_StudentDetail ON Table_Issue.Student_ID = Table_StudentDetail.Student_ID INNER JOIN Table_Login ON Table_Issue.Received_By = Table_Login.User_ID where Table_Book.Book_Name like @a or Table_StudentDetail.Name like @a";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@a", txtSearch.Text + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "t");
            datagridViewReceived.DataSource = ds.Tables["t"];
        }

       
    }
}
