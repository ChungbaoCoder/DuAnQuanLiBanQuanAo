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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            lblUserName = new Label();
            lblPassWord = new Label();
            txtUserName = new TextBox();
            txtPassWord = new TextBox();
            llblQuenMatKhau = new LinkLabel();
            btnLogin = new Button();
            picIcon1 = new PictureBox();
            picIcon2 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)picIcon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIcon2).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.None;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Light", 12F);
            lblUserName.Location = new Point(157, 183);
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
            lblPassWord.Location = new Point(157, 265);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(93, 28);
            lblPassWord.TabIndex = 2;
            lblPassWord.Text = "Mật Khẩu";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.Font = new Font("Gadugi", 10.2F, FontStyle.Italic);
            txtUserName.Location = new Point(157, 214);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "NHẬP TÀI KHOẢN";
            txtUserName.Size = new Size(309, 30);
            txtUserName.TabIndex = 3;
            // 
            // txtPassWord
            // 
            txtPassWord.AccessibleDescription = "";
            txtPassWord.Anchor = AnchorStyles.None;
            txtPassWord.Font = new Font("Gadugi", 10.2F, FontStyle.Italic);
            txtPassWord.ForeColor = Color.Black;
            txtPassWord.Location = new Point(157, 296);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.PlaceholderText = "NHẬP MẬT KHẨU";
            txtPassWord.Size = new Size(309, 30);
            txtPassWord.TabIndex = 4;
            txtPassWord.Tag = "";
            // 
            // llblQuenMatKhau
            // 
            linklblQuenMK.Anchor = AnchorStyles.None;
            linklblQuenMK.AutoSize = true;
            linklblQuenMK.Location = new Point(157, 361);
            linklblQuenMK.Name = "linklblQuenMK";
            linklblQuenMK.Size = new Size(120, 20);
            linklblQuenMK.TabIndex = 6;
            linklblQuenMK.TabStop = true;
            linklblQuenMK.Text = "Quên mật khẩu ?";
            linklblQuenMK.LinkClicked += linklblQuenMK_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(64, 64, 64);
            btnLogin.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(315, 346);

            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 50);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // picIcon1
            // 
            picIcon1.Anchor = AnchorStyles.None;
            picIcon1.Image = (Image)resources.GetObject("picIcon1.Image");
            picIcon1.Location = new Point(76, 198);
            picIcon1.Name = "picIcon1";
            picIcon1.Size = new Size(65, 61);
            picIcon1.SizeMode = PictureBoxSizeMode.StretchImage;
            picIcon1.TabIndex = 8;
            picIcon1.TabStop = false;
            // 
            // picIcon2
            // 
            picIcon2.Anchor = AnchorStyles.None;
            picIcon2.Image = (Image)resources.GetObject("picIcon2.Image");
            picIcon2.Location = new Point(76, 265);
            picIcon2.Name = "picIcon2";
            picIcon2.Size = new Size(65, 61);
            picIcon2.SizeMode = PictureBoxSizeMode.StretchImage;
            picIcon2.TabIndex = 9;
            picIcon2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 126);
            label1.Name = "label1";
            label1.Size = new Size(195, 32);
            label1.TabIndex = 10;
            label1.Text = "CHÀO MỪNG";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(527, 12);
            button1.Name = "button1";
            button1.Size = new Size(28, 29);
            button1.TabIndex = 11;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(567, 568);
            Controls.Add(button1);
            Controls.Add(label1);
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
        private Label label1;
        private Button button1;
    }
}