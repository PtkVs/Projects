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
    public partial class FormDetailsChangeBookDetailsUpdate : Form
    {
        public FormDetailsChangeBookDetailsUpdate()
        {
            InitializeComponent();
        }
        //1
        string connectionStr = "data source=DELL\\SQLEXPRESS; integrated security=true; initial catalog=BookMgmtSystem;";
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_Book where Book_Name=@a and Book_ID=@b";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtNewBookNameChangeBookDetailsUpdate.Text);
            cmd.Parameters.AddWithValue("@b", lblBookIdChangeBookDetailsUpdate.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "e");
            DataTable dt = ds.Tables["e"];
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The New Book Name cannot be same as the Old Book Name");
                txtNewBookNameChangeBookDetailsUpdate.Text = "";
                txtNewBookNameChangeBookDetailsUpdate.Focus();
            }
            else
            {
                SqlConnection con2 = new SqlConnection(connectionStr);
                string sql2 = "update Table_Book set Book_Name=@b,Category_ID=@c,Author_ID=@d where Book_ID=@a";
                SqlCommand cmd2 = new SqlCommand(sql2, con2);
                cmd2.Parameters.AddWithValue("@a", lblBookIdChangeBookDetailsUpdate.Text);
                cmd2.Parameters.AddWithValue("@b", txtNewBookNameChangeBookDetailsUpdate.Text);
                cmd2.Parameters.AddWithValue("@c", Convert.ToInt32(cbxNewCategoryChangeBookDetailsUpdate.SelectedValue.ToString()));
                cmd2.Parameters.AddWithValue("@d", Convert.ToInt32(cbxNewAuthorChangeBookDetailsUpdate.SelectedValue.ToString()));

                con2.Open();
                cmd2.ExecuteNonQuery();
                con2.Close();

                MessageBox.Show("Update Successfull");
                this.Close();
                

            }
        }

        //2
        public void LoadAuthor()
        {

            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_Author";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "t");
            DataTable dt = ds.Tables["t"];
            if (dt.Rows.Count > 0)
            {
                //inserting choose author
                DataRow dr = dt.NewRow();
                dr["Author_Name"] = "Choose Author";
                dt.Rows.InsertAt(dr, 0);

                cbxNewAuthorChangeBookDetailsUpdate.DataSource = dt;
                cbxNewAuthorChangeBookDetailsUpdate.DisplayMember = "Author_Name";
                cbxNewAuthorChangeBookDetailsUpdate.ValueMember = "Author_ID";
            }

        }

        //3
        private void FormDetailsChangeBookDetailsUpdate_Load(object sender, EventArgs e)
        {
            LoadAuthor();
            LoadCategory();
        }

        //4
        public void LoadCategory()
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_Category";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "a");
            DataTable dt = ds.Tables["a"];
            if (dt.Rows.Count > 0)
            {
                //inserting choose category
                DataRow dr = dt.NewRow();
                dr["Category_Name"] = "Choose Category";
                dt.Rows.InsertAt(dr, 0);

                cbxNewCategoryChangeBookDetailsUpdate.DataSource = dt;
                cbxNewCategoryChangeBookDetailsUpdate.DisplayMember = "Category_Name";
                cbxNewCategoryChangeBookDetailsUpdate.ValueMember = "Category_ID";
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
                string sql = "delete from Table_Book where Book_ID=@a";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@a", lblBookIdChangeBookDetailsUpdate.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully");
                this.Close();
               
            }
        }

        



        
    }
}
