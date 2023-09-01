namespace Digital_Clock
{
    partial class DigitalClock
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTime = new Label();
            labelYM = new Label();
            labelDay = new Label();
            labelDate = new Label();
            SuspendLayout();
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Times New Roman", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelTime.ForeColor = SystemColors.ActiveCaption;
            labelTime.Location = new Point(160, 128);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(397, 108);
            labelTime.TabIndex = 0;
            labelTime.Text = "00:00:00";
            // 
            // labelYM
            // 
            labelYM.AutoSize = true;
            labelYM.Font = new Font("MV Boli", 27F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelYM.ForeColor = SystemColors.ActiveCaption;
            labelYM.Location = new Point(52, 308);
            labelYM.Name = "labelYM";
            labelYM.Size = new Size(229, 46);
            labelYM.TabIndex = 1;
            labelYM.Text = "Year,Month";
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Font = new Font("MV Boli", 27F, FontStyle.Bold, GraphicsUnit.Point);
            labelDay.ForeColor = SystemColors.ActiveCaption;
            labelDay.Location = new Point(514, 308);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(84, 46);
            labelDay.TabIndex = 2;
            labelDay.Text = "Day";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("MV Boli", 27F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelDate.ForeColor = SystemColors.ActiveCaption;
            labelDate.Location = new Point(331, 308);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(103, 46);
            labelDate.TabIndex = 3;
            labelDate.Text = "Date";
            // 
            // DigitalClock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDate);
            Controls.Add(labelDay);
            Controls.Add(labelYM);
            Controls.Add(labelTime);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DigitalClock";
            Text = "DigitalClock";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTime;
        private Label labelYM;
        private Label labelDay;
        private Label labelDate;
    }
}