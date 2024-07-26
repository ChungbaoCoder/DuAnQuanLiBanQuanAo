namespace QuanLiShopQuanAo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
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
            btnThemSanPham = new Button();
            lblAnhSanPham = new Label();
            picAnhSanPham = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            grpThemSanPham.SuspendLayout();
            grpSuaSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhSanPham).BeginInit();
            SuspendLayout();
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.AllowUserToResizeColumns = false;
            dgvSanPham.AllowUserToResizeRows = false;
            dgvSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { dgvhCheckBoxSanPham, dgvhMaSanPham, dgvhTenSanPham, dgvhLoaiSanPham, dgvhSoLuong, dgvhGiaSanPham, dgvhMaNhaCC, dgvhTrangThai });
            dgvSanPham.Location = new Point(26, 2);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(1120, 357);
            dgvSanPham.TabIndex = 11;
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
            // dgvhSoLuong
            // 
            dgvhSoLuong.HeaderText = "Số Lượng";
            dgvhSoLuong.MinimumWidth = 6;
            dgvhSoLuong.Name = "dgvhSoLuong";
            dgvhSoLuong.ReadOnly = true;
            // 
            // dgvhGiaSanPham
            // 
            dgvhGiaSanPham.HeaderText = "Giá";
            dgvhGiaSanPham.MinimumWidth = 6;
            dgvhGiaSanPham.Name = "dgvhGiaSanPham";
            dgvhGiaSanPham.ReadOnly = true;
            // 
            // dgvhMaNhaCC
            // 
            dgvhMaNhaCC.HeaderText = "Mã Nhà Cung Cấp";
            dgvhMaNhaCC.MinimumWidth = 6;
            dgvhMaNhaCC.Name = "dgvhMaNhaCC";
            dgvhMaNhaCC.ReadOnly = true;
            // 
            // dgvhTrangThai
            // 
            dgvhTrangThai.HeaderText = "Trạng Thái";
            dgvhTrangThai.MinimumWidth = 6;
            dgvhTrangThai.Name = "dgvhTrangThai";
            dgvhTrangThai.ReadOnly = true;
            // 
            // btnTaiLaiDanhSach
            // 
            btnTaiLaiDanhSach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTaiLaiDanhSach.Font = new Font("Segoe UI", 10.8F);
            btnTaiLaiDanhSach.Image = Properties.Resources.icons8_reload_30;
            btnTaiLaiDanhSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaiLaiDanhSach.Location = new Point(346, 372);
            btnTaiLaiDanhSach.Name = "btnTaiLaiDanhSach";
            btnTaiLaiDanhSach.Size = new Size(182, 40);
            btnTaiLaiDanhSach.TabIndex = 57;
            btnTaiLaiDanhSach.Text = "Tải Lại Danh Sách";
            btnTaiLaiDanhSach.TextAlign = ContentAlignment.MiddleRight;
            btnTaiLaiDanhSach.UseVisualStyleBackColor = true;
            btnTaiLaiDanhSach.Click += btnTaiLaiDanhSach_Click;
            // 
            // btnTimSanPham
            // 
            btnTimSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTimSanPham.Font = new Font("Segoe UI", 10.8F);
            btnTimSanPham.Image = Properties.Resources.icons8_find_30;
            btnTimSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimSanPham.Location = new Point(1019, 377);
            btnTimSanPham.Name = "btnTimSanPham";
            btnTimSanPham.Size = new Size(97, 35);
            btnTimSanPham.TabIndex = 50;
            btnTimSanPham.Text = "Tìm";
            btnTimSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnTimSanPham.UseVisualStyleBackColor = true;
            btnTimSanPham.Click += btnTimSanPham_Click;
            // 
            // txtTimKiemSanPham
            // 
            txtTimKiemSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiemSanPham.Font = new Font("Segoe UI", 12F);
            txtTimKiemSanPham.Location = new Point(680, 377);
            txtTimKiemSanPham.Name = "txtTimKiemSanPham";
            txtTimKiemSanPham.Size = new Size(334, 34);
            txtTimKiemSanPham.TabIndex = 56;
            // 
            // grpThemSanPham
            // 
            grpThemSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            grpThemSanPham.Location = new Point(26, 480);
            grpThemSanPham.Name = "grpThemSanPham";
            grpThemSanPham.Size = new Size(429, 341);
            grpThemSanPham.TabIndex = 55;
            grpThemSanPham.TabStop = false;
            // 
            // btnMoFileThem
            // 
            btnMoFileThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMoFileThem.Location = new Point(345, 141);
            btnMoFileThem.Name = "btnMoFileThem";
            btnMoFileThem.Size = new Size(73, 34);
            btnMoFileThem.TabIndex = 56;
            btnMoFileThem.Text = "Mở File";
            btnMoFileThem.UseVisualStyleBackColor = true;
            btnMoFileThem.Click += btnMoFileThem_Click;
            // 
            // lblThemSanPham
            // 
            lblThemSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblThemSanPham.AutoSize = true;
            lblThemSanPham.Font = new Font("Segoe UI", 14F);
            lblThemSanPham.Location = new Point(5, 19);
            lblThemSanPham.Name = "lblThemSanPham";
            lblThemSanPham.Size = new Size(304, 32);
            lblThemSanPham.TabIndex = 55;
            lblThemSanPham.Text = "Thêm Thông Tin Sản Phẩm";
            // 
            // rdoThemChuaBan
            // 
            rdoThemChuaBan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdoThemChuaBan.AutoSize = true;
            rdoThemChuaBan.Location = new Point(267, 257);
            rdoThemChuaBan.Name = "rdoThemChuaBan";
            rdoThemChuaBan.Size = new Size(108, 29);
            rdoThemChuaBan.TabIndex = 51;
            rdoThemChuaBan.TabStop = true;
            rdoThemChuaBan.Text = "Chưa Bán";
            rdoThemChuaBan.UseVisualStyleBackColor = true;
            // 
            // rdoThemDangBan
            // 
            rdoThemDangBan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdoThemDangBan.AutoSize = true;
            rdoThemDangBan.Location = new Point(145, 256);
            rdoThemDangBan.Name = "rdoThemDangBan";
            rdoThemDangBan.Size = new Size(110, 29);
            rdoThemDangBan.TabIndex = 50;
            rdoThemDangBan.TabStop = true;
            rdoThemDangBan.Text = "Đang Bán";
            rdoThemDangBan.UseVisualStyleBackColor = true;
            // 
            // lblThemTrangThaiSanPham
            // 
            lblThemTrangThaiSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblThemTrangThaiSanPham.AutoSize = true;
            lblThemTrangThaiSanPham.Font = new Font("Segoe UI", 13F);
            lblThemTrangThaiSanPham.Location = new Point(5, 257);
            lblThemTrangThaiSanPham.Name = "lblThemTrangThaiSanPham";
            lblThemTrangThaiSanPham.Size = new Size(113, 30);
            lblThemTrangThaiSanPham.TabIndex = 49;
            lblThemTrangThaiSanPham.Text = "Trạng Thái";
            // 
            // btnClearThemSanPham
            // 
            btnClearThemSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClearThemSanPham.Font = new Font("Segoe UI", 10.8F);
            btnClearThemSanPham.Image = Properties.Resources.icons8_delete_30;
            btnClearThemSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearThemSanPham.Location = new Point(257, 292);
            btnClearThemSanPham.Name = "btnClearThemSanPham";
            btnClearThemSanPham.Size = new Size(72, 37);
            btnClearThemSanPham.TabIndex = 48;
            btnClearThemSanPham.Text = "Xóa";
            btnClearThemSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnClearThemSanPham.UseVisualStyleBackColor = true;
            btnClearThemSanPham.Click += btnClearThemSanPham_Click;
            // 
            // txtThemSoLuongSanPham
            // 
            txtThemSoLuongSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtThemSoLuongSanPham.Font = new Font("Segoe UI", 12F);
            txtThemSoLuongSanPham.Location = new Point(145, 179);
            txtThemSoLuongSanPham.Name = "txtThemSoLuongSanPham";
            txtThemSoLuongSanPham.Size = new Size(273, 34);
            txtThemSoLuongSanPham.TabIndex = 47;
            // 
            // cmbThemNhaCungCap
            // 
            cmbThemNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbThemNhaCungCap.Font = new Font("Segoe UI", 11F);
            cmbThemNhaCungCap.FormattingEnabled = true;
            cmbThemNhaCungCap.Location = new Point(151, 296);
            cmbThemNhaCungCap.Name = "cmbThemNhaCungCap";
            cmbThemNhaCungCap.Size = new Size(111, 33);
            cmbThemNhaCungCap.TabIndex = 35;
            // 
            // lblThemLoaiSanPham
            // 
            lblThemLoaiSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblThemLoaiSanPham.AutoSize = true;
            lblThemLoaiSanPham.Font = new Font("Segoe UI", 13F);
            lblThemLoaiSanPham.Location = new Point(5, 102);
            lblThemLoaiSanPham.Name = "lblThemLoaiSanPham";
            lblThemLoaiSanPham.Size = new Size(153, 30);
            lblThemLoaiSanPham.TabIndex = 46;
            lblThemLoaiSanPham.Text = "Loại Sản Phẩm";
            // 
            // txtThemGiaSanPham
            // 
            txtThemGiaSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtThemGiaSanPham.Font = new Font("Segoe UI", 12F);
            txtThemGiaSanPham.Location = new Point(145, 221);
            txtThemGiaSanPham.Name = "txtThemGiaSanPham";
            txtThemGiaSanPham.Size = new Size(273, 34);
            txtThemGiaSanPham.TabIndex = 43;
            // 
            // txtThemLoaiSanPham
            // 
            txtThemLoaiSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtThemLoaiSanPham.Font = new Font("Segoe UI", 12F);
            txtThemLoaiSanPham.Location = new Point(145, 100);
            txtThemLoaiSanPham.Name = "txtThemLoaiSanPham";
            txtThemLoaiSanPham.Size = new Size(273, 34);
            txtThemLoaiSanPham.TabIndex = 45;
            // 
            // txtThemHinhAnhSanPham
            // 
            txtThemHinhAnhSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtThemHinhAnhSanPham.Font = new Font("Segoe UI", 12F);
            txtThemHinhAnhSanPham.Location = new Point(145, 141);
            txtThemHinhAnhSanPham.Name = "txtThemHinhAnhSanPham";
            txtThemHinhAnhSanPham.Size = new Size(195, 34);
            txtThemHinhAnhSanPham.TabIndex = 36;
            // 
            // lblThemGiaSanPham
            // 
            lblThemGiaSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblThemGiaSanPham.AutoSize = true;
            lblThemGiaSanPham.Font = new Font("Segoe UI", 13F);
            lblThemGiaSanPham.Location = new Point(5, 221);
            lblThemGiaSanPham.Name = "lblThemGiaSanPham";
            lblThemGiaSanPham.Size = new Size(44, 30);
            lblThemGiaSanPham.TabIndex = 44;
            lblThemGiaSanPham.Text = "Giá";
            // 
            // lblThemHinhAnhSanPham
            // 
            lblThemHinhAnhSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblThemHinhAnhSanPham.AutoSize = true;
            lblThemHinhAnhSanPham.Font = new Font("Segoe UI", 13F);
            lblThemHinhAnhSanPham.Location = new Point(5, 141);
            lblThemHinhAnhSanPham.Name = "lblThemHinhAnhSanPham";
            lblThemHinhAnhSanPham.Size = new Size(102, 30);
            lblThemHinhAnhSanPham.TabIndex = 35;
            lblThemHinhAnhSanPham.Text = "Hình Ảnh";
            // 
            // txtThemTenSanPham
            // 
            txtThemTenSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtThemTenSanPham.Font = new Font("Segoe UI", 12F);
            txtThemTenSanPham.Location = new Point(145, 59);
            txtThemTenSanPham.Name = "txtThemTenSanPham";
            txtThemTenSanPham.Size = new Size(273, 34);
            txtThemTenSanPham.TabIndex = 41;
            // 
            // btnLuuThemSanPham
            // 
            btnLuuThemSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuuThemSanPham.Font = new Font("Segoe UI", 10.8F);
            btnLuuThemSanPham.Image = Properties.Resources.icons8_add_30;
            btnLuuThemSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuuThemSanPham.Location = new Point(335, 292);
            btnLuuThemSanPham.Name = "btnLuuThemSanPham";
            btnLuuThemSanPham.Size = new Size(88, 38);
            btnLuuThemSanPham.TabIndex = 31;
            btnLuuThemSanPham.Text = "Thêm";
            btnLuuThemSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnLuuThemSanPham.UseVisualStyleBackColor = true;
            btnLuuThemSanPham.Click += btnLuuThemSanPham_Click;
            // 
            // lblThemTenSanPham
            // 
            lblThemTenSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblThemTenSanPham.AutoSize = true;
            lblThemTenSanPham.Font = new Font("Segoe UI", 13F);
            lblThemTenSanPham.Location = new Point(5, 62);
            lblThemTenSanPham.Name = "lblThemTenSanPham";
            lblThemTenSanPham.Size = new Size(148, 30);
            lblThemTenSanPham.TabIndex = 42;
            lblThemTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // lblThemNhaCungCap
            // 
            lblThemNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblThemNhaCungCap.AutoSize = true;
            lblThemNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblThemNhaCungCap.Location = new Point(5, 296);
            lblThemNhaCungCap.Name = "lblThemNhaCungCap";
            lblThemNhaCungCap.Size = new Size(153, 30);
            lblThemNhaCungCap.TabIndex = 40;
            lblThemNhaCungCap.Text = "Nhà Cung Cấp";
            // 
            // lblThemSoLuongSanPham
            // 
            lblThemSoLuongSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblThemSoLuongSanPham.AutoSize = true;
            lblThemSoLuongSanPham.Font = new Font("Segoe UI", 13F);
            lblThemSoLuongSanPham.Location = new Point(5, 181);
            lblThemSoLuongSanPham.Name = "lblThemSoLuongSanPham";
            lblThemSoLuongSanPham.Size = new Size(105, 30);
            lblThemSoLuongSanPham.TabIndex = 38;
            lblThemSoLuongSanPham.Text = "Số Lượng";
            // 
            // btnSuaSanPham
            // 
            btnSuaSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSuaSanPham.Font = new Font("Segoe UI", 10.8F);
            btnSuaSanPham.Image = Properties.Resources.icons8_update_30;
            btnSuaSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuaSanPham.Location = new Point(210, 418);
            btnSuaSanPham.Name = "btnSuaSanPham";
            btnSuaSanPham.Size = new Size(165, 40);
            btnSuaSanPham.TabIndex = 53;
            btnSuaSanPham.Text = "Sửa Sản Phẩm";
            btnSuaSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnSuaSanPham.UseVisualStyleBackColor = true;
            btnSuaSanPham.Click += btnSuaSanPham_Click;
            // 
            // btnChonTatCa
            // 
            btnChonTatCa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnChonTatCa.Font = new Font("Segoe UI", 10.8F);
            btnChonTatCa.Image = Properties.Resources.icons8_all_30;
            btnChonTatCa.ImageAlign = ContentAlignment.MiddleLeft;
            btnChonTatCa.Location = new Point(26, 372);
            btnChonTatCa.Name = "btnChonTatCa";
            btnChonTatCa.Size = new Size(145, 40);
            btnChonTatCa.TabIndex = 52;
            btnChonTatCa.Text = "Chọn Tất Cả";
            btnChonTatCa.TextAlign = ContentAlignment.MiddleRight;
            btnChonTatCa.UseVisualStyleBackColor = true;
            btnChonTatCa.Click += btnChonTatCa_Click;
            // 
            // btnXoaSanPham
            // 
            btnXoaSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaSanPham.Font = new Font("Segoe UI", 10.8F);
            btnXoaSanPham.Image = Properties.Resources.icons8_delete_30;
            btnXoaSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaSanPham.Location = new Point(177, 372);
            btnXoaSanPham.Name = "btnXoaSanPham";
            btnXoaSanPham.Size = new Size(158, 40);
            btnXoaSanPham.TabIndex = 51;
            btnXoaSanPham.Text = "Xoá Sản Phẩm";
            btnXoaSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnXoaSanPham.UseVisualStyleBackColor = true;
            btnXoaSanPham.Click += btnXoaSanPham_Click;
            // 
            // grpSuaSanPham
            // 
            grpSuaSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            grpSuaSanPham.Location = new Point(694, 448);
            grpSuaSanPham.Name = "grpSuaSanPham";
            grpSuaSanPham.Size = new Size(452, 373);
            grpSuaSanPham.TabIndex = 54;
            grpSuaSanPham.TabStop = false;
            // 
            // btnMoFileSua
            // 
            btnMoFileSua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMoFileSua.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMoFileSua.Location = new Point(364, 181);
            btnMoFileSua.Name = "btnMoFileSua";
            btnMoFileSua.Size = new Size(73, 34);
            btnMoFileSua.TabIndex = 59;
            btnMoFileSua.Text = "Mở File";
            btnMoFileSua.UseVisualStyleBackColor = true;
            btnMoFileSua.Click += btnMoFileSua_Click;
            // 
            // lblSuaNhaCungCap
            // 
            lblSuaNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaNhaCungCap.AutoSize = true;
            lblSuaNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblSuaNhaCungCap.Location = new Point(5, 336);
            lblSuaNhaCungCap.Name = "lblSuaNhaCungCap";
            lblSuaNhaCungCap.Size = new Size(153, 30);
            lblSuaNhaCungCap.TabIndex = 52;
            lblSuaNhaCungCap.Text = "Nhà Cung Cấp";
            // 
            // txtSuaHinhAnhSanPham
            // 
            txtSuaHinhAnhSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaHinhAnhSanPham.Font = new Font("Segoe UI", 12F);
            txtSuaHinhAnhSanPham.Location = new Point(170, 181);
            txtSuaHinhAnhSanPham.Name = "txtSuaHinhAnhSanPham";
            txtSuaHinhAnhSanPham.Size = new Size(189, 34);
            txtSuaHinhAnhSanPham.TabIndex = 58;
            // 
            // lblSuaHinhAnhSanPham
            // 
            lblSuaHinhAnhSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaHinhAnhSanPham.AutoSize = true;
            lblSuaHinhAnhSanPham.Font = new Font("Segoe UI", 13F);
            lblSuaHinhAnhSanPham.Location = new Point(5, 185);
            lblSuaHinhAnhSanPham.Name = "lblSuaHinhAnhSanPham";
            lblSuaHinhAnhSanPham.Size = new Size(102, 30);
            lblSuaHinhAnhSanPham.TabIndex = 57;
            lblSuaHinhAnhSanPham.Text = "Hình Ảnh";
            // 
            // rdoSuaChuaBan
            // 
            rdoSuaChuaBan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdoSuaChuaBan.AutoSize = true;
            rdoSuaChuaBan.Location = new Point(295, 297);
            rdoSuaChuaBan.Name = "rdoSuaChuaBan";
            rdoSuaChuaBan.Size = new Size(115, 32);
            rdoSuaChuaBan.TabIndex = 54;
            rdoSuaChuaBan.TabStop = true;
            rdoSuaChuaBan.Text = "Chưa Bán";
            rdoSuaChuaBan.UseVisualStyleBackColor = true;
            // 
            // rdoSuaDangBan
            // 
            rdoSuaDangBan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdoSuaDangBan.AutoSize = true;
            rdoSuaDangBan.Location = new Point(174, 297);
            rdoSuaDangBan.Name = "rdoSuaDangBan";
            rdoSuaDangBan.Size = new Size(117, 32);
            rdoSuaDangBan.TabIndex = 53;
            rdoSuaDangBan.TabStop = true;
            rdoSuaDangBan.Text = "Đang Bán";
            rdoSuaDangBan.UseVisualStyleBackColor = true;
            // 
            // txtSuaGiaSanPham
            // 
            txtSuaGiaSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaGiaSanPham.Font = new Font("Segoe UI", 12F);
            txtSuaGiaSanPham.Location = new Point(170, 257);
            txtSuaGiaSanPham.Name = "txtSuaGiaSanPham";
            txtSuaGiaSanPham.Size = new Size(267, 34);
            txtSuaGiaSanPham.TabIndex = 36;
            // 
            // lblSuaTrangThaiSanPham
            // 
            lblSuaTrangThaiSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaTrangThaiSanPham.AutoSize = true;
            lblSuaTrangThaiSanPham.Font = new Font("Segoe UI", 13F);
            lblSuaTrangThaiSanPham.Location = new Point(5, 297);
            lblSuaTrangThaiSanPham.Name = "lblSuaTrangThaiSanPham";
            lblSuaTrangThaiSanPham.Size = new Size(113, 30);
            lblSuaTrangThaiSanPham.TabIndex = 52;
            lblSuaTrangThaiSanPham.Text = "Trạng Thái";
            // 
            // btnClearSuaSanPham
            // 
            btnClearSuaSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClearSuaSanPham.Font = new Font("Segoe UI", 10.8F);
            btnClearSuaSanPham.Image = Properties.Resources.icons8_delete_30;
            btnClearSuaSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearSuaSanPham.Location = new Point(287, 328);
            btnClearSuaSanPham.Name = "btnClearSuaSanPham";
            btnClearSuaSanPham.Size = new Size(72, 37);
            btnClearSuaSanPham.TabIndex = 35;
            btnClearSuaSanPham.Text = "Xóa";
            btnClearSuaSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnClearSuaSanPham.UseVisualStyleBackColor = true;
            btnClearSuaSanPham.Click += btnClearSuaSanPham_Click;
            // 
            // lblSuaSanPham
            // 
            lblSuaSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaSanPham.AutoSize = true;
            lblSuaSanPham.Font = new Font("Segoe UI", 14F);
            lblSuaSanPham.Location = new Point(5, 18);
            lblSuaSanPham.Name = "lblSuaSanPham";
            lblSuaSanPham.Size = new Size(282, 32);
            lblSuaSanPham.TabIndex = 34;
            lblSuaSanPham.Text = "Sửa Thông Tin Sản Phẩm";
            // 
            // txtSuaTenSanPham
            // 
            txtSuaTenSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaTenSanPham.Font = new Font("Segoe UI", 12F);
            txtSuaTenSanPham.Location = new Point(170, 102);
            txtSuaTenSanPham.Name = "txtSuaTenSanPham";
            txtSuaTenSanPham.Size = new Size(267, 34);
            txtSuaTenSanPham.TabIndex = 32;
            // 
            // lblSuaMaSanPham
            // 
            lblSuaMaSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaMaSanPham.AutoSize = true;
            lblSuaMaSanPham.Font = new Font("Segoe UI", 13F);
            lblSuaMaSanPham.Location = new Point(5, 64);
            lblSuaMaSanPham.Name = "lblSuaMaSanPham";
            lblSuaMaSanPham.Size = new Size(145, 30);
            lblSuaMaSanPham.TabIndex = 18;
            lblSuaMaSanPham.Text = "Mã Sản Phẩm";
            // 
            // txtSuaMaSanPham
            // 
            txtSuaMaSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaMaSanPham.Font = new Font("Segoe UI", 12F);
            txtSuaMaSanPham.Location = new Point(170, 62);
            txtSuaMaSanPham.Name = "txtSuaMaSanPham";
            txtSuaMaSanPham.ReadOnly = true;
            txtSuaMaSanPham.Size = new Size(267, 34);
            txtSuaMaSanPham.TabIndex = 22;
            // 
            // lblSuaTenSanPham
            // 
            lblSuaTenSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaTenSanPham.AutoSize = true;
            lblSuaTenSanPham.Font = new Font("Segoe UI", 13F);
            lblSuaTenSanPham.Location = new Point(5, 104);
            lblSuaTenSanPham.Name = "lblSuaTenSanPham";
            lblSuaTenSanPham.Size = new Size(148, 30);
            lblSuaTenSanPham.TabIndex = 33;
            lblSuaTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // txtSuaSoLuongSanPham
            // 
            txtSuaSoLuongSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaSoLuongSanPham.Font = new Font("Segoe UI", 12F);
            txtSuaSoLuongSanPham.Location = new Point(170, 221);
            txtSuaSoLuongSanPham.Name = "txtSuaSoLuongSanPham";
            txtSuaSoLuongSanPham.Size = new Size(267, 34);
            txtSuaSoLuongSanPham.TabIndex = 23;
            // 
            // btnLuuSuaSanPham
            // 
            btnLuuSuaSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuuSuaSanPham.Font = new Font("Segoe UI", 10.8F);
            btnLuuSuaSanPham.Image = Properties.Resources.icons8_save_30;
            btnLuuSuaSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuuSuaSanPham.Location = new Point(364, 328);
            btnLuuSuaSanPham.Name = "btnLuuSuaSanPham";
            btnLuuSuaSanPham.Size = new Size(73, 37);
            btnLuuSuaSanPham.TabIndex = 19;
            btnLuuSuaSanPham.Text = "Lưu";
            btnLuuSuaSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnLuuSuaSanPham.UseVisualStyleBackColor = true;
            btnLuuSuaSanPham.Click += btnLuuSuaSanPham_Click;
            // 
            // lblSuaSoLuongSanPham
            // 
            lblSuaSoLuongSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaSoLuongSanPham.AutoSize = true;
            lblSuaSoLuongSanPham.Font = new Font("Segoe UI", 13F);
            lblSuaSoLuongSanPham.Location = new Point(5, 224);
            lblSuaSoLuongSanPham.Name = "lblSuaSoLuongSanPham";
            lblSuaSoLuongSanPham.Size = new Size(105, 30);
            lblSuaSoLuongSanPham.TabIndex = 24;
            lblSuaSoLuongSanPham.Text = "Số Lượng";
            // 
            // txtSuaLoaiSanPham
            // 
            txtSuaLoaiSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaLoaiSanPham.Font = new Font("Segoe UI", 12F);
            txtSuaLoaiSanPham.Location = new Point(170, 141);
            txtSuaLoaiSanPham.Name = "txtSuaLoaiSanPham";
            txtSuaLoaiSanPham.Size = new Size(267, 34);
            txtSuaLoaiSanPham.TabIndex = 25;
            // 
            // lblSuaGiaSanPham
            // 
            lblSuaGiaSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaGiaSanPham.AutoSize = true;
            lblSuaGiaSanPham.Font = new Font("Segoe UI", 13F);
            lblSuaGiaSanPham.Location = new Point(5, 261);
            lblSuaGiaSanPham.Name = "lblSuaGiaSanPham";
            lblSuaGiaSanPham.Size = new Size(44, 30);
            lblSuaGiaSanPham.TabIndex = 28;
            lblSuaGiaSanPham.Text = "Giá";
            // 
            // cmbSuaNhaCungCap
            // 
            cmbSuaNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbSuaNhaCungCap.Font = new Font("Segoe UI", 11F);
            cmbSuaNhaCungCap.FormattingEnabled = true;
            cmbSuaNhaCungCap.Location = new Point(170, 335);
            cmbSuaNhaCungCap.Name = "cmbSuaNhaCungCap";
            cmbSuaNhaCungCap.Size = new Size(111, 33);
            cmbSuaNhaCungCap.TabIndex = 27;
            // 
            // lblSuaLoaiSanPham
            // 
            lblSuaLoaiSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaLoaiSanPham.AutoSize = true;
            lblSuaLoaiSanPham.Font = new Font("Segoe UI", 13F);
            lblSuaLoaiSanPham.Location = new Point(5, 143);
            lblSuaLoaiSanPham.Name = "lblSuaLoaiSanPham";
            lblSuaLoaiSanPham.Size = new Size(153, 30);
            lblSuaLoaiSanPham.TabIndex = 26;
            lblSuaLoaiSanPham.Text = "Loại Sản Phẩm";
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThemSanPham.Font = new Font("Segoe UI", 10.8F);
            btnThemSanPham.Image = Properties.Resources.icons8_add_30;
            btnThemSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemSanPham.Location = new Point(26, 418);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(178, 40);
            btnThemSanPham.TabIndex = 59;
            btnThemSanPham.Text = "Thêm Sản Phẩm";
            btnThemSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnThemSanPham.UseVisualStyleBackColor = true;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // lblAnhSanPham
            // 
            lblAnhSanPham.Anchor = AnchorStyles.Top;
            lblAnhSanPham.AutoSize = true;
            lblAnhSanPham.Font = new Font("Segoe UI", 13F);
            lblAnhSanPham.Location = new Point(501, 753);
            lblAnhSanPham.Name = "lblAnhSanPham";
            lblAnhSanPham.Size = new Size(152, 30);
            lblAnhSanPham.TabIndex = 57;
            lblAnhSanPham.Text = "Ảnh Sản Phẩm";
            // 
            // picAnhSanPham
            // 
            picAnhSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picAnhSanPham.Image = (Image)resources.GetObject("picAnhSanPham.Image");
            picAnhSanPham.Location = new Point(461, 496);
            picAnhSanPham.Name = "picAnhSanPham";
            picAnhSanPham.Size = new Size(227, 254);
            picAnhSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            picAnhSanPham.TabIndex = 29;
            picAnhSanPham.TabStop = false;
            // 
            // frmKho
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 841);
            Controls.Add(lblAnhSanPham);
            Controls.Add(btnThemSanPham);
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
            Font = new Font("Segoe UI", 10.8F);
            Margin = new Padding(4);
            Name = "frmKho";
            Text = "Quản Lí Kho";
            Load += frmKho_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            grpThemSanPham.ResumeLayout(false);
            grpThemSanPham.PerformLayout();
            grpSuaSanPham.ResumeLayout(false);
            grpSuaSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhSanPham).EndInit();
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
        private Button btnMoFileThem;
        private Button btnMoFileSua;
        private TextBox txtSuaHinhAnhSanPham;
        private Label lblSuaHinhAnhSanPham;
        private Button btnThemSanPham;
        private Label lblAnhSanPham;
        private PictureBox picAnhSanPham;
    }
}