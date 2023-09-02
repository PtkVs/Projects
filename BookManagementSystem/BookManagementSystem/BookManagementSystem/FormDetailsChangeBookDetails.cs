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
    public partial class FormDetailsChangeBookDetails : Form
    {
        public FormDetailsChangeBookDetails()
        {
            InitializeComponent();
        }
        //1
        string connectionStr = "Data Source=DELL\\SQLEXPRESS; Integrated Security=true; Initial Catalog=BookMgmtSystem;";
        private void FormDetailsChangeBookDetails_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "SELECT     Table_Book.Book_ID, Table_Book.ISBN_No, Table_Book.Book_Name, Table_Category.Category_Name, Table_Author.Author_Name, Table_Book.Price, Table_Book.Quantity FROM Table_Author INNER JOIN Table_Book ON Table_Author.Author_ID = Table_Book.Author_ID INNER JOIN Table_Category ON Table_Book.Category_ID = Table_Category.Category_ID";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "a");
            datagridBookDetails.DataSource = ds.Tables["a"];
        }


        //2
        private void datagridBookDetails_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormDetailsChangeBookDetailsUpdate frm = new FormDetailsChangeBookDetailsUpdate();

            frm.lblBookIdChangeBookDetailsUpdate.Text = datagridBookDetails.CurrentRow.Cells[0].Value.ToString();
            frm.lblIsbnNoChangeBookDetailsUpdate.Text = datagridBookDetails.CurrentRow.Cells[1].Value.ToString();
            frm.lblBookNameChangeBookDetailsUpdate.Text = datagridBookDetails.CurrentRow.Cells[2].Value.ToString();
            frm.lblCategoryChangeBookDetailsUpdate.Text = datagridBookDetails.CurrentRow.Cells[3].Value.ToString();
            frm.lblAuthorChangeBookDetailsUpdate.Text = datagridBookDetails.CurrentRow.Cells[4].Value.ToString();
            frm.lblPriceChangeBookDetailsUpdate.Text = datagridBookDetails.CurrentRow.Cells[5].Value.ToString();
            frm.lblQuantityChangeBookDetailsUpdate.Text = datagridBookDetails.CurrentRow.Cells[6].Value.ToString();

            frm.Show();
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
            da.Fill(ds,"t");

            if(ds.Tables["t"].Rows.Count>0)
            {
              datagridBookDetails.DataSource = ds.Tables["t"];
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
            datagridBookDetails.DataSource = ds.Tables["t"];

        }
           

           

        
    }
}
