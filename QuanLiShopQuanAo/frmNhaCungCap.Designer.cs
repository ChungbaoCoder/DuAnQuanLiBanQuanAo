namespace QuanLiShopQuanAo
{
    partial class frmNhaCungCap
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
            btnXoaNhaCungCap = new Button();
            btnSuaNhaCungCap = new Button();
            btnTaiLaiDanhSach = new Button();
            btnTimNhaCungCap = new Button();
            txtTimKiemNhaCungCap = new TextBox();
            grpThemNhaCungCap = new GroupBox();
            cmbThemMaSanPham = new ComboBox();
            lblThemMaSanPham = new Label();
            lblThemSDTNhaCungCap = new Label();
            btnClearThemNhaCungCap = new Button();
            btnLuuThemNhaCungCap = new Button();
            lblThemNhaCungCap = new Label();
            txtThemDiaChiNhaCungCap = new TextBox();
            txtThemSDTNhaCungCap = new TextBox();
            txtThemTenNhaCungCap = new TextBox();
            lblThemTenNhaCungCap = new Label();
            lblThemDiaChiNhaCungCap = new Label();
            btnChonTatCa = new Button();
            grpSuaNhaCungCap = new GroupBox();
            cmbSuaMaSanPham = new ComboBox();
            lblSuaMaSanPham = new Label();
            btnClearSuaNhaCungCap = new Button();
            lblSuaNhaCungCap = new Label();
            txtSuaTenNhaCungCap = new TextBox();
            lblSuaMaNhaCungCap = new Label();
            txtSuaMaNhaCungCap = new TextBox();
            lblSuaTenNhaCungCap = new Label();
            txtSuaDiaChiNhaCungCap = new TextBox();
            lblSuaDiaChiNhaCungCap = new Label();
            txtSuaSDTNhaCungCap = new TextBox();
            btnLuuSuaNhaCungCap = new Button();
            lblSuaSDTNhaCungCap = new Label();
            btnThemNhaCungCap = new Button();
            dgvNhaCungCap = new DataGridView();
            dgvhCheckBoxNhaCungCap = new DataGridViewCheckBoxColumn();
            dgvhMaNhaCungCap = new DataGridViewTextBoxColumn();
            dgvhTenNhaCungCap = new DataGridViewTextBoxColumn();
            dgvhDiaChiNhaCungCap = new DataGridViewTextBoxColumn();
            dgvhSDTNhaCungCap = new DataGridViewTextBoxColumn();
            msDashBoard.SuspendLayout();
            grpThemNhaCungCap.SuspendLayout();
            grpSuaNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
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
            msDashBoard.Size = new Size(172, 700);
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
            // btnXoaNhaCungCap
            // 
            btnXoaNhaCungCap.Location = new Point(327, 327);
            btnXoaNhaCungCap.Name = "btnXoaNhaCungCap";
            btnXoaNhaCungCap.Size = new Size(140, 45);
            btnXoaNhaCungCap.TabIndex = 68;
            btnXoaNhaCungCap.Text = "Xoá Nhà CC";
            btnXoaNhaCungCap.UseVisualStyleBackColor = true;
            btnXoaNhaCungCap.Click += btnXoaNhaCungCap_Click;
            // 
            // btnSuaNhaCungCap
            // 
            btnSuaNhaCungCap.Location = new Point(327, 378);
            btnSuaNhaCungCap.Name = "btnSuaNhaCungCap";
            btnSuaNhaCungCap.Size = new Size(140, 45);
            btnSuaNhaCungCap.TabIndex = 67;
            btnSuaNhaCungCap.Text = "Sửa Nhà CC";
            btnSuaNhaCungCap.UseVisualStyleBackColor = true;
            btnSuaNhaCungCap.Click += btnSuaNhaCungCap_Click;
            // 
            // btnTaiLaiDanhSach
            // 
            btnTaiLaiDanhSach.Location = new Point(473, 327);
            btnTaiLaiDanhSach.Name = "btnTaiLaiDanhSach";
            btnTaiLaiDanhSach.Size = new Size(180, 45);
            btnTaiLaiDanhSach.TabIndex = 66;
            btnTaiLaiDanhSach.Text = "Tải Lại Danh Sách";
            btnTaiLaiDanhSach.UseVisualStyleBackColor = true;
            btnTaiLaiDanhSach.Click += btnTaiLaiDanhSach_Click;
            // 
            // btnTimNhaCungCap
            // 
            btnTimNhaCungCap.Font = new Font("Segoe UI", 12F);
            btnTimNhaCungCap.Location = new Point(1044, 332);
            btnTimNhaCungCap.Name = "btnTimNhaCungCap";
            btnTimNhaCungCap.Size = new Size(90, 34);
            btnTimNhaCungCap.TabIndex = 61;
            btnTimNhaCungCap.Text = "Tìm";
            btnTimNhaCungCap.UseVisualStyleBackColor = true;
            btnTimNhaCungCap.Click += btnTimNhaCungCap_Click;
            // 
            // txtTimKiemNhaCungCap
            // 
            txtTimKiemNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtTimKiemNhaCungCap.Location = new Point(659, 332);
            txtTimKiemNhaCungCap.Name = "txtTimKiemNhaCungCap";
            txtTimKiemNhaCungCap.Size = new Size(379, 34);
            txtTimKiemNhaCungCap.TabIndex = 65;
            // 
            // grpThemNhaCungCap
            // 
            grpThemNhaCungCap.Controls.Add(cmbThemMaSanPham);
            grpThemNhaCungCap.Controls.Add(lblThemMaSanPham);
            grpThemNhaCungCap.Controls.Add(lblThemSDTNhaCungCap);
            grpThemNhaCungCap.Controls.Add(btnClearThemNhaCungCap);
            grpThemNhaCungCap.Controls.Add(btnLuuThemNhaCungCap);
            grpThemNhaCungCap.Controls.Add(lblThemNhaCungCap);
            grpThemNhaCungCap.Controls.Add(txtThemDiaChiNhaCungCap);
            grpThemNhaCungCap.Controls.Add(txtThemSDTNhaCungCap);
            grpThemNhaCungCap.Controls.Add(txtThemTenNhaCungCap);
            grpThemNhaCungCap.Controls.Add(lblThemTenNhaCungCap);
            grpThemNhaCungCap.Controls.Add(lblThemDiaChiNhaCungCap);
            grpThemNhaCungCap.Location = new Point(181, 423);
            grpThemNhaCungCap.Name = "grpThemNhaCungCap";
            grpThemNhaCungCap.Size = new Size(462, 261);
            grpThemNhaCungCap.TabIndex = 64;
            grpThemNhaCungCap.TabStop = false;
            // 
            // cmbThemMaSanPham
            // 
            cmbThemMaSanPham.Font = new Font("Segoe UI", 11F);
            cmbThemMaSanPham.FormattingEnabled = true;
            cmbThemMaSanPham.Items.AddRange(new object[] { "Nhân Viên", "Quản Trị" });
            cmbThemMaSanPham.Location = new Point(214, 208);
            cmbThemMaSanPham.Name = "cmbThemMaSanPham";
            cmbThemMaSanPham.Size = new Size(88, 33);
            cmbThemMaSanPham.TabIndex = 50;
            // 
            // lblThemMaSanPham
            // 
            lblThemMaSanPham.AutoSize = true;
            lblThemMaSanPham.Font = new Font("Segoe UI", 13F);
            lblThemMaSanPham.Location = new Point(6, 211);
            lblThemMaSanPham.Name = "lblThemMaSanPham";
            lblThemMaSanPham.Size = new Size(145, 30);
            lblThemMaSanPham.TabIndex = 49;
            lblThemMaSanPham.Text = "Mã Sản Phẩm";
            // 
            // lblThemSDTNhaCungCap
            // 
            lblThemSDTNhaCungCap.AutoSize = true;
            lblThemSDTNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblThemSDTNhaCungCap.Location = new Point(6, 123);
            lblThemSDTNhaCungCap.Name = "lblThemSDTNhaCungCap";
            lblThemSDTNhaCungCap.Size = new Size(147, 30);
            lblThemSDTNhaCungCap.TabIndex = 36;
            lblThemSDTNhaCungCap.Text = "Số Điện Thoại";
            // 
            // btnClearThemNhaCungCap
            // 
            btnClearThemNhaCungCap.Font = new Font("Segoe UI", 12F);
            btnClearThemNhaCungCap.Location = new Point(308, 207);
            btnClearThemNhaCungCap.Name = "btnClearThemNhaCungCap";
            btnClearThemNhaCungCap.Size = new Size(70, 34);
            btnClearThemNhaCungCap.TabIndex = 37;
            btnClearThemNhaCungCap.Text = "Clear";
            btnClearThemNhaCungCap.UseVisualStyleBackColor = true;
            btnClearThemNhaCungCap.Click += btnClearThemNhaCungCap_Click;
            // 
            // btnLuuThemNhaCungCap
            // 
            btnLuuThemNhaCungCap.Font = new Font("Segoe UI", 12F);
            btnLuuThemNhaCungCap.Location = new Point(384, 207);
            btnLuuThemNhaCungCap.Name = "btnLuuThemNhaCungCap";
            btnLuuThemNhaCungCap.Size = new Size(70, 34);
            btnLuuThemNhaCungCap.TabIndex = 36;
            btnLuuThemNhaCungCap.Text = "Lưu";
            btnLuuThemNhaCungCap.UseVisualStyleBackColor = true;
            btnLuuThemNhaCungCap.Click += btnLuuThemNhaCungCap_Click;
            // 
            // lblThemNhaCungCap
            // 
            lblThemNhaCungCap.AutoSize = true;
            lblThemNhaCungCap.Font = new Font("Segoe UI", 14F);
            lblThemNhaCungCap.Location = new Point(6, 21);
            lblThemNhaCungCap.Name = "lblThemNhaCungCap";
            lblThemNhaCungCap.Size = new Size(354, 32);
            lblThemNhaCungCap.TabIndex = 36;
            lblThemNhaCungCap.Text = "Thêm Thông Tin Nhà Cung Cấp";
            // 
            // txtThemDiaChiNhaCungCap
            // 
            txtThemDiaChiNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtThemDiaChiNhaCungCap.Location = new Point(214, 163);
            txtThemDiaChiNhaCungCap.Name = "txtThemDiaChiNhaCungCap";
            txtThemDiaChiNhaCungCap.Size = new Size(240, 34);
            txtThemDiaChiNhaCungCap.TabIndex = 47;
            // 
            // txtThemSDTNhaCungCap
            // 
            txtThemSDTNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtThemSDTNhaCungCap.Location = new Point(214, 119);
            txtThemSDTNhaCungCap.Name = "txtThemSDTNhaCungCap";
            txtThemSDTNhaCungCap.Size = new Size(240, 34);
            txtThemSDTNhaCungCap.TabIndex = 45;
            // 
            // txtThemTenNhaCungCap
            // 
            txtThemTenNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtThemTenNhaCungCap.Location = new Point(214, 77);
            txtThemTenNhaCungCap.Name = "txtThemTenNhaCungCap";
            txtThemTenNhaCungCap.Size = new Size(240, 34);
            txtThemTenNhaCungCap.TabIndex = 41;
            // 
            // lblThemTenNhaCungCap
            // 
            lblThemTenNhaCungCap.AutoSize = true;
            lblThemTenNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblThemTenNhaCungCap.Location = new Point(6, 79);
            lblThemTenNhaCungCap.Name = "lblThemTenNhaCungCap";
            lblThemTenNhaCungCap.Size = new Size(193, 30);
            lblThemTenNhaCungCap.TabIndex = 42;
            lblThemTenNhaCungCap.Text = "Tên Nhà Cung Cấp";
            // 
            // lblThemDiaChiNhaCungCap
            // 
            lblThemDiaChiNhaCungCap.AutoSize = true;
            lblThemDiaChiNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblThemDiaChiNhaCungCap.Location = new Point(6, 165);
            lblThemDiaChiNhaCungCap.Name = "lblThemDiaChiNhaCungCap";
            lblThemDiaChiNhaCungCap.Size = new Size(81, 30);
            lblThemDiaChiNhaCungCap.TabIndex = 38;
            lblThemDiaChiNhaCungCap.Text = "Địa Chỉ";
            // 
            // btnChonTatCa
            // 
            btnChonTatCa.Location = new Point(181, 327);
            btnChonTatCa.Name = "btnChonTatCa";
            btnChonTatCa.Size = new Size(140, 45);
            btnChonTatCa.TabIndex = 62;
            btnChonTatCa.Text = "Chọn Tất Cả";
            btnChonTatCa.UseVisualStyleBackColor = true;
            btnChonTatCa.Click += btnChonTatCa_Click;
            // 
            // grpSuaNhaCungCap
            // 
            grpSuaNhaCungCap.Controls.Add(cmbSuaMaSanPham);
            grpSuaNhaCungCap.Controls.Add(lblSuaMaSanPham);
            grpSuaNhaCungCap.Controls.Add(btnClearSuaNhaCungCap);
            grpSuaNhaCungCap.Controls.Add(lblSuaNhaCungCap);
            grpSuaNhaCungCap.Controls.Add(txtSuaTenNhaCungCap);
            grpSuaNhaCungCap.Controls.Add(lblSuaMaNhaCungCap);
            grpSuaNhaCungCap.Controls.Add(txtSuaMaNhaCungCap);
            grpSuaNhaCungCap.Controls.Add(lblSuaTenNhaCungCap);
            grpSuaNhaCungCap.Controls.Add(txtSuaDiaChiNhaCungCap);
            grpSuaNhaCungCap.Controls.Add(lblSuaDiaChiNhaCungCap);
            grpSuaNhaCungCap.Controls.Add(txtSuaSDTNhaCungCap);
            grpSuaNhaCungCap.Controls.Add(btnLuuSuaNhaCungCap);
            grpSuaNhaCungCap.Controls.Add(lblSuaSDTNhaCungCap);
            grpSuaNhaCungCap.Font = new Font("Segoe UI", 12F);
            grpSuaNhaCungCap.Location = new Point(649, 378);
            grpSuaNhaCungCap.Name = "grpSuaNhaCungCap";
            grpSuaNhaCungCap.Size = new Size(485, 306);
            grpSuaNhaCungCap.TabIndex = 63;
            grpSuaNhaCungCap.TabStop = false;
            // 
            // cmbSuaMaSanPham
            // 
            cmbSuaMaSanPham.Font = new Font("Segoe UI", 11F);
            cmbSuaMaSanPham.FormattingEnabled = true;
            cmbSuaMaSanPham.Items.AddRange(new object[] { "Nhân Viên", "Quản Trị" });
            cmbSuaMaSanPham.Location = new Point(228, 254);
            cmbSuaMaSanPham.Name = "cmbSuaMaSanPham";
            cmbSuaMaSanPham.Size = new Size(88, 33);
            cmbSuaMaSanPham.TabIndex = 51;
            // 
            // lblSuaMaSanPham
            // 
            lblSuaMaSanPham.AutoSize = true;
            lblSuaMaSanPham.Font = new Font("Segoe UI", 13F);
            lblSuaMaSanPham.Location = new Point(6, 257);
            lblSuaMaSanPham.Name = "lblSuaMaSanPham";
            lblSuaMaSanPham.Size = new Size(145, 30);
            lblSuaMaSanPham.TabIndex = 51;
            lblSuaMaSanPham.Text = "Mã Sản Phẩm";
            // 
            // btnClearSuaNhaCungCap
            // 
            btnClearSuaNhaCungCap.Font = new Font("Segoe UI", 12F);
            btnClearSuaNhaCungCap.Location = new Point(322, 253);
            btnClearSuaNhaCungCap.Name = "btnClearSuaNhaCungCap";
            btnClearSuaNhaCungCap.Size = new Size(70, 34);
            btnClearSuaNhaCungCap.TabIndex = 35;
            btnClearSuaNhaCungCap.Text = "Clear";
            btnClearSuaNhaCungCap.UseVisualStyleBackColor = true;
            btnClearSuaNhaCungCap.Click += btnClearSuaNhaCungCap_Click;
            // 
            // lblSuaNhaCungCap
            // 
            lblSuaNhaCungCap.AutoSize = true;
            lblSuaNhaCungCap.Font = new Font("Segoe UI", 14F);
            lblSuaNhaCungCap.Location = new Point(10, 21);
            lblSuaNhaCungCap.Name = "lblSuaNhaCungCap";
            lblSuaNhaCungCap.Size = new Size(332, 32);
            lblSuaNhaCungCap.TabIndex = 34;
            lblSuaNhaCungCap.Text = "Sửa Thông Tin Nhà Cung Cấp";
            // 
            // txtSuaTenNhaCungCap
            // 
            txtSuaTenNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtSuaTenNhaCungCap.Location = new Point(229, 123);
            txtSuaTenNhaCungCap.Name = "txtSuaTenNhaCungCap";
            txtSuaTenNhaCungCap.Size = new Size(239, 34);
            txtSuaTenNhaCungCap.TabIndex = 32;
            // 
            // lblSuaMaNhaCungCap
            // 
            lblSuaMaNhaCungCap.AutoSize = true;
            lblSuaMaNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblSuaMaNhaCungCap.Location = new Point(6, 79);
            lblSuaMaNhaCungCap.Name = "lblSuaMaNhaCungCap";
            lblSuaMaNhaCungCap.Size = new Size(190, 30);
            lblSuaMaNhaCungCap.TabIndex = 18;
            lblSuaMaNhaCungCap.Text = "Mã Nhà Cung Cấp";
            // 
            // txtSuaMaNhaCungCap
            // 
            txtSuaMaNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtSuaMaNhaCungCap.Location = new Point(228, 79);
            txtSuaMaNhaCungCap.Name = "txtSuaMaNhaCungCap";
            txtSuaMaNhaCungCap.ReadOnly = true;
            txtSuaMaNhaCungCap.Size = new Size(240, 34);
            txtSuaMaNhaCungCap.TabIndex = 22;
            // 
            // lblSuaTenNhaCungCap
            // 
            lblSuaTenNhaCungCap.AutoSize = true;
            lblSuaTenNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblSuaTenNhaCungCap.Location = new Point(6, 123);
            lblSuaTenNhaCungCap.Name = "lblSuaTenNhaCungCap";
            lblSuaTenNhaCungCap.Size = new Size(193, 30);
            lblSuaTenNhaCungCap.TabIndex = 33;
            lblSuaTenNhaCungCap.Text = "Tên Nhà Cung Cấp";
            // 
            // txtSuaDiaChiNhaCungCap
            // 
            txtSuaDiaChiNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtSuaDiaChiNhaCungCap.Location = new Point(229, 211);
            txtSuaDiaChiNhaCungCap.Name = "txtSuaDiaChiNhaCungCap";
            txtSuaDiaChiNhaCungCap.Size = new Size(239, 34);
            txtSuaDiaChiNhaCungCap.TabIndex = 23;
            // 
            // lblSuaDiaChiNhaCungCap
            // 
            lblSuaDiaChiNhaCungCap.AutoSize = true;
            lblSuaDiaChiNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblSuaDiaChiNhaCungCap.Location = new Point(6, 213);
            lblSuaDiaChiNhaCungCap.Name = "lblSuaDiaChiNhaCungCap";
            lblSuaDiaChiNhaCungCap.Size = new Size(81, 30);
            lblSuaDiaChiNhaCungCap.TabIndex = 24;
            lblSuaDiaChiNhaCungCap.Text = "Địa Chỉ";
            // 
            // txtSuaSDTNhaCungCap
            // 
            txtSuaSDTNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtSuaSDTNhaCungCap.Location = new Point(229, 167);
            txtSuaSDTNhaCungCap.Name = "txtSuaSDTNhaCungCap";
            txtSuaSDTNhaCungCap.Size = new Size(239, 34);
            txtSuaSDTNhaCungCap.TabIndex = 25;
            // 
            // btnLuuSuaNhaCungCap
            // 
            btnLuuSuaNhaCungCap.Font = new Font("Segoe UI", 12F);
            btnLuuSuaNhaCungCap.Location = new Point(398, 253);
            btnLuuSuaNhaCungCap.Name = "btnLuuSuaNhaCungCap";
            btnLuuSuaNhaCungCap.Size = new Size(70, 34);
            btnLuuSuaNhaCungCap.TabIndex = 19;
            btnLuuSuaNhaCungCap.Text = "Lưu";
            btnLuuSuaNhaCungCap.UseVisualStyleBackColor = true;
            btnLuuSuaNhaCungCap.Click += btnLuuSuaNhaCungCap_Click;
            // 
            // lblSuaSDTNhaCungCap
            // 
            lblSuaSDTNhaCungCap.AutoSize = true;
            lblSuaSDTNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblSuaSDTNhaCungCap.Location = new Point(6, 169);
            lblSuaSDTNhaCungCap.Name = "lblSuaSDTNhaCungCap";
            lblSuaSDTNhaCungCap.Size = new Size(147, 30);
            lblSuaSDTNhaCungCap.TabIndex = 26;
            lblSuaSDTNhaCungCap.Text = "Số Điện Thoại";
            // 
            // btnThemNhaCungCap
            // 
            btnThemNhaCungCap.Location = new Point(181, 378);
            btnThemNhaCungCap.Name = "btnThemNhaCungCap";
            btnThemNhaCungCap.Size = new Size(140, 45);
            btnThemNhaCungCap.TabIndex = 69;
            btnThemNhaCungCap.Text = "Thêm Nhà CC";
            btnThemNhaCungCap.UseVisualStyleBackColor = true;
            btnThemNhaCungCap.Click += btnThemNhaCungCap_Click;
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.AllowUserToAddRows = false;
            dgvNhaCungCap.AllowUserToDeleteRows = false;
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCungCap.Columns.AddRange(new DataGridViewColumn[] { dgvhCheckBoxNhaCungCap, dgvhMaNhaCungCap, dgvhTenNhaCungCap, dgvhDiaChiNhaCungCap, dgvhSDTNhaCungCap });
            dgvNhaCungCap.Location = new Point(181, 12);
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.RowHeadersVisible = false;
            dgvNhaCungCap.RowHeadersWidth = 51;
            dgvNhaCungCap.Size = new Size(953, 300);
            dgvNhaCungCap.TabIndex = 38;
            // 
            // dgvhCheckBoxNhaCungCap
            // 
            dgvhCheckBoxNhaCungCap.HeaderText = "";
            dgvhCheckBoxNhaCungCap.MinimumWidth = 6;
            dgvhCheckBoxNhaCungCap.Name = "dgvhCheckBoxNhaCungCap";
            dgvhCheckBoxNhaCungCap.Width = 25;
            // 
            // dgvhMaNhaCungCap
            // 
            dgvhMaNhaCungCap.HeaderText = "Mã Nhà Cung Cấp";
            dgvhMaNhaCungCap.MinimumWidth = 6;
            dgvhMaNhaCungCap.Name = "dgvhMaNhaCungCap";
            dgvhMaNhaCungCap.ReadOnly = true;
            dgvhMaNhaCungCap.Width = 200;
            // 
            // dgvhTenNhaCungCap
            // 
            dgvhTenNhaCungCap.HeaderText = "Tên Nhà Cung Cấp";
            dgvhTenNhaCungCap.MinimumWidth = 6;
            dgvhTenNhaCungCap.Name = "dgvhTenNhaCungCap";
            dgvhTenNhaCungCap.ReadOnly = true;
            dgvhTenNhaCungCap.Width = 250;
            // 
            // dgvhDiaChiNhaCungCap
            // 
            dgvhDiaChiNhaCungCap.HeaderText = "Địa Chỉ";
            dgvhDiaChiNhaCungCap.MinimumWidth = 6;
            dgvhDiaChiNhaCungCap.Name = "dgvhDiaChiNhaCungCap";
            dgvhDiaChiNhaCungCap.ReadOnly = true;
            dgvhDiaChiNhaCungCap.Width = 250;
            // 
            // dgvhSDTNhaCungCap
            // 
            dgvhSDTNhaCungCap.HeaderText = "Số Điện Thoại";
            dgvhSDTNhaCungCap.MinimumWidth = 6;
            dgvhSDTNhaCungCap.Name = "dgvhSDTNhaCungCap";
            dgvhSDTNhaCungCap.ReadOnly = true;
            dgvhSDTNhaCungCap.Width = 225;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 700);
            Controls.Add(btnThemNhaCungCap);
            Controls.Add(btnXoaNhaCungCap);
            Controls.Add(btnSuaNhaCungCap);
            Controls.Add(btnTaiLaiDanhSach);
            Controls.Add(btnTimNhaCungCap);
            Controls.Add(txtTimKiemNhaCungCap);
            Controls.Add(grpThemNhaCungCap);
            Controls.Add(btnChonTatCa);
            Controls.Add(grpSuaNhaCungCap);
            Controls.Add(dgvNhaCungCap);
            Controls.Add(msDashBoard);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmNhaCungCap";
            Text = "Quản Lí Nhà Cung Cấp";
            Load += frmNhaCungCap_Load;
            msDashBoard.ResumeLayout(false);
            msDashBoard.PerformLayout();
            grpThemNhaCungCap.ResumeLayout(false);
            grpThemNhaCungCap.PerformLayout();
            grpSuaNhaCungCap.ResumeLayout(false);
            grpSuaNhaCungCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
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
        private Button btnXoaNhaCungCap;
        private Button btnSuaNhaCungCap;
        private Button btnTaiLaiDanhSach;
        private Button btnTimNhaCungCap;
        private TextBox txtTimKiemNhaCungCap;
        private GroupBox grpThemNhaCungCap;
        private Label lblThemSDTNhaCungCap;
        private Button btnClearThemNhaCungCap;
        private Button btnLuuThemNhaCungCap;
        private Label lblThemNhaCungCap;
        private TextBox txtThemDiaChiNhaCungCap;
        private TextBox txtThemSDTNhaCungCap;
        private TextBox txtThemTenNhaCungCap;
        private Label lblThemTenNhaCungCap;
        private Label lblThemDiaChiNhaCungCap;
        private Button btnChonTatCa;
        private GroupBox grpSuaNhaCungCap;
        private Button btnClearSuaNhaCungCap;
        private Label lblSuaNhaCungCap;
        private TextBox txtSuaTenNhaCungCap;
        private Label lblSuaMaNhaCungCap;
        private TextBox txtSuaMaNhaCungCap;
        private Label lblSuaTenNhaCungCap;
        private TextBox txtSuaDiaChiNhaCungCap;
        private Label lblSuaDiaChiNhaCungCap;
        private TextBox txtSuaSDTNhaCungCap;
        private Button btnLuuSuaNhaCungCap;
        private Label lblSuaSDTNhaCungCap;
        private Label lblThemMaSanPham;
        private Label lblSuaMaSanPham;
        private ComboBox cmbThemMaSanPham;
        private ComboBox cmbSuaMaSanPham;
        private Button btnThemNhaCungCap;
        private DataGridView dgvNhaCungCap;
        private DataGridViewCheckBoxColumn dgvhCheckBoxNhaCungCap;
        private DataGridViewTextBoxColumn dgvhMaNhaCungCap;
        private DataGridViewTextBoxColumn dgvhTenNhaCungCap;
        private DataGridViewTextBoxColumn dgvhDiaChiNhaCungCap;
        private DataGridViewTextBoxColumn dgvhSDTNhaCungCap;
    }
}