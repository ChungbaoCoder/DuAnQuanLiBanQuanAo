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
            dvghMaKhachHang = new DataGridViewTextBoxColumn();
            dgvSanPham = new DataGridView();
            dgvhCheckBoxSanPham = new DataGridViewCheckBoxColumn();
            dgvhMaSanPham = new DataGridViewTextBoxColumn();
            dgvhTenSanPham = new DataGridViewTextBoxColumn();
            dgvhLoaiSanPham = new DataGridViewTextBoxColumn();
            dgvhGiaSanPham = new DataGridViewTextBoxColumn();
            dgvhSoLuong = new DataGridViewTextBoxColumn();
            dgvhTrangThai = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAnhSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupSoLuong).BeginInit();
            SuspendLayout();
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Font = new Font("Segoe UI", 13F);
            lblTenKhachHang.Location = new Point(12, 9);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(180, 30);
            lblTenKhachHang.TabIndex = 7;
            lblTenKhachHang.Text = "Tên Khách Hàng :";
            // 
            // btnHoanThanhHD
            // 
            btnHoanThanhHD.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHoanThanhHD.Font = new Font("Segoe UI", 14F);
            btnHoanThanhHD.Location = new Point(856, 835);
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
            dgvChiTietHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHoaDon.Columns.AddRange(new DataGridViewColumn[] { dgvhCheckBoxHoaDon, dgvhMaHoaDonKhach, dgvhMaSanPhamKhach, dgvhTenSanPhamKhach, dgvhSoLuongKhach, dgvhGiaTienKhach, dgvhThanhTienKhach, dvghMaKhachHang });
            dgvChiTietHoaDon.Location = new Point(12, 42);
            dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            dgvChiTietHoaDon.RowHeadersVisible = false;
            dgvChiTietHoaDon.RowHeadersWidth = 51;
            dgvChiTietHoaDon.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvChiTietHoaDon.Size = new Size(1144, 350);
            dgvChiTietHoaDon.TabIndex = 5;
            // 
            // dgvhCheckBoxHoaDon
            // 
            dgvhCheckBoxHoaDon.HeaderText = "";
            dgvhCheckBoxHoaDon.MinimumWidth = 6;
            dgvhCheckBoxHoaDon.Name = "dgvhCheckBoxHoaDon";
            dgvhCheckBoxHoaDon.Resizable = DataGridViewTriState.True;
            dgvhCheckBoxHoaDon.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dgvhMaHoaDonKhach
            // 
            dgvhMaHoaDonKhach.HeaderText = "Mã Hoá Đơn";
            dgvhMaHoaDonKhach.MinimumWidth = 6;
            dgvhMaHoaDonKhach.Name = "dgvhMaHoaDonKhach";
            dgvhMaHoaDonKhach.ReadOnly = true;
            // 
            // dgvhMaSanPhamKhach
            // 
            dgvhMaSanPhamKhach.HeaderText = "Mã Sản Phẩm";
            dgvhMaSanPhamKhach.MinimumWidth = 6;
            dgvhMaSanPhamKhach.Name = "dgvhMaSanPhamKhach";
            dgvhMaSanPhamKhach.ReadOnly = true;
            // 
            // dgvhTenSanPhamKhach
            // 
            dgvhTenSanPhamKhach.HeaderText = "Tên Sản Phẩm";
            dgvhTenSanPhamKhach.MinimumWidth = 6;
            dgvhTenSanPhamKhach.Name = "dgvhTenSanPhamKhach";
            dgvhTenSanPhamKhach.ReadOnly = true;
            // 
            // dgvhSoLuongKhach
            // 
            dgvhSoLuongKhach.HeaderText = "Số Lượng";
            dgvhSoLuongKhach.MinimumWidth = 6;
            dgvhSoLuongKhach.Name = "dgvhSoLuongKhach";
            dgvhSoLuongKhach.ReadOnly = true;
            // 
            // dgvhGiaTienKhach
            // 
            dgvhGiaTienKhach.HeaderText = "Giá Tiền";
            dgvhGiaTienKhach.MinimumWidth = 6;
            dgvhGiaTienKhach.Name = "dgvhGiaTienKhach";
            // 
            // dgvhThanhTienKhach
            // 
            dgvhThanhTienKhach.HeaderText = "Tổng Thành Tiền";
            dgvhThanhTienKhach.MinimumWidth = 6;
            dgvhThanhTienKhach.Name = "dgvhThanhTienKhach";
            // 
            // dvghMaKhachHang
            // 
            dvghMaKhachHang.HeaderText = "Mã Khách Hàng";
            dvghMaKhachHang.MinimumWidth = 6;
            dvghMaKhachHang.Name = "dvghMaKhachHang";
            dvghMaKhachHang.ReadOnly = true;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.AllowUserToResizeColumns = false;
            dgvSanPham.AllowUserToResizeRows = false;
            dgvSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { dgvhCheckBoxSanPham, dgvhMaSanPham, dgvhTenSanPham, dgvhLoaiSanPham, dgvhGiaSanPham, dgvhSoLuong, dgvhTrangThai, dgvhHinhAnhSanPham });
            dgvSanPham.Location = new Point(12, 503);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(828, 320);
            dgvSanPham.TabIndex = 9;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // dgvhCheckBoxSanPham
            // 
            dgvhCheckBoxSanPham.HeaderText = "";
            dgvhCheckBoxSanPham.MinimumWidth = 6;
            dgvhCheckBoxSanPham.Name = "dgvhCheckBoxSanPham";
            // 
            // dgvhMaSanPham
            // 
            dgvhMaSanPham.HeaderText = "Mã Sản Phẩm";
            dgvhMaSanPham.MinimumWidth = 6;
            dgvhMaSanPham.Name = "dgvhMaSanPham";
            dgvhMaSanPham.ReadOnly = true;
            // 
            // dgvhTenSanPham
            // 
            dgvhTenSanPham.HeaderText = "Tên Sản Phẩm";
            dgvhTenSanPham.MinimumWidth = 6;
            dgvhTenSanPham.Name = "dgvhTenSanPham";
            dgvhTenSanPham.ReadOnly = true;
            // 
            // dgvhLoaiSanPham
            // 
            dgvhLoaiSanPham.HeaderText = "Loại Sản Phẩm";
            dgvhLoaiSanPham.MinimumWidth = 6;
            dgvhLoaiSanPham.Name = "dgvhLoaiSanPham";
            dgvhLoaiSanPham.ReadOnly = true;
            // 
            // dgvhGiaSanPham
            // 
            dgvhGiaSanPham.HeaderText = "Giá Sản Phẩm";
            dgvhGiaSanPham.MinimumWidth = 6;
            dgvhGiaSanPham.Name = "dgvhGiaSanPham";
            dgvhGiaSanPham.ReadOnly = true;
            // 
            // dgvhSoLuong
            // 
            dgvhSoLuong.HeaderText = "Số Lượng";
            dgvhSoLuong.MinimumWidth = 6;
            dgvhSoLuong.Name = "dgvhSoLuong";
            dgvhSoLuong.ReadOnly = true;
            // 
            // dgvhTrangThai
            // 
            dgvhTrangThai.HeaderText = "Trạng Thái";
            dgvhTrangThai.MinimumWidth = 6;
            dgvhTrangThai.Name = "dgvhTrangThai";
            dgvhTrangThai.ReadOnly = true;
            // 
            // dgvhHinhAnhSanPham
            // 
            dgvhHinhAnhSanPham.HeaderText = "Hình Ảnh";
            dgvhHinhAnhSanPham.MinimumWidth = 6;
            dgvhHinhAnhSanPham.Name = "dgvhHinhAnhSanPham";
            dgvhHinhAnhSanPham.ReadOnly = true;
            // 
            // lblSanPham
            // 
            lblSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSanPham.AutoSize = true;
            lblSanPham.Font = new Font("Segoe UI", 13F);
            lblSanPham.Location = new Point(12, 470);
            lblSanPham.Name = "lblSanPham";
            lblSanPham.Size = new Size(108, 30);
            lblSanPham.TabIndex = 10;
            lblSanPham.Text = "Sản Phẩm";
            // 
            // picAnhSanPham
            // 
            picAnhSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            picAnhSanPham.Location = new Point(846, 503);
            picAnhSanPham.Name = "picAnhSanPham";
            picAnhSanPham.Size = new Size(310, 320);
            picAnhSanPham.TabIndex = 11;
            picAnhSanPham.TabStop = false;
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Font = new Font("Segoe UI", 13F);
            lblHinhAnh.Location = new Point(846, 470);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(102, 30);
            lblHinhAnh.TabIndex = 12;
            lblHinhAnh.Text = "Hình Ảnh";
            // 
            // lblSoLuong
            // 
            lblSoLuong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 13F);
            lblSoLuong.Location = new Point(12, 856);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(110, 30);
            lblSoLuong.TabIndex = 14;
            lblSoLuong.Text = "Số Lượng:";
            // 
            // btnXoaHoaDon
            // 
            btnXoaHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaHoaDon.Image = Properties.Resources.icons8_delete_30;
            btnXoaHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaHoaDon.Location = new Point(168, 410);
            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new Size(157, 45);
            btnXoaHoaDon.TabIndex = 16;
            btnXoaHoaDon.Text = "Xoá Hoá Đơn";
            btnXoaHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnXoaHoaDon.UseVisualStyleBackColor = true;
            btnXoaHoaDon.Click += btnXoaHoaDon_Click;
            // 
            // btnChonTatCa
            // 
            btnChonTatCa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnChonTatCa.Image = Properties.Resources.icons8_all_30;
            btnChonTatCa.ImageAlign = ContentAlignment.MiddleLeft;
            btnChonTatCa.Location = new Point(12, 410);
            btnChonTatCa.Name = "btnChonTatCa";
            btnChonTatCa.Size = new Size(150, 45);
            btnChonTatCa.TabIndex = 17;
            btnChonTatCa.Text = "Chọn Tất Cả";
            btnChonTatCa.TextAlign = ContentAlignment.MiddleRight;
            btnChonTatCa.UseVisualStyleBackColor = true;
            btnChonTatCa.Click += btnChonTatCa_Click;
            // 
            // btnThemVaoHoaDon
            // 
            btnThemVaoHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThemVaoHoaDon.Location = new Point(248, 846);
            btnThemVaoHoaDon.Name = "btnThemVaoHoaDon";
            btnThemVaoHoaDon.Size = new Size(201, 50);
            btnThemVaoHoaDon.TabIndex = 18;
            btnThemVaoHoaDon.Text = "Thêm Vào Hoá Đơn";
            btnThemVaoHoaDon.UseVisualStyleBackColor = true;
            btnThemVaoHoaDon.Click += btnThemVaoHoaDon_Click;
            // 
            // nupSoLuong
            // 
            nupSoLuong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nupSoLuong.Location = new Point(128, 855);
            nupSoLuong.Name = "nupSoLuong";
            nupSoLuong.Size = new Size(114, 34);
            nupSoLuong.TabIndex = 38;
            // 
            // btnTaiLaiDanhSach
            // 
            btnTaiLaiDanhSach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTaiLaiDanhSach.Image = Properties.Resources.icons8_reload_30;
            btnTaiLaiDanhSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaiLaiDanhSach.Location = new Point(331, 410);
            btnTaiLaiDanhSach.Name = "btnTaiLaiDanhSach";
            btnTaiLaiDanhSach.Size = new Size(201, 45);
            btnTaiLaiDanhSach.TabIndex = 39;
            btnTaiLaiDanhSach.Text = "Tải Lại Danh Sách";
            btnTaiLaiDanhSach.TextAlign = ContentAlignment.MiddleRight;
            btnTaiLaiDanhSach.UseVisualStyleBackColor = true;
            btnTaiLaiDanhSach.Click += btnTaiLaiDanhSach_Click;
            // 
            // frmChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 917);
            Controls.Add(btnTaiLaiDanhSach);
            Controls.Add(nupSoLuong);
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
            Load += frmChiTietHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAnhSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupSoLuong).EndInit();
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
        private DataGridViewCheckBoxColumn dgvhCheckBoxSanPham;
        private DataGridViewTextBoxColumn dgvhMaSanPham;
        private DataGridViewTextBoxColumn dgvhTenSanPham;
        private DataGridViewTextBoxColumn dgvhLoaiSanPham;
        private DataGridViewTextBoxColumn dgvhGiaSanPham;
        private DataGridViewTextBoxColumn dgvhSoLuong;
        private DataGridViewTextBoxColumn dgvhTrangThai;
        private DataGridViewTextBoxColumn dgvhHinhAnhSanPham;
        private DataGridViewCheckBoxColumn dgvhCheckBoxHoaDon;
        private DataGridViewTextBoxColumn dgvhMaHoaDonKhach;
        private DataGridViewTextBoxColumn dgvhMaSanPhamKhach;
        private DataGridViewTextBoxColumn dgvhTenSanPhamKhach;
        private DataGridViewTextBoxColumn dgvhSoLuongKhach;
        private DataGridViewTextBoxColumn dgvhGiaTienKhach;
        private DataGridViewTextBoxColumn dgvhThanhTienKhach;
        private DataGridViewTextBoxColumn dvghMaKhachHang;
    }
}