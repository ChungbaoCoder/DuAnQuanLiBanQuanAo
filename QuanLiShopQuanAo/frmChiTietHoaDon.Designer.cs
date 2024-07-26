namespace QuanLiShopQuanAo
{
    partial class frmChiTietHoaDon
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
            lblTenKhachHang = new Label();
            btnHoanThanhHD = new Button();
            dgvChiTietHoaDon = new DataGridView();
            dgvhCheckBoxHoaDon = new DataGridViewCheckBoxColumn();
            dgvhMaHoaDonKhach = new DataGridViewTextBoxColumn();
            dgvhMaSanPhamKhach = new DataGridViewTextBoxColumn();
            dgvhTenSanPhamKhach = new DataGridViewTextBoxColumn();
            dgvhSoLuongKhach = new DataGridViewTextBoxColumn();
            dgvhGiaTienKhach = new DataGridViewTextBoxColumn();
            dgvhThanhTienKhach = new DataGridViewTextBoxColumn();
            dgvSanPham = new DataGridView();
            dgvhCheckBoxSanPham = new DataGridViewCheckBoxColumn();
            dgvhMaSanPham = new DataGridViewTextBoxColumn();
            dgvhTenSanPham = new DataGridViewTextBoxColumn();
            dgvhLoaiSanPham = new DataGridViewTextBoxColumn();
            dgvhGiaSanPham = new DataGridViewTextBoxColumn();
            dgvhHinhAnhSanPham = new DataGridViewTextBoxColumn();
            lblSanPham = new Label();
            picAnhSanPham = new PictureBox();
            lblHinhAnh = new Label();
            lblSoLuong = new Label();
            btnXoaHoaDon = new Button();
            btnChonTatCa = new Button();
            btnThemVaoHoaDon = new Button();
            nupSoLuong = new NumericUpDown();
            btnTaiLaiDanhSach = new Button();
            tslDashBoard = new ToolStripLabel();
            tsmiSanPham = new ToolStripMenuItem();
            tsmiKho = new ToolStripMenuItem();
            tsmiHoaDon = new ToolStripMenuItem();
            tsmiNhanVien = new ToolStripMenuItem();
            tsmiNhaCungCap = new ToolStripMenuItem();
            msDashBoard = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAnhSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupSoLuong).BeginInit();
            msDashBoard.SuspendLayout();
            SuspendLayout();
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Font = new Font("Segoe UI", 13F);
            lblTenKhachHang.Location = new Point(175, 9);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(180, 30);
            lblTenKhachHang.TabIndex = 7;
            lblTenKhachHang.Text = "Tên Khách Hàng :";
            // 
            // btnHoanThanhHD
            // 
            btnHoanThanhHD.Font = new Font("Segoe UI", 14F);
            btnHoanThanhHD.Location = new Point(797, 835);
            btnHoanThanhHD.Name = "btnHoanThanhHD";
            btnHoanThanhHD.Size = new Size(300, 70);
            btnHoanThanhHD.TabIndex = 6;
            btnHoanThanhHD.Text = "Hoàn Thành Hoá Đơn";
            btnHoanThanhHD.UseVisualStyleBackColor = true;
            btnHoanThanhHD.Click += btnHoanThanhHD_Click;
            // 
            // dgvChiTietHoaDon
            // 
            dgvChiTietHoaDon.AllowUserToAddRows = false;
            dgvChiTietHoaDon.AllowUserToDeleteRows = false;
            dgvChiTietHoaDon.AllowUserToResizeColumns = false;
            dgvChiTietHoaDon.AllowUserToResizeRows = false;
            dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHoaDon.Columns.AddRange(new DataGridViewColumn[] { dgvhCheckBoxHoaDon, dgvhMaHoaDonKhach, dgvhMaSanPhamKhach, dgvhTenSanPhamKhach, dgvhSoLuongKhach, dgvhGiaTienKhach, dgvhThanhTienKhach });
            dgvChiTietHoaDon.Location = new Point(175, 42);
            dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            dgvChiTietHoaDon.RowHeadersVisible = false;
            dgvChiTietHoaDon.RowHeadersWidth = 51;
            dgvChiTietHoaDon.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvChiTietHoaDon.Size = new Size(922, 350);
            dgvChiTietHoaDon.TabIndex = 5;
            // 
            // dgvhCheckBoxHoaDon
            // 
            dgvhCheckBoxHoaDon.HeaderText = "";
            dgvhCheckBoxHoaDon.MinimumWidth = 6;
            dgvhCheckBoxHoaDon.Name = "dgvhCheckBoxHoaDon";
            dgvhCheckBoxHoaDon.Resizable = DataGridViewTriState.True;
            dgvhCheckBoxHoaDon.SortMode = DataGridViewColumnSortMode.Automatic;
            dgvhCheckBoxHoaDon.Width = 25;
            // 
            // dgvhMaHoaDonKhach
            // 
            dgvhMaHoaDonKhach.HeaderText = "Mã Hoá Đơn";
            dgvhMaHoaDonKhach.MinimumWidth = 6;
            dgvhMaHoaDonKhach.Name = "dgvhMaHoaDonKhach";
            dgvhMaHoaDonKhach.ReadOnly = true;
            dgvhMaHoaDonKhach.Width = 152;
            // 
            // dgvhMaSanPhamKhach
            // 
            dgvhMaSanPhamKhach.HeaderText = "Mã Sản Phẩm";
            dgvhMaSanPhamKhach.MinimumWidth = 6;
            dgvhMaSanPhamKhach.Name = "dgvhMaSanPhamKhach";
            dgvhMaSanPhamKhach.ReadOnly = true;
            dgvhMaSanPhamKhach.Width = 160;
            // 
            // dgvhTenSanPhamKhach
            // 
            dgvhTenSanPhamKhach.HeaderText = "Tên Sản Phẩm";
            dgvhTenSanPhamKhach.MinimumWidth = 6;
            dgvhTenSanPhamKhach.Name = "dgvhTenSanPhamKhach";
            dgvhTenSanPhamKhach.ReadOnly = true;
            dgvhTenSanPhamKhach.Width = 161;
            // 
            // dgvhSoLuongKhach
            // 
            dgvhSoLuongKhach.HeaderText = "Số Lượng";
            dgvhSoLuongKhach.MinimumWidth = 6;
            dgvhSoLuongKhach.Name = "dgvhSoLuongKhach";
            dgvhSoLuongKhach.ReadOnly = true;
            dgvhSoLuongKhach.Width = 125;
            // 
            // dgvhGiaTienKhach
            // 
            dgvhGiaTienKhach.HeaderText = "Giá Tiền";
            dgvhGiaTienKhach.MinimumWidth = 6;
            dgvhGiaTienKhach.Name = "dgvhGiaTienKhach";
            dgvhGiaTienKhach.Width = 111;
            // 
            // dgvhThanhTienKhach
            // 
            dgvhThanhTienKhach.HeaderText = "Tổng Thành Tiền";
            dgvhThanhTienKhach.MinimumWidth = 6;
            dgvhThanhTienKhach.Name = "dgvhThanhTienKhach";
            dgvhThanhTienKhach.Width = 185;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.AllowUserToResizeColumns = false;
            dgvSanPham.AllowUserToResizeRows = false;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { dgvhCheckBoxSanPham, dgvhMaSanPham, dgvhTenSanPham, dgvhLoaiSanPham, dgvhGiaSanPham, dgvhHinhAnhSanPham });
            dgvSanPham.Location = new Point(175, 503);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(678, 320);
            dgvSanPham.TabIndex = 9;
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
            dgvhMaSanPham.Width = 160;
            // 
            // dgvhTenSanPham
            // 
            dgvhTenSanPham.HeaderText = "Tên Sản Phẩm";
            dgvhTenSanPham.MinimumWidth = 6;
            dgvhTenSanPham.Name = "dgvhTenSanPham";
            dgvhTenSanPham.ReadOnly = true;
            dgvhTenSanPham.Width = 161;
            // 
            // dgvhLoaiSanPham
            // 
            dgvhLoaiSanPham.HeaderText = "Loại Sản Phẩm";
            dgvhLoaiSanPham.MinimumWidth = 6;
            dgvhLoaiSanPham.Name = "dgvhLoaiSanPham";
            dgvhLoaiSanPham.ReadOnly = true;
            dgvhLoaiSanPham.Width = 168;
            // 
            // dgvhGiaSanPham
            // 
            dgvhGiaSanPham.HeaderText = "Giá Sản Phẩm";
            dgvhGiaSanPham.MinimumWidth = 6;
            dgvhGiaSanPham.Name = "dgvhGiaSanPham";
            dgvhGiaSanPham.ReadOnly = true;
            dgvhGiaSanPham.Width = 161;
            // 
            // dgvhHinhAnhSanPham
            // 
            dgvhHinhAnhSanPham.HeaderText = "Hình Ảnh";
            dgvhHinhAnhSanPham.MinimumWidth = 6;
            dgvhHinhAnhSanPham.Name = "dgvhHinhAnhSanPham";
            dgvhHinhAnhSanPham.ReadOnly = true;
            dgvhHinhAnhSanPham.Width = 125;
            // 
            // lblSanPham
            // 
            lblSanPham.AutoSize = true;
            lblSanPham.Font = new Font("Segoe UI", 13F);
            lblSanPham.Location = new Point(175, 470);
            lblSanPham.Name = "lblSanPham";
            lblSanPham.Size = new Size(108, 30);
            lblSanPham.TabIndex = 10;
            lblSanPham.Text = "Sản Phẩm";
            // 
            // picAnhSanPham
            // 
            picAnhSanPham.Location = new Point(859, 503);
            picAnhSanPham.Name = "picAnhSanPham";
            picAnhSanPham.Size = new Size(238, 320);
            picAnhSanPham.TabIndex = 11;
            picAnhSanPham.TabStop = false;
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Font = new Font("Segoe UI", 13F);
            lblHinhAnh.Location = new Point(859, 470);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(102, 30);
            lblHinhAnh.TabIndex = 12;
            lblHinhAnh.Text = "Hình Ảnh";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 13F);
            lblSoLuong.Location = new Point(175, 835);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(110, 30);
            lblSoLuong.TabIndex = 14;
            lblSoLuong.Text = "Số Lượng:";
            // 
            // btnXoaHoaDon
            // 
            btnXoaHoaDon.Location = new Point(331, 410);
            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new Size(150, 45);
            btnXoaHoaDon.TabIndex = 16;
            btnXoaHoaDon.Text = "Xoá Hoá Đơn";
            btnXoaHoaDon.UseVisualStyleBackColor = true;
            btnXoaHoaDon.Click += btnXoaHoaDon_Click;
            // 
            // btnChonTatCa
            // 
            btnChonTatCa.Location = new Point(175, 410);
            btnChonTatCa.Name = "btnChonTatCa";
            btnChonTatCa.Size = new Size(150, 45);
            btnChonTatCa.TabIndex = 17;
            btnChonTatCa.Text = "Chọn Tất Cả";
            btnChonTatCa.UseVisualStyleBackColor = true;
            btnChonTatCa.Click += btnChonTatCa_Click;
            // 
            // btnThemVaoHoaDon
            // 
            btnThemVaoHoaDon.Location = new Point(411, 834);
            btnThemVaoHoaDon.Name = "btnThemVaoHoaDon";
            btnThemVaoHoaDon.Size = new Size(201, 34);
            btnThemVaoHoaDon.TabIndex = 18;
            btnThemVaoHoaDon.Text = "Thêm Vào Hoá Đơn";
            btnThemVaoHoaDon.UseVisualStyleBackColor = true;
            btnThemVaoHoaDon.Click += btnThemVaoHoaDon_Click;
            // 
            // nupSoLuong
            // 
            nupSoLuong.Location = new Point(291, 834);
            nupSoLuong.Name = "nupSoLuong";
            nupSoLuong.Size = new Size(114, 34);
            nupSoLuong.TabIndex = 38;
            // 
            // btnTaiLaiDanhSach
            // 
            btnTaiLaiDanhSach.Location = new Point(487, 410);
            btnTaiLaiDanhSach.Name = "btnTaiLaiDanhSach";
            btnTaiLaiDanhSach.Size = new Size(180, 45);
            btnTaiLaiDanhSach.TabIndex = 39;
            btnTaiLaiDanhSach.Text = "Tải Lại Danh Sách";
            btnTaiLaiDanhSach.UseVisualStyleBackColor = true;
            btnTaiLaiDanhSach.Click += btnTaiLaiDanhSach_Click;
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
            // msDashBoard
            // 
            msDashBoard.AutoSize = false;
            msDashBoard.Dock = DockStyle.Left;
            msDashBoard.ImageScalingSize = new Size(20, 20);
            msDashBoard.Items.AddRange(new ToolStripItem[] { tslDashBoard, tsmiSanPham, tsmiKho, tsmiHoaDon, tsmiNhanVien, tsmiNhaCungCap });
            msDashBoard.Location = new Point(0, 0);
            msDashBoard.Name = "msDashBoard";
            msDashBoard.Padding = new Padding(5, 2, 0, 2);
            msDashBoard.Size = new Size(172, 917);
            msDashBoard.TabIndex = 37;
            msDashBoard.Text = "menuStrip1";
            // 
            // frmChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 917);
            Controls.Add(btnTaiLaiDanhSach);
            Controls.Add(nupSoLuong);
            Controls.Add(msDashBoard);
            Controls.Add(btnThemVaoHoaDon);
            Controls.Add(btnChonTatCa);
            Controls.Add(btnXoaHoaDon);
            Controls.Add(lblSoLuong);
            Controls.Add(lblHinhAnh);
            Controls.Add(picAnhSanPham);
            Controls.Add(lblSanPham);
            Controls.Add(dgvSanPham);
            Controls.Add(lblTenKhachHang);
            Controls.Add(btnHoanThanhHD);
            Controls.Add(dgvChiTietHoaDon);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmChiTietHoaDon";
            Text = "Lập Hoá Đơn";
            FormClosing += frmChiTietHoaDon_FormClosing;
            Load += frmChiTietHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAnhSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupSoLuong).EndInit();
            msDashBoard.ResumeLayout(false);
            msDashBoard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenKhachHang;
        private Button btnHoanThanhHD;
        private DataGridView dgvChiTietHoaDon;
        private DataGridView dgvSanPham;
        private Label lblSanPham;
        private PictureBox picAnhSanPham;
        private Label lblHinhAnh;
        private Label lblSoLuong;
        private Button btnXoaHoaDon;
        private Button btnChonTatCa;
        private Button btnThemVaoHoaDon;
        private NumericUpDown nupSoLuong;
        private Button btnTaiLaiDanhSach;
        private ToolStripLabel tslDashBoard;
        private ToolStripMenuItem tsmiSanPham;
        private ToolStripMenuItem tsmiKho;
        private ToolStripMenuItem tsmiHoaDon;
        private ToolStripMenuItem tsmiNhanVien;
        private ToolStripMenuItem tsmiNhaCungCap;
        private MenuStrip msDashBoard;
        private DataGridViewCheckBoxColumn dgvhCheckBoxHoaDon;
        private DataGridViewTextBoxColumn dgvhMaHoaDonKhach;
        private DataGridViewTextBoxColumn dgvhMaSanPhamKhach;
        private DataGridViewTextBoxColumn dgvhTenSanPhamKhach;
        private DataGridViewTextBoxColumn dgvhSoLuongKhach;
        private DataGridViewTextBoxColumn dgvhGiaTienKhach;
        private DataGridViewTextBoxColumn dgvhThanhTienKhach;
        private DataGridViewCheckBoxColumn dgvhCheckBoxSanPham;
        private DataGridViewTextBoxColumn dgvhMaSanPham;
        private DataGridViewTextBoxColumn dgvhTenSanPham;
        private DataGridViewTextBoxColumn dgvhLoaiSanPham;
        private DataGridViewTextBoxColumn dgvhGiaSanPham;
        private DataGridViewTextBoxColumn dgvhHinhAnhSanPham;
    }
}