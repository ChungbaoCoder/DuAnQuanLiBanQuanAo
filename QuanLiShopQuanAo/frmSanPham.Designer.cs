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
            SuspendLayout();
            // 
            // fpnlSanPham
            // 
            fpnlSanPham.AutoScroll = true;
            fpnlSanPham.BackColor = SystemColors.ActiveCaption;
            fpnlSanPham.Dock = DockStyle.Fill;
            fpnlSanPham.Location = new Point(0, 0);
            fpnlSanPham.Name = "fpnlSanPham";
            fpnlSanPham.Size = new Size(1401, 750);
            fpnlSanPham.TabIndex = 0;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1401, 750);
            Controls.Add(fpnlSanPham);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmSanPham";
            Text = "Quản Lí Sản Phẩm";
            Load += frmSanPham_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel fpnlSanPham;
    }
}