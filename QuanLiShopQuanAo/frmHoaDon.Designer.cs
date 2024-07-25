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
            dgvHoaDonDaTao = new DataGridView();
            dgvhCheckBox = new DataGridViewCheckBoxColumn();
            dgvhMaHoaDonLap = new DataGridViewTextBoxColumn();
            dgvhTenKhach = new DataGridViewTextBoxColumn();
            dgvhNgayTao = new DataGridViewTextBoxColumn();
            dgvhTongTien = new DataGridViewTextBoxColumn();
            dgvhTrangThai = new DataGridViewTextBoxColumn();
            dgvhNhanVien = new DataGridViewTextBoxColumn();
            lblSuaHoaDon = new Label();
            lblTaoHoaDon = new Label();
            lblTenKhach = new Label();
            txtTenKhach = new TextBox();
            lblNgayLap = new Label();
            dtpNgayLap = new DateTimePicker();
            btnChonTatCa = new Button();
            btnXoaHoaDon = new Button();
            grpTaoHoaDon = new GroupBox();
            btnLapHoaDon = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblNgayLapHDMoi = new Label();
            txtSDT = new TextBox();
            txtTenKhachMua = new TextBox();
            txtMaHoaDon = new TextBox();
            lblSDT = new Label();
            lblTenKhachMua = new Label();
            lblMaHoaDon = new Label();
            lblTrangThai = new Label();
            cmbTrangThai = new ComboBox();
            grpSuaHoaDon = new GroupBox();
            btnSua = new Button();
            btnTaiLaiDanhSach = new Button();
            msDashBoard = new MenuStrip();
            tslDashBoard = new ToolStripLabel();
            tsmiSanPham = new ToolStripMenuItem();
            tsmiKho = new ToolStripMenuItem();
            tsmiHoaDon = new ToolStripMenuItem();
            tsmiNhanVien = new ToolStripMenuItem();
            tsmiNhaCungCap = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonDaTao).BeginInit();
            grpTaoHoaDon.SuspendLayout();
            grpSuaHoaDon.SuspendLayout();
            msDashBoard.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHoaDonDaTao
            // 
            dgvHoaDonDaTao.AllowUserToAddRows = false;
            dgvHoaDonDaTao.AllowUserToDeleteRows = false;
            dgvHoaDonDaTao.AllowUserToResizeColumns = false;
            dgvHoaDonDaTao.AllowUserToResizeRows = false;
            dgvHoaDonDaTao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonDaTao.Columns.AddRange(new DataGridViewColumn[] { dgvhCheckBox, dgvhMaHoaDonLap, dgvhTenKhach, dgvhNgayTao, dgvhTongTien, dgvhTrangThai, dgvhNhanVien });
            dgvHoaDonDaTao.Location = new Point(175, 12);
            dgvHoaDonDaTao.Name = "dgvHoaDonDaTao";
            dgvHoaDonDaTao.RowHeadersVisible = false;
            dgvHoaDonDaTao.RowHeadersWidth = 51;
            dgvHoaDonDaTao.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvHoaDonDaTao.Size = new Size(1178, 400);
            dgvHoaDonDaTao.TabIndex = 5;
            // 
            // dgvhCheckBox
            // 
            dgvhCheckBox.HeaderText = "";
            dgvhCheckBox.MinimumWidth = 6;
            dgvhCheckBox.Name = "dgvhCheckBox";
            dgvhCheckBox.Resizable = DataGridViewTriState.True;
            dgvhCheckBox.SortMode = DataGridViewColumnSortMode.Automatic;
            dgvhCheckBox.Width = 25;
            // 
            // dgvhMaHoaDonLap
            // 
            dgvhMaHoaDonLap.HeaderText = "Mã Hoá Đơn";
            dgvhMaHoaDonLap.MinimumWidth = 6;
            dgvhMaHoaDonLap.Name = "dgvhMaHoaDonLap";
            dgvhMaHoaDonLap.ReadOnly = true;
            dgvhMaHoaDonLap.Resizable = DataGridViewTriState.True;
            dgvhMaHoaDonLap.Width = 175;
            // 
            // dgvhTenKhach
            // 
            dgvhTenKhach.HeaderText = "Tên Khách Hàng";
            dgvhTenKhach.MinimumWidth = 6;
            dgvhTenKhach.Name = "dgvhTenKhach";
            dgvhTenKhach.ReadOnly = true;
            dgvhTenKhach.Width = 225;
            // 
            // dgvhNgayTao
            // 
            dgvhNgayTao.HeaderText = "Ngày Tạo";
            dgvhNgayTao.MinimumWidth = 6;
            dgvhNgayTao.Name = "dgvhNgayTao";
            dgvhNgayTao.ReadOnly = true;
            dgvhNgayTao.Width = 200;
            // 
            // dgvhTongTien
            // 
            dgvhTongTien.HeaderText = "Tổng Tiền";
            dgvhTongTien.MinimumWidth = 6;
            dgvhTongTien.Name = "dgvhTongTien";
            dgvhTongTien.ReadOnly = true;
            dgvhTongTien.Width = 175;
            // 
            // dgvhTrangThai
            // 
            dgvhTrangThai.HeaderText = "Trạng Thái";
            dgvhTrangThai.MinimumWidth = 6;
            dgvhTrangThai.Name = "dgvhTrangThai";
            dgvhTrangThai.ReadOnly = true;
            dgvhTrangThai.Width = 175;
            // 
            // dgvhNhanVien
            // 
            dgvhNhanVien.HeaderText = "Nhân Viên Ghi";
            dgvhNhanVien.MinimumWidth = 6;
            dgvhNhanVien.Name = "dgvhNhanVien";
            dgvhNhanVien.ReadOnly = true;
            dgvhNhanVien.Width = 200;
            // 
            // lblSuaHoaDon
            // 
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
            lblTenKhach.AutoSize = true;
            lblTenKhach.Font = new Font("Segoe UI", 13F);
            lblTenKhach.Location = new Point(6, 80);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(169, 30);
            lblTenKhach.TabIndex = 11;
            lblTenKhach.Text = "Tên Khách Hàng";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(220, 80);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(350, 34);
            txtTenKhach.TabIndex = 12;
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Font = new Font("Segoe UI", 13F);
            lblNgayLap.Location = new Point(6, 128);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(104, 30);
            lblNgayLap.TabIndex = 13;
            lblNgayLap.Text = "Ngày Lập";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CustomFormat = "dd-MM-yyyy";
            dtpNgayLap.Location = new Point(220, 128);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(350, 34);
            dtpNgayLap.TabIndex = 14;
            // 
            // btnChonTatCa
            // 
            btnChonTatCa.Location = new Point(175, 439);
            btnChonTatCa.Name = "btnChonTatCa";
            btnChonTatCa.Size = new Size(150, 45);
            btnChonTatCa.TabIndex = 19;
            btnChonTatCa.Text = "Chọn Tất Cả";
            btnChonTatCa.UseVisualStyleBackColor = true;
            // 
            // btnXoaHoaDon
            // 
            btnXoaHoaDon.Location = new Point(331, 439);
            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new Size(150, 45);
            btnXoaHoaDon.TabIndex = 18;
            btnXoaHoaDon.Text = "Xoá Hoá Đơn";
            btnXoaHoaDon.UseVisualStyleBackColor = true;
            // 
            // grpTaoHoaDon
            // 
            grpTaoHoaDon.Controls.Add(btnLapHoaDon);
            grpTaoHoaDon.Controls.Add(dateTimePicker1);
            grpTaoHoaDon.Controls.Add(lblNgayLapHDMoi);
            grpTaoHoaDon.Controls.Add(txtSDT);
            grpTaoHoaDon.Controls.Add(txtTenKhachMua);
            grpTaoHoaDon.Controls.Add(txtMaHoaDon);
            grpTaoHoaDon.Controls.Add(lblSDT);
            grpTaoHoaDon.Controls.Add(lblTenKhachMua);
            grpTaoHoaDon.Controls.Add(lblTaoHoaDon);
            grpTaoHoaDon.Controls.Add(lblMaHoaDon);
            grpTaoHoaDon.Location = new Point(756, 415);
            grpTaoHoaDon.Name = "grpTaoHoaDon";
            grpTaoHoaDon.Size = new Size(597, 372);
            grpTaoHoaDon.TabIndex = 20;
            grpTaoHoaDon.TabStop = false;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Font = new Font("Segoe UI", 14F);
            btnLapHoaDon.Location = new Point(341, 292);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(250, 50);
            btnLapHoaDon.TabIndex = 26;
            btnLapHoaDon.Text = "Lập Hoá Đơn Mới";
            btnLapHoaDon.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Location = new Point(241, 226);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(350, 34);
            dateTimePicker1.TabIndex = 22;
            // 
            // lblNgayLapHDMoi
            // 
            lblNgayLapHDMoi.AutoSize = true;
            lblNgayLapHDMoi.Font = new Font("Segoe UI", 13F);
            lblNgayLapHDMoi.Location = new Point(6, 230);
            lblNgayLapHDMoi.Name = "lblNgayLapHDMoi";
            lblNgayLapHDMoi.Size = new Size(104, 30);
            lblNgayLapHDMoi.TabIndex = 21;
            lblNgayLapHDMoi.Text = "Ngày Lập";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(241, 177);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(350, 34);
            txtSDT.TabIndex = 25;
            // 
            // txtTenKhachMua
            // 
            txtTenKhachMua.Location = new Point(241, 126);
            txtTenKhachMua.Name = "txtTenKhachMua";
            txtTenKhachMua.Size = new Size(350, 34);
            txtTenKhachMua.TabIndex = 24;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(241, 77);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.ReadOnly = true;
            txtMaHoaDon.Size = new Size(350, 34);
            txtMaHoaDon.TabIndex = 21;
            // 
            // lblSDT
            // 
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
            lblTenKhachMua.AutoSize = true;
            lblTenKhachMua.Font = new Font("Segoe UI", 13F);
            lblTenKhachMua.Location = new Point(6, 128);
            lblTenKhachMua.Name = "lblTenKhachMua";
            lblTenKhachMua.Size = new Size(111, 30);
            lblTenKhachMua.TabIndex = 22;
            lblTenKhachMua.Text = "Tên Khách";
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Segoe UI", 13F);
            lblMaHoaDon.Location = new Point(6, 77);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(136, 30);
            lblMaHoaDon.TabIndex = 21;
            lblMaHoaDon.Text = "Mã Hoá Đơn";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 13F);
            lblTrangThai.Location = new Point(6, 178);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(113, 30);
            lblTrangThai.TabIndex = 21;
            lblTrangThai.Text = "Trạng Thái";
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.Font = new Font("Segoe UI", 11F);
            cmbTrangThai.FormattingEnabled = true;
            cmbTrangThai.Items.AddRange(new object[] { "Chưa Thanh Toán", "Đã Thanh Toán" });
            cmbTrangThai.Location = new Point(220, 179);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.Size = new Size(219, 33);
            cmbTrangThai.TabIndex = 22;
            cmbTrangThai.Text = "Chưa Thanh Toán";
            // 
            // grpSuaHoaDon
            // 
            grpSuaHoaDon.Controls.Add(btnSua);
            grpSuaHoaDon.Controls.Add(txtTenKhach);
            grpSuaHoaDon.Controls.Add(cmbTrangThai);
            grpSuaHoaDon.Controls.Add(dtpNgayLap);
            grpSuaHoaDon.Controls.Add(lblTrangThai);
            grpSuaHoaDon.Controls.Add(lblSuaHoaDon);
            grpSuaHoaDon.Controls.Add(lblNgayLap);
            grpSuaHoaDon.Controls.Add(lblTenKhach);
            grpSuaHoaDon.Location = new Point(174, 490);
            grpSuaHoaDon.Name = "grpSuaHoaDon";
            grpSuaHoaDon.Size = new Size(576, 297);
            grpSuaHoaDon.TabIndex = 23;
            grpSuaHoaDon.TabStop = false;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 13F);
            btnSua.Location = new Point(445, 179);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(125, 35);
            btnSua.TabIndex = 23;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnTaiLaiDanhSach
            // 
            btnTaiLaiDanhSach.Location = new Point(487, 439);
            btnTaiLaiDanhSach.Name = "btnTaiLaiDanhSach";
            btnTaiLaiDanhSach.Size = new Size(180, 45);
            btnTaiLaiDanhSach.TabIndex = 50;
            btnTaiLaiDanhSach.Text = "Tải Lại Danh Sách";
            btnTaiLaiDanhSach.UseVisualStyleBackColor = true;
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
            msDashBoard.Size = new Size(172, 802);
            msDashBoard.TabIndex = 51;
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
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 802);
            Controls.Add(msDashBoard);
            Controls.Add(btnTaiLaiDanhSach);
            Controls.Add(btnChonTatCa);
            Controls.Add(btnXoaHoaDon);
            Controls.Add(dgvHoaDonDaTao);
            Controls.Add(grpTaoHoaDon);
            Controls.Add(grpSuaHoaDon);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmHoaDon";
            Text = "Quản Lí Hoá Đơn";
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonDaTao).EndInit();
            grpTaoHoaDon.ResumeLayout(false);
            grpTaoHoaDon.PerformLayout();
            grpSuaHoaDon.ResumeLayout(false);
            grpSuaHoaDon.PerformLayout();
            msDashBoard.ResumeLayout(false);
            msDashBoard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvHoaDonDaTao;
        private Label lblSuaHoaDon;
        private Label lblTaoHoaDon;
        private Label lblTenKhach;
        private TextBox txtTenKhach;
        private Label lblNgayLap;
        private DateTimePicker dtpNgayLap;
        private Button btnChonTatCa;
        private Button btnXoaHoaDon;
        private DataGridViewCheckBoxColumn dgvhCheckBox;
        private DataGridViewTextBoxColumn dgvhMaHoaDonLap;
        private DataGridViewTextBoxColumn dgvhTenKhach;
        private DataGridViewTextBoxColumn dgvhNgayTao;
        private DataGridViewTextBoxColumn dgvhTongTien;
        private DataGridViewTextBoxColumn dgvhTrangThai;
        private DataGridViewTextBoxColumn dgvhNhanVien;
        private GroupBox grpTaoHoaDon;
        private Label lblTenKhachMua;
        private Label lblMaHoaDon;
        private Label lblSDT;
        private TextBox txtSDT;
        private TextBox txtTenKhachMua;
        private TextBox txtMaHoaDon;
        private DateTimePicker dateTimePicker1;
        private Label lblNgayLapHDMoi;
        private Button btnLapHoaDon;
        private Label lblTrangThai;
        private ComboBox cmbTrangThai;
        private GroupBox grpSuaHoaDon;
        private Button btnSua;
        private Button btnTaiLaiDanhSach;
        private MenuStrip msDashBoard;
        private ToolStripLabel tslDashBoard;
        private ToolStripMenuItem tsmiSanPham;
        private ToolStripMenuItem tsmiKho;
        private ToolStripMenuItem tsmiHoaDon;
        private ToolStripMenuItem tsmiNhanVien;
        private ToolStripMenuItem tsmiNhaCungCap;
    }
}