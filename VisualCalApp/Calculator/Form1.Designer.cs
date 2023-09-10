namespace Calculator
{
    partial class Form1
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
            txtDisplay = new TextBox();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnFour = new Button();
            btnSix = new Button();
            btnZero = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnSeven = new Button();
            btnFive = new Button();
            btnAdd = new Button();
            btnSubstract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            btnEquals = new Button();
            btnPoint = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisplay.Location = new Point(31, 24);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(416, 35);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOne.Location = new Point(31, 236);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(59, 56);
            btnOne.TabIndex = 1;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += button1_Click;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTwo.Location = new Point(110, 236);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(59, 56);
            btnTwo.TabIndex = 2;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThree.Location = new Point(187, 236);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(59, 56);
            btnThree.TabIndex = 3;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFour.Location = new Point(31, 165);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(59, 56);
            btnFour.TabIndex = 4;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSix.Location = new Point(187, 165);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(59, 56);
            btnSix.TabIndex = 5;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnZero.Location = new Point(31, 307);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(215, 56);
            btnZero.TabIndex = 6;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEight.Location = new Point(110, 93);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(59, 56);
            btnEight.TabIndex = 7;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNine.Location = new Point(187, 93);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(59, 56);
            btnNine.TabIndex = 8;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeven.Location = new Point(31, 93);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(59, 56);
            btnSeven.TabIndex = 9;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFive.Location = new Point(110, 165);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(59, 56);
            btnFive.TabIndex = 10;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += button10_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(301, 165);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(59, 56);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubstract
            // 
            btnSubstract.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubstract.Location = new Point(388, 165);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(59, 56);
            btnSubstract.TabIndex = 12;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = true;
            btnSubstract.Click += btnSubstract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiply.Location = new Point(301, 236);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(59, 56);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.Location = new Point(388, 236);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(59, 56);
            btnDivide.TabIndex = 14;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(388, 93);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(59, 56);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.Location = new Point(301, 307);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(146, 56);
            btnEquals.TabIndex = 16;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnPoint
            // 
            btnPoint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPoint.Location = new Point(301, 93);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(59, 56);
            btnPoint.TabIndex = 17;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnPoint_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 375);
            Controls.Add(btnPoint);
            Controls.Add(btnEquals);
            Controls.Add(btnClear);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubstract);
            Controls.Add(btnAdd);
            Controls.Add(btnFive);
            Controls.Add(btnSeven);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnZero);
            Controls.Add(btnSix);
            Controls.Add(btnFour);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnFour;
        private Button btnSix;
        private Button btnZero;
        private Button btnEight;
        private Button btnNine;
        private Button btnSeven;
        private Button btnFive;
        private Button btnAdd;
        private Button btnSubstract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnClear;
        private Button btnEquals;
        private Button btnPoint;
    }
}