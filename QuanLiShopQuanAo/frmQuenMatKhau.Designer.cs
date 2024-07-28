namespace QuanLiShopQuanAo
{
    partial class frmQuenMatKhau
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
            btnGuiDoiEmail = new Button();
            txtMatKhauCu = new TextBox();
            lblMatKhauCu = new Label();
            txtMatKhauMoi = new TextBox();
            lblMatKhauMoi = new Label();
            txtXacNhanMatKhauMoi = new TextBox();
            lblXacNhanMatKhauMoi = new Label();
            btnGuiDoiMatKhau = new Button();
            lblTitle = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            llblQuenMatKhau = new LinkLabel();
            llblDoiMatKhau = new LinkLabel();
            SuspendLayout();
            // 
            // btnGuiDoiEmail
            // 
            btnGuiDoiEmail.Anchor = AnchorStyles.None;
            btnGuiDoiEmail.BackColor = Color.FromArgb(64, 64, 64);
            btnGuiDoiEmail.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuiDoiEmail.ForeColor = Color.White;
            btnGuiDoiEmail.Location = new Point(347, 375);
            btnGuiDoiEmail.Name = "btnGuiDoiEmail";
            btnGuiDoiEmail.Size = new Size(150, 50);
            btnGuiDoiEmail.TabIndex = 45;
            btnGuiDoiEmail.Text = "Gửi Email";
            btnGuiDoiEmail.UseVisualStyleBackColor = false;
            btnGuiDoiEmail.Click += btnGuiEmail_Click;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Anchor = AnchorStyles.None;
            txtMatKhauCu.Font = new Font("Segoe UI", 12F);
            txtMatKhauCu.Location = new Point(294, 157);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(450, 34);
            txtMatKhauCu.TabIndex = 47;
            txtMatKhauCu.Visible = false;
            // 
            // lblMatKhauCu
            // 
            lblMatKhauCu.Anchor = AnchorStyles.None;
            lblMatKhauCu.AutoSize = true;
            lblMatKhauCu.Font = new Font("Segoe UI Light", 13F);
            lblMatKhauCu.Location = new Point(39, 159);
            lblMatKhauCu.Name = "lblMatKhauCu";
            lblMatKhauCu.Size = new Size(134, 30);
            lblMatKhauCu.TabIndex = 48;
            lblMatKhauCu.Text = "Mật Khẩu Cũ";
            lblMatKhauCu.Visible = false;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Anchor = AnchorStyles.None;
            txtMatKhauMoi.Font = new Font("Segoe UI", 12F);
            txtMatKhauMoi.Location = new Point(294, 226);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(450, 34);
            txtMatKhauMoi.TabIndex = 49;
            txtMatKhauMoi.Visible = false;
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.Anchor = AnchorStyles.None;
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Font = new Font("Segoe UI Light", 13F);
            lblMatKhauMoi.Location = new Point(39, 228);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(143, 30);
            lblMatKhauMoi.TabIndex = 50;
            lblMatKhauMoi.Text = "Mật Khẩu Mới";
            lblMatKhauMoi.Visible = false;
            // 
            // txtXacNhanMatKhauMoi
            // 
            txtXacNhanMatKhauMoi.Anchor = AnchorStyles.None;
            txtXacNhanMatKhauMoi.Font = new Font("Segoe UI", 12F);
            txtXacNhanMatKhauMoi.Location = new Point(294, 296);
            txtXacNhanMatKhauMoi.Name = "txtXacNhanMatKhauMoi";
            txtXacNhanMatKhauMoi.Size = new Size(450, 34);
            txtXacNhanMatKhauMoi.TabIndex = 51;
            txtXacNhanMatKhauMoi.Visible = false;
            // 
            // lblXacNhanMatKhauMoi
            // 
            lblXacNhanMatKhauMoi.Anchor = AnchorStyles.None;
            lblXacNhanMatKhauMoi.AutoSize = true;
            lblXacNhanMatKhauMoi.Font = new Font("Segoe UI Light", 13F);
            lblXacNhanMatKhauMoi.Location = new Point(39, 298);
            lblXacNhanMatKhauMoi.Name = "lblXacNhanMatKhauMoi";
            lblXacNhanMatKhauMoi.Size = new Size(239, 30);
            lblXacNhanMatKhauMoi.TabIndex = 52;
            lblXacNhanMatKhauMoi.Text = "Xác Nhận Mật Khẩu Mới";
            lblXacNhanMatKhauMoi.Visible = false;
            // 
            // btnGuiDoiMatKhau
            // 
            btnGuiDoiMatKhau.Anchor = AnchorStyles.None;
            btnGuiDoiMatKhau.BackColor = Color.FromArgb(64, 64, 64);
            btnGuiDoiMatKhau.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuiDoiMatKhau.ForeColor = Color.White;
            btnGuiDoiMatKhau.Location = new Point(514, 375);
            btnGuiDoiMatKhau.Name = "btnGuiDoiMatKhau";
            btnGuiDoiMatKhau.Size = new Size(230, 50);
            btnGuiDoiMatKhau.TabIndex = 55;
            btnGuiDoiMatKhau.Text = "Gửi Email Đổi Mật Khẩu";
            btnGuiDoiMatKhau.UseVisualStyleBackColor = false;
            btnGuiDoiMatKhau.Visible = false;
            btnGuiDoiMatKhau.Click += btnGuiDoiMatKhau_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Light", 20F);
            lblTitle.Location = new Point(294, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(243, 46);
            lblTitle.TabIndex = 56;
            lblTitle.Text = "Quên Mật Khẩu";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Light", 13F);
            lblEmail.Location = new Point(39, 88);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 30);
            lblEmail.TabIndex = 57;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(294, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(450, 34);
            txtEmail.TabIndex = 56;
            // 
            // llblQuenMatKhau
            // 
            llblQuenMatKhau.Anchor = AnchorStyles.None;
            llblQuenMatKhau.AutoSize = true;
            llblQuenMatKhau.Font = new Font("Segoe UI", 11F);
            llblQuenMatKhau.Location = new Point(39, 387);
            llblQuenMatKhau.Name = "llblQuenMatKhau";
            llblQuenMatKhau.Size = new Size(153, 25);
            llblQuenMatKhau.TabIndex = 54;
            llblQuenMatKhau.TabStop = true;
            llblQuenMatKhau.Text = "Quên Mật Khẩu?";
            llblQuenMatKhau.Visible = false;
            llblQuenMatKhau.LinkClicked += llblQuenMatKhau_LinkClicked;
            // 
            // llblDoiMatKhau
            // 
            llblDoiMatKhau.Anchor = AnchorStyles.None;
            llblDoiMatKhau.AutoSize = true;
            llblDoiMatKhau.Font = new Font("Segoe UI", 11F);
            llblDoiMatKhau.Location = new Point(39, 151);
            llblDoiMatKhau.Name = "llblDoiMatKhau";
            llblDoiMatKhau.Size = new Size(136, 25);
            llblDoiMatKhau.TabIndex = 53;
            llblDoiMatKhau.TabStop = true;
            llblDoiMatKhau.Text = "Đổi Mật Khẩu?";
            llblDoiMatKhau.Click += llblDoiMatKhau_Click;
            // 
            // frmQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 458);
            Controls.Add(lblXacNhanMatKhauMoi);
            Controls.Add(llblDoiMatKhau);
            Controls.Add(btnGuiDoiMatKhau);
            Controls.Add(lblMatKhauMoi);
            Controls.Add(lblMatKhauCu);
            Controls.Add(txtXacNhanMatKhauMoi);
            Controls.Add(txtMatKhauCu);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(lblEmail);
            Controls.Add(lblTitle);
            Controls.Add(txtEmail);
            Controls.Add(btnGuiDoiEmail);
            Controls.Add(llblQuenMatKhau);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmQuenMatKhau";
            Text = "frmQuenMatKhau";
            ResizeEnd += frmQuenMatKhau_ResizeEnd;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDoiMatKhauEmail;
        private Button btnGuiDoiEmail;
        private TextBox txtMatKhauCu;
        private Label lblMatKhauCu;
        private TextBox txtMatKhauMoi;
        private Label lblMatKhauMoi;
        private TextBox txtXacNhanMatKhauMoi;
        private Label lblXacNhanMatKhauMoi;
        private Button btnGuiDoiMatKhau;
        private Button button1;
        private Button button2;
        private Label lblTitle;
        private Label lblEmail;
        private TextBox txtEmail;
        private LinkLabel llblDoiMatKhau;
        private LinkLabel llblQuenMatKhau;
    }
}