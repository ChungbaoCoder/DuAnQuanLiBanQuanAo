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
            btnXoaNhaCungCap = new Button();
            btnSuaNhaCungCap = new Button();
            btnTaiLaiDanhSach = new Button();
            btnTimNhaCungCap = new Button();
            txtTimKiemNhaCungCap = new TextBox();
            grpThemNhaCungCap = new GroupBox();
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
            grpThemNhaCungCap.SuspendLayout();
            grpSuaNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            SuspendLayout();
            // 
            // btnXoaNhaCungCap
            // 
            btnXoaNhaCungCap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaNhaCungCap.Font = new Font("Segoe UI", 10.8F);
            btnXoaNhaCungCap.Image = Properties.Resources.icons8_delete_30;
            btnXoaNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaNhaCungCap.Location = new Point(176, 292);
            btnXoaNhaCungCap.Name = "btnXoaNhaCungCap";
            btnXoaNhaCungCap.Size = new Size(136, 40);
            btnXoaNhaCungCap.TabIndex = 68;
            btnXoaNhaCungCap.Text = "Xoá Nhà CC";
            btnXoaNhaCungCap.TextAlign = ContentAlignment.MiddleRight;
            btnXoaNhaCungCap.UseVisualStyleBackColor = true;
            btnXoaNhaCungCap.Click += btnXoaNhaCungCap_Click;
            // 
            // btnSuaNhaCungCap
            // 
            btnSuaNhaCungCap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSuaNhaCungCap.Font = new Font("Segoe UI", 10.8F);
            btnSuaNhaCungCap.Image = Properties.Resources.icons8_update_30;
            btnSuaNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuaNhaCungCap.Location = new Point(183, 338);
            btnSuaNhaCungCap.Name = "btnSuaNhaCungCap";
            btnSuaNhaCungCap.Size = new Size(142, 40);
            btnSuaNhaCungCap.TabIndex = 67;
            btnSuaNhaCungCap.Text = "Sửa Nhà CC";
            btnSuaNhaCungCap.TextAlign = ContentAlignment.MiddleRight;
            btnSuaNhaCungCap.UseVisualStyleBackColor = true;
            btnSuaNhaCungCap.Click += btnSuaNhaCungCap_Click;
            // 
            // btnTaiLaiDanhSach
            // 
            btnTaiLaiDanhSach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTaiLaiDanhSach.Font = new Font("Segoe UI", 10.8F);
            btnTaiLaiDanhSach.Image = Properties.Resources.icons8_reload_30;
            btnTaiLaiDanhSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaiLaiDanhSach.Location = new Point(318, 292);
            btnTaiLaiDanhSach.Name = "btnTaiLaiDanhSach";
            btnTaiLaiDanhSach.Size = new Size(182, 40);
            btnTaiLaiDanhSach.TabIndex = 66;
            btnTaiLaiDanhSach.Text = "Tải Lại Danh Sách";
            btnTaiLaiDanhSach.TextAlign = ContentAlignment.MiddleRight;
            btnTaiLaiDanhSach.UseVisualStyleBackColor = true;
            btnTaiLaiDanhSach.Click += btnTaiLaiDanhSach_Click;
            // 
            // btnTimNhaCungCap
            // 
            btnTimNhaCungCap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTimNhaCungCap.Font = new Font("Segoe UI", 10.8F);
            btnTimNhaCungCap.Image = Properties.Resources.icons8_find_30;
            btnTimNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimNhaCungCap.Location = new Point(863, 296);
            btnTimNhaCungCap.Name = "btnTimNhaCungCap";
            btnTimNhaCungCap.Size = new Size(82, 36);
            btnTimNhaCungCap.TabIndex = 61;
            btnTimNhaCungCap.Text = "Tìm";
            btnTimNhaCungCap.TextAlign = ContentAlignment.MiddleRight;
            btnTimNhaCungCap.UseVisualStyleBackColor = true;
            btnTimNhaCungCap.Click += btnTimNhaCungCap_Click;
            // 
            // txtTimKiemNhaCungCap
            // 
            txtTimKiemNhaCungCap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiemNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtTimKiemNhaCungCap.Location = new Point(530, 296);
            txtTimKiemNhaCungCap.Name = "txtTimKiemNhaCungCap";
            txtTimKiemNhaCungCap.Size = new Size(328, 34);
            txtTimKiemNhaCungCap.TabIndex = 65;
            // 
            // grpThemNhaCungCap
            // 
            grpThemNhaCungCap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            grpThemNhaCungCap.Controls.Add(lblThemSDTNhaCungCap);
            grpThemNhaCungCap.Controls.Add(btnClearThemNhaCungCap);
            grpThemNhaCungCap.Controls.Add(btnLuuThemNhaCungCap);
            grpThemNhaCungCap.Controls.Add(lblThemNhaCungCap);
            grpThemNhaCungCap.Controls.Add(txtThemDiaChiNhaCungCap);
            grpThemNhaCungCap.Controls.Add(txtThemSDTNhaCungCap);
            grpThemNhaCungCap.Controls.Add(txtThemTenNhaCungCap);
            grpThemNhaCungCap.Controls.Add(lblThemTenNhaCungCap);
            grpThemNhaCungCap.Controls.Add(lblThemDiaChiNhaCungCap);
            grpThemNhaCungCap.Location = new Point(25, 378);
            grpThemNhaCungCap.Name = "grpThemNhaCungCap";
            grpThemNhaCungCap.Size = new Size(420, 233);
            grpThemNhaCungCap.TabIndex = 64;
            grpThemNhaCungCap.TabStop = false;
            // 
            // lblThemSDTNhaCungCap
            // 
            lblThemSDTNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblThemSDTNhaCungCap.AutoSize = true;
            lblThemSDTNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblThemSDTNhaCungCap.Location = new Point(5, 110);
            lblThemSDTNhaCungCap.Name = "lblThemSDTNhaCungCap";
            lblThemSDTNhaCungCap.Size = new Size(147, 30);
            lblThemSDTNhaCungCap.TabIndex = 36;
            lblThemSDTNhaCungCap.Text = "Số Điện Thoại";
            // 
            // btnClearThemNhaCungCap
            // 
            btnClearThemNhaCungCap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClearThemNhaCungCap.Font = new Font("Segoe UI", 10.8F);
            btnClearThemNhaCungCap.Image = Properties.Resources.icons8_clear_30;
            btnClearThemNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearThemNhaCungCap.Location = new Point(230, 186);
            btnClearThemNhaCungCap.Name = "btnClearThemNhaCungCap";
            btnClearThemNhaCungCap.Size = new Size(86, 35);
            btnClearThemNhaCungCap.TabIndex = 37;
            btnClearThemNhaCungCap.Text = "Xóa";
            btnClearThemNhaCungCap.TextAlign = ContentAlignment.MiddleRight;
            btnClearThemNhaCungCap.UseVisualStyleBackColor = true;
            btnClearThemNhaCungCap.Click += btnClearThemNhaCungCap_Click;
            // 
            // btnLuuThemNhaCungCap
            // 
            btnLuuThemNhaCungCap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuuThemNhaCungCap.Font = new Font("Segoe UI", 10.8F);
            btnLuuThemNhaCungCap.Image = Properties.Resources.icons8_save_30;
            btnLuuThemNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuuThemNhaCungCap.Location = new Point(322, 186);
            btnLuuThemNhaCungCap.Name = "btnLuuThemNhaCungCap";
            btnLuuThemNhaCungCap.Size = new Size(82, 35);
            btnLuuThemNhaCungCap.TabIndex = 36;
            btnLuuThemNhaCungCap.Text = "Lưu";
            btnLuuThemNhaCungCap.TextAlign = ContentAlignment.MiddleRight;
            btnLuuThemNhaCungCap.UseVisualStyleBackColor = true;
            btnLuuThemNhaCungCap.Click += btnLuuThemNhaCungCap_Click;
            // 
            // lblThemNhaCungCap
            // 
            lblThemNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblThemNhaCungCap.AutoSize = true;
            lblThemNhaCungCap.Font = new Font("Segoe UI", 14F);
            lblThemNhaCungCap.Location = new Point(5, 19);
            lblThemNhaCungCap.Name = "lblThemNhaCungCap";
            lblThemNhaCungCap.Size = new Size(354, 32);
            lblThemNhaCungCap.TabIndex = 36;
            lblThemNhaCungCap.Text = "Thêm Thông Tin Nhà Cung Cấp";
            // 
            // txtThemDiaChiNhaCungCap
            // 
            txtThemDiaChiNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtThemDiaChiNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtThemDiaChiNhaCungCap.Location = new Point(195, 146);
            txtThemDiaChiNhaCungCap.Name = "txtThemDiaChiNhaCungCap";
            txtThemDiaChiNhaCungCap.Size = new Size(219, 34);
            txtThemDiaChiNhaCungCap.TabIndex = 47;
            // 
            // txtThemSDTNhaCungCap
            // 
            txtThemSDTNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtThemSDTNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtThemSDTNhaCungCap.Location = new Point(195, 106);
            txtThemSDTNhaCungCap.Name = "txtThemSDTNhaCungCap";
            txtThemSDTNhaCungCap.Size = new Size(219, 34);
            txtThemSDTNhaCungCap.TabIndex = 45;
            // 
            // txtThemTenNhaCungCap
            // 
            txtThemTenNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtThemTenNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtThemTenNhaCungCap.Location = new Point(195, 69);
            txtThemTenNhaCungCap.Name = "txtThemTenNhaCungCap";
            txtThemTenNhaCungCap.Size = new Size(219, 34);
            txtThemTenNhaCungCap.TabIndex = 41;
            // 
            // lblThemTenNhaCungCap
            // 
            lblThemTenNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblThemTenNhaCungCap.AutoSize = true;
            lblThemTenNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblThemTenNhaCungCap.Location = new Point(5, 71);
            lblThemTenNhaCungCap.Name = "lblThemTenNhaCungCap";
            lblThemTenNhaCungCap.Size = new Size(193, 30);
            lblThemTenNhaCungCap.TabIndex = 42;
            lblThemTenNhaCungCap.Text = "Tên Nhà Cung Cấp";
            // 
            // lblThemDiaChiNhaCungCap
            // 
            lblThemDiaChiNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblThemDiaChiNhaCungCap.AutoSize = true;
            lblThemDiaChiNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblThemDiaChiNhaCungCap.Location = new Point(5, 147);
            lblThemDiaChiNhaCungCap.Name = "lblThemDiaChiNhaCungCap";
            lblThemDiaChiNhaCungCap.Size = new Size(81, 30);
            lblThemDiaChiNhaCungCap.TabIndex = 38;
            lblThemDiaChiNhaCungCap.Text = "Địa Chỉ";
            // 
            // btnChonTatCa
            // 
            btnChonTatCa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnChonTatCa.Font = new Font("Segoe UI", 10.8F);
            btnChonTatCa.Image = Properties.Resources.icons8_all_30;
            btnChonTatCa.ImageAlign = ContentAlignment.MiddleLeft;
            btnChonTatCa.Location = new Point(25, 292);
            btnChonTatCa.Name = "btnChonTatCa";
            btnChonTatCa.Size = new Size(145, 40);
            btnChonTatCa.TabIndex = 62;
            btnChonTatCa.Text = "Chọn Tất Cả";
            btnChonTatCa.TextAlign = ContentAlignment.MiddleRight;
            btnChonTatCa.UseVisualStyleBackColor = true;
            btnChonTatCa.Click += btnChonTatCa_Click;
            // 
            // grpSuaNhaCungCap
            // 
            grpSuaNhaCungCap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            grpSuaNhaCungCap.Location = new Point(451, 338);
            grpSuaNhaCungCap.Name = "grpSuaNhaCungCap";
            grpSuaNhaCungCap.Size = new Size(494, 273);
            grpSuaNhaCungCap.TabIndex = 63;
            grpSuaNhaCungCap.TabStop = false;
            // 
            // btnClearSuaNhaCungCap
            // 
            btnClearSuaNhaCungCap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClearSuaNhaCungCap.Font = new Font("Segoe UI", 10.8F);
            btnClearSuaNhaCungCap.Image = Properties.Resources.icons8_clear_30;
            btnClearSuaNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearSuaNhaCungCap.Location = new Point(313, 226);
            btnClearSuaNhaCungCap.Name = "btnClearSuaNhaCungCap";
            btnClearSuaNhaCungCap.Size = new Size(77, 34);
            btnClearSuaNhaCungCap.TabIndex = 35;
            btnClearSuaNhaCungCap.Text = "Xóa";
            btnClearSuaNhaCungCap.TextAlign = ContentAlignment.MiddleRight;
            btnClearSuaNhaCungCap.UseVisualStyleBackColor = true;
            btnClearSuaNhaCungCap.Click += btnClearSuaNhaCungCap_Click;
            // 
            // lblSuaNhaCungCap
            // 
            lblSuaNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaNhaCungCap.AutoSize = true;
            lblSuaNhaCungCap.Font = new Font("Segoe UI", 14F);
            lblSuaNhaCungCap.Location = new Point(9, 19);
            lblSuaNhaCungCap.Name = "lblSuaNhaCungCap";
            lblSuaNhaCungCap.Size = new Size(332, 32);
            lblSuaNhaCungCap.TabIndex = 34;
            lblSuaNhaCungCap.Text = "Sửa Thông Tin Nhà Cung Cấp";
            // 
            // txtSuaTenNhaCungCap
            // 
            txtSuaTenNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaTenNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtSuaTenNhaCungCap.Location = new Point(208, 110);
            txtSuaTenNhaCungCap.Name = "txtSuaTenNhaCungCap";
            txtSuaTenNhaCungCap.Size = new Size(271, 34);
            txtSuaTenNhaCungCap.TabIndex = 32;
            // 
            // lblSuaMaNhaCungCap
            // 
            lblSuaMaNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaMaNhaCungCap.AutoSize = true;
            lblSuaMaNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblSuaMaNhaCungCap.Location = new Point(5, 71);
            lblSuaMaNhaCungCap.Name = "lblSuaMaNhaCungCap";
            lblSuaMaNhaCungCap.Size = new Size(190, 30);
            lblSuaMaNhaCungCap.TabIndex = 18;
            lblSuaMaNhaCungCap.Text = "Mã Nhà Cung Cấp";
            // 
            // txtSuaMaNhaCungCap
            // 
            txtSuaMaNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaMaNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtSuaMaNhaCungCap.Location = new Point(207, 71);
            txtSuaMaNhaCungCap.Name = "txtSuaMaNhaCungCap";
            txtSuaMaNhaCungCap.ReadOnly = true;
            txtSuaMaNhaCungCap.Size = new Size(272, 34);
            txtSuaMaNhaCungCap.TabIndex = 22;
            // 
            // lblSuaTenNhaCungCap
            // 
            lblSuaTenNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaTenNhaCungCap.AutoSize = true;
            lblSuaTenNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblSuaTenNhaCungCap.Location = new Point(5, 110);
            lblSuaTenNhaCungCap.Name = "lblSuaTenNhaCungCap";
            lblSuaTenNhaCungCap.Size = new Size(193, 30);
            lblSuaTenNhaCungCap.TabIndex = 33;
            lblSuaTenNhaCungCap.Text = "Tên Nhà Cung Cấp";
            // 
            // txtSuaDiaChiNhaCungCap
            // 
            txtSuaDiaChiNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaDiaChiNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtSuaDiaChiNhaCungCap.Location = new Point(208, 188);
            txtSuaDiaChiNhaCungCap.Name = "txtSuaDiaChiNhaCungCap";
            txtSuaDiaChiNhaCungCap.Size = new Size(271, 34);
            txtSuaDiaChiNhaCungCap.TabIndex = 23;
            // 
            // lblSuaDiaChiNhaCungCap
            // 
            lblSuaDiaChiNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaDiaChiNhaCungCap.AutoSize = true;
            lblSuaDiaChiNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblSuaDiaChiNhaCungCap.Location = new Point(5, 190);
            lblSuaDiaChiNhaCungCap.Name = "lblSuaDiaChiNhaCungCap";
            lblSuaDiaChiNhaCungCap.Size = new Size(81, 30);
            lblSuaDiaChiNhaCungCap.TabIndex = 24;
            lblSuaDiaChiNhaCungCap.Text = "Địa Chỉ";
            // 
            // txtSuaSDTNhaCungCap
            // 
            txtSuaSDTNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSuaSDTNhaCungCap.Font = new Font("Segoe UI", 12F);
            txtSuaSDTNhaCungCap.Location = new Point(208, 149);
            txtSuaSDTNhaCungCap.Name = "txtSuaSDTNhaCungCap";
            txtSuaSDTNhaCungCap.Size = new Size(271, 34);
            txtSuaSDTNhaCungCap.TabIndex = 25;
            // 
            // btnLuuSuaNhaCungCap
            // 
            btnLuuSuaNhaCungCap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuuSuaNhaCungCap.Font = new Font("Segoe UI", 10.8F);
            btnLuuSuaNhaCungCap.Image = Properties.Resources.icons8_save_30;
            btnLuuSuaNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuuSuaNhaCungCap.Location = new Point(396, 226);
            btnLuuSuaNhaCungCap.Name = "btnLuuSuaNhaCungCap";
            btnLuuSuaNhaCungCap.Size = new Size(83, 34);
            btnLuuSuaNhaCungCap.TabIndex = 19;
            btnLuuSuaNhaCungCap.Text = "Lưu";
            btnLuuSuaNhaCungCap.TextAlign = ContentAlignment.MiddleRight;
            btnLuuSuaNhaCungCap.UseVisualStyleBackColor = true;
            btnLuuSuaNhaCungCap.Click += btnLuuSuaNhaCungCap_Click;
            // 
            // lblSuaSDTNhaCungCap
            // 
            lblSuaSDTNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuaSDTNhaCungCap.AutoSize = true;
            lblSuaSDTNhaCungCap.Font = new Font("Segoe UI", 13F);
            lblSuaSDTNhaCungCap.Location = new Point(5, 151);
            lblSuaSDTNhaCungCap.Name = "lblSuaSDTNhaCungCap";
            lblSuaSDTNhaCungCap.Size = new Size(147, 30);
            lblSuaSDTNhaCungCap.TabIndex = 26;
            lblSuaSDTNhaCungCap.Text = "Số Điện Thoại";
            // 
            // btnThemNhaCungCap
            // 
            btnThemNhaCungCap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThemNhaCungCap.Font = new Font("Segoe UI", 10.8F);
            btnThemNhaCungCap.Image = Properties.Resources.icons8_add_30;
            btnThemNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemNhaCungCap.Location = new Point(25, 338);
            btnThemNhaCungCap.Name = "btnThemNhaCungCap";
            btnThemNhaCungCap.Size = new Size(152, 40);
            btnThemNhaCungCap.TabIndex = 69;
            btnThemNhaCungCap.Text = "Thêm Nhà CC";
            btnThemNhaCungCap.TextAlign = ContentAlignment.MiddleRight;
            btnThemNhaCungCap.UseVisualStyleBackColor = true;
            btnThemNhaCungCap.Click += btnThemNhaCungCap_Click;
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.AllowUserToAddRows = false;
            dgvNhaCungCap.AllowUserToDeleteRows = false;
            dgvNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCungCap.Columns.AddRange(new DataGridViewColumn[] { dgvhCheckBoxNhaCungCap, dgvhMaNhaCungCap, dgvhTenNhaCungCap, dgvhDiaChiNhaCungCap, dgvhSDTNhaCungCap });
            dgvNhaCungCap.Location = new Point(25, 11);
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.RowHeadersVisible = false;
            dgvNhaCungCap.RowHeadersWidth = 51;
            dgvNhaCungCap.Size = new Size(919, 268);
            dgvNhaCungCap.TabIndex = 38;
            // 
            // dgvhCheckBoxNhaCungCap
            // 
            dgvhCheckBoxNhaCungCap.HeaderText = "";
            dgvhCheckBoxNhaCungCap.MinimumWidth = 6;
            dgvhCheckBoxNhaCungCap.Name = "dgvhCheckBoxNhaCungCap";
            // 
            // dgvhMaNhaCungCap
            // 
            dgvhMaNhaCungCap.HeaderText = "Mã Nhà Cung Cấp";
            dgvhMaNhaCungCap.MinimumWidth = 6;
            dgvhMaNhaCungCap.Name = "dgvhMaNhaCungCap";
            dgvhMaNhaCungCap.ReadOnly = true;
            // 
            // dgvhTenNhaCungCap
            // 
            dgvhTenNhaCungCap.HeaderText = "Tên Nhà Cung Cấp";
            dgvhTenNhaCungCap.MinimumWidth = 6;
            dgvhTenNhaCungCap.Name = "dgvhTenNhaCungCap";
            dgvhTenNhaCungCap.ReadOnly = true;
            // 
            // dgvhDiaChiNhaCungCap
            // 
            dgvhDiaChiNhaCungCap.HeaderText = "Địa Chỉ";
            dgvhDiaChiNhaCungCap.MinimumWidth = 6;
            dgvhDiaChiNhaCungCap.Name = "dgvhDiaChiNhaCungCap";
            dgvhDiaChiNhaCungCap.ReadOnly = true;
            // 
            // dgvhSDTNhaCungCap
            // 
            dgvhSDTNhaCungCap.HeaderText = "Số Điện Thoại";
            dgvhSDTNhaCungCap.MinimumWidth = 6;
            dgvhSDTNhaCungCap.Name = "dgvhSDTNhaCungCap";
            dgvhSDTNhaCungCap.ReadOnly = true;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 625);
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
            Font = new Font("Segoe UI", 10.8F);
            Margin = new Padding(4);
            Name = "frmNhaCungCap";
            Text = "Quản Lí Nhà Cung Cấp";
            Load += frmNhaCungCap_Load;
            grpThemNhaCungCap.ResumeLayout(false);
            grpThemNhaCungCap.PerformLayout();
            grpSuaNhaCungCap.ResumeLayout(false);
            grpSuaNhaCungCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button btnThemNhaCungCap;
        private DataGridView dgvNhaCungCap;
        private DataGridViewCheckBoxColumn dgvhCheckBoxNhaCungCap;
        private DataGridViewTextBoxColumn dgvhMaNhaCungCap;
        private DataGridViewTextBoxColumn dgvhTenNhaCungCap;
        private DataGridViewTextBoxColumn dgvhDiaChiNhaCungCap;
        private DataGridViewTextBoxColumn dgvhSDTNhaCungCap;
    }
}