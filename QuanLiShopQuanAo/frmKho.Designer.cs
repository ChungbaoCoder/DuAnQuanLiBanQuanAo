﻿namespace QuanLiShopQuanAo
{
    partial class frmKho
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
            dgvSanPham = new DataGridView();
            dgvhCheckBoxSanPham = new DataGridViewCheckBoxColumn();
            dgvhMaSanPham = new DataGridViewTextBoxColumn();
            dgvhTenSanPham = new DataGridViewTextBoxColumn();
            dgvhLoaiSanPham = new DataGridViewTextBoxColumn();
            dgvhSoLuong = new DataGridViewTextBoxColumn();
            dgvhGiaSanPham = new DataGridViewTextBoxColumn();
            dgvhMaNhaCC = new DataGridViewTextBoxColumn();
            dgvhTrangThai = new DataGridViewTextBoxColumn();
            btnTaiLaiDanhSach = new Button();
            btnTimSanPham = new Button();
            txtTimKiemSanPham = new TextBox();
            grpThemSanPham = new GroupBox();
            btnMoFileThem = new Button();
            lblThemSanPham = new Label();
            rdoThemChuaBan = new RadioButton();
            rdoThemDangBan = new RadioButton();
            lblThemTrangThaiSanPham = new Label();
            btnClearThemSanPham = new Button();
            txtThemSoLuongSanPham = new TextBox();
            cmbThemNhaCungCap = new ComboBox();
            lblThemLoaiSanPham = new Label();
            txtThemGiaSanPham = new TextBox();
            txtThemLoaiSanPham = new TextBox();
            txtThemHinhAnhSanPham = new TextBox();
            lblThemGiaSanPham = new Label();
            lblThemHinhAnhSanPham = new Label();
            txtThemTenSanPham = new TextBox();
            btnLuuThemSanPham = new Button();
            lblThemTenSanPham = new Label();
            lblThemNhaCungCap = new Label();
            lblThemSoLuongSanPham = new Label();
            picAnhSanPham = new PictureBox();
            btnSuaSanPham = new Button();
            btnChonTatCa = new Button();
            btnXoaSanPham = new Button();
            grpSuaSanPham = new GroupBox();
            btnMoFileSua = new Button();
            lblSuaNhaCungCap = new Label();
            txtSuaHinhAnhSanPham = new TextBox();
            lblSuaHinhAnhSanPham = new Label();
            rdoSuaChuaBan = new RadioButton();
            rdoSuaDangBan = new RadioButton();
            txtSuaGiaSanPham = new TextBox();
            lblSuaTrangThaiSanPham = new Label();
            btnClearSuaSanPham = new Button();
            lblSuaSanPham = new Label();
            txtSuaTenSanPham = new TextBox();
            lblSuaMaSanPham = new Label();
            txtSuaMaSanPham = new TextBox();
            lblSuaTenSanPham = new Label();
            txtSuaSoLuongSanPham = new TextBox();
            btnLuuSuaSanPham = new Button();
            lblSuaSoLuongSanPham = new Label();
            txtSuaLoaiSanPham = new TextBox();
            lblSuaGiaSanPham = new Label();
            cmbSuaNhaCungCap = new ComboBox();
            lblSuaLoaiSanPham = new Label();
            msDashBoard = new MenuStrip();
            tslDashBoard = new ToolStripLabel();
            tsmiSanPham = new ToolStripMenuItem();
            tsmiKho = new ToolStripMenuItem();
            tsmiHoaDon = new ToolStripMenuItem();
            tsmiNhanVien = new ToolStripMenuItem();
            tsmiNhaCungCap = new ToolStripMenuItem();
            btnThemSanPham = new Button();
            lblAnhSanPham = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            grpThemSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhSanPham).BeginInit();
            grpSuaSanPham.SuspendLayout();
            msDashBoard.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.AllowUserToResizeColumns = false;
            dgvSanPham.AllowUserToResizeRows = false;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { dgvhCheckBoxSanPham, dgvhMaSanPham, dgvhTenSanPham, dgvhLoaiSanPham, dgvhSoLuong, dgvhGiaSanPham, dgvhMaNhaCC, dgvhTrangThai });
            dgvSanPham.Location = new Point(182, 12);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(1203, 400);
            dgvSanPham.TabIndex = 11;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // dgvhCheckBoxSanPham
            // 
            dgvhCheckBoxSanPham.HeaderText = "";
            dgvhCheckBoxSanPham.MinimumWidth = 6;
            dgvhCheckBoxSanPham.Name = "dgvhCheckBoxSanPham";
            dgvhCheckBoxSanPham.Width = 25;
            // 
            // dgvhMaSanPham
            // 
            dgvhMaSanPham.HeaderText = "Mã Sản Phẩm";
            dgvhMaSanPham.MinimumWidth = 6;
            dgvhMaSanPham.Name = "dgvhMaSanPham";
            dgvhMaSanPham.ReadOnly = true;
            dgvhMaSanPham.Width = 175;
            // 
            // dgvhTenSanPham
            // 
            dgvhTenSanPham.HeaderText = "Tên Sản Phẩm";
            dgvhTenSanPham.MinimumWidth = 6;
            dgvhTenSanPham.Name = "dgvhTenSanPham";
            dgvhTenSanPham.ReadOnly = true;
            dgvhTenSanPham.Width = 200;
            // 
            // dgvhLoaiSanPham
            // 
            dgvhLoaiSanPham.HeaderText = "Loại Sản Phẩm";
            dgvhLoaiSanPham.MinimumWidth = 6;
            dgvhLoaiSanPham.Name = "dgvhLoaiSanPham";
            dgvhLoaiSanPham.ReadOnly = true;
            dgvhLoaiSanPham.Width = 200;
            // 
            // dgvhSoLuong
            // 
            dgvhSoLuong.HeaderText = "Số Lượng";
            dgvhSoLuong.MinimumWidth = 6;
            dgvhSoLuong.Name = "dgvhSoLuong";
            dgvhSoLuong.ReadOnly = true;
            dgvhSoLuong.Width = 125;
            // 
            // dgvhGiaSanPham
            // 
            dgvhGiaSanPham.HeaderText = "Giá";
            dgvhGiaSanPham.MinimumWidth = 6;
            dgvhGiaSanPham.Name = "dgvhGiaSanPham";
            dgvhGiaSanPham.ReadOnly = true;
            dgvhGiaSanPham.Width = 125;
            // 
            // dgvhMaNhaCC
            // 
            dgvhMaNhaCC.HeaderText = "Mã Nhà Cung Cấp";
            dgvhMaNhaCC.MinimumWidth = 6;
            dgvhMaNhaCC.Name = "dgvhMaNhaCC";
            dgvhMaNhaCC.ReadOnly = true;
            dgvhMaNhaCC.Width = 200;
            // 
            // dgvhTrangThai
            // 
            dgvhTrangThai.HeaderText = "Trạng Thái";
            dgvhTrangThai.MinimumWidth = 6;
            dgvhTrangThai.Name = "dgvhTrangThai";
            dgvhTrangThai.ReadOnly = true;
            dgvhTrangThai.Width = 150;
            // 
            // btnTaiLaiDanhSach
            // 
            btnTaiLaiDanhSach.Location = new Point(514, 427);
            btnTaiLaiDanhSach.Name = "btnTaiLaiDanhSach";
            btnTaiLaiDanhSach.Size = new Size(180, 45);
            btnTaiLaiDanhSach.TabIndex = 57;
            btnTaiLaiDanhSach.Text = "Tải Lại Danh Sách";
            btnTaiLaiDanhSach.UseVisualStyleBackColor = true;
            btnTaiLaiDanhSach.Click += btnTaiLaiDanhSach_Click;
            // 
            // btnTimSanPham
            // 
            btnTimSanPham.Font = new Font("Segoe UI", 12F);
            btnTimSanPham.Location = new Point(1245, 432);
            btnTimSanPham.Name = "btnTimSanPham";
            btnTimSanPham.Size = new Size(140, 34);
            btnTimSanPham.TabIndex = 50;
            btnTimSanPham.Text = "Tìm";
            btnTimSanPham.UseVisualStyleBackColor = true;
            btnTimSanPham.Click += btnTimSanPham_Click;
            // 
            // txtTimKiemSanPham
            // 
            txtTimKiemSanPham.Font = new Font("Segoe UI", 12F);
            txtTimKiemSanPham.Location = new Point(901, 432);
            txtTimKiemSanPham.Name = "txtTimKiemSanPham";
            txtTimKiemSanPham.Size = new Size(338, 34);
            txtTimKiemSanPham.TabIndex = 56;
            // 
            // grpThemSanPham
            // 
            grpThemSanPham.Controls.Add(btnMoFileThem);
            grpThemSanPham.Controls.Add(lblThemSanPham);
            grpThemSanPham.Controls.Add(rdoThemChuaBan);
            grpThemSanPham.Controls.Add(rdoThemDangBan);
            grpThemSanPham.Controls.Add(lblThemTrangThaiSanPham);
            grpThemSanPham.Controls.Add(btnClearThemSanPham);
            grpThemSanPham.Controls.Add(txtThemSoLuongSanPham);
            grpThemSanPham.Controls.Add(cmbThemNhaCungCap);
            grpThemSanPham.Controls.Add(lblThemLoaiSanPham);
            grpThemSanPham.Controls.Add(txtThemGiaSanPham);
            grpThemSanPham.Controls.Add(txtThemLoaiSanPham);
            grpThemSanPham.Controls.Add(txtThemHinhAnhSanPham);
            grpThemSanPham.Controls.Add(lblThemGiaSanPham);
            grpThemSanPham.Controls.Add(lblThemHinhAnhSanPham);
            grpThemSanPham.Controls.Add(txtThemTenSanPham);
            grpThemSanPham.Controls.Add(btnLuuThemSanPham);
            grpThemSanPham.Controls.Add(lblThemTenSanPham);
            grpThemSanPham.Controls.Add(lblThemNhaCungCap);
            grpThemSanPham.Controls.Add(lblThemSoLuongSanPham);
            grpThemSanPham.Location = new Point(182, 531);
            grpThemSanPham.Name = "grpThemSanPham";
            grpThemSanPham.Size = new Size(472, 399);
            grpThemSanPham.TabIndex = 55;
            grpThemSanPham.TabStop = false;
            // 
            // btnMoFileThem
            // 
            btnMoFileThem.Location = new Point(380, 158);
            btnMoFileThem.Name = "btnMoFileThem";
            btnMoFileThem.Size = new Size(80, 34);
            btnMoFileThem.TabIndex = 56;
            btnMoFileThem.Text = "Mở File";
            btnMoFileThem.UseVisualStyleBackColor = true;
            btnMoFileThem.Click += btnMoFileThem_Click;
            // 
            // lblThemSanPham
            // 
            lblThemSanPham.AutoSize = true;
            lblThemSanPham.Font = new Font("Segoe UI", 14F);
            lblThemSanPham.Location = new Point(6, 21);
            lblThemSanPham.Name = "lblThemSanPham";
            lblThemSanPham.Size = new Size(304, 32);
            lblThemSanPham.TabIndex = 55;
            lblThemSanPham.Text = "Thêm Thông Tin Sản Phẩm";
            // 
            // rdoThemChuaBan
            // 
            rdoThemChuaBan.AutoSize = true;
            rdoThemChuaBan.Location = new Point(294, 287);
            rdoThemChuaBan.Name = "rdoThemChuaBan";
            rdoThemChuaBan.Size = new Size(115, 32);
            rdoThemChuaBan.TabIndex = 51;
            rdoThemChuaBan.TabStop = true;
            rdoThemChuaBan.Text = "Chưa Bán";
            rdoThemChuaBan.UseVisualStyleBackColor = true;
            // 
            // rdoThemDangBan
            // 
            rdoThemDangBan.AutoSize = true;
            rdoThemDangBan.Location = new Point(160, 287);
            rdoThemDangBan.Name = "rdoThemDangBan";
            rdoThemDangBan.Size = new Size(117, 32);
            rdoThemDangBan.TabIndex = 50;
            rdoThemDangBan.TabStop = true;
            rdoThemDangBan.Text = "Đang Bán";
            rdoThemDangBan.UseVisualStyleBackColor = true;
            // 
            // lblThemTrangThaiSanPham
            // 
            lblThemTrangThaiSanPham.AutoSize = true;
            lblThemTrangThaiSanPham.Font = new Font("Segoe UI", 13F);
            lblThemTrangThaiSanPham.Location = new Point(6, 288);
            lblThemTrangThaiSanPham.Name = "lblThemTrangThaiSanPham";
            lblThemTrangThaiSanPham.Size = new Size(113, 30);
            lblThemTrangThaiSanPham.TabIndex = 49;
            lblThemTrangThaiSanPham.Text = "Trạng Thái";
            // 
            // btnClearThemSanPham
            // 
            btnClearThemSanPham.Location = new Point(294, 333);
            btnClearThemSanPham.Name = "btnClearThemSanPham";
            btnClearThemSanPham.Size = new Size(80, 34);
            btnClearThemSanPham.TabIndex = 48;
            btnClearThemSanPham.Text = "Clear";
            btnClearThemSanPham.UseVisualStyleBackColor = true;
            btnClearThemSanPham.Click += btnClearThemSanPham_Click;
            // 
            // txtThemSoLuongSanPham
            // 
            txtThemSoLuongSanPham.Font = new Font("Segoe UI", 12F);
            txtThemSoLuongSanPham.Location = new Point(160, 201);
            txtThemSoLuongSanPham.Name = "txtThemSoLuongSanPham";
            txtThemSoLuongSanPham.Size = new Size(300, 34);
            txtThemSoLuongSanPham.TabIndex = 47;
            // 
            // cmbThemNhaCungCap
            // 
            cmbThemNhaCungCap.Font = new Font("Segoe UI", 11F);
            cmbThemNhaCungCap.FormattingEnabled = true;
            cmbThemNhaCungCap.Location = new Point(160, 333);
            cmbThemNhaCungCap.Name = "cmbThemNhaCungCap";
            cmbThemNhaCungCap.Size = new Size(128, 33);
            cmbThemNhaCungCap.TabIndex = 35;
            // 
            // lblThemLoaiSanPham
            // 
            lblThemLoaiSanPham.AutoSize = true;
            lblThemLoaiSanPham.Font = new Font("Segoe UI", 13F);
            lblThemLoaiSanPham.Location = new Point(6, 114);
            lblThemLoaiSanPham.Name = "lblThemLoaiSanPham";
            lblThemLoaiSanPham.Size = new Size(153, 30);
            lblThemLoaiSanPham.TabIndex = 46;
            lblThemLoaiSanPham.Text = "Loại Sản Phẩm";
            // 
            // txtThemGiaSanPham
            // 
            txtThemGiaSanPham.Font = new Font("Segoe UI", 12F);
            txtThemGiaSanPham.Location = new Point(160, 247);
            txtThemGiaSanPham.Name = "txtThemGiaSanPham";
            txtThemGiaSanPham.Size = new Size(300, 34);
            txtThemGiaSanPham.TabIndex = 43;
            // 
            // txtThemLoaiSanPham
            // 
            txtThemLoaiSanPham.Font = new Font("Segoe UI", 12F);
            txtThemLoaiSanPham.Location = new Point(160, 112);
            txtThemLoaiSanPham.Name = "txtThemLoaiSanPham";
            txtThemLoaiSanPham.Size = new Size(300, 34);
            txtThemLoaiSanPham.TabIndex = 45;
            // 
            // txtThemHinhAnhSanPham
            // 
            txtThemHinhAnhSanPham.Font = new Font("Segoe UI", 12F);
            txtThemHinhAnhSanPham.Location = new Point(160, 158);
            txtThemHinhAnhSanPham.Name = "txtThemHinhAnhSanPham";
            txtThemHinhAnhSanPham.Size = new Size(214, 34);
            txtThemHinhAnhSanPham.TabIndex = 36;
            // 
            // lblThemGiaSanPham
            // 
            lblThemGiaSanPham.AutoSize = true;
            lblThemGiaSanPham.Font = new Font("Segoe UI", 13F);
            lblThemGiaSanPham.Location = new Point(6, 247);
            lblThemGiaSanPham.Name = "lblThemGiaSanPham";
            lblThemGiaSanPham.Size = new Size(44, 30);
            lblThemGiaSanPham.TabIndex = 44;
            lblThemGiaSanPham.Text = "Giá";
            // 
            // lblThemHinhAnhSanPham
            // 
            lblThemHinhAnhSanPham.AutoSize = true;
            lblThemHinhAnhSanPham.Font = new Font("Segoe UI", 13F);
            lblThemHinhAnhSanPham.Location = new Point(6, 158);
            lblThemHinhAnhSanPham.Name = "lblThemHinhAnhSanPham";
            lblThemHinhAnhSanPham.Size = new Size(102, 30);
            lblThemHinhAnhSanPham.TabIndex = 35;
            lblThemHinhAnhSanPham.Text = "Hình Ảnh";
            // 
            // txtThemTenSanPham
            // 
            txtThemTenSanPham.Font = new Font("Segoe UI", 12F);
            txtThemTenSanPham.Location = new Point(160, 66);
            txtThemTenSanPham.Name = "txtThemTenSanPham";
            txtThemTenSanPham.Size = new Size(300, 34);
            txtThemTenSanPham.TabIndex = 41;
            // 
            // btnLuuThemSanPham
            // 
            btnLuuThemSanPham.Location = new Point(380, 333);
            btnLuuThemSanPham.Name = "btnLuuThemSanPham";
            btnLuuThemSanPham.Size = new Size(80, 34);
            btnLuuThemSanPham.TabIndex = 31;
            btnLuuThemSanPham.Text = "Thêm";
            btnLuuThemSanPham.UseVisualStyleBackColor = true;
            btnLuuThemSanPham.Click += btnLuuThemSanPham_Click;
            // 
            // lblThemTenSanPham
            // 
            lblThemTenSanPham.AutoSize = true;
            lblThemTenSanPham.Font = new Font("Segoe UI", 13F);
            lblThemTenSanPham.Location = new Point(6, 70);
            lblThemTenSanPham.Name = "lblThemTenSanPham";
            lblThemTenSanPham.Size = new Size(148, 30);
            lblThemTenSanPham.TabIndex = 42;
            lblThemTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // lblThemNhaCungCap
            // 
            lblThemNhaCungCap.AutoSize = true;
            lblThemNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblThemNhaCungCap.Location = new Point(6, 332);
            lblThemNhaCungCap.Name = "lblThemNhaCungCap";
            lblThemNhaCungCap.Size = new Size(153, 30);
            lblThemNhaCungCap.TabIndex = 40;
            lblThemNhaCungCap.Text = "Nhà Cung Cấp";
            // 
            // lblThemSoLuongSanPham
            // 
            lblThemSoLuongSanPham.AutoSize = true;
            lblThemSoLuongSanPham.Font = new Font("Segoe UI", 13F);
            lblThemSoLuongSanPham.Location = new Point(6, 203);
            lblThemSoLuongSanPham.Name = "lblThemSoLuongSanPham";
            lblThemSoLuongSanPham.Size = new Size(105, 30);
            lblThemSoLuongSanPham.TabIndex = 38;
            lblThemSoLuongSanPham.Text = "Số Lượng";
            // 
            // picAnhSanPham
            // 
            picAnhSanPham.Location = new Point(660, 544);
            picAnhSanPham.Name = "picAnhSanPham";
            picAnhSanPham.Size = new Size(235, 313);
            picAnhSanPham.TabIndex = 29;
            picAnhSanPham.TabStop = false;
            // 
            // btnSuaSanPham
            // 
            btnSuaSanPham.Location = new Point(348, 478);
            btnSuaSanPham.Name = "btnSuaSanPham";
            btnSuaSanPham.Size = new Size(160, 45);
            btnSuaSanPham.TabIndex = 53;
            btnSuaSanPham.Text = "Sửa Sản Phẩm";
            btnSuaSanPham.UseVisualStyleBackColor = true;
            btnSuaSanPham.Click += btnSuaSanPham_Click;
            // 
            // btnChonTatCa
            // 
            btnChonTatCa.Location = new Point(182, 427);
            btnChonTatCa.Name = "btnChonTatCa";
            btnChonTatCa.Size = new Size(160, 45);
            btnChonTatCa.TabIndex = 52;
            btnChonTatCa.Text = "Chọn Tất Cả";
            btnChonTatCa.UseVisualStyleBackColor = true;
            btnChonTatCa.Click += btnChonTatCa_Click;
            // 
            // btnXoaSanPham
            // 
            btnXoaSanPham.Location = new Point(348, 427);
            btnXoaSanPham.Name = "btnXoaSanPham";
            btnXoaSanPham.Size = new Size(160, 45);
            btnXoaSanPham.TabIndex = 51;
            btnXoaSanPham.Text = "Xoá Sản Phẩm";
            btnXoaSanPham.UseVisualStyleBackColor = true;
            btnXoaSanPham.Click += btnXoaSanPham_Click;
            // 
            // grpSuaSanPham
            // 
            grpSuaSanPham.Controls.Add(btnMoFileSua);
            grpSuaSanPham.Controls.Add(lblSuaNhaCungCap);
            grpSuaSanPham.Controls.Add(txtSuaHinhAnhSanPham);
            grpSuaSanPham.Controls.Add(lblSuaHinhAnhSanPham);
            grpSuaSanPham.Controls.Add(rdoSuaChuaBan);
            grpSuaSanPham.Controls.Add(rdoSuaDangBan);
            grpSuaSanPham.Controls.Add(txtSuaGiaSanPham);
            grpSuaSanPham.Controls.Add(lblSuaTrangThaiSanPham);
            grpSuaSanPham.Controls.Add(btnClearSuaSanPham);
            grpSuaSanPham.Controls.Add(lblSuaSanPham);
            grpSuaSanPham.Controls.Add(txtSuaTenSanPham);
            grpSuaSanPham.Controls.Add(lblSuaMaSanPham);
            grpSuaSanPham.Controls.Add(txtSuaMaSanPham);
            grpSuaSanPham.Controls.Add(lblSuaTenSanPham);
            grpSuaSanPham.Controls.Add(txtSuaSoLuongSanPham);
            grpSuaSanPham.Controls.Add(btnLuuSuaSanPham);
            grpSuaSanPham.Controls.Add(lblSuaSoLuongSanPham);
            grpSuaSanPham.Controls.Add(txtSuaLoaiSanPham);
            grpSuaSanPham.Controls.Add(lblSuaGiaSanPham);
            grpSuaSanPham.Controls.Add(cmbSuaNhaCungCap);
            grpSuaSanPham.Controls.Add(lblSuaLoaiSanPham);
            grpSuaSanPham.Font = new Font("Segoe UI", 12F);
            grpSuaSanPham.Location = new Point(901, 478);
            grpSuaSanPham.Name = "grpSuaSanPham";
            grpSuaSanPham.Size = new Size(484, 450);
            grpSuaSanPham.TabIndex = 54;
            grpSuaSanPham.TabStop = false;
            // 
            // btnMoFileSua
            // 
            btnMoFileSua.Location = new Point(387, 219);
            btnMoFileSua.Name = "btnMoFileSua";
            btnMoFileSua.Size = new Size(80, 34);
            btnMoFileSua.TabIndex = 59;
            btnMoFileSua.Text = "Mở File";
            btnMoFileSua.UseVisualStyleBackColor = true;
            btnMoFileSua.Click += btnMoFileSua_Click;
            // 
            // lblSuaNhaCungCap
            // 
            lblSuaNhaCungCap.AutoSize = true;
            lblSuaNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblSuaNhaCungCap.Location = new Point(6, 392);
            lblSuaNhaCungCap.Name = "lblSuaNhaCungCap";
            lblSuaNhaCungCap.Size = new Size(153, 30);
            lblSuaNhaCungCap.TabIndex = 52;
            lblSuaNhaCungCap.Text = "Nhà Cung Cấp";
            // 
            // txtSuaHinhAnhSanPham
            // 
            txtSuaHinhAnhSanPham.Font = new Font("Segoe UI", 12F);
            txtSuaHinhAnhSanPham.Location = new Point(187, 219);
            txtSuaHinhAnhSanPham.Name = "txtSuaHinhAnhSanPham";
            txtSuaHinhAnhSanPham.Size = new Size(194, 34);
            txtSuaHinhAnhSanPham.TabIndex = 58;
            // 
            // lblSuaHinhAnhSanPham
            // 
            lblSuaHinhAnhSanPham.AutoSize = true;
            lblSuaHinhAnhSanPham.Font = new Font("Segoe UI", 13F);
            lblSuaHinhAnhSanPham.Location = new Point(6, 223);
            lblSuaHinhAnhSanPham.Name = "lblSuaHinhAnhSanPham";
            lblSuaHinhAnhSanPham.Size = new Size(102, 30);
            lblSuaHinhAnhSanPham.TabIndex = 57;
            lblSuaHinhAnhSanPham.Text = "Hình Ảnh";
            // 
            // rdoSuaChuaBan
            // 
            rdoSuaChuaBan.AutoSize = true;
            rdoSuaChuaBan.Location = new Point(325, 349);
            rdoSuaChuaBan.Name = "rdoSuaChuaBan";
            rdoSuaChuaBan.Size = new Size(115, 32);
            rdoSuaChuaBan.TabIndex = 54;
            rdoSuaChuaBan.TabStop = true;
            rdoSuaChuaBan.Text = "Chưa Bán";
            rdoSuaChuaBan.UseVisualStyleBackColor = true;
            // 
            // rdoSuaDangBan
            // 
            rdoSuaDangBan.AutoSize = true;
            rdoSuaDangBan.Location = new Point(191, 349);
            rdoSuaDangBan.Name = "rdoSuaDangBan";
            rdoSuaDangBan.Size = new Size(117, 32);
            rdoSuaDangBan.TabIndex = 53;
            rdoSuaDangBan.TabStop = true;
            rdoSuaDangBan.Text = "Đang Bán";
            rdoSuaDangBan.UseVisualStyleBackColor = true;
            // 
            // txtSuaGiaSanPham
            // 
            txtSuaGiaSanPham.Font = new Font("Segoe UI", 12F);
            txtSuaGiaSanPham.Location = new Point(187, 304);
            txtSuaGiaSanPham.Name = "txtSuaGiaSanPham";
            txtSuaGiaSanPham.Size = new Size(280, 34);
            txtSuaGiaSanPham.TabIndex = 36;
            // 
            // lblSuaTrangThaiSanPham
            // 
            lblSuaTrangThaiSanPham.AutoSize = true;
            lblSuaTrangThaiSanPham.Font = new Font("Segoe UI", 13F);
            lblSuaTrangThaiSanPham.Location = new Point(6, 349);
            lblSuaTrangThaiSanPham.Name = "lblSuaTrangThaiSanPham";
            lblSuaTrangThaiSanPham.Size = new Size(113, 30);
            lblSuaTrangThaiSanPham.TabIndex = 52;
            lblSuaTrangThaiSanPham.Text = "Trạng Thái";
            // 
            // btnClearSuaSanPham
            // 
            btnClearSuaSanPham.Font = new Font("Segoe UI", 12F);
            btnClearSuaSanPham.Location = new Point(325, 390);
            btnClearSuaSanPham.Name = "btnClearSuaSanPham";
            btnClearSuaSanPham.Size = new Size(70, 34);
            btnClearSuaSanPham.TabIndex = 35;
            btnClearSuaSanPham.Text = "Clear";
            btnClearSuaSanPham.UseVisualStyleBackColor = true;
            btnClearSuaSanPham.Click += btnClearSuaSanPham_Click;
            // 
            // lblSuaSanPham
            // 
            lblSuaSanPham.AutoSize = true;
            lblSuaSanPham.Font = new Font("Segoe UI", 14F);
            lblSuaSanPham.Location = new Point(10, 21);
            lblSuaSanPham.Name = "lblSuaSanPham";
            lblSuaSanPham.Size = new Size(282, 32);
            lblSuaSanPham.TabIndex = 34;
            lblSuaSanPham.Text = "Sửa Thông Tin Sản Phẩm";
            // 
            // txtSuaTenSanPham
            // 
            txtSuaTenSanPham.Font = new Font("Segoe UI", 12F);
            txtSuaTenSanPham.Location = new Point(187, 130);
            txtSuaTenSanPham.Name = "txtSuaTenSanPham";
            txtSuaTenSanPham.Size = new Size(280, 34);
            txtSuaTenSanPham.TabIndex = 32;
            // 
            // lblSuaMaSanPham
            // 
            lblSuaMaSanPham.AutoSize = true;
            lblSuaMaSanPham.Font = new Font("Segoe UI", 13F);
            lblSuaMaSanPham.Location = new Point(6, 88);
            lblSuaMaSanPham.Name = "lblSuaMaSanPham";
            lblSuaMaSanPham.Size = new Size(145, 30);
            lblSuaMaSanPham.TabIndex = 18;
            lblSuaMaSanPham.Text = "Mã Sản Phẩm";
            // 
            // txtSuaMaSanPham
            // 
            txtSuaMaSanPham.Font = new Font("Segoe UI", 12F);
            txtSuaMaSanPham.Location = new Point(187, 86);
            txtSuaMaSanPham.Name = "txtSuaMaSanPham";
            txtSuaMaSanPham.ReadOnly = true;
            txtSuaMaSanPham.Size = new Size(280, 34);
            txtSuaMaSanPham.TabIndex = 22;
            // 
            // lblSuaTenSanPham
            // 
            lblSuaTenSanPham.AutoSize = true;
            lblSuaTenSanPham.Font = new Font("Segoe UI", 13F);
            lblSuaTenSanPham.Location = new Point(6, 132);
            lblSuaTenSanPham.Name = "lblSuaTenSanPham";
            lblSuaTenSanPham.Size = new Size(148, 30);
            lblSuaTenSanPham.TabIndex = 33;
            lblSuaTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // txtSuaSoLuongSanPham
            // 
            txtSuaSoLuongSanPham.Font = new Font("Segoe UI", 12F);
            txtSuaSoLuongSanPham.Location = new Point(187, 263);
            txtSuaSoLuongSanPham.Name = "txtSuaSoLuongSanPham";
            txtSuaSoLuongSanPham.Size = new Size(280, 34);
            txtSuaSoLuongSanPham.TabIndex = 23;
            // 
            // btnLuuSuaSanPham
            // 
            btnLuuSuaSanPham.Font = new Font("Segoe UI", 12F);
            btnLuuSuaSanPham.Location = new Point(401, 391);
            btnLuuSuaSanPham.Name = "btnLuuSuaSanPham";
            btnLuuSuaSanPham.Size = new Size(70, 33);
            btnLuuSuaSanPham.TabIndex = 19;
            btnLuuSuaSanPham.Text = "Lưu";
            btnLuuSuaSanPham.UseVisualStyleBackColor = true;
            btnLuuSuaSanPham.Click += btnLuuSuaSanPham_Click;
            // 
            // lblSuaSoLuongSanPham
            // 
            lblSuaSoLuongSanPham.AutoSize = true;
            lblSuaSoLuongSanPham.Font = new Font("Segoe UI", 13F);
            lblSuaSoLuongSanPham.Location = new Point(6, 267);
            lblSuaSoLuongSanPham.Name = "lblSuaSoLuongSanPham";
            lblSuaSoLuongSanPham.Size = new Size(105, 30);
            lblSuaSoLuongSanPham.TabIndex = 24;
            lblSuaSoLuongSanPham.Text = "Số Lượng";
            // 
            // txtSuaLoaiSanPham
            // 
            txtSuaLoaiSanPham.Font = new Font("Segoe UI", 12F);
            txtSuaLoaiSanPham.Location = new Point(187, 174);
            txtSuaLoaiSanPham.Name = "txtSuaLoaiSanPham";
            txtSuaLoaiSanPham.Size = new Size(280, 34);
            txtSuaLoaiSanPham.TabIndex = 25;
            // 
            // lblSuaGiaSanPham
            // 
            lblSuaGiaSanPham.AutoSize = true;
            lblSuaGiaSanPham.Font = new Font("Segoe UI", 13F);
            lblSuaGiaSanPham.Location = new Point(6, 308);
            lblSuaGiaSanPham.Name = "lblSuaGiaSanPham";
            lblSuaGiaSanPham.Size = new Size(44, 30);
            lblSuaGiaSanPham.TabIndex = 28;
            lblSuaGiaSanPham.Text = "Giá";
            // 
            // cmbSuaNhaCungCap
            // 
            cmbSuaNhaCungCap.Font = new Font("Segoe UI", 11F);
            cmbSuaNhaCungCap.FormattingEnabled = true;
            cmbSuaNhaCungCap.Location = new Point(187, 391);
            cmbSuaNhaCungCap.Name = "cmbSuaNhaCungCap";
            cmbSuaNhaCungCap.Size = new Size(132, 33);
            cmbSuaNhaCungCap.TabIndex = 27;
            // 
            // lblSuaLoaiSanPham
            // 
            lblSuaLoaiSanPham.AutoSize = true;
            lblSuaLoaiSanPham.Font = new Font("Segoe UI", 13F);
            lblSuaLoaiSanPham.Location = new Point(6, 176);
            lblSuaLoaiSanPham.Name = "lblSuaLoaiSanPham";
            lblSuaLoaiSanPham.Size = new Size(153, 30);
            lblSuaLoaiSanPham.TabIndex = 26;
            lblSuaLoaiSanPham.Text = "Loại Sản Phẩm";
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
            msDashBoard.Size = new Size(172, 942);
            msDashBoard.TabIndex = 58;
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
            // btnThemSanPham
            // 
            btnThemSanPham.Location = new Point(182, 478);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(160, 45);
            btnThemSanPham.TabIndex = 59;
            btnThemSanPham.Text = "Thêm Sản Phẩm";
            btnThemSanPham.UseVisualStyleBackColor = true;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // lblAnhSanPham
            // 
            lblAnhSanPham.AutoSize = true;
            lblAnhSanPham.Font = new Font("Segoe UI", 13F);
            lblAnhSanPham.Location = new Point(708, 870);
            lblAnhSanPham.Name = "lblAnhSanPham";
            lblAnhSanPham.Size = new Size(152, 30);
            lblAnhSanPham.TabIndex = 57;
            lblAnhSanPham.Text = "Ảnh Sản Phẩm";
            // 
            // frmKho
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 942);
            Controls.Add(lblAnhSanPham);
            Controls.Add(btnThemSanPham);
            Controls.Add(msDashBoard);
            Controls.Add(btnTaiLaiDanhSach);
            Controls.Add(btnTimSanPham);
            Controls.Add(txtTimKiemSanPham);
            Controls.Add(grpThemSanPham);
            Controls.Add(btnSuaSanPham);
            Controls.Add(btnChonTatCa);
            Controls.Add(btnXoaSanPham);
            Controls.Add(grpSuaSanPham);
            Controls.Add(dgvSanPham);
            Controls.Add(picAnhSanPham);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmKho";
            Text = "Quản Lí Kho";
            Load += frmKho_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            grpThemSanPham.ResumeLayout(false);
            grpThemSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhSanPham).EndInit();
            grpSuaSanPham.ResumeLayout(false);
            grpSuaSanPham.PerformLayout();
            msDashBoard.ResumeLayout(false);
            msDashBoard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvSanPham;
        private DataGridViewCheckBoxColumn dgvhCheckBoxSanPham;
        private DataGridViewTextBoxColumn dgvhMaSanPham;
        private DataGridViewTextBoxColumn dgvhTenSanPham;
        private DataGridViewTextBoxColumn dgvhLoaiSanPham;
        private DataGridViewTextBoxColumn dgvhSoLuong;
        private DataGridViewTextBoxColumn dgvhGiaSanPham;
        private DataGridViewTextBoxColumn dgvhMaNhaCC;
        private DataGridViewTextBoxColumn dgvhTrangThai;
        private Button btnTaiLaiDanhSach;
        private Button btnTimSanPham;
        private TextBox txtTimKiemSanPham;
        private GroupBox grpThemSanPham;
        private Button btnClearThemSanPham;
        private TextBox txtThemSoLuongSanPham;
        private ComboBox cmbThemNhaCungCap;
        private Label lblThemLoaiSanPham;
        private TextBox txtThemGiaSanPham;
        private TextBox txtThemLoaiSanPham;
        private Label lblThemGiaSanPham;
        private TextBox txtThemTenSanPham;
        private Button btnLuuThemSanPham;
        private Label lblThemHinhAnhSanPham;
        private TextBox txtThemHinhAnhSanPham;
        private PictureBox picAnhSanPham;
        private Label lblThemTenSanPham;
        private Label lblThemNhaCungCap;
        private Label lblThemSoLuongSanPham;
        private Button btnSuaSanPham;
        private Button btnChonTatCa;
        private Button btnXoaSanPham;
        private GroupBox grpSuaSanPham;
        private Button btnClearSuaSanPham;
        private Label lblSuaSanPham;
        private TextBox txtSuaTenSanPham;
        private Label lblSuaMaSanPham;
        private TextBox txtSuaMaSanPham;
        private Label lblSuaTenSanPham;
        private TextBox txtSuaSoLuongSanPham;
        private Button btnLuuSuaSanPham;
        private Label lblSuaSoLuongSanPham;
        private TextBox txtSuaLoaiSanPham;
        private Label lblSuaGiaSanPham;
        private ComboBox cmbSuaNhaCungCap;
        private Label lblSuaLoaiSanPham;
        private RadioButton rdoThemChuaBan;
        private RadioButton rdoThemDangBan;
        private Label lblThemTrangThaiSanPham;
        private TextBox txtSuaGiaSanPham;
        private RadioButton rdoSuaChuaBan;
        private RadioButton rdoSuaDangBan;
        private Label lblSuaTrangThaiSanPham;
        private Label lblSuaNhaCungCap;
        private Label lblThemSanPham;
        private MenuStrip msDashBoard;
        private ToolStripLabel tslDashBoard;
        private ToolStripMenuItem tsmiSanPham;
        private ToolStripMenuItem tsmiKho;
        private ToolStripMenuItem tsmiHoaDon;
        private ToolStripMenuItem tsmiNhanVien;
        private ToolStripMenuItem tsmiNhaCungCap;
        private Button btnMoFileThem;
        private Button btnMoFileSua;
        private TextBox txtSuaHinhAnhSanPham;
        private Label lblSuaHinhAnhSanPham;
        private Button btnThemSanPham;
        private Label lblAnhSanPham;
    }
}