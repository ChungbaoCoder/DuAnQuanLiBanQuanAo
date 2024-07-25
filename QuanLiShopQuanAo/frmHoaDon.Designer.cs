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
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonDaTao).BeginInit();
            grpTaoHoaDon.SuspendLayout();
            grpSuaHoaDon.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHoaDonDaTao
            // 
            dgvHoaDonDaTao.AllowUserToAddRows = false;
            dgvHoaDonDaTao.AllowUserToDeleteRows = false;
            dgvHoaDonDaTao.AllowUserToResizeColumns = false;
            dgvHoaDonDaTao.AllowUserToResizeRows = false;
            dgvHoaDonDaTao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHoaDonDaTao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDonDaTao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonDaTao.Columns.AddRange(new DataGridViewColumn[] { dgvhCheckBox, dgvhMaHoaDonLap, dgvhTenKhach, dgvhNgayTao, dgvhTongTien, dgvhTrangThai, dgvhNhanVien });
            dgvHoaDonDaTao.Location = new Point(28, 12);
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
            // 
            // dgvhMaHoaDonLap
            // 
            dgvhMaHoaDonLap.HeaderText = "Mã Hoá Đơn";
            dgvhMaHoaDonLap.MinimumWidth = 6;
            dgvhMaHoaDonLap.Name = "dgvhMaHoaDonLap";
            dgvhMaHoaDonLap.ReadOnly = true;
            dgvhMaHoaDonLap.Resizable = DataGridViewTriState.True;
            // 
            // dgvhTenKhach
            // 
            dgvhTenKhach.HeaderText = "Tên Khách Hàng";
            dgvhTenKhach.MinimumWidth = 6;
            dgvhTenKhach.Name = "dgvhTenKhach";
            dgvhTenKhach.ReadOnly = true;
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
            lblTenKhach.Location = new Point(6, 80);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(169, 30);
            lblTenKhach.TabIndex = 11;
            lblTenKhach.Text = "Tên Khách Hàng";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTenKhach.Location = new Point(220, 80);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(350, 34);
            txtTenKhach.TabIndex = 12;
            // 
            // lblNgayLap
            // 
            lblNgayLap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dtpNgayLap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpNgayLap.CustomFormat = "dd-MM-yyyy";
            dtpNgayLap.Location = new Point(220, 128);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(350, 34);
            dtpNgayLap.TabIndex = 14;
            // 
            // btnChonTatCa
            // 
            btnChonTatCa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnChonTatCa.Location = new Point(28, 439);
            btnChonTatCa.Name = "btnChonTatCa";
            btnChonTatCa.Size = new Size(150, 45);
            btnChonTatCa.TabIndex = 19;
            btnChonTatCa.Text = "Chọn Tất Cả";
            btnChonTatCa.UseVisualStyleBackColor = true;
            // 
            // btnXoaHoaDon
            // 
            btnXoaHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaHoaDon.Location = new Point(184, 439);
            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new Size(150, 45);
            btnXoaHoaDon.TabIndex = 18;
            btnXoaHoaDon.Text = "Xoá Hoá Đơn";
            btnXoaHoaDon.UseVisualStyleBackColor = true;
            // 
            // grpTaoHoaDon
            // 
            grpTaoHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            grpTaoHoaDon.Location = new Point(609, 415);
            grpTaoHoaDon.Name = "grpTaoHoaDon";
            grpTaoHoaDon.Size = new Size(597, 372);
            grpTaoHoaDon.TabIndex = 20;
            grpTaoHoaDon.TabStop = false;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Location = new Point(241, 226);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(350, 34);
            dateTimePicker1.TabIndex = 22;
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
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSDT.Location = new Point(241, 177);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(350, 34);
            txtSDT.TabIndex = 25;
            // 
            // txtTenKhachMua
            // 
            txtTenKhachMua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTenKhachMua.Location = new Point(241, 126);
            txtTenKhachMua.Name = "txtTenKhachMua";
            txtTenKhachMua.Size = new Size(350, 34);
            txtTenKhachMua.TabIndex = 24;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMaHoaDon.Location = new Point(241, 77);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.ReadOnly = true;
            txtMaHoaDon.Size = new Size(350, 34);
            txtMaHoaDon.TabIndex = 21;
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
            // lblMaHoaDon
            // 
            lblMaHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            lblTrangThai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            cmbTrangThai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            grpSuaHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            grpSuaHoaDon.Controls.Add(btnSua);
            grpSuaHoaDon.Controls.Add(txtTenKhach);
            grpSuaHoaDon.Controls.Add(cmbTrangThai);
            grpSuaHoaDon.Controls.Add(dtpNgayLap);
            grpSuaHoaDon.Controls.Add(lblTrangThai);
            grpSuaHoaDon.Controls.Add(lblSuaHoaDon);
            grpSuaHoaDon.Controls.Add(lblNgayLap);
            grpSuaHoaDon.Controls.Add(lblTenKhach);
            grpSuaHoaDon.Location = new Point(27, 490);
            grpSuaHoaDon.Name = "grpSuaHoaDon";
            grpSuaHoaDon.Size = new Size(576, 297);
            grpSuaHoaDon.TabIndex = 23;
            grpSuaHoaDon.TabStop = false;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            btnTaiLaiDanhSach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTaiLaiDanhSach.Location = new Point(340, 439);
            btnTaiLaiDanhSach.Name = "btnTaiLaiDanhSach";
            btnTaiLaiDanhSach.Size = new Size(180, 45);
            btnTaiLaiDanhSach.TabIndex = 50;
            btnTaiLaiDanhSach.Text = "Tải Lại Danh Sách";
            btnTaiLaiDanhSach.UseVisualStyleBackColor = true;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 802);
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
    }
}