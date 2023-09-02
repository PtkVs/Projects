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
    public partial class FormEntryBook : Form
    {
        public FormEntryBook()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

   
       
       //1
        string connectionStr = "data source=DELL\\SQLEXPRESS; Integrated Security=true; Initial Catalog=BookMgmtSystem;";
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtBookname.Text == "" || txtIsbnno.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "" || cbxAuthor.SelectedValue.ToString() == "" || cbxCategory.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Any of the above fields cannot be empty");
            }
            else if (Convert.ToInt32(txtIsbnno.Text.ToString()) < 0)
            {
                MessageBox.Show("The Isbn No. Cannot Be Negative");
                txtIsbnno.Text = "";
                txtIsbnno.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionStr);
                string sql = "select * from Table_Book where ISBN_No=@a";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@a", txtIsbnno.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "t");
                DataTable dt = ds.Tables["t"];

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("The Book containing this ISBN No. Already Exists");
                }



                else
                {
                    SqlConnection con2 = new SqlConnection(connectionStr);
                    string sql2 = "insert into Table_Book(ISBN_No,Book_Name,Category_ID,Price,Quantity,Author_ID) values(@g,@b,@c,@d,@e,@f)";
                    SqlCommand cmd2 = new SqlCommand(sql2, con2);
                    cmd2.Parameters.AddWithValue("@g", txtIsbnno.Text);
                    cmd2.Parameters.AddWithValue("@b", txtBookname.Text);
                    cmd2.Parameters.AddWithValue("@c", Convert.ToInt32(cbxCategory.SelectedValue.ToString()));
                    cmd2.Parameters.AddWithValue("@d", Convert.ToDecimal(txtPrice.Text));
                    cmd2.Parameters.AddWithValue("@e", Convert.ToInt32(txtQuantity.Text));
                    cmd2.Parameters.AddWithValue("@f", Convert.ToInt32(cbxAuthor.SelectedValue.ToString()));

                    con2.Open();
                    int i = cmd2.ExecuteNonQuery();
                    con2.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Book Added Successfully");
                        txtIsbnno.Text = "";
                        txtBookname.Text = "";
                        txtNewcategory.Text = "";
                        txtPrice.Text = "";
                        txtQuantity.Text = "";
                        txtNewAuthor.Text = "";
                        cbxAuthor.Text = "Choose Author";
                        cbxCategory.Text = "Choose Category";
                        txtIsbnno.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Book Addition Unsuccessful");
                        txtIsbnno.Text = "";
                        txtBookname.Text = "";
                        txtNewcategory.Text = "";
                        txtPrice.Text = "";
                        txtQuantity.Text = "";
                        txtNewAuthor.Text = "";
                        cbxAuthor.Text = "Choose Author";
                        cbxCategory.Text = "Choose Category";
                        txtIsbnno.Focus();

                    }
                }
            }
        }





                
       


        //2
        private void btnNewauthor_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "insert into Table_Author values(@a)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtNewAuthor.Text);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                MessageBox.Show("New Author Created Successfully");
            }
            else
            {
                MessageBox.Show("New Author Creation Unsuccessful");
            }

                LoadAuthor();
        }
       
       
        
        //3
        private void btnNewcategory_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "insert into Table_Category values(@a)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtNewcategory.Text);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                MessageBox.Show("New Category Created Successfully");
            }
            else
            {
                MessageBox.Show("New Category Creation Unsuccessful");
            }
            
            LoadCategory();
            
        }
         
        
        
        //4
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

                cbxAuthor.DataSource = dt;
                cbxAuthor.DisplayMember = "Author_Name";
                cbxAuthor.ValueMember = "Author_ID";
            }

        }

       
        
        
        //5
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

                cbxCategory.DataSource = dt;
                cbxCategory.DisplayMember = "Category_Name";
                cbxCategory.ValueMember = "Category_ID";
            }
        }



        //6
        private void FormEntrybook_Load(object sender, EventArgs e)
        {
            LoadAuthor();
            LoadCategory();

        }

       
   

    
        //11
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        
    }
}
