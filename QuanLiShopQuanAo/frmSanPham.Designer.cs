namespace QuanLiShopQuanAo
{
    partial class frmSanPham
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
            fpnlSanPham = new FlowLayoutPanel();
            btnThem = new Button();
            txtTenSanPham = new TextBox();
            txtMoTaSanPham = new TextBox();
            txtGiaSanPham = new TextBox();
            pnlSanPham = new Panel();
            picAddHinhSanPham = new PictureBox();
            pnlSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAddHinhSanPham).BeginInit();
            SuspendLayout();
            // 
            // fpnlSanPham
            // 
            fpnlSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fpnlSanPham.AutoScroll = true;
            fpnlSanPham.BackColor = SystemColors.ActiveCaption;
            fpnlSanPham.Location = new Point(0, 0);
            fpnlSanPham.Name = "fpnlSanPham";
            fpnlSanPham.Size = new Size(921, 750);
            fpnlSanPham.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(15, 195);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 40);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(15, 11);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.PlaceholderText = "Tên Sản Phẩm";
            txtTenSanPham.Size = new Size(181, 34);
            txtTenSanPham.TabIndex = 2;
            // 
            // txtMoTaSanPham
            // 
            txtMoTaSanPham.Location = new Point(15, 55);
            txtMoTaSanPham.Name = "txtMoTaSanPham";
            txtMoTaSanPham.PlaceholderText = "Mô Tả";
            txtMoTaSanPham.Size = new Size(181, 34);
            txtMoTaSanPham.TabIndex = 3;
            // 
            // txtGiaSanPham
            // 
            txtGiaSanPham.Location = new Point(15, 103);
            txtGiaSanPham.Name = "txtGiaSanPham";
            txtGiaSanPham.PlaceholderText = "Giá";
            txtGiaSanPham.Size = new Size(181, 34);
            txtGiaSanPham.TabIndex = 4;
            // 
            // pnlSanPham
            // 
            pnlSanPham.BackColor = SystemColors.ActiveCaption;
            pnlSanPham.Controls.Add(picAddHinhSanPham);
            pnlSanPham.Controls.Add(txtGiaSanPham);
            pnlSanPham.Controls.Add(txtMoTaSanPham);
            pnlSanPham.Controls.Add(txtTenSanPham);
            pnlSanPham.Controls.Add(btnThem);
            pnlSanPham.Dock = DockStyle.Right;
            pnlSanPham.Location = new Point(927, 0);
            pnlSanPham.Name = "pnlSanPham";
            pnlSanPham.Size = new Size(474, 750);
            pnlSanPham.TabIndex = 5;
            // 
            // picAddHinhSanPham
            // 
            picAddHinhSanPham.BackColor = SystemColors.ActiveBorder;
            picAddHinhSanPham.BorderStyle = BorderStyle.FixedSingle;
            picAddHinhSanPham.Location = new Point(15, 147);
            picAddHinhSanPham.Name = "picAddHinhSanPham";
            picAddHinhSanPham.Size = new Size(181, 10);
            picAddHinhSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            picAddHinhSanPham.TabIndex = 5;
            picAddHinhSanPham.TabStop = false;
            picAddHinhSanPham.Click += picAddHinhSanPham_Click;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1401, 750);
            Controls.Add(pnlSanPham);
            Controls.Add(fpnlSanPham);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmSanPham";
            Text = "Quản Lí Sản Phẩm";
            Load += frmSanPham_Load;
            pnlSanPham.ResumeLayout(false);
            pnlSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAddHinhSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel fpnlSanPham;
        private Button btnThem;
        private TextBox txtTenSanPham;
        private TextBox txtMoTaSanPham;
        private TextBox txtGiaSanPham;
        private Panel pnlSanPham;
        public PictureBox picAddHinhSanPham;
    }
}