namespace QuanLiShopQuanAo
{
    partial class frmHoaDon
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
            dgvHoaDon = new DataGridView();
            dgvhCheckBox = new DataGridViewCheckBoxColumn();
            dgvhMaHoaDon = new DataGridViewTextBoxColumn();
            dgvhTenKhach = new DataGridViewTextBoxColumn();
            dgvhSDTKhach = new DataGridViewTextBoxColumn();
            dgvhNgayTao = new DataGridViewTextBoxColumn();
            dgvhTongTien = new DataGridViewTextBoxColumn();
            dgvhTrangThai = new DataGridViewTextBoxColumn();
            dgvhNhanVien = new DataGridViewTextBoxColumn();
            lblSuaHoaDon = new Label();
            lblTaoHoaDon = new Label();
            lblTenKhach = new Label();
            txtSuaTenKhach = new TextBox();
            lblNgayLap = new Label();
            dtpSuaNgayLap = new DateTimePicker();
            btnChonTatCa = new Button();
            btnXoaHoaDon = new Button();
            grpTaoHoaDon = new GroupBox();
            btnLapHoaDon = new Button();
            dtpLapHoaDon = new DateTimePicker();
            lblNgayLapHDMoi = new Label();
            txtSDTKhachMua = new TextBox();
            txtTenKhachMua = new TextBox();
            txtTaoMaHoaDon = new TextBox();
            lblSDT = new Label();
            lblTenKhachMua = new Label();
            lblTaoMaHoaDon = new Label();
            lblTrangThai = new Label();
            grpSuaHoaDon = new GroupBox();
            txtSuaMaHoaDon = new TextBox();
            btnSuaHoaDon = new Button();
            lblSuaMaHoaDon = new Label();
            cmbTrangThai = new ComboBox();
            btnTaiLaiDanhSach = new Button();
            btnTimHoaDon = new Button();
            txtTimKiemHoaDon = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            grpTaoHoaDon.SuspendLayout();
            grpSuaHoaDon.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AllowUserToResizeColumns = false;
            dgvHoaDon.AllowUserToResizeRows = false;
            dgvHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { dgvhCheckBox, dgvhMaHoaDon, dgvhTenKhach, dgvhSDTKhach, dgvhNgayTao, dgvhTongTien, dgvhTrangThai, dgvhNhanVien });
            dgvHoaDon.Location = new Point(28, 12);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(1178, 447);
            dgvHoaDon.TabIndex = 5;
            // 
            // dgvhCheckBox
            // 
            dgvhCheckBox.HeaderText = "";
            dgvhCheckBox.MinimumWidth = 6;
            dgvhCheckBox.Name = "dgvhCheckBox";
            dgvhCheckBox.Resizable = DataGridViewTriState.True;
            dgvhCheckBox.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dgvhMaHoaDon
            // 
            dgvhMaHoaDon.HeaderText = "Mã Hoá Đơn";
            dgvhMaHoaDon.MinimumWidth = 6;
            dgvhMaHoaDon.Name = "dgvhMaHoaDon";
            dgvhMaHoaDon.ReadOnly = true;
            dgvhMaHoaDon.Resizable = DataGridViewTriState.True;
            // 
            // dgvhTenKhach
            // 
            dgvhTenKhach.HeaderText = "Tên Khách Hàng";
            dgvhTenKhach.MinimumWidth = 6;
            dgvhTenKhach.Name = "dgvhTenKhach";
            dgvhTenKhach.ReadOnly = true;
            // 
            // dgvhSDTKhach
            // 
            dgvhSDTKhach.HeaderText = "Số Điện Thoại";
            dgvhSDTKhach.MinimumWidth = 6;
            dgvhSDTKhach.Name = "dgvhSDTKhach";
            dgvhSDTKhach.ReadOnly = true;
            // 
            // dgvhNgayTao
            // 
            dgvhNgayTao.HeaderText = "Ngày Tạo";
            dgvhNgayTao.MinimumWidth = 6;
            dgvhNgayTao.Name = "dgvhNgayTao";
            dgvhNgayTao.ReadOnly = true;
            // 
            // dgvhTongTien
            // 
            dgvhTongTien.HeaderText = "Tổng Tiền";
            dgvhTongTien.MinimumWidth = 6;
            dgvhTongTien.Name = "dgvhTongTien";
            dgvhTongTien.ReadOnly = true;
            // 
            // dgvhTrangThai
            // 
            dgvhTrangThai.HeaderText = "Trạng Thái";
            dgvhTrangThai.MinimumWidth = 6;
            dgvhTrangThai.Name = "dgvhTrangThai";
            dgvhTrangThai.ReadOnly = true;
            // 
            // dgvhNhanVien
            // 
            dgvhNhanVien.HeaderText = "Nhân Viên Ghi";
            dgvhNhanVien.MinimumWidth = 6;
            dgvhNhanVien.Name = "dgvhNhanVien";
            dgvhNhanVien.ReadOnly = true;
            // 
            // lblSuaHoaDon
            // 
            lblSuaHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaHoaDon.AutoSize = true;
            lblSuaHoaDon.Font = new Font("Segoe UI", 14F);
            lblSuaHoaDon.Location = new Point(6, 30);
            lblSuaHoaDon.Name = "lblSuaHoaDon";
            lblSuaHoaDon.Size = new Size(155, 32);
            lblSuaHoaDon.TabIndex = 6;
            lblSuaHoaDon.Text = "Sửa Hoá Đơn";
            // 
            // lblTaoHoaDon
            // 
            lblTaoHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTaoHoaDon.AutoSize = true;
            lblTaoHoaDon.Font = new Font("Segoe UI", 14F);
            lblTaoHoaDon.Location = new Point(6, 30);
            lblTaoHoaDon.Name = "lblTaoHoaDon";
            lblTaoHoaDon.Size = new Size(155, 32);
            lblTaoHoaDon.TabIndex = 10;
            lblTaoHoaDon.Text = "Tạo Hoá Đơn";
            // 
            // lblTenKhach
            // 
            lblTenKhach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTenKhach.AutoSize = true;
            lblTenKhach.Font = new Font("Segoe UI", 13F);
            lblTenKhach.Location = new Point(6, 128);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(169, 30);
            lblTenKhach.TabIndex = 11;
            lblTenKhach.Text = "Tên Khách Hàng";
            // 
            // txtSuaTenKhach
            // 
            txtSuaTenKhach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaTenKhach.Location = new Point(196, 128);
            txtSuaTenKhach.Name = "txtSuaTenKhach";
            txtSuaTenKhach.Size = new Size(380, 34);
            txtSuaTenKhach.TabIndex = 12;
            // 
            // lblNgayLap
            // 
            lblNgayLap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNgayLap.AutoSize = true;
            lblNgayLap.Font = new Font("Segoe UI", 13F);
            lblNgayLap.Location = new Point(6, 176);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(104, 30);
            lblNgayLap.TabIndex = 13;
            lblNgayLap.Text = "Ngày Lập";
            // 
            // dtpSuaNgayLap
            // 
            dtpSuaNgayLap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpSuaNgayLap.CustomFormat = "dd-MM-yyyy";
            dtpSuaNgayLap.Location = new Point(196, 176);
            dtpSuaNgayLap.Name = "dtpSuaNgayLap";
            dtpSuaNgayLap.Size = new Size(380, 34);
            dtpSuaNgayLap.TabIndex = 14;
            // 
            // btnChonTatCa
            // 
            btnChonTatCa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnChonTatCa.Image = Properties.Resources.icons8_all_30;
            btnChonTatCa.ImageAlign = ContentAlignment.MiddleLeft;
            btnChonTatCa.Location = new Point(28, 476);
            btnChonTatCa.Name = "btnChonTatCa";
            btnChonTatCa.Size = new Size(150, 45);
            btnChonTatCa.TabIndex = 19;
            btnChonTatCa.Text = "Chọn Tất Cả";
            btnChonTatCa.TextAlign = ContentAlignment.MiddleRight;
            btnChonTatCa.UseVisualStyleBackColor = true;
            btnChonTatCa.Click += btnChonTatCa_Click;
            // 
            // btnXoaHoaDon
            // 
            btnXoaHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaHoaDon.Image = Properties.Resources.icons8_delete_30;
            btnXoaHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaHoaDon.Location = new Point(184, 476);
            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new Size(171, 45);
            btnXoaHoaDon.TabIndex = 18;
            btnXoaHoaDon.Text = "Xoá Hoá Đơn";
            btnXoaHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnXoaHoaDon.UseVisualStyleBackColor = true;
            btnXoaHoaDon.Click += btnXoaHoaDon_Click;
            // 
            // grpTaoHoaDon
            // 
            grpTaoHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpTaoHoaDon.Controls.Add(btnLapHoaDon);
            grpTaoHoaDon.Controls.Add(dtpLapHoaDon);
            grpTaoHoaDon.Controls.Add(lblNgayLapHDMoi);
            grpTaoHoaDon.Controls.Add(txtSDTKhachMua);
            grpTaoHoaDon.Controls.Add(txtTenKhachMua);
            grpTaoHoaDon.Controls.Add(txtTaoMaHoaDon);
            grpTaoHoaDon.Controls.Add(lblSDT);
            grpTaoHoaDon.Controls.Add(lblTenKhachMua);
            grpTaoHoaDon.Controls.Add(lblTaoHoaDon);
            grpTaoHoaDon.Controls.Add(lblTaoMaHoaDon);
            grpTaoHoaDon.Location = new Point(639, 527);
            grpTaoHoaDon.Name = "grpTaoHoaDon";
            grpTaoHoaDon.Size = new Size(567, 343);
            grpTaoHoaDon.TabIndex = 20;
            grpTaoHoaDon.TabStop = false;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLapHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLapHoaDon.Image = Properties.Resources.icons8_add_30;
            btnLapHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnLapHoaDon.Location = new Point(327, 277);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(215, 50);
            btnLapHoaDon.TabIndex = 26;
            btnLapHoaDon.Text = "Lập Hoá Đơn Mới";
            btnLapHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnLapHoaDon.UseVisualStyleBackColor = true;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // dtpLapHoaDon
            // 
            dtpLapHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpLapHoaDon.CustomFormat = "dd-MM-yyyy";
            dtpLapHoaDon.Location = new Point(192, 226);
            dtpLapHoaDon.Name = "dtpLapHoaDon";
            dtpLapHoaDon.Size = new Size(350, 34);
            dtpLapHoaDon.TabIndex = 22;
            // 
            // lblNgayLapHDMoi
            // 
            lblNgayLapHDMoi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNgayLapHDMoi.AutoSize = true;
            lblNgayLapHDMoi.Font = new Font("Segoe UI", 13F);
            lblNgayLapHDMoi.Location = new Point(6, 230);
            lblNgayLapHDMoi.Name = "lblNgayLapHDMoi";
            lblNgayLapHDMoi.Size = new Size(104, 30);
            lblNgayLapHDMoi.TabIndex = 21;
            lblNgayLapHDMoi.Text = "Ngày Lập";
            // 
            // txtSDTKhachMua
            // 
            txtSDTKhachMua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSDTKhachMua.Location = new Point(192, 177);
            txtSDTKhachMua.Name = "txtSDTKhachMua";
            txtSDTKhachMua.Size = new Size(350, 34);
            txtSDTKhachMua.TabIndex = 25;
            // 
            // txtTenKhachMua
            // 
            txtTenKhachMua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTenKhachMua.Location = new Point(192, 126);
            txtTenKhachMua.Name = "txtTenKhachMua";
            txtTenKhachMua.Size = new Size(350, 34);
            txtTenKhachMua.TabIndex = 24;
            // 
            // txtTaoMaHoaDon
            // 
            txtTaoMaHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTaoMaHoaDon.Location = new Point(192, 77);
            txtTaoMaHoaDon.Name = "txtTaoMaHoaDon";
            txtTaoMaHoaDon.ReadOnly = true;
            txtTaoMaHoaDon.Size = new Size(350, 34);
            txtTaoMaHoaDon.TabIndex = 21;
            // 
            // lblSDT
            // 
            lblSDT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 13F);
            lblSDT.Location = new Point(6, 179);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(147, 30);
            lblSDT.TabIndex = 23;
            lblSDT.Text = "Số Điện Thoại";
            // 
            // lblTenKhachMua
            // 
            lblTenKhachMua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTenKhachMua.AutoSize = true;
            lblTenKhachMua.Font = new Font("Segoe UI", 13F);
            lblTenKhachMua.Location = new Point(6, 128);
            lblTenKhachMua.Name = "lblTenKhachMua";
            lblTenKhachMua.Size = new Size(111, 30);
            lblTenKhachMua.TabIndex = 22;
            lblTenKhachMua.Text = "Tên Khách";
            // 
            // lblTaoMaHoaDon
            // 
            lblTaoMaHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTaoMaHoaDon.AutoSize = true;
            lblTaoMaHoaDon.Font = new Font("Segoe UI", 13F);
            lblTaoMaHoaDon.Location = new Point(6, 77);
            lblTaoMaHoaDon.Name = "lblTaoMaHoaDon";
            lblTaoMaHoaDon.Size = new Size(136, 30);
            lblTaoMaHoaDon.TabIndex = 21;
            lblTaoMaHoaDon.Text = "Mã Hoá Đơn";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 13F);
            lblTrangThai.Location = new Point(6, 226);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(113, 30);
            lblTrangThai.TabIndex = 21;
            lblTrangThai.Text = "Trạng Thái";
            // 
            // grpSuaHoaDon
            // 
            grpSuaHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            grpSuaHoaDon.Controls.Add(txtSuaMaHoaDon);
            grpSuaHoaDon.Controls.Add(btnSuaHoaDon);
            grpSuaHoaDon.Controls.Add(lblSuaMaHoaDon);
            grpSuaHoaDon.Controls.Add(txtSuaTenKhach);
            grpSuaHoaDon.Controls.Add(cmbTrangThai);
            grpSuaHoaDon.Controls.Add(dtpSuaNgayLap);
            grpSuaHoaDon.Controls.Add(lblTrangThai);
            grpSuaHoaDon.Controls.Add(lblSuaHoaDon);
            grpSuaHoaDon.Controls.Add(lblNgayLap);
            grpSuaHoaDon.Controls.Add(lblTenKhach);
            grpSuaHoaDon.Location = new Point(27, 527);
            grpSuaHoaDon.Name = "grpSuaHoaDon";
            grpSuaHoaDon.Size = new Size(606, 343);
            grpSuaHoaDon.TabIndex = 23;
            grpSuaHoaDon.TabStop = false;
            // 
            // txtSuaMaHoaDon
            // 
            txtSuaMaHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaMaHoaDon.Location = new Point(196, 77);
            txtSuaMaHoaDon.Name = "txtSuaMaHoaDon";
            txtSuaMaHoaDon.ReadOnly = true;
            txtSuaMaHoaDon.Size = new Size(380, 34);
            txtSuaMaHoaDon.TabIndex = 27;
            // 
            // btnSuaHoaDon
            // 
            btnSuaHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSuaHoaDon.Font = new Font("Segoe UI", 13F);
            btnSuaHoaDon.Image = Properties.Resources.icons8_save_30;
            btnSuaHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuaHoaDon.Location = new Point(475, 227);
            btnSuaHoaDon.Name = "btnSuaHoaDon";
            btnSuaHoaDon.Size = new Size(101, 33);
            btnSuaHoaDon.TabIndex = 23;
            btnSuaHoaDon.Text = "Sửa";
            btnSuaHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnSuaHoaDon.UseVisualStyleBackColor = true;
            btnSuaHoaDon.Click += btnSuaHoaDon_Click;
            // 
            // lblSuaMaHoaDon
            // 
            lblSuaMaHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaMaHoaDon.AutoSize = true;
            lblSuaMaHoaDon.Font = new Font("Segoe UI", 13F);
            lblSuaMaHoaDon.Location = new Point(6, 79);
            lblSuaMaHoaDon.Name = "lblSuaMaHoaDon";
            lblSuaMaHoaDon.Size = new Size(136, 30);
            lblSuaMaHoaDon.TabIndex = 28;
            lblSuaMaHoaDon.Text = "Mã Hoá Đơn";
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbTrangThai.Font = new Font("Segoe UI", 11F);
            cmbTrangThai.FormattingEnabled = true;
            cmbTrangThai.Items.AddRange(new object[] { "Chưa Thanh Toán", "Đã Thanh Toán" });
            cmbTrangThai.Location = new Point(196, 227);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.Size = new Size(273, 33);
            cmbTrangThai.TabIndex = 22;
            cmbTrangThai.Text = "Chưa Thanh Toán";
            // 
            // btnTaiLaiDanhSach
            // 
            btnTaiLaiDanhSach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTaiLaiDanhSach.Image = Properties.Resources.icons8_reload_30;
            btnTaiLaiDanhSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaiLaiDanhSach.Location = new Point(361, 476);
            btnTaiLaiDanhSach.Name = "btnTaiLaiDanhSach";
            btnTaiLaiDanhSach.Size = new Size(202, 45);
            btnTaiLaiDanhSach.TabIndex = 50;
            btnTaiLaiDanhSach.Text = "Tải Lại Danh Sách";
            btnTaiLaiDanhSach.TextAlign = ContentAlignment.MiddleRight;
            btnTaiLaiDanhSach.UseVisualStyleBackColor = true;
            btnTaiLaiDanhSach.Click += btnTaiLaiDanhSach_Click;
            // 
            // btnTimHoaDon
            // 
            btnTimHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTimHoaDon.Font = new Font("Segoe UI", 12F);
            btnTimHoaDon.Image = Properties.Resources.icons8_find_30;
            btnTimHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimHoaDon.Location = new Point(1105, 481);
            btnTimHoaDon.Name = "btnTimHoaDon";
            btnTimHoaDon.Size = new Size(101, 34);
            btnTimHoaDon.TabIndex = 51;
            btnTimHoaDon.Text = "Tìm";
            btnTimHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnTimHoaDon.UseVisualStyleBackColor = true;
            btnTimHoaDon.Click += btnTimHoaDon_Click;
            // 
            // txtTimKiemHoaDon
            // 
            txtTimKiemHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiemHoaDon.Font = new Font("Segoe UI", 12F);
            txtTimKiemHoaDon.Location = new Point(639, 481);
            txtTimKiemHoaDon.Name = "txtTimKiemHoaDon";
            txtTimKiemHoaDon.Size = new Size(460, 34);
            txtTimKiemHoaDon.TabIndex = 52;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 882);
            Controls.Add(btnTimHoaDon);
            Controls.Add(txtTimKiemHoaDon);
            Controls.Add(btnTaiLaiDanhSach);
            Controls.Add(btnChonTatCa);
            Controls.Add(btnXoaHoaDon);
            Controls.Add(dgvHoaDon);
            Controls.Add(grpTaoHoaDon);
            Controls.Add(grpSuaHoaDon);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmHoaDon";
            Text = "Quản Lí Hoá Đơn";
            Load += frmHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            grpTaoHoaDon.ResumeLayout(false);
            grpTaoHoaDon.PerformLayout();
            grpSuaHoaDon.ResumeLayout(false);
            grpSuaHoaDon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvHoaDon;
        private Label lblSuaHoaDon;
        private Label lblTaoHoaDon;
        private Label lblTenKhach;
        private TextBox txtSuaTenKhach;
        private Label lblNgayLap;
        private DateTimePicker dtpSuaNgayLap;
        private Button btnChonTatCa;
        private Button btnXoaHoaDon;
        private GroupBox grpTaoHoaDon;
        private Label lblTenKhachMua;
        private Label lblTaoMaHoaDon;
        private Label lblSDT;
        private TextBox txtSDTKhachMua;
        private TextBox txtTenKhachMua;
        private TextBox txtTaoMaHoaDon;
        private DateTimePicker dtpLapHoaDon;
        private Label lblNgayLapHDMoi;
        private Button btnLapHoaDon;
        private Label lblTrangThai;
        private GroupBox grpSuaHoaDon;
        private Button btnSuaHoaDon;
        private Button btnTaiLaiDanhSach;
        private Button btnTimHoaDon;
        private TextBox txtTimKiemHoaDon;
        private TextBox txtSuaMaHoaDon;
        private Label lblSuaMaHoaDon;
        private ComboBox cmbTrangThai;
        private DataGridViewCheckBoxColumn dgvhCheckBox;
        private DataGridViewTextBoxColumn dgvhMaHoaDon;
        private DataGridViewTextBoxColumn dgvhTenKhach;
        private DataGridViewTextBoxColumn dgvhSDTKhach;
        private DataGridViewTextBoxColumn dgvhNgayTao;
        private DataGridViewTextBoxColumn dgvhTongTien;
        private DataGridViewTextBoxColumn dgvhTrangThai;
        private DataGridViewTextBoxColumn dgvhNhanVien;
    }
}