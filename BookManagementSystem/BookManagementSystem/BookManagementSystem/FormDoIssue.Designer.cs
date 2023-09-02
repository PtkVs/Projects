namespace BookManagementSystem
{
    partial class FormDoIssue
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
            this.grpDoIssue = new System.Windows.Forms.GroupBox();
            this.lblBookIdDoIssue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpDoIssue.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDoIssue
            // 
            this.grpDoIssue.BackColor = System.Drawing.Color.Gold;
            this.grpDoIssue.Controls.Add(this.button1);
            this.grpDoIssue.Controls.Add(this.lblBookIdDoIssue);
            this.grpDoIssue.Controls.Add(this.label1);
            this.grpDoIssue.Controls.Add(this.btnCancel);
            this.grpDoIssue.Controls.Add(this.btnIssue);
            this.grpDoIssue.Controls.Add(this.lblStudentName);
            this.grpDoIssue.Controls.Add(this.txtStudentID);
            this.grpDoIssue.Controls.Add(this.lblStudentID);
            this.grpDoIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDoIssue.Location = new System.Drawing.Point(81, 65);
            this.grpDoIssue.Name = "grpDoIssue";
            this.grpDoIssue.Size = new System.Drawing.Size(414, 206);
            this.grpDoIssue.TabIndex = 0;
            this.grpDoIssue.TabStop = false;
            // 
            // lblBookIdDoIssue
            // 
            this.lblBookIdDoIssue.AutoSize = true;
            this.lblBookIdDoIssue.Location = new System.Drawing.Point(170, 31);
            this.lblBookIdDoIssue.Name = "lblBookIdDoIssue";
            this.lblBookIdDoIssue.Size = new System.Drawing.Size(90, 13);
            this.lblBookIdDoIssue.TabIndex = 13;
            this.lblBookIdDoIssue.Text = "lblBookIdDoIssue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Book ID      :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(280, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(173, 145);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(87, 23);
            this.btnIssue.TabIndex = 9;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click_1);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(169, 115);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(0, 13);
            this.lblStudentName.TabIndex = 8;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(167, 79);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(200, 20);
            this.txtStudentID.TabIndex = 7;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged_1);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(41, 86);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(67, 13);
            this.lblStudentID.TabIndex = 6;
            this.lblStudentID.Text = "Student ID  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Issue Books";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDoIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 311);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpDoIssue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDoIssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormDoIssue_Load);
            this.grpDoIssue.ResumeLayout(false);
            this.grpDoIssue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDoIssue;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblBookIdDoIssue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;

    }
}