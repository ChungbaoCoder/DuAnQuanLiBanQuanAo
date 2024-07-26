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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
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
            grpThemKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            grpSuaKhachHang.SuspendLayout();
            SuspendLayout();
            // 
            // btnTaiLaiDanhSach
            // 
            btnTaiLaiDanhSach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTaiLaiDanhSach.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTaiLaiDanhSach.Image = (Image)resources.GetObject("btnTaiLaiDanhSach.Image");
            btnTaiLaiDanhSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaiLaiDanhSach.Location = new Point(323, 427);
            btnTaiLaiDanhSach.Name = "btnTaiLaiDanhSach";
            btnTaiLaiDanhSach.Size = new Size(180, 45);
            btnTaiLaiDanhSach.TabIndex = 58;
            btnTaiLaiDanhSach.Text = "Tải Lại Danh Sách";
            btnTaiLaiDanhSach.TextAlign = ContentAlignment.MiddleRight;
            btnTaiLaiDanhSach.UseVisualStyleBackColor = true;
            btnTaiLaiDanhSach.Click += btnTaiLaiDanhSach_Click;
            // 
            // btnTimKhachHang
            // 
            btnTimKhachHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTimKhachHang.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKhachHang.Image = (Image)resources.GetObject("btnTimKhachHang.Image");
            btnTimKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKhachHang.Location = new Point(943, 433);
            btnTimKhachHang.Name = "btnTimKhachHang";
            btnTimKhachHang.Size = new Size(91, 34);
            btnTimKhachHang.TabIndex = 50;
            btnTimKhachHang.Text = "Tìm";
            btnTimKhachHang.TextAlign = ContentAlignment.MiddleRight;
            btnTimKhachHang.UseVisualStyleBackColor = true;
            btnTimKhachHang.Click += btnTimKhachHang_Click;
            // 
            // txtTimKiemKhachHang
            // 
            txtTimKiemKhachHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiemKhachHang.Font = new Font("Segoe UI", 12F);
            txtTimKiemKhachHang.Location = new Point(575, 432);
            txtTimKiemKhachHang.Name = "txtTimKiemKhachHang";
            txtTimKiemKhachHang.Size = new Size(362, 34);
            txtTimKiemKhachHang.TabIndex = 57;
            // 
            // grpThemKhachHang
            // 
            grpThemKhachHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            grpThemKhachHang.Controls.Add(lblThemSDTKhachHang);
            grpThemKhachHang.Controls.Add(btnClearThemKhachHang);
            grpThemKhachHang.Controls.Add(btnLuuThemKhachHang);
            grpThemKhachHang.Controls.Add(lblThemKhachHang);
            grpThemKhachHang.Controls.Add(txtThemDiaChiKhachHang);
            grpThemKhachHang.Controls.Add(txtThemSDTKhachHang);
            grpThemKhachHang.Controls.Add(txtThemTenKhachHang);
            grpThemKhachHang.Controls.Add(lblThemTenKhachHang);
            grpThemKhachHang.Controls.Add(lblThemDiaChiKhachHang);
            grpThemKhachHang.Location = new Point(31, 529);
            grpThemKhachHang.Name = "grpThemKhachHang";
            grpThemKhachHang.Size = new Size(486, 251);
            grpThemKhachHang.TabIndex = 56;
            grpThemKhachHang.TabStop = false;
            // 
            // lblThemSDTKhachHang
            // 
            lblThemSDTKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            btnClearThemKhachHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClearThemKhachHang.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearThemKhachHang.Image = (Image)resources.GetObject("btnClearThemKhachHang.Image");
            btnClearThemKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearThemKhachHang.Location = new Point(263, 204);
            btnClearThemKhachHang.Name = "btnClearThemKhachHang";
            btnClearThemKhachHang.Size = new Size(94, 34);
            btnClearThemKhachHang.TabIndex = 37;
            btnClearThemKhachHang.Text = "Xóa";
            btnClearThemKhachHang.TextAlign = ContentAlignment.MiddleRight;
            btnClearThemKhachHang.UseVisualStyleBackColor = true;
            btnClearThemKhachHang.Click += btnClearThemKhachHang_Click;
            // 
            // btnLuuThemKhachHang
            // 
            btnLuuThemKhachHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuuThemKhachHang.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuuThemKhachHang.Image = (Image)resources.GetObject("btnLuuThemKhachHang.Image");
            btnLuuThemKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuuThemKhachHang.Location = new Point(363, 204);
            btnLuuThemKhachHang.Name = "btnLuuThemKhachHang";
            btnLuuThemKhachHang.Size = new Size(85, 33);
            btnLuuThemKhachHang.TabIndex = 36;
            btnLuuThemKhachHang.Text = "Lưu";
            btnLuuThemKhachHang.TextAlign = ContentAlignment.MiddleRight;
            btnLuuThemKhachHang.UseVisualStyleBackColor = true;
            btnLuuThemKhachHang.Click += btnLuuThemKhachHang_Click;
            // 
            // lblThemKhachHang
            // 
            lblThemKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            txtThemDiaChiKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtThemDiaChiKhachHang.Font = new Font("Segoe UI", 12F);
            txtThemDiaChiKhachHang.Location = new Point(183, 163);
            txtThemDiaChiKhachHang.Name = "txtThemDiaChiKhachHang";
            txtThemDiaChiKhachHang.Size = new Size(290, 34);
            txtThemDiaChiKhachHang.TabIndex = 47;
            // 
            // txtThemSDTKhachHang
            // 
            txtThemSDTKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtThemSDTKhachHang.Font = new Font("Segoe UI", 12F);
            txtThemSDTKhachHang.Location = new Point(183, 119);
            txtThemSDTKhachHang.Name = "txtThemSDTKhachHang";
            txtThemSDTKhachHang.Size = new Size(290, 34);
            txtThemSDTKhachHang.TabIndex = 45;
            // 
            // txtThemTenKhachHang
            // 
            txtThemTenKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtThemTenKhachHang.Font = new Font("Segoe UI", 12F);
            txtThemTenKhachHang.Location = new Point(183, 75);
            txtThemTenKhachHang.Name = "txtThemTenKhachHang";
            txtThemTenKhachHang.Size = new Size(290, 34);
            txtThemTenKhachHang.TabIndex = 41;
            // 
            // lblThemTenKhachHang
            // 
            lblThemTenKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            lblThemDiaChiKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            btnChonTatCa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnChonTatCa.BackgroundImageLayout = ImageLayout.Zoom;
            btnChonTatCa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChonTatCa.Image = (Image)resources.GetObject("btnChonTatCa.Image");
            btnChonTatCa.ImageAlign = ContentAlignment.MiddleLeft;
            btnChonTatCa.Location = new Point(31, 427);
            btnChonTatCa.Name = "btnChonTatCa";
            btnChonTatCa.Size = new Size(140, 45);
            btnChonTatCa.TabIndex = 53;
            btnChonTatCa.Text = "Chọn Tất Cả";
            btnChonTatCa.TextAlign = ContentAlignment.MiddleRight;
            btnChonTatCa.UseVisualStyleBackColor = true;
            btnChonTatCa.Click += btnChonTatCa_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AllowUserToResizeColumns = false;
            dgvKhachHang.AllowUserToResizeRows = false;
            dgvKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { dgvhCheckBoxKH, dgvhMaKH, dgvhTenKH, dgvhSDTKH, dgvhDiaChiKH });
            dgvKhachHang.Location = new Point(31, 12);
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
            // 
            // dgvhMaKH
            // 
            dgvhMaKH.HeaderText = "Mã Khách Hàng";
            dgvhMaKH.MinimumWidth = 6;
            dgvhMaKH.Name = "dgvhMaKH";
            dgvhMaKH.ReadOnly = true;
            // 
            // dgvhTenKH
            // 
            dgvhTenKH.HeaderText = "Tên Khách Hàng";
            dgvhTenKH.MinimumWidth = 6;
            dgvhTenKH.Name = "dgvhTenKH";
            dgvhTenKH.ReadOnly = true;
            // 
            // dgvhSDTKH
            // 
            dgvhSDTKH.HeaderText = "SĐT";
            dgvhSDTKH.MinimumWidth = 6;
            dgvhSDTKH.Name = "dgvhSDTKH";
            dgvhSDTKH.ReadOnly = true;
            // 
            // dgvhDiaChiKH
            // 
            dgvhDiaChiKH.HeaderText = "Địa Chỉ";
            dgvhDiaChiKH.MinimumWidth = 6;
            dgvhDiaChiKH.Name = "dgvhDiaChiKH";
            dgvhDiaChiKH.ReadOnly = true;
            // 
            // grpSuaKhachHang
            // 
            grpSuaKhachHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            grpSuaKhachHang.Location = new Point(523, 478);
            grpSuaKhachHang.Name = "grpSuaKhachHang";
            grpSuaKhachHang.Size = new Size(511, 302);
            grpSuaKhachHang.TabIndex = 55;
            grpSuaKhachHang.TabStop = false;
            // 
            // btnClearSuaKhachHang
            // 
            btnClearSuaKhachHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClearSuaKhachHang.Font = new Font("Segoe UI", 10.8F);
            btnClearSuaKhachHang.Image = (Image)resources.GetObject("btnClearSuaKhachHang.Image");
            btnClearSuaKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearSuaKhachHang.Location = new Point(259, 249);
            btnClearSuaKhachHang.Name = "btnClearSuaKhachHang";
            btnClearSuaKhachHang.Size = new Size(102, 34);
            btnClearSuaKhachHang.TabIndex = 35;
            btnClearSuaKhachHang.Text = "Xóa";
            btnClearSuaKhachHang.TextAlign = ContentAlignment.MiddleRight;
            btnClearSuaKhachHang.UseVisualStyleBackColor = true;
            btnClearSuaKhachHang.Click += btnClearSuaKhachHang_Click;
            // 
            // lblSuaKhachHang
            // 
            lblSuaKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            txtSuaTenKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaTenKhachHang.Font = new Font("Segoe UI", 12F);
            txtSuaTenKhachHang.Location = new Point(187, 121);
            txtSuaTenKhachHang.Name = "txtSuaTenKhachHang";
            txtSuaTenKhachHang.Size = new Size(300, 34);
            txtSuaTenKhachHang.TabIndex = 32;
            // 
            // lblSuaMaKhachHang
            // 
            lblSuaMaKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            txtSuaMaKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaMaKhachHang.Font = new Font("Segoe UI", 12F);
            txtSuaMaKhachHang.Location = new Point(187, 77);
            txtSuaMaKhachHang.Name = "txtSuaMaKhachHang";
            txtSuaMaKhachHang.ReadOnly = true;
            txtSuaMaKhachHang.Size = new Size(300, 34);
            txtSuaMaKhachHang.TabIndex = 22;
            // 
            // lblSuaTenKhachHang
            // 
            lblSuaTenKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            txtSuaDiaChiKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaDiaChiKhachHang.Font = new Font("Segoe UI", 12F);
            txtSuaDiaChiKhachHang.Location = new Point(187, 209);
            txtSuaDiaChiKhachHang.Name = "txtSuaDiaChiKhachHang";
            txtSuaDiaChiKhachHang.Size = new Size(300, 34);
            txtSuaDiaChiKhachHang.TabIndex = 23;
            // 
            // lblSuaDiaChiKhachHang
            // 
            lblSuaDiaChiKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            txtSuaSDTKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaSDTKhachHang.Font = new Font("Segoe UI", 12F);
            txtSuaSDTKhachHang.Location = new Point(187, 165);
            txtSuaSDTKhachHang.Name = "txtSuaSDTKhachHang";
            txtSuaSDTKhachHang.Size = new Size(300, 34);
            txtSuaSDTKhachHang.TabIndex = 25;
            // 
            // btnLuuSuaKhachHang
            // 
            btnLuuSuaKhachHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuuSuaKhachHang.Font = new Font("Segoe UI", 10.8F);
            btnLuuSuaKhachHang.Image = (Image)resources.GetObject("btnLuuSuaKhachHang.Image");
            btnLuuSuaKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuuSuaKhachHang.Location = new Point(367, 249);
            btnLuuSuaKhachHang.Name = "btnLuuSuaKhachHang";
            btnLuuSuaKhachHang.Size = new Size(94, 33);
            btnLuuSuaKhachHang.TabIndex = 19;
            btnLuuSuaKhachHang.Text = "Lưu";
            btnLuuSuaKhachHang.TextAlign = ContentAlignment.MiddleRight;
            btnLuuSuaKhachHang.UseVisualStyleBackColor = true;
            btnLuuSuaKhachHang.Click += btnLuuSuaKhachHang_Click;
            // 
            // lblSuaSDTKhachHang
            // 
            lblSuaSDTKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            btnSuaKhach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSuaKhach.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuaKhach.Image = (Image)resources.GetObject("btnSuaKhach.Image");
            btnSuaKhach.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuaKhach.Location = new Point(177, 478);
            btnSuaKhach.Name = "btnSuaKhach";
            btnSuaKhach.Size = new Size(140, 45);
            btnSuaKhach.TabIndex = 59;
            btnSuaKhach.Text = "Sửa Khách";
            btnSuaKhach.TextAlign = ContentAlignment.MiddleRight;
            btnSuaKhach.UseVisualStyleBackColor = true;
            btnSuaKhach.Click += btnSuaKhach_Click;
            // 
            // btnXoaKhach
            // 
            btnXoaKhach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaKhach.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaKhach.Image = (Image)resources.GetObject("btnXoaKhach.Image");
            btnXoaKhach.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaKhach.Location = new Point(177, 427);
            btnXoaKhach.Name = "btnXoaKhach";
            btnXoaKhach.Size = new Size(140, 45);
            btnXoaKhach.TabIndex = 60;
            btnXoaKhach.Text = "Xoá Khách";
            btnXoaKhach.TextAlign = ContentAlignment.MiddleRight;
            btnXoaKhach.UseVisualStyleBackColor = true;
            btnXoaKhach.Click += btnXoaKhach_Click;
            // 
            // btnThemKhach
            // 
            btnThemKhach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThemKhach.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemKhach.Image = (Image)resources.GetObject("btnThemKhach.Image");
            btnThemKhach.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemKhach.Location = new Point(31, 478);
            btnThemKhach.Name = "btnThemKhach";
            btnThemKhach.Size = new Size(140, 45);
            btnThemKhach.TabIndex = 61;
            btnThemKhach.Text = "Thêm Khách";
            btnThemKhach.TextAlign = ContentAlignment.MiddleRight;
            btnThemKhach.UseVisualStyleBackColor = true;
            btnThemKhach.Click += btnThemKhach_Click;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 791);
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
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            Load += frmKhachHang_Load;
            grpThemKhachHang.ResumeLayout(false);
            grpThemKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            grpSuaKhachHang.ResumeLayout(false);
            grpSuaKhachHang.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnTaiLaiDanhSach;
        private Button btnTimKhachHang;
        private TextBox txtTimKiemKhachHang;
        private GroupBox grpThemKhachHang;
        private TextBox txtThemDiaChiKhachHang;
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