namespace QuanLiShopQuanAo.Resources
{
    partial class frmHoTroEmail
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtFilePath = new TextBox();
            txtNoiDung = new TextBox();
            txtEmail = new TextBox();
            btnGui = new Button();
            btnOpenFile = new Button();
            lblEmail = new Label();
            lblChonFile = new Label();
            lblContext = new Label();
            lblTitle = new Label();
            tsmiExit = new ToolStripMenuItem();
            tsmiReturn = new ToolStripMenuItem();
            msQuitControl = new MenuStrip();
            msQuitControl.SuspendLayout();
            SuspendLayout();
            // 
            // txtFilePath
            // 
            txtFilePath.AccessibleName = "";
            txtFilePath.BackColor = SystemColors.ActiveCaptionText;
            txtFilePath.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtFilePath.ForeColor = Color.White;
            txtFilePath.Location = new Point(189, 229);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(257, 30);
            txtFilePath.TabIndex = 13;
            // 
            // txtNoiDung
            // 
            txtNoiDung.BackColor = SystemColors.ActiveCaptionText;
            txtNoiDung.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtNoiDung.ForeColor = Color.White;
            txtNoiDung.Location = new Point(189, 284);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.PlaceholderText = "Nội dung";
            txtNoiDung.Size = new Size(524, 167);
            txtNoiDung.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = SystemColors.ActiveCaptionText;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(189, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Nhập Email";
            txtEmail.Size = new Size(257, 30);
            txtEmail.TabIndex = 11;
            // 
            // btnGui
            // 
            btnGui.BackColor = SystemColors.ActiveCaptionText;
            btnGui.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGui.ForeColor = Color.White;
            btnGui.Location = new Point(319, 469);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(108, 48);
            btnGui.TabIndex = 10;
            btnGui.Text = "Gửi";
            btnGui.UseVisualStyleBackColor = false;
            btnGui.Click += btnGui_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = SystemColors.ActiveCaptionText;
            btnOpenFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnOpenFile.ForeColor = Color.White;
            btnOpenFile.Location = new Point(477, 232);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(94, 29);
            btnOpenFile.TabIndex = 14;
            btnOpenFile.Text = "Mở";
            btnOpenFile.UseVisualStyleBackColor = false;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.ActiveCaptionText;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(34, 166);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(102, 23);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Nhập Emai ";
            // 
            // lblChonFile
            // 
            lblChonFile.AutoSize = true;
            lblChonFile.BackColor = SystemColors.ActiveCaptionText;
            lblChonFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblChonFile.ForeColor = Color.White;
            lblChonFile.Location = new Point(34, 227);
            lblChonFile.Name = "lblChonFile";
            lblChonFile.Size = new Size(82, 23);
            lblChonFile.TabIndex = 16;
            lblChonFile.Text = "Chọn file";
            // 
            // lblContext
            // 
            lblContext.AutoSize = true;
            lblContext.BackColor = SystemColors.ActiveCaptionText;
            lblContext.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblContext.ForeColor = Color.White;
            lblContext.Location = new Point(34, 284);
            lblContext.Name = "lblContext";
            lblContext.Size = new Size(130, 23);
            lblContext.TabIndex = 17;
            lblContext.Text = "Nhập nội dung";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(266, 49);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(268, 31);
            lblTitle.TabIndex = 18;
            lblTitle.Text = "HỖ TRỢ KHÁCH HÀNG ";
            // 
            // tsmiExit
            // 
            tsmiExit.BackColor = Color.Black;
            tsmiExit.DropDownItems.AddRange(new ToolStripItem[] { tsmiReturn });
            tsmiExit.ForeColor = SystemColors.ButtonHighlight;
            tsmiExit.Name = "tsmiExit";
            tsmiExit.Size = new Size(52, 24);
            tsmiExit.Text = "EXIT";
            // 
            // tsmiReturn
            // 
            tsmiReturn.BackColor = SystemColors.ActiveCaptionText;
            tsmiReturn.ForeColor = SystemColors.ButtonHighlight;
            tsmiReturn.Name = "tsmiReturn";
            tsmiReturn.Size = new Size(224, 26);
            tsmiReturn.Text = "Quay lại";
            tsmiReturn.Click += tsmiReturn_Click;
            // 
            // msQuitControl
            // 
            msQuitControl.BackColor = Color.Black;
            msQuitControl.ImageScalingSize = new Size(20, 20);
            msQuitControl.Items.AddRange(new ToolStripItem[] { tsmiExit });
            msQuitControl.Location = new Point(0, 0);
            msQuitControl.Name = "msQuitControl";
            msQuitControl.Size = new Size(778, 28);
            msQuitControl.TabIndex = 20;
            msQuitControl.Text = "menuStrip1";
            // 
            // frmHoTroEmail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(778, 529);
            Controls.Add(msQuitControl);
            Controls.Add(lblTitle);
            Controls.Add(lblContext);
            Controls.Add(lblChonFile);
            Controls.Add(lblEmail);
            Controls.Add(btnOpenFile);
            Controls.Add(txtFilePath);
            Controls.Add(txtNoiDung);
            Controls.Add(txtEmail);
            Controls.Add(btnGui);
            MainMenuStrip = msQuitControl;
            Name = "frmHoTroEmail";
            Text = "frmHoTroEmail";
            msQuitControl.ResumeLayout(false);
            msQuitControl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnOpenFile;
        private Label lblEmail;
        private Label lblChonFile;
        private Label lblContext;
        private Label lblTitle;
        private ToolStripMenuItem tsmiExit;
        private ToolStripMenuItem tsmiReturn;
        private MenuStrip msQuitControl;
    }
}
