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
    public partial class FormDetailsChangeUserDetails : Form
    {
        public FormDetailsChangeUserDetails()
        {
            InitializeComponent();
        }
        //m
        string connectionStr = "Data Source=DELL\\SQLEXPRESS; Integrated Security=True; Initial Catalog=BookMgmtSystem;";
        
        //1
        private void FormDetailsChangeUserDetails_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_Login";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "t");
            datagridUserDetails.DataSource = ds.Tables["t"];

          

        }

      
        //2
        private void datagridUserDetails_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormDetailsChangeUserDetailsUpdate frm = new FormDetailsChangeUserDetailsUpdate();

            frm.lblUserIdChangeUserDetailsUpdate.Text = datagridUserDetails.CurrentRow.Cells[0].Value.ToString();
            frm.lblUsernameChangeUserDetailsUpdate.Text = datagridUserDetails.CurrentRow.Cells[1].Value.ToString();
            frm.txtOldPasswordUserDetailsUpdate.Text = datagridUserDetails.CurrentRow.Cells[2].Value.ToString();
            frm.lblUserTypeChangeUserDetailsUpdate.Text = datagridUserDetails.CurrentRow.Cells[3].Value.ToString();




            frm.Show();
            this.Hide();

        }
          



        

        //3
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_Login where Username = @a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtSearch.Text );

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "t");

            if (ds.Tables["t"].Rows.Count > 0)
            {
                datagridUserDetails.DataSource = ds.Tables["t"];
            }
            else
            {
                MessageBox.Show("Username Does not exsists");
            }

           

        }

        //4
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_Login where Username like @a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtSearch.Text + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "t");
            datagridUserDetails.DataSource = ds.Tables["t"];





        }

       
    }
}
