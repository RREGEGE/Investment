namespace Investment
{
    partial class SignUp
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblName = new Label();
            lblID = new Label();
            picBoxExit = new PictureBox();
            tbName = new TextBox();
            tbID = new TextBox();
            lblPW = new Label();
            lbNumber = new Label();
            tbPW = new TextBox();
            ttbNumber = new TextBox();
            btnSignUp = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxExit).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(27, 38, 59);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.Controls.Add(lblName, 1, 1);
            tableLayoutPanel1.Controls.Add(lblID, 1, 2);
            tableLayoutPanel1.Controls.Add(picBoxExit, 3, 0);
            tableLayoutPanel1.Controls.Add(tbName, 2, 1);
            tableLayoutPanel1.Controls.Add(tbID, 2, 2);
            tableLayoutPanel1.Controls.Add(lblPW, 1, 3);
            tableLayoutPanel1.Controls.Add(lbNumber, 1, 4);
            tableLayoutPanel1.Controls.Add(tbPW, 2, 3);
            tableLayoutPanel1.Controls.Add(ttbNumber, 2, 4);
            tableLayoutPanel1.Controls.Add(btnSignUp, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Microsoft Sans Serif", 8.25F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(297, 317);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(42, 42);
            lblName.Margin = new Padding(1, 4, 2, 4);
            lblName.Name = "lblName";
            lblName.Size = new Size(74, 30);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            lblName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Dock = DockStyle.Fill;
            lblID.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.White;
            lblID.Location = new Point(42, 80);
            lblID.Margin = new Padding(1, 4, 2, 4);
            lblID.Name = "lblID";
            lblID.Size = new Size(74, 30);
            lblID.TabIndex = 1;
            lblID.Text = "ID:";
            lblID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picBoxExit
            // 
            picBoxExit.Dock = DockStyle.Right;
            picBoxExit.Image = Properties.Resources.x_mark;
            picBoxExit.Location = new Point(257, 3);
            picBoxExit.Name = "picBoxExit";
            picBoxExit.Size = new Size(37, 32);
            picBoxExit.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxExit.TabIndex = 4;
            picBoxExit.TabStop = false;
            // 
            // tbName
            // 
            tbName.Dock = DockStyle.Fill;
            tbName.Location = new Point(121, 43);
            tbName.Margin = new Padding(3, 5, 3, 5);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(130, 28);
            tbName.TabIndex = 5;
            // 
            // tbID
            // 
            tbID.Dock = DockStyle.Fill;
            tbID.Location = new Point(121, 81);
            tbID.Margin = new Padding(3, 5, 3, 5);
            tbID.Multiline = true;
            tbID.Name = "tbID";
            tbID.Size = new Size(130, 28);
            tbID.TabIndex = 6;
            // 
            // lblPW
            // 
            lblPW.AutoSize = true;
            lblPW.Dock = DockStyle.Fill;
            lblPW.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPW.ForeColor = Color.White;
            lblPW.Location = new Point(42, 118);
            lblPW.Margin = new Padding(1, 4, 2, 4);
            lblPW.Name = "lblPW";
            lblPW.Size = new Size(74, 30);
            lblPW.TabIndex = 7;
            lblPW.Text = "Password:";
            lblPW.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbNumber
            // 
            lbNumber.AutoSize = true;
            lbNumber.Dock = DockStyle.Fill;
            lbNumber.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNumber.ForeColor = Color.White;
            lbNumber.Location = new Point(42, 156);
            lbNumber.Margin = new Padding(1, 4, 2, 4);
            lbNumber.Name = "lbNumber";
            lbNumber.Size = new Size(74, 30);
            lbNumber.TabIndex = 8;
            lbNumber.Text = "Mobile:";
            lbNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbPW
            // 
            tbPW.Dock = DockStyle.Fill;
            tbPW.Location = new Point(121, 119);
            tbPW.Margin = new Padding(3, 5, 3, 5);
            tbPW.Multiline = true;
            tbPW.Name = "tbPW";
            tbPW.Size = new Size(130, 28);
            tbPW.TabIndex = 9;
            // 
            // ttbNumber
            // 
            ttbNumber.Dock = DockStyle.Fill;
            ttbNumber.Location = new Point(121, 157);
            ttbNumber.Margin = new Padding(3, 5, 3, 5);
            ttbNumber.Multiline = true;
            ttbNumber.Name = "ttbNumber";
            ttbNumber.Size = new Size(130, 28);
            ttbNumber.TabIndex = 10;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(30, 64, 175);
            btnSignUp.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.SetColumnSpan(btnSignUp, 2);
            btnSignUp.Dock = DockStyle.Fill;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(44, 226);
            btnSignUp.Margin = new Padding(3, 5, 3, 0);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(207, 58);
            btnSignUp.TabIndex = 11;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 317);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            StartPosition = FormStartPosition.Manual;
            Text = "SignUp";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblName;
        private Label lblID;
        private PictureBox picBoxExit;
        private TextBox tbName;
        private TextBox tbID;
        private Label lblPW;
        private Label lbNumber;
        private TextBox tbPW;
        private TextBox ttbNumber;
        private Button btnSignUp;
    }
}