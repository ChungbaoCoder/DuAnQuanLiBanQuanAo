namespace QuanLiShopQuanAo.DataBaseConnection
{
    partial class frmDangNhap
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
            lblUserName = new Label();
            lblPassWord = new Label();
            txtUserName = new TextBox();
            txtPassWord = new TextBox();
            llblQuenMatKhau = new LinkLabel();
            btnLogin = new Button();
            picIcon1 = new PictureBox();
            picIcon2 = new PictureBox();
            lblTitle = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)picIcon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIcon2).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.None;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Light", 12F);
            lblUserName.Location = new Point(113, 142);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(92, 28);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Tài Khoản";
            // 
            // lblPassWord
            // 
            lblPassWord.Anchor = AnchorStyles.None;
            lblPassWord.AutoSize = true;
            lblPassWord.Font = new Font("Segoe UI Light", 12F);
            lblPassWord.Location = new Point(113, 224);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(93, 28);
            lblPassWord.TabIndex = 2;
            lblPassWord.Text = "Mật Khẩu";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.Font = new Font("Gadugi", 10.2F, FontStyle.Italic);
            txtUserName.Location = new Point(113, 173);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "NHẬP TÀI KHOẢN";
            txtUserName.Size = new Size(308, 30);
            txtUserName.TabIndex = 3;
            // 
            // txtPassWord
            // 
            txtPassWord.AccessibleDescription = "";
            txtPassWord.Anchor = AnchorStyles.None;
            txtPassWord.Font = new Font("Gadugi", 10.2F, FontStyle.Italic);
            txtPassWord.ForeColor = Color.Black;
            txtPassWord.Location = new Point(113, 255);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.PlaceholderText = "NHẬP MẬT KHẨU";
            txtPassWord.Size = new Size(308, 30);
            txtPassWord.TabIndex = 4;
            txtPassWord.Tag = "";
            // 
            // llblQuenMatKhau
            // 
            llblQuenMatKhau.Anchor = AnchorStyles.None;
            llblQuenMatKhau.AutoSize = true;
            llblQuenMatKhau.BackColor = Color.Black;
            llblQuenMatKhau.ForeColor = Color.Cornsilk;
            llblQuenMatKhau.Location = new Point(113, 320);
            llblQuenMatKhau.Name = "llblQuenMatKhau";
            llblQuenMatKhau.Size = new Size(120, 20);
            llblQuenMatKhau.TabIndex = 7;
            llblQuenMatKhau.TabStop = true;
            llblQuenMatKhau.Text = "Quên mật khẩu ?";
            llblQuenMatKhau.Click += llblQuenMK_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(271, 304);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 50);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // picIcon1
            // 
            picIcon1.Anchor = AnchorStyles.None;
            picIcon1.Image = Properties.Resources.user;
            picIcon1.Location = new Point(32, 157);
            picIcon1.Name = "picIcon1";
            picIcon1.Size = new Size(65, 61);
            picIcon1.SizeMode = PictureBoxSizeMode.Zoom;
            picIcon1.TabIndex = 8;
            picIcon1.TabStop = false;
            // 
            // picIcon2
            // 
            picIcon2.Anchor = AnchorStyles.None;
            picIcon2.Image = Properties.Resources.padlock;
            picIcon2.Location = new Point(32, 224);
            picIcon2.Name = "picIcon2";
            picIcon2.Size = new Size(65, 61);
            picIcon2.SizeMode = PictureBoxSizeMode.Zoom;
            picIcon2.TabIndex = 9;
            picIcon2.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(151, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(195, 32);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "CHÀO MỪNG";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(433, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 29);
            btnClose.TabIndex = 11;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += button1_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(478, 478);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Controls.Add(picIcon2);
            Controls.Add(picIcon1);
            Controls.Add(btnLogin);
            Controls.Add(llblQuenMatKhau);
            Controls.Add(txtPassWord);
            Controls.Add(txtUserName);
            Controls.Add(lblPassWord);
            Controls.Add(lblUserName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            FormClosing += frmDangNhap_FormClosing;
            ResizeEnd += frmDangNhap_ResizeEnd;
            ((System.ComponentModel.ISupportInitialize)picIcon1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIcon2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblPassWord;
        private TextBox txtUserName;
        private TextBox txtPassWord;
        private LinkLabel llblQuenMatKhau;
        private Button btnLogin;
        private PictureBox picIcon1;
        private PictureBox picIcon2;
        private Label lblTitle;
        private Button btnClose;
    }
}