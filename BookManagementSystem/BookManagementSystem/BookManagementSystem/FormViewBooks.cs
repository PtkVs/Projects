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
    public partial class FormViewBooks : Form
    {
        public FormViewBooks()
        {
            InitializeComponent();
        }

        //1
        string connectionStr = "Data Source=DELL\\SQLEXPRESS; Integrated Security=True; Initial Catalog=BookMgmtSystem;";
        private void FormView_Load(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection(connectionStr);
            string sql = "SELECT     Table_Book.Book_ID, Table_Book.ISBN_No, Table_Book.Book_Name, Table_Category.Category_Name, Table_Author.Author_Name, Table_Book.Price, Table_Book.Quantity FROM Table_Author INNER JOIN Table_Book ON Table_Author.Author_ID = Table_Book.Author_ID INNER JOIN Table_Category ON Table_Book.Category_ID = Table_Category.Category_ID";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "a");
            datagridViewBooks.DataSource = ds.Tables["a"];

        }


        //2
        private void datagridViewBooks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormDoIssue fdi = new FormDoIssue();
            fdi.lblBookIdDoIssue.Text = datagridViewBooks.CurrentRow.Cells[0].Value.ToString();
            
            
            fdi.Show();
            this.Hide();
           
        }

        //3
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_Book where Book_Name=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtSearch.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "a");

            if (ds.Tables["a"].Rows.Count > 0)
            {
                datagridViewBooks.DataSource = ds.Tables["a"];
            }

            else
            {
                MessageBox.Show("Such Book name Does not exsists");
            }

        }

        //4
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_Book where Book_Name like @a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtSearch.Text + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "t");
            datagridViewBooks.DataSource = ds.Tables["t"];
        }

        
    }
}
