namespace QuanLiShopQuanAo
{
    partial class frmMainMenu
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
            flpDashBoard = new FlowLayoutPanel();
            pnlDashBoard = new Panel();
            lblDashBoard = new Label();
            pnlHoaDon = new Panel();
            picHoaDonIcon = new PictureBox();
            btnHoaDon = new Button();
            pnlKhachHang = new Panel();
            picKhachHangIcon = new PictureBox();
            btnKhachHang = new Button();
            pnlNhanVien = new Panel();
            picNhanVienIcon = new PictureBox();
            btnNhanVien = new Button();
            pnlNhaCungCap = new Panel();
            picNhaCungCapIcon = new PictureBox();
            btnNhaCungCap = new Button();
            pnlKho = new Panel();
            picKhoIcon = new PictureBox();
            btnKho = new Button();
            pnlHoTro = new Panel();
            picHoTro = new PictureBox();
            btnHoTro = new Button();
            pnlTop = new Panel();
            lblTrangChu = new Label();
            picIconTrangChu = new PictureBox();
            pnlHelloUser = new Panel();
            picAnhNhanVien = new PictureBox();
            lblChao = new Label();
            lblUserName = new Label();
            pnlContent = new Panel();
            lblTitleWelcome = new Label();
            picAnhMainMenu = new PictureBox();
            flpDashBoard.SuspendLayout();
            pnlDashBoard.SuspendLayout();
            pnlHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHoaDonIcon).BeginInit();
            pnlKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picKhachHangIcon).BeginInit();
            pnlNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNhanVienIcon).BeginInit();
            pnlNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNhaCungCapIcon).BeginInit();
            pnlKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picKhoIcon).BeginInit();
            pnlHoTro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHoTro).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconTrangChu).BeginInit();
            pnlHelloUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhNhanVien).BeginInit();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhMainMenu).BeginInit();
            SuspendLayout();
            // 
            // flpDashBoard
            // 
            flpDashBoard.BackColor = SystemColors.ActiveCaption;
            flpDashBoard.Controls.Add(pnlDashBoard);
            flpDashBoard.Controls.Add(pnlHoaDon);
            flpDashBoard.Controls.Add(pnlKhachHang);
            flpDashBoard.Controls.Add(pnlNhanVien);
            flpDashBoard.Controls.Add(pnlNhaCungCap);
            flpDashBoard.Controls.Add(pnlKho);
            flpDashBoard.Controls.Add(pnlHoTro);
            flpDashBoard.Dock = DockStyle.Left;
            flpDashBoard.Location = new Point(0, 0);
            flpDashBoard.Name = "flpDashBoard";
            flpDashBoard.Size = new Size(196, 513);
            flpDashBoard.TabIndex = 0;
            // 
            // pnlDashBoard
            // 
            pnlDashBoard.BorderStyle = BorderStyle.Fixed3D;
            pnlDashBoard.Controls.Add(lblDashBoard);
            pnlDashBoard.Location = new Point(3, 3);
            pnlDashBoard.Name = "pnlDashBoard";
            pnlDashBoard.Size = new Size(190, 65);
            pnlDashBoard.TabIndex = 2;
            // 
            // lblDashBoard
            // 
            lblDashBoard.Anchor = AnchorStyles.None;
            lblDashBoard.AutoSize = true;
            lblDashBoard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblDashBoard.ForeColor = SystemColors.ControlText;
            lblDashBoard.ImageAlign = ContentAlignment.BottomLeft;
            lblDashBoard.Location = new Point(7, 18);
            lblDashBoard.Name = "lblDashBoard";
            lblDashBoard.Size = new Size(174, 25);
            lblDashBoard.TabIndex = 4;
            lblDashBoard.Text = "Bảng Điều Khiển";
            lblDashBoard.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlHoaDon
            // 
            pnlHoaDon.Controls.Add(picHoaDonIcon);
            pnlHoaDon.Controls.Add(btnHoaDon);
            pnlHoaDon.Location = new Point(3, 74);
            pnlHoaDon.Name = "pnlHoaDon";
            pnlHoaDon.Size = new Size(185, 53);
            pnlHoaDon.TabIndex = 6;
            // 
            // picHoaDonIcon
            // 
            picHoaDonIcon.Image = Properties.Resources.list_icon;
            picHoaDonIcon.Location = new Point(3, 3);
            picHoaDonIcon.Name = "picHoaDonIcon";
            picHoaDonIcon.Size = new Size(48, 45);
            picHoaDonIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picHoaDonIcon.TabIndex = 0;
            picHoaDonIcon.TabStop = false;
            // 
            // btnHoaDon
            // 
            btnHoaDon.AutoSize = true;
            btnHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHoaDon.Location = new Point(3, 3);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(218, 45);
            btnHoaDon.TabIndex = 1;
            btnHoaDon.Text = "Hóa Đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // pnlKhachHang
            // 
            pnlKhachHang.Controls.Add(picKhachHangIcon);
            pnlKhachHang.Controls.Add(btnKhachHang);
            pnlKhachHang.Location = new Point(3, 133);
            pnlKhachHang.Name = "pnlKhachHang";
            pnlKhachHang.Size = new Size(185, 53);
            pnlKhachHang.TabIndex = 8;
            // 
            // picKhachHangIcon
            // 
            picKhachHangIcon.Image = Properties.Resources.customer_icon;
            picKhachHangIcon.Location = new Point(3, 3);
            picKhachHangIcon.Name = "picKhachHangIcon";
            picKhachHangIcon.Size = new Size(48, 45);
            picKhachHangIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picKhachHangIcon.TabIndex = 0;
            picKhachHangIcon.TabStop = false;
            // 
            // btnKhachHang
            // 
            btnKhachHang.AutoSize = true;
            btnKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKhachHang.Location = new Point(3, 3);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(218, 45);
            btnKhachHang.TabIndex = 1;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // pnlNhanVien
            // 
            pnlNhanVien.Controls.Add(picNhanVienIcon);
            pnlNhanVien.Controls.Add(btnNhanVien);
            pnlNhanVien.Location = new Point(3, 192);
            pnlNhanVien.Name = "pnlNhanVien";
            pnlNhanVien.Size = new Size(185, 53);
            pnlNhanVien.TabIndex = 9;
            // 
            // picNhanVienIcon
            // 
            picNhanVienIcon.Image = Properties.Resources.staff_icon;
            picNhanVienIcon.Location = new Point(3, 3);
            picNhanVienIcon.Name = "picNhanVienIcon";
            picNhanVienIcon.Size = new Size(48, 45);
            picNhanVienIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picNhanVienIcon.TabIndex = 0;
            picNhanVienIcon.TabStop = false;
            // 
            // btnNhanVien
            // 
            btnNhanVien.AutoSize = true;
            btnNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNhanVien.Location = new Point(3, 3);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(218, 45);
            btnNhanVien.TabIndex = 1;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // pnlNhaCungCap
            // 
            pnlNhaCungCap.Controls.Add(picNhaCungCapIcon);
            pnlNhaCungCap.Controls.Add(btnNhaCungCap);
            pnlNhaCungCap.Location = new Point(3, 251);
            pnlNhaCungCap.Name = "pnlNhaCungCap";
            pnlNhaCungCap.Size = new Size(185, 53);
            pnlNhaCungCap.TabIndex = 10;
            // 
            // picNhaCungCapIcon
            // 
            picNhaCungCapIcon.Image = Properties.Resources.shop_icon;
            picNhaCungCapIcon.Location = new Point(3, 3);
            picNhaCungCapIcon.Name = "picNhaCungCapIcon";
            picNhaCungCapIcon.Size = new Size(48, 45);
            picNhaCungCapIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picNhaCungCapIcon.TabIndex = 0;
            picNhaCungCapIcon.TabStop = false;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.AutoSize = true;
            btnNhaCungCap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNhaCungCap.Location = new Point(3, 3);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Size = new Size(234, 45);
            btnNhaCungCap.TabIndex = 1;
            btnNhaCungCap.Text = "Nhà Cung Cấp";
            btnNhaCungCap.UseVisualStyleBackColor = true;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // pnlKho
            // 
            pnlKho.Controls.Add(picKhoIcon);
            pnlKho.Controls.Add(btnKho);
            pnlKho.Location = new Point(3, 310);
            pnlKho.Name = "pnlKho";
            pnlKho.Size = new Size(185, 53);
            pnlKho.TabIndex = 5;
            // 
            // picKhoIcon
            // 
            picKhoIcon.Image = Properties.Resources.supplies_icon;
            picKhoIcon.Location = new Point(3, 3);
            picKhoIcon.Name = "picKhoIcon";
            picKhoIcon.Size = new Size(48, 45);
            picKhoIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picKhoIcon.TabIndex = 0;
            picKhoIcon.TabStop = false;
            // 
            // btnKho
            // 
            btnKho.AutoSize = true;
            btnKho.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKho.Location = new Point(3, 3);
            btnKho.Name = "btnKho";
            btnKho.Size = new Size(218, 45);
            btnKho.TabIndex = 1;
            btnKho.Text = "Kho";
            btnKho.UseVisualStyleBackColor = true;
            btnKho.Click += btnKho_Click;
            // 
            // pnlHoTro
            // 
            pnlHoTro.Controls.Add(picHoTro);
            pnlHoTro.Controls.Add(btnHoTro);
            pnlHoTro.Location = new Point(3, 369);
            pnlHoTro.Name = "pnlHoTro";
            pnlHoTro.Size = new Size(185, 53);
            pnlHoTro.TabIndex = 11;
            // 
            // picHoTro
            // 
            picHoTro.Image = Properties.Resources.con_nice;
            picHoTro.Location = new Point(3, 3);
            picHoTro.Name = "picHoTro";
            picHoTro.Size = new Size(48, 45);
            picHoTro.SizeMode = PictureBoxSizeMode.Zoom;
            picHoTro.TabIndex = 2;
            picHoTro.TabStop = false;
            // 
            // btnHoTro
            // 
            btnHoTro.AutoSize = true;
            btnHoTro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHoTro.Location = new Point(48, 3);
            btnHoTro.Name = "btnHoTro";
            btnHoTro.Size = new Size(134, 45);
            btnHoTro.TabIndex = 1;
            btnHoTro.Text = "Hỗ Trợ";
            btnHoTro.UseVisualStyleBackColor = true;
            btnHoTro.Click += btnHoTro_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = SystemColors.ActiveBorder;
            pnlTop.Controls.Add(lblTrangChu);
            pnlTop.Controls.Add(picIconTrangChu);
            pnlTop.Controls.Add(pnlHelloUser);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(196, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(667, 71);
            pnlTop.TabIndex = 1;
            // 
            // lblTrangChu
            // 
            lblTrangChu.AutoSize = true;
            lblTrangChu.Location = new Point(92, 19);
            lblTrangChu.Name = "lblTrangChu";
            lblTrangChu.Size = new Size(123, 32);
            lblTrangChu.TabIndex = 4;
            lblTrangChu.Text = "Trang Chủ";
            // 
            // picIconTrangChu
            // 
            picIconTrangChu.Image = Properties.Resources.home;
            picIconTrangChu.Location = new Point(6, 3);
            picIconTrangChu.Name = "picIconTrangChu";
            picIconTrangChu.Size = new Size(80, 65);
            picIconTrangChu.SizeMode = PictureBoxSizeMode.Zoom;
            picIconTrangChu.TabIndex = 3;
            picIconTrangChu.TabStop = false;
            picIconTrangChu.Click += picIconTrangChu_Click;
            // 
            // pnlHelloUser
            // 
            pnlHelloUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlHelloUser.Controls.Add(picAnhNhanVien);
            pnlHelloUser.Controls.Add(lblChao);
            pnlHelloUser.Controls.Add(lblUserName);
            pnlHelloUser.Location = new Point(371, 0);
            pnlHelloUser.Name = "pnlHelloUser";
            pnlHelloUser.Size = new Size(296, 68);
            pnlHelloUser.TabIndex = 2;
            // 
            // picAnhNhanVien
            // 
            picAnhNhanVien.Location = new Point(97, 3);
            picAnhNhanVien.Name = "picAnhNhanVien";
            picAnhNhanVien.Size = new Size(54, 62);
            picAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhNhanVien.TabIndex = 5;
            picAnhNhanVien.TabStop = false;
            // 
            // lblChao
            // 
            lblChao.Anchor = AnchorStyles.None;
            lblChao.AutoSize = true;
            lblChao.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChao.ImageAlign = ContentAlignment.BottomLeft;
            lblChao.Location = new Point(17, 19);
            lblChao.Name = "lblChao";
            lblChao.Size = new Size(74, 29);
            lblChao.TabIndex = 6;
            lblChao.Text = "Chào";
            lblChao.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.None;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblUserName.ImageAlign = ContentAlignment.BottomLeft;
            lblUserName.Location = new Point(157, 19);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(86, 29);
            lblUserName.TabIndex = 5;
            lblUserName.Text = "Admin";
            lblUserName.TextAlign = ContentAlignment.TopCenter;
            lblUserName.Click += lblUserName_Click;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(lblTitleWelcome);
            pnlContent.Controls.Add(picAnhMainMenu);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(196, 71);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(667, 442);
            pnlContent.TabIndex = 2;
            // 
            // lblTitleWelcome
            // 
            lblTitleWelcome.Anchor = AnchorStyles.Top;
            lblTitleWelcome.AutoSize = true;
            lblTitleWelcome.BackColor = Color.DarkGray;
            lblTitleWelcome.ForeColor = Color.Black;
            lblTitleWelcome.Location = new Point(92, 0);
            lblTitleWelcome.Name = "lblTitleWelcome";
            lblTitleWelcome.Size = new Size(492, 32);
            lblTitleWelcome.TabIndex = 5;
            lblTitleWelcome.Text = "CHÀO MỪNG ĐẾN VỚI SHOP QUẦN ÁO ABC";
            // 
            // picAnhMainMenu
            // 
            picAnhMainMenu.Dock = DockStyle.Fill;
            picAnhMainMenu.Image = Properties.Resources.chào_mừng_bạn_đến_với;
            picAnhMainMenu.Location = new Point(0, 0);
            picAnhMainMenu.Name = "picAnhMainMenu";
            picAnhMainMenu.Size = new Size(667, 442);
            picAnhMainMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhMainMenu.TabIndex = 0;
            picAnhMainMenu.TabStop = false;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 513);
            Controls.Add(pnlContent);
            Controls.Add(pnlTop);
            Controls.Add(flpDashBoard);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frmMainMenu";
            Text = "Màn hình chính";
            FormClosing += frmMainMenu_FormClosing;
            Load += frmMainMenu_Load;
            flpDashBoard.ResumeLayout(false);
            pnlDashBoard.ResumeLayout(false);
            pnlDashBoard.PerformLayout();
            pnlHoaDon.ResumeLayout(false);
            pnlHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHoaDonIcon).EndInit();
            pnlKhachHang.ResumeLayout(false);
            pnlKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picKhachHangIcon).EndInit();
            pnlNhanVien.ResumeLayout(false);
            pnlNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNhanVienIcon).EndInit();
            pnlNhaCungCap.ResumeLayout(false);
            pnlNhaCungCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNhaCungCapIcon).EndInit();
            pnlKho.ResumeLayout(false);
            pnlKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picKhoIcon).EndInit();
            pnlHoTro.ResumeLayout(false);
            pnlHoTro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHoTro).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconTrangChu).EndInit();
            pnlHelloUser.ResumeLayout(false);
            pnlHelloUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhNhanVien).EndInit();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhMainMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpDashBoard;
        private Panel pnlTop;
        private Panel pnlKho;
        private Button btnKho;
        private PictureBox picKhoIcon;
        private Panel pnlHoaDon;
        private Button btnHoaDon;
        private PictureBox picHoaDonIcon;
        private Panel pnlKhachHang;
        private Button btnKhachHang;
        private PictureBox picKhachHangIcon;
        private Panel pnlNhanVien;
        private Button btnNhanVien;
        private PictureBox picNhanVienIcon;
        private Panel pnlDashBoard;
        private Label lblDashBoard;
        private Panel pnlHelloUser;
        private Label lblUserName;
        private Label lblChao;
        private Label lblTrangChu;
        private PictureBox picIconTrangChu;
        private Panel pnlContent;
        private Panel pnlNhaCungCap;
        private PictureBox picNhaCungCapIcon;
        private Button btnNhaCungCap;
        private PictureBox picAnhNhanVien;
        private PictureBox picAnhMainMenu;
        private Label lblTitleWelcome;
        private Panel pnlHoTro;
        private Button btnHoTro;
        private PictureBox picHoTro;
    }
}