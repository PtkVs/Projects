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
    public partial class FormDetailsChangeStudentDetails : Form
    {
        public FormDetailsChangeStudentDetails()
        {
            InitializeComponent();
        }
        //1
        string connectionStr = "data source=DELL\\SQLEXPRESS; integrated security=true; initial catalog=BookMgmtSystem;";
        private void FormDetailsChangeStudentDetails_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_StudentDetail";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "a");
            datagridStudentDetails.DataSource = ds.Tables["a"];
        }

        //2
        private void datagridStudentDetails_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormDetailsChangeStudentDetailsLUpdate frm = new FormDetailsChangeStudentDetailsLUpdate();

            frm.lblStudentIdChangeStudentDetailsUpdate.Text = datagridStudentDetails.CurrentRow.Cells[0].Value.ToString();
            frm.lblStudentNameChangeStudentDetailsUpdate.Text = datagridStudentDetails.CurrentRow.Cells[1].Value.ToString();
            frm.lblPhoneNoChangeStudentDetailsUpdate.Text = datagridStudentDetails.CurrentRow.Cells[2].Value.ToString();
            frm.lblAddressChangeStudentDetailsUpdate.Text = datagridStudentDetails.CurrentRow.Cells[3].Value.ToString();
            frm.lblEmailChangeStudentDetailsUpdate.Text = datagridStudentDetails.CurrentRow.Cells[4].Value.ToString();

            frm.Show();
            this.Hide();
        }

        //3
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_StudentDetail where Name=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtSearch.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "t");

            if (ds.Tables["t"].Rows.Count > 0)
            {
                datagridStudentDetails.DataSource = ds.Tables["t"];
            }

            else
            {
                MessageBox.Show("Student name Does not exsists");
            }

        }

        //4
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(connectionStr);
            string sql = "select * from Table_StudentDetail where Name like @a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@a", txtSearch.Text + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "t");
            datagridStudentDetails.DataSource = ds.Tables["t"];
        }
    }
}
