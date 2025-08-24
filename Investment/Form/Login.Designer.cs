namespace Investment
{
    partial class Login
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
            tbID = new TextBox();
            lblID = new Label();
            lblPW = new Label();
            tbPW = new TextBox();
            btnLogin = new Button();
            btnSignUp = new Button();
            picBoxExit = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxExit).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(27, 38, 59);
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.99310684F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.9264736F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.5545959F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.76291F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.76291F));
            tableLayoutPanel1.Controls.Add(tbID, 2, 1);
            tableLayoutPanel1.Controls.Add(lblID, 1, 1);
            tableLayoutPanel1.Controls.Add(lblPW, 1, 2);
            tableLayoutPanel1.Controls.Add(tbPW, 2, 2);
            tableLayoutPanel1.Controls.Add(btnLogin, 3, 1);
            tableLayoutPanel1.Controls.Add(btnSignUp, 2, 3);
            tableLayoutPanel1.Controls.Add(picBoxExit, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Microsoft Sans Serif", 8.25F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(509, 227);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tbID
            // 
            tbID.Dock = DockStyle.Fill;
            tbID.Font = new Font("Microsoft Sans Serif", 14.25F);
            tbID.Location = new Point(180, 40);
            tbID.Multiline = true;
            tbID.Name = "tbID";
            tbID.PlaceholderText = "Enter your ID";
            tbID.Size = new Size(205, 44);
            tbID.TabIndex = 1;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Dock = DockStyle.Fill;
            lblID.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            lblID.ForeColor = Color.White;
            lblID.Location = new Point(16, 41);
            lblID.Margin = new Padding(1, 4, 2, 4);
            lblID.Name = "lblID";
            lblID.Size = new Size(159, 42);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            lblID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPW
            // 
            lblPW.AutoSize = true;
            lblPW.Dock = DockStyle.Fill;
            lblPW.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            lblPW.ForeColor = Color.White;
            lblPW.Location = new Point(16, 91);
            lblPW.Margin = new Padding(1, 4, 2, 4);
            lblPW.Name = "lblPW";
            lblPW.Size = new Size(159, 42);
            lblPW.TabIndex = 1;
            lblPW.Text = "PASSWORD:";
            lblPW.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbPW
            // 
            tbPW.Dock = DockStyle.Fill;
            tbPW.Font = new Font("Microsoft Sans Serif", 14.25F);
            tbPW.Location = new Point(180, 90);
            tbPW.Multiline = true;
            tbPW.Name = "tbPW";
            tbPW.PasswordChar = '*';
            tbPW.PlaceholderText = "Enter your Password";
            tbPW.Size = new Size(205, 44);
            tbPW.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(30, 64, 175);
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.SetColumnSpan(btnLogin, 2);
            btnLogin.Dock = DockStyle.Fill;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(398, 40);
            btnLogin.Margin = new Padding(10, 3, 3, 3);
            btnLogin.Name = "btnLogin";
            tableLayoutPanel1.SetRowSpan(btnLogin, 2);
            btnLogin.Size = new Size(108, 94);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(27, 38, 59);
            btnSignUp.BackgroundImageLayout = ImageLayout.None;
            btnSignUp.Dock = DockStyle.Fill;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(180, 142);
            btnSignUp.Margin = new Padding(3, 5, 3, 0);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(205, 45);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // picBoxExit
            // 
            picBoxExit.Dock = DockStyle.Right;
            picBoxExit.Image = Properties.Resources.x_mark;
            picBoxExit.Location = new Point(466, 3);
            picBoxExit.Name = "picBoxExit";
            picBoxExit.Size = new Size(40, 31);
            picBoxExit.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxExit.TabIndex = 4;
            picBoxExit.TabStop = false;
            picBoxExit.Click += picBoxExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 227);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbID;
        private Label lblID;
        private Label lblPW;
        private TextBox tbPW;
        private Button btnLogin;
        private PictureBox picBoxExit;
        private Button btnSignUp;
    }
}