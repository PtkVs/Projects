using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class MDIAdmin : Form
    {
        private int childFormNumber = 0;

        public MDIAdmin()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        //0
        private void MDIAdmin_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Today.ToLongDateString();
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //1
        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild !=null)
            {
                ActiveMdiChild.Close();
            }
            FormEntryBook frm = new FormEntryBook();
            frm.MdiParent = this;
            frm.Show();
        }

        //2
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) 
            {
                ActiveMdiChild.Close();
            }
            FormViewBooks frm = new FormViewBooks();
            frm.MdiParent = this;
            frm.Show();

        }

        //3
        private void addStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormStudentDetails frm = new FormStudentDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        
        //4
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) 
            {
                ActiveMdiChild.Close();
            }
            FormAddUser frm = new FormAddUser();
            frm.MdiParent = this;
            frm.Show();

      }

        //5
        private void issuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormViewIssues frm = new FormViewIssues();
            frm.MdiParent = this;
            frm.Show();

        }

        //6
        private void changeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormDetailsChangeUserDetails frm = new FormDetailsChangeUserDetails();
            frm.MdiParent = this;
            frm.Show();

        }

        //7
        private void changeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormDetailsChangeBookDetails frm = new FormDetailsChangeBookDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        //8
        private void changeStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormDetailsChangeStudentDetails frm = new FormDetailsChangeStudentDetails();
            frm.MdiParent = this;
            frm.Show();
        }
        
        //9
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Close();
        }

        //10
        private void viewReceivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormViewReceived frm = new FormViewReceived();
            frm.MdiParent = this;
            frm.Show();
            
        }

        //11
        private void selfDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormIndividualUserDetailsUpdate frm = new FormIndividualUserDetailsUpdate();
            frm.MdiParent = this;
            frm.Show();
            
        }

        //12
        private void issuedReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            ReportIssued frm = new ReportIssued();
            frm.MdiParent = this;
            frm.Show();

        }

        //13
        private void viewFineToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormViewFine frm = new FormViewFine();
            frm.MdiParent = this;
            frm.Show();
        }

        //14
        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormHelpAboutUs frm = new FormHelpAboutUs();
            frm.MdiParent = this;
            frm.Show();
        }

        //15
        private void guideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormHelpGuide frm = new FormHelpGuide();
            frm.MdiParent = this;
            frm.Show();
        }

        //16
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Close();
        }

        //17
        private void btnBooks_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormViewBooks frm = new FormViewBooks();
            frm.MdiParent = this;
            frm.Show();
        }

        //18
        private void btnIssues_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormViewIssues frm = new FormViewIssues();
            frm.MdiParent = this;
            frm.Show();
        }

        //19
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormViewReceived frm = new FormViewReceived();
            frm.MdiParent = this;
            frm.Show();
        }

        //20
        private void btnFine_Click(object sender, EventArgs e)
        {

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormViewFine frm = new FormViewFine();
            frm.MdiParent = this;
            frm.Show();
        }

        //21
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormDetailsChangeUserDetails frm = new FormDetailsChangeUserDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        //22
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormDetailsChangeStudentDetails frm = new FormDetailsChangeStudentDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        //23
        private void btnIssuedReport_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            ReportIssued frm = new ReportIssued();
            frm.MdiParent = this;
            frm.Show();
        }

        //24
        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormEntryBook frm = new FormEntryBook();
            frm.MdiParent = this;
            frm.Show();
        }

        //25
        private void AddUsers_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormAddUser frm = new FormAddUser();
            frm.MdiParent = this;
            frm.Show();
        }

        //26
        private void AddStudent_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormStudentDetails frm = new FormStudentDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        //27
        private void fineReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormReportFine frm = new FormReportFine();
            frm.MdiParent = this;
            frm.Show();
        }

        //28
        private void fineReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormReportFine frm = new FormReportFine();
            frm.MdiParent = this;
            frm.Show();
        }



        

    }
}
