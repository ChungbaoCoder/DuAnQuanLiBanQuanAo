namespace QuanLiShopQuanAo
{
    partial class ProductControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblGiaTien = new Label();
            picSanPham = new PictureBox();
            lblTenSanPham = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSanPham).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(lblGiaTien);
            panel1.Controls.Add(picSanPham);
            panel1.Controls.Add(lblTenSanPham);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 495);
            panel1.TabIndex = 47;
            // 
            // lblGiaTien
            // 
            lblGiaTien.AutoSize = true;
            lblGiaTien.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaTien.ForeColor = Color.FromArgb(0, 192, 0);
            lblGiaTien.Location = new Point(3, 386);
            lblGiaTien.Name = "lblGiaTien";
            lblGiaTien.Size = new Size(121, 34);
            lblGiaTien.TabIndex = 4;
            lblGiaTien.Text = "Giá tiền";
            // 
            // picSanPham
            // 
            picSanPham.Location = new Point(16, 89);
            picSanPham.Margin = new Padding(3, 4, 3, 4);
            picSanPham.Name = "picSanPham";
            picSanPham.Size = new Size(254, 265);
            picSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            picSanPham.TabIndex = 1;
            picSanPham.TabStop = false;
            // 
            // lblTenSanPham
            // 
            lblTenSanPham.AutoSize = true;
            lblTenSanPham.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenSanPham.Location = new Point(16, 24);
            lblTenSanPham.Name = "lblTenSanPham";
            lblTenSanPham.Size = new Size(54, 34);
            lblTenSanPham.TabIndex = 0;
            lblTenSanPham.Text = "Áo";
            // 
            // ProductControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductControl";
            Size = new Size(286, 497);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Label lblGiaTien;
        public PictureBox picSanPham;
        public Label lblTenSanPham;
    }
}
