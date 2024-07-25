namespace QuanLiShopQuanAo
{
    partial class frmKhachHang
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
            msDashBoard = new MenuStrip();
            tslDashBoard = new ToolStripLabel();
            tsmiSanPham = new ToolStripMenuItem();
            tsmiKho = new ToolStripMenuItem();
            tsmiHoaDon = new ToolStripMenuItem();
            tsmiNhanVien = new ToolStripMenuItem();
            tsmiNhaCungCap = new ToolStripMenuItem();
            btnTaiLaiDanhSach = new Button();
            btnTimKhachHang = new Button();
            txtTimKiemKhachHang = new TextBox();
            grpThemKhachHang = new GroupBox();
            lblThemSDTKhachHang = new Label();
            btnClearThemKhachHang = new Button();
            btnLuuThemKhachHang = new Button();
            lblThemKhachHang = new Label();
            txtThemDiaChiKhachHang = new TextBox();
            txtThemSDTKhachHang = new TextBox();
            txtThemTenKhachHang = new TextBox();
            lblThemTenKhachHang = new Label();
            lblThemDiaChiKhachHang = new Label();
            btnChonTatCa = new Button();
            dgvKhachHang = new DataGridView();
            dgvhCheckBoxKH = new DataGridViewCheckBoxColumn();
            dgvhMaKH = new DataGridViewTextBoxColumn();
            dgvhTenKH = new DataGridViewTextBoxColumn();
            dgvhSDTKH = new DataGridViewTextBoxColumn();
            dgvhDiaChiKH = new DataGridViewTextBoxColumn();
            grpSuaKhachHang = new GroupBox();
            btnClearSuaKhachHang = new Button();
            lblSuaKhachHang = new Label();
            txtSuaTenKhachHang = new TextBox();
            lblSuaMaKhachHang = new Label();
            txtSuaMaKhachHang = new TextBox();
            lblSuaTenKhachHang = new Label();
            txtSuaDiaChiKhachHang = new TextBox();
            lblSuaDiaChiKhachHang = new Label();
            txtSuaSDTKhachHang = new TextBox();
            btnLuuSuaKhachHang = new Button();
            lblSuaSDTKhachHang = new Label();
            btnSuaKhach = new Button();
            btnXoaKhach = new Button();
            btnThemKhach = new Button();
            msDashBoard.SuspendLayout();
            grpThemKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            grpSuaKhachHang.SuspendLayout();
            SuspendLayout();
            // 
            // msDashBoard
            // 
            msDashBoard.AutoSize = false;
            msDashBoard.Dock = DockStyle.Left;
            msDashBoard.ImageScalingSize = new Size(20, 20);
            msDashBoard.Items.AddRange(new ToolStripItem[] { tslDashBoard, tsmiSanPham, tsmiKho, tsmiHoaDon, tsmiNhanVien, tsmiNhaCungCap });
            msDashBoard.Location = new Point(0, 0);
            msDashBoard.Name = "msDashBoard";
            msDashBoard.Padding = new Padding(5, 2, 0, 2);
            msDashBoard.Size = new Size(172, 791);
            msDashBoard.TabIndex = 37;
            msDashBoard.Text = "menuStrip1";
            // 
            // tslDashBoard
            // 
            tslDashBoard.Font = new Font("Segoe UI", 17F);
            tslDashBoard.Name = "tslDashBoard";
            tslDashBoard.Size = new Size(166, 40);
            tslDashBoard.Text = "Dash Board";
            tslDashBoard.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tsmiSanPham
            // 
            tsmiSanPham.Font = new Font("Segoe UI", 11F);
            tsmiSanPham.Margin = new Padding(0, 10, 0, 10);
            tsmiSanPham.Name = "tsmiSanPham";
            tsmiSanPham.Size = new Size(166, 29);
            tsmiSanPham.Text = "Sản Phẩm";
            tsmiSanPham.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tsmiKho
            // 
            tsmiKho.Font = new Font("Segoe UI", 11F);
            tsmiKho.Margin = new Padding(0, 0, 0, 10);
            tsmiKho.Name = "tsmiKho";
            tsmiKho.Size = new Size(166, 29);
            tsmiKho.Text = "Kho";
            tsmiKho.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tsmiHoaDon
            // 
            tsmiHoaDon.Font = new Font("Segoe UI", 11F);
            tsmiHoaDon.Margin = new Padding(0, 0, 0, 10);
            tsmiHoaDon.Name = "tsmiHoaDon";
            tsmiHoaDon.Size = new Size(166, 29);
            tsmiHoaDon.Text = "Hoá Đơn";
            tsmiHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tsmiNhanVien
            // 
            tsmiNhanVien.Font = new Font("Segoe UI", 11F);
            tsmiNhanVien.Margin = new Padding(0, 0, 0, 10);
            tsmiNhanVien.Name = "tsmiNhanVien";
            tsmiNhanVien.Size = new Size(166, 29);
            tsmiNhanVien.Text = "Nhân Viên";
            tsmiNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tsmiNhaCungCap
            // 
            tsmiNhaCungCap.Font = new Font("Segoe UI", 11F);
            tsmiNhaCungCap.Margin = new Padding(0, 0, 0, 10);
            tsmiNhaCungCap.Name = "tsmiNhaCungCap";
            tsmiNhaCungCap.Size = new Size(166, 29);
            tsmiNhaCungCap.Text = "Nhà Cung Cấp";
            tsmiNhaCungCap.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnTaiLaiDanhSach
            // 
            btnTaiLaiDanhSach.Location = new Point(467, 427);
            btnTaiLaiDanhSach.Name = "btnTaiLaiDanhSach";
            btnTaiLaiDanhSach.Size = new Size(180, 45);
            btnTaiLaiDanhSach.TabIndex = 58;
            btnTaiLaiDanhSach.Text = "Tải Lại Danh Sách";
            btnTaiLaiDanhSach.UseVisualStyleBackColor = true;
            btnTaiLaiDanhSach.Click += btnTaiLaiDanhSach_Click;
            // 
            // btnTimKhachHang
            // 
            btnTimKhachHang.Font = new Font("Segoe UI", 12F);
            btnTimKhachHang.Location = new Point(1039, 432);
            btnTimKhachHang.Name = "btnTimKhachHang";
            btnTimKhachHang.Size = new Size(140, 34);
            btnTimKhachHang.TabIndex = 50;
            btnTimKhachHang.Text = "Tìm";
            btnTimKhachHang.UseVisualStyleBackColor = true;
            btnTimKhachHang.Click += btnTimKhachHang_Click;
            // 
            // txtTimKiemKhachHang
            // 
            txtTimKiemKhachHang.Font = new Font("Segoe UI", 12F);
            txtTimKiemKhachHang.Location = new Point(667, 432);
            txtTimKiemKhachHang.Name = "txtTimKiemKhachHang";
            txtTimKiemKhachHang.Size = new Size(362, 34);
            txtTimKiemKhachHang.TabIndex = 57;
            // 
            // grpThemKhachHang
            // 
            grpThemKhachHang.Controls.Add(lblThemSDTKhachHang);
            grpThemKhachHang.Controls.Add(btnClearThemKhachHang);
            grpThemKhachHang.Controls.Add(btnLuuThemKhachHang);
            grpThemKhachHang.Controls.Add(lblThemKhachHang);
            grpThemKhachHang.Controls.Add(txtThemDiaChiKhachHang);
            grpThemKhachHang.Controls.Add(txtThemSDTKhachHang);
            grpThemKhachHang.Controls.Add(txtThemTenKhachHang);
            grpThemKhachHang.Controls.Add(lblThemTenKhachHang);
            grpThemKhachHang.Controls.Add(lblThemDiaChiKhachHang);
            grpThemKhachHang.Location = new Point(175, 529);
            grpThemKhachHang.Name = "grpThemKhachHang";
            grpThemKhachHang.Size = new Size(486, 251);
            grpThemKhachHang.TabIndex = 56;
            grpThemKhachHang.TabStop = false;
            // 
            // lblThemSDTKhachHang
            // 
            lblThemSDTKhachHang.AutoSize = true;
            lblThemSDTKhachHang.Font = new Font("Segoe UI", 13F);
            lblThemSDTKhachHang.Location = new Point(9, 123);
            lblThemSDTKhachHang.Name = "lblThemSDTKhachHang";
            lblThemSDTKhachHang.Size = new Size(147, 30);
            lblThemSDTKhachHang.TabIndex = 36;
            lblThemSDTKhachHang.Text = "Số Điện Thoại";
            // 
            // btnClearThemKhachHang
            // 
            btnClearThemKhachHang.Font = new Font("Segoe UI", 12F);
            btnClearThemKhachHang.Location = new Point(228, 203);
            btnClearThemKhachHang.Name = "btnClearThemKhachHang";
            btnClearThemKhachHang.Size = new Size(120, 34);
            btnClearThemKhachHang.TabIndex = 37;
            btnClearThemKhachHang.Text = "Clear";
            btnClearThemKhachHang.UseVisualStyleBackColor = true;
            btnClearThemKhachHang.Click += btnClearThemKhachHang_Click;
            // 
            // btnLuuThemKhachHang
            // 
            btnLuuThemKhachHang.Font = new Font("Segoe UI", 12F);
            btnLuuThemKhachHang.Location = new Point(353, 203);
            btnLuuThemKhachHang.Name = "btnLuuThemKhachHang";
            btnLuuThemKhachHang.Size = new Size(120, 33);
            btnLuuThemKhachHang.TabIndex = 36;
            btnLuuThemKhachHang.Text = "Lưu";
            btnLuuThemKhachHang.UseVisualStyleBackColor = true;
            btnLuuThemKhachHang.Click += btnLuuThemKhachHang_Click;
            // 
            // lblThemKhachHang
            // 
            lblThemKhachHang.AutoSize = true;
            lblThemKhachHang.Font = new Font("Segoe UI", 14F);
            lblThemKhachHang.Location = new Point(6, 21);
            lblThemKhachHang.Name = "lblThemKhachHang";
            lblThemKhachHang.Size = new Size(327, 32);
            lblThemKhachHang.TabIndex = 36;
            lblThemKhachHang.Text = "Thêm Thông Tin Khách Hàng";
            // 
            // txtThemDiaChiKhachHang
            // 
            txtThemDiaChiKhachHang.Font = new Font("Segoe UI", 12F);
            txtThemDiaChiKhachHang.Location = new Point(183, 163);
            txtThemDiaChiKhachHang.Name = "txtThemDiaChiKhachHang";
            txtThemDiaChiKhachHang.Size = new Size(290, 34);
            txtThemDiaChiKhachHang.TabIndex = 47;
            // 
            // txtThemSDTKhachHang
            // 
            txtThemSDTKhachHang.Font = new Font("Segoe UI", 12F);
            txtThemSDTKhachHang.Location = new Point(183, 119);
            txtThemSDTKhachHang.Name = "txtThemSDTKhachHang";
            txtThemSDTKhachHang.Size = new Size(290, 34);
            txtThemSDTKhachHang.TabIndex = 45;
            // 
            // txtThemTenKhachHang
            // 
            txtThemTenKhachHang.Font = new Font("Segoe UI", 12F);
            txtThemTenKhachHang.Location = new Point(183, 75);
            txtThemTenKhachHang.Name = "txtThemTenKhachHang";
            txtThemTenKhachHang.Size = new Size(290, 34);
            txtThemTenKhachHang.TabIndex = 41;
            // 
            // lblThemTenKhachHang
            // 
            lblThemTenKhachHang.AutoSize = true;
            lblThemTenKhachHang.Font = new Font("Segoe UI", 13F);
            lblThemTenKhachHang.Location = new Point(6, 79);
            lblThemTenKhachHang.Name = "lblThemTenKhachHang";
            lblThemTenKhachHang.Size = new Size(169, 30);
            lblThemTenKhachHang.TabIndex = 42;
            lblThemTenKhachHang.Text = "Tên Khách Hàng";
            // 
            // lblThemDiaChiKhachHang
            // 
            lblThemDiaChiKhachHang.AutoSize = true;
            lblThemDiaChiKhachHang.Font = new Font("Segoe UI", 13F);
            lblThemDiaChiKhachHang.Location = new Point(9, 165);
            lblThemDiaChiKhachHang.Name = "lblThemDiaChiKhachHang";
            lblThemDiaChiKhachHang.Size = new Size(81, 30);
            lblThemDiaChiKhachHang.TabIndex = 38;
            lblThemDiaChiKhachHang.Text = "Địa Chỉ";
            // 
            // btnChonTatCa
            // 
            btnChonTatCa.Location = new Point(175, 427);
            btnChonTatCa.Name = "btnChonTatCa";
            btnChonTatCa.Size = new Size(140, 45);
            btnChonTatCa.TabIndex = 53;
            btnChonTatCa.Text = "Chọn Tất Cả";
            btnChonTatCa.UseVisualStyleBackColor = true;
            btnChonTatCa.Click += btnChonTatCa_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AllowUserToResizeColumns = false;
            dgvKhachHang.AllowUserToResizeRows = false;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { dgvhCheckBoxKH, dgvhMaKH, dgvhTenKH, dgvhSDTKH, dgvhDiaChiKH });
            dgvKhachHang.Location = new Point(175, 12);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(1003, 400);
            dgvKhachHang.TabIndex = 51;
            // 
            // dgvhCheckBoxKH
            // 
            dgvhCheckBoxKH.HeaderText = "";
            dgvhCheckBoxKH.MinimumWidth = 6;
            dgvhCheckBoxKH.Name = "dgvhCheckBoxKH";
            dgvhCheckBoxKH.Width = 25;
            // 
            // dgvhMaKH
            // 
            dgvhMaKH.HeaderText = "Mã Khách Hàng";
            dgvhMaKH.MinimumWidth = 6;
            dgvhMaKH.Name = "dgvhMaKH";
            dgvhMaKH.ReadOnly = true;
            dgvhMaKH.Width = 200;
            // 
            // dgvhTenKH
            // 
            dgvhTenKH.HeaderText = "Tên Khách Hàng";
            dgvhTenKH.MinimumWidth = 6;
            dgvhTenKH.Name = "dgvhTenKH";
            dgvhTenKH.ReadOnly = true;
            dgvhTenKH.Width = 250;
            // 
            // dgvhSDTKH
            // 
            dgvhSDTKH.HeaderText = "SĐT";
            dgvhSDTKH.MinimumWidth = 6;
            dgvhSDTKH.Name = "dgvhSDTKH";
            dgvhSDTKH.ReadOnly = true;
            dgvhSDTKH.Width = 225;
            // 
            // dgvhDiaChiKH
            // 
            dgvhDiaChiKH.HeaderText = "Địa Chỉ";
            dgvhDiaChiKH.MinimumWidth = 6;
            dgvhDiaChiKH.Name = "dgvhDiaChiKH";
            dgvhDiaChiKH.ReadOnly = true;
            dgvhDiaChiKH.Width = 300;
            // 
            // grpSuaKhachHang
            // 
            grpSuaKhachHang.Controls.Add(btnClearSuaKhachHang);
            grpSuaKhachHang.Controls.Add(lblSuaKhachHang);
            grpSuaKhachHang.Controls.Add(txtSuaTenKhachHang);
            grpSuaKhachHang.Controls.Add(lblSuaMaKhachHang);
            grpSuaKhachHang.Controls.Add(txtSuaMaKhachHang);
            grpSuaKhachHang.Controls.Add(lblSuaTenKhachHang);
            grpSuaKhachHang.Controls.Add(txtSuaDiaChiKhachHang);
            grpSuaKhachHang.Controls.Add(lblSuaDiaChiKhachHang);
            grpSuaKhachHang.Controls.Add(txtSuaSDTKhachHang);
            grpSuaKhachHang.Controls.Add(btnLuuSuaKhachHang);
            grpSuaKhachHang.Controls.Add(lblSuaSDTKhachHang);
            grpSuaKhachHang.Font = new Font("Segoe UI", 12F);
            grpSuaKhachHang.Location = new Point(667, 478);
            grpSuaKhachHang.Name = "grpSuaKhachHang";
            grpSuaKhachHang.Size = new Size(511, 302);
            grpSuaKhachHang.TabIndex = 55;
            grpSuaKhachHang.TabStop = false;
            // 
            // btnClearSuaKhachHang
            // 
            btnClearSuaKhachHang.Font = new Font("Segoe UI", 12F);
            btnClearSuaKhachHang.Location = new Point(242, 249);
            btnClearSuaKhachHang.Name = "btnClearSuaKhachHang";
            btnClearSuaKhachHang.Size = new Size(120, 34);
            btnClearSuaKhachHang.TabIndex = 35;
            btnClearSuaKhachHang.Text = "Clear";
            btnClearSuaKhachHang.UseVisualStyleBackColor = true;
            btnClearSuaKhachHang.Click += btnClearSuaKhachHang_Click;
            // 
            // lblSuaKhachHang
            // 
            lblSuaKhachHang.AutoSize = true;
            lblSuaKhachHang.Font = new Font("Segoe UI", 14F);
            lblSuaKhachHang.Location = new Point(10, 21);
            lblSuaKhachHang.Name = "lblSuaKhachHang";
            lblSuaKhachHang.Size = new Size(305, 32);
            lblSuaKhachHang.TabIndex = 34;
            lblSuaKhachHang.Text = "Sửa Thông Tin Khách Hàng";
            // 
            // txtSuaTenKhachHang
            // 
            txtSuaTenKhachHang.Font = new Font("Segoe UI", 12F);
            txtSuaTenKhachHang.Location = new Point(187, 121);
            txtSuaTenKhachHang.Name = "txtSuaTenKhachHang";
            txtSuaTenKhachHang.Size = new Size(300, 34);
            txtSuaTenKhachHang.TabIndex = 32;
            // 
            // lblSuaMaKhachHang
            // 
            lblSuaMaKhachHang.AutoSize = true;
            lblSuaMaKhachHang.Font = new Font("Segoe UI", 13F);
            lblSuaMaKhachHang.Location = new Point(6, 79);
            lblSuaMaKhachHang.Name = "lblSuaMaKhachHang";
            lblSuaMaKhachHang.Size = new Size(166, 30);
            lblSuaMaKhachHang.TabIndex = 18;
            lblSuaMaKhachHang.Text = "Mã Khách Hàng";
            // 
            // txtSuaMaKhachHang
            // 
            txtSuaMaKhachHang.Font = new Font("Segoe UI", 12F);
            txtSuaMaKhachHang.Location = new Point(187, 77);
            txtSuaMaKhachHang.Name = "txtSuaMaKhachHang";
            txtSuaMaKhachHang.ReadOnly = true;
            txtSuaMaKhachHang.Size = new Size(300, 34);
            txtSuaMaKhachHang.TabIndex = 22;
            // 
            // lblSuaTenKhachHang
            // 
            lblSuaTenKhachHang.AutoSize = true;
            lblSuaTenKhachHang.Font = new Font("Segoe UI", 13F);
            lblSuaTenKhachHang.Location = new Point(6, 123);
            lblSuaTenKhachHang.Name = "lblSuaTenKhachHang";
            lblSuaTenKhachHang.Size = new Size(169, 30);
            lblSuaTenKhachHang.TabIndex = 33;
            lblSuaTenKhachHang.Text = "Tên Khách Hàng";
            // 
            // txtSuaDiaChiKhachHang
            // 
            txtSuaDiaChiKhachHang.Font = new Font("Segoe UI", 12F);
            txtSuaDiaChiKhachHang.Location = new Point(187, 209);
            txtSuaDiaChiKhachHang.Name = "txtSuaDiaChiKhachHang";
            txtSuaDiaChiKhachHang.Size = new Size(300, 34);
            txtSuaDiaChiKhachHang.TabIndex = 23;
            // 
            // lblSuaDiaChiKhachHang
            // 
            lblSuaDiaChiKhachHang.AutoSize = true;
            lblSuaDiaChiKhachHang.Font = new Font("Segoe UI", 13F);
            lblSuaDiaChiKhachHang.Location = new Point(6, 211);
            lblSuaDiaChiKhachHang.Name = "lblSuaDiaChiKhachHang";
            lblSuaDiaChiKhachHang.Size = new Size(81, 30);
            lblSuaDiaChiKhachHang.TabIndex = 24;
            lblSuaDiaChiKhachHang.Text = "Địa Chỉ";
            // 
            // txtSuaSDTKhachHang
            // 
            txtSuaSDTKhachHang.Font = new Font("Segoe UI", 12F);
            txtSuaSDTKhachHang.Location = new Point(187, 165);
            txtSuaSDTKhachHang.Name = "txtSuaSDTKhachHang";
            txtSuaSDTKhachHang.Size = new Size(300, 34);
            txtSuaSDTKhachHang.TabIndex = 25;
            // 
            // btnLuuSuaKhachHang
            // 
            btnLuuSuaKhachHang.Font = new Font("Segoe UI", 12F);
            btnLuuSuaKhachHang.Location = new Point(367, 249);
            btnLuuSuaKhachHang.Name = "btnLuuSuaKhachHang";
            btnLuuSuaKhachHang.Size = new Size(120, 33);
            btnLuuSuaKhachHang.TabIndex = 19;
            btnLuuSuaKhachHang.Text = "Lưu";
            btnLuuSuaKhachHang.UseVisualStyleBackColor = true;
            btnLuuSuaKhachHang.Click += btnLuuSuaKhachHang_Click;
            // 
            // lblSuaSDTKhachHang
            // 
            lblSuaSDTKhachHang.AutoSize = true;
            lblSuaSDTKhachHang.Font = new Font("Segoe UI", 13F);
            lblSuaSDTKhachHang.Location = new Point(6, 167);
            lblSuaSDTKhachHang.Name = "lblSuaSDTKhachHang";
            lblSuaSDTKhachHang.Size = new Size(147, 30);
            lblSuaSDTKhachHang.TabIndex = 26;
            lblSuaSDTKhachHang.Text = "Số Điện Thoại";
            // 
            // btnSuaKhach
            // 
            btnSuaKhach.Location = new Point(321, 478);
            btnSuaKhach.Name = "btnSuaKhach";
            btnSuaKhach.Size = new Size(140, 45);
            btnSuaKhach.TabIndex = 59;
            btnSuaKhach.Text = "Sửa Khách";
            btnSuaKhach.UseVisualStyleBackColor = true;
            btnSuaKhach.Click += btnSuaKhach_Click;
            // 
            // btnXoaKhach
            // 
            btnXoaKhach.Location = new Point(321, 427);
            btnXoaKhach.Name = "btnXoaKhach";
            btnXoaKhach.Size = new Size(140, 45);
            btnXoaKhach.TabIndex = 60;
            btnXoaKhach.Text = "Xoá Khách";
            btnXoaKhach.UseVisualStyleBackColor = true;
            btnXoaKhach.Click += btnXoaKhach_Click;
            // 
            // btnThemKhach
            // 
            btnThemKhach.Location = new Point(175, 478);
            btnThemKhach.Name = "btnThemKhach";
            btnThemKhach.Size = new Size(140, 45);
            btnThemKhach.TabIndex = 61;
            btnThemKhach.Text = "Thêm Khách";
            btnThemKhach.UseVisualStyleBackColor = true;
            btnThemKhach.Click += btnThemKhach_Click;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 791);
            Controls.Add(btnThemKhach);
            Controls.Add(btnXoaKhach);
            Controls.Add(btnSuaKhach);
            Controls.Add(btnTaiLaiDanhSach);
            Controls.Add(btnTimKhachHang);
            Controls.Add(txtTimKiemKhachHang);
            Controls.Add(grpThemKhachHang);
            Controls.Add(btnChonTatCa);
            Controls.Add(dgvKhachHang);
            Controls.Add(grpSuaKhachHang);
            Controls.Add(msDashBoard);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            Load += frmKhachHang_Load;
            msDashBoard.ResumeLayout(false);
            msDashBoard.PerformLayout();
            grpThemKhachHang.ResumeLayout(false);
            grpThemKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            grpSuaKhachHang.ResumeLayout(false);
            grpSuaKhachHang.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msDashBoard;
        private ToolStripLabel tslDashBoard;
        private ToolStripMenuItem tsmiSanPham;
        private ToolStripMenuItem tsmiKho;
        private ToolStripMenuItem tsmiHoaDon;
        private ToolStripMenuItem tsmiNhanVien;
        private ToolStripMenuItem tsmiNhaCungCap;
        private Button btnTaiLaiDanhSach;
        private Button btnTimKhachHang;
        private TextBox txtTimKiemKhachHang;
        private GroupBox grpThemKhachHang;
        private TextBox txtThemDiaChiKhachHang;
        private Label lblSDT;
        private TextBox txtThemSDTKhachHang;
        private TextBox txtThemTenKhachHang;
        private Label lblThemTenKhachHang;
        private Label lblThemDiaChiKhachHang;
        private Button btnChonTatCa;
        private DataGridView dgvKhachHang;
        private GroupBox grpSuaKhachHang;
        private Button btnClearSuaKhachHang;
        private Label lblSuaKhachHang;
        private TextBox txtSuaTenKhachHang;
        private Label lblSuaMaKhachHang;
        private TextBox txtSuaMaKhachHang;
        private Label lblSuaTenKhachHang;
        private TextBox txtSuaDiaChiKhachHang;
        private Button btnLuuSuaKhachHang;
        private Label lblSuaDiaChiKhachHang;
        private TextBox txtSuaSDTKhachHang;
        private Label lblSuaSDTKhachHang;
        private Button btnSuaKhach;
        private Button btnXoaKhach;
        private Label lblThemKhachHang;
        private Button btnClearThemKhachHang;
        private Button btnLuuThemKhachHang;
        private Label lblThemSDTKhachHang;
        private DataGridViewCheckBoxColumn dgvhCheckBoxKH;
        private DataGridViewTextBoxColumn dgvhMaKH;
        private DataGridViewTextBoxColumn dgvhTenKH;
        private DataGridViewTextBoxColumn dgvhSDTKH;
        private DataGridViewTextBoxColumn dgvhDiaChiKH;
        private Button btnThemKhach;
    }
}