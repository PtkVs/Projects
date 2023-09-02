namespace BookManagementSystem
{
    partial class MDIUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIUser));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReceivedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSelfDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuedReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fineReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnBook = new System.Windows.Forms.ToolStripButton();
            this.btnIssues = new System.Windows.Forms.ToolStripButton();
            this.btnReceived = new System.Windows.Forms.ToolStripButton();
            this.btnFine = new System.Windows.Forms.ToolStripButton();
            this.btnAddBooks = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btnSelf = new System.Windows.Forms.ToolStripButton();
            this.btnStudent = new System.Windows.Forms.ToolStripButton();
            this.btnReport = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnIssuedReport = new System.Windows.Forms.ToolStripMenuItem();
            this.fineReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.entryToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1322, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBooksToolStripMenuItem,
            this.viewIssuesToolStripMenuItem,
            this.viewReceivedToolStripMenuItem,
            this.viewFineToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // viewBooksToolStripMenuItem
            // 
            this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            this.viewBooksToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewBooksToolStripMenuItem.Text = "View Books";
            this.viewBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBooksToolStripMenuItem_Click);
            // 
            // viewIssuesToolStripMenuItem
            // 
            this.viewIssuesToolStripMenuItem.Name = "viewIssuesToolStripMenuItem";
            this.viewIssuesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewIssuesToolStripMenuItem.Text = "View Issues ";
            this.viewIssuesToolStripMenuItem.Click += new System.EventHandler(this.viewIssuesToolStripMenuItem_Click);
            // 
            // viewReceivedToolStripMenuItem
            // 
            this.viewReceivedToolStripMenuItem.Name = "viewReceivedToolStripMenuItem";
            this.viewReceivedToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewReceivedToolStripMenuItem.Text = "View Received";
            this.viewReceivedToolStripMenuItem.Click += new System.EventHandler(this.viewReceivedToolStripMenuItem_Click);
            // 
            // viewFineToolStripMenuItem
            // 
            this.viewFineToolStripMenuItem.Name = "viewFineToolStripMenuItem";
            this.viewFineToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewFineToolStripMenuItem.Text = "View Fine";
            this.viewFineToolStripMenuItem.Click += new System.EventHandler(this.viewFineToolStripMenuItem_Click);
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.addStudentDetailsToolStripMenuItem});
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.entryToolStripMenuItem.Text = "Entry";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // addStudentDetailsToolStripMenuItem
            // 
            this.addStudentDetailsToolStripMenuItem.Name = "addStudentDetailsToolStripMenuItem";
            this.addStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addStudentDetailsToolStripMenuItem.Text = "Add Student Details";
            this.addStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.addStudentDetailsToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBookDetailsToolStripMenuItem,
            this.changeStudentDetailsToolStripMenuItem,
            this.changeSelfDetailsToolStripMenuItem});
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // changeBookDetailsToolStripMenuItem
            // 
            this.changeBookDetailsToolStripMenuItem.Name = "changeBookDetailsToolStripMenuItem";
            this.changeBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.changeBookDetailsToolStripMenuItem.Text = "Change Book Details";
            this.changeBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.changeBookDetailsToolStripMenuItem_Click);
            // 
            // changeStudentDetailsToolStripMenuItem
            // 
            this.changeStudentDetailsToolStripMenuItem.Name = "changeStudentDetailsToolStripMenuItem";
            this.changeStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.changeStudentDetailsToolStripMenuItem.Text = "Change Student Details";
            this.changeStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.changeStudentDetailsToolStripMenuItem_Click);
            // 
            // changeSelfDetailsToolStripMenuItem
            // 
            this.changeSelfDetailsToolStripMenuItem.Name = "changeSelfDetailsToolStripMenuItem";
            this.changeSelfDetailsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.changeSelfDetailsToolStripMenuItem.Text = "Change Self Details";
            this.changeSelfDetailsToolStripMenuItem.Click += new System.EventHandler(this.changeSelfDetailsToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issuedReportToolStripMenuItem,
            this.fineReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // issuedReportToolStripMenuItem
            // 
            this.issuedReportToolStripMenuItem.Name = "issuedReportToolStripMenuItem";
            this.issuedReportToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.issuedReportToolStripMenuItem.Text = "Issued Report";
            this.issuedReportToolStripMenuItem.Click += new System.EventHandler(this.issuedReportToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.userManualToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.userManualToolStripMenuItem.Text = "User Manual";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.userManualToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnBook,
            this.btnIssues,
            this.btnReceived,
            this.btnFine,
            this.toolStripSeparator2,
            this.btnAddBooks,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.btnSelf,
            this.btnStudent,
            this.toolStripSeparator3,
            this.btnReport,
            this.btnLogout,
            this.toolStripButton8});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1322, 47);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelDate});
            this.statusStrip.Location = new System.Drawing.Point(0, 446);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1322, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // labelDate
            // 
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(39, 17);
            this.labelDate.Text = "Status";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1235, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome User";
            // 
            // fineReportToolStripMenuItem
            // 
            this.fineReportToolStripMenuItem.Name = "fineReportToolStripMenuItem";
            this.fineReportToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fineReportToolStripMenuItem.Text = "Fine Report";
            this.fineReportToolStripMenuItem.Click += new System.EventHandler(this.fineReportToolStripMenuItem_Click);
            // 
            // BtnBook
            // 
            this.BtnBook.Image = ((System.Drawing.Image)(resources.GetObject("BtnBook.Image")));
            this.BtnBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBook.Name = "BtnBook";
            this.BtnBook.Size = new System.Drawing.Size(81, 44);
            this.BtnBook.Text = "Books";
            this.BtnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // btnIssues
            // 
            this.btnIssues.Image = ((System.Drawing.Image)(resources.GetObject("btnIssues.Image")));
            this.btnIssues.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIssues.Name = "btnIssues";
            this.btnIssues.Size = new System.Drawing.Size(84, 44);
            this.btnIssues.Text = "Issues";
            this.btnIssues.Click += new System.EventHandler(this.btnIssues_Click);
            // 
            // btnReceived
            // 
            this.btnReceived.Image = ((System.Drawing.Image)(resources.GetObject("btnReceived.Image")));
            this.btnReceived.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceived.Name = "btnReceived";
            this.btnReceived.Size = new System.Drawing.Size(98, 44);
            this.btnReceived.Text = "Received";
            this.btnReceived.Click += new System.EventHandler(this.btnReceived_Click);
            // 
            // btnFine
            // 
            this.btnFine.Image = ((System.Drawing.Image)(resources.GetObject("btnFine.Image")));
            this.btnFine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(73, 44);
            this.btnFine.Text = "Fine";
            this.btnFine.Click += new System.EventHandler(this.btnFine_Click);
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBooks.Image")));
            this.btnAddBooks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Size = new System.Drawing.Size(104, 44);
            this.btnAddBooks.Text = "Add Books";
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(119, 44);
            this.toolStripButton3.Text = "Add Students";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnSelf
            // 
            this.btnSelf.Image = ((System.Drawing.Image)(resources.GetObject("btnSelf.Image")));
            this.btnSelf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelf.Name = "btnSelf";
            this.btnSelf.Size = new System.Drawing.Size(74, 44);
            this.btnSelf.Text = "Self";
            this.btnSelf.Click += new System.EventHandler(this.btnSelf_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            this.btnStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(91, 44);
            this.btnStudent.Text = "Student";
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnReport
            // 
            this.btnReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIssuedReport,
            this.fineReportToolStripMenuItem1});
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(99, 44);
            this.btnReport.Text = "Reports";
            // 
            // btnIssuedReport
            // 
            this.btnIssuedReport.Image = global::BookManagementSystem.Properties.Resources.download__10_1;
            this.btnIssuedReport.Name = "btnIssuedReport";
            this.btnIssuedReport.Size = new System.Drawing.Size(176, 46);
            this.btnIssuedReport.Text = "Issued Report";
            this.btnIssuedReport.Click += new System.EventHandler(this.btnIssuedReport_Click);
            // 
            // fineReportToolStripMenuItem1
            // 
            this.fineReportToolStripMenuItem1.Image = global::BookManagementSystem.Properties.Resources.images__3_1;
            this.fineReportToolStripMenuItem1.Name = "fineReportToolStripMenuItem1";
            this.fineReportToolStripMenuItem1.Size = new System.Drawing.Size(176, 46);
            this.fineReportToolStripMenuItem1.Text = "Fine Report";
            this.fineReportToolStripMenuItem1.Click += new System.EventHandler(this.fineReportToolStripMenuItem1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(44, 44);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // MDIUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIUser";
            this.Text = "Book Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIUser_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelDate;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton BtnBook;
        private System.Windows.Forms.ToolStripButton btnIssues;
        private System.Windows.Forms.ToolStripButton btnReceived;
        private System.Windows.Forms.ToolStripButton btnFine;
        private System.Windows.Forms.ToolStripButton btnSelf;
        private System.Windows.Forms.ToolStripButton btnStudent;
        private System.Windows.Forms.ToolStripDropDownButton btnReport;
        private System.Windows.Forms.ToolStripButton btnLogout;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripMenuItem btnIssuedReport;
        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewIssuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReceivedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSelfDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuedReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAddBooks;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fineReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fineReportToolStripMenuItem1;
    }
}



