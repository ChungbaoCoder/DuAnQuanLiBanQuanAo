namespace QuanLiShopQuanAo.Resources
{
    partial class frmHoTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoTro));
            pnlBackGroundPic = new Panel();
            msDashBoard = new MenuStrip();
            tsmiSupport = new ToolStripMenuItem();
            tsmiSendMail = new ToolStripMenuItem();
            tsmiToolUpdate = new ToolStripMenuItem();
            tsmiIntroduction = new ToolStripMenuItem();
            tsmiDetailAbout = new ToolStripMenuItem();
            tsmiUserGuide = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
            tsmiTurnBack = new ToolStripMenuItem();
            picBackGround = new PictureBox();
            pnlBackGroundPic.SuspendLayout();
            msDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBackGround).BeginInit();
            SuspendLayout();
            // 
            // pnlBackGroundPic
            // 
            pnlBackGroundPic.Controls.Add(msDashBoard);
            pnlBackGroundPic.Controls.Add(picBackGround);
            pnlBackGroundPic.Dock = DockStyle.Fill;
            pnlBackGroundPic.Location = new Point(0, 0);
            pnlBackGroundPic.Name = "pnlBackGroundPic";
            pnlBackGroundPic.Size = new Size(726, 468);
            pnlBackGroundPic.TabIndex = 0;
            // 
            // msDashBoard
            // 
            msDashBoard.BackColor = SystemColors.ActiveCaptionText;
            msDashBoard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msDashBoard.ImageScalingSize = new Size(20, 20);
            msDashBoard.Items.AddRange(new ToolStripItem[] { tsmiSupport, tsmiIntroduction, tsmiQuit });
            msDashBoard.Location = new Point(0, 0);
            msDashBoard.Name = "msDashBoard";
            msDashBoard.Size = new Size(726, 36);
            msDashBoard.TabIndex = 2;
            msDashBoard.Text = "menuStrip1";
            // 
            // tsmiSupport
            // 
            tsmiSupport.BackColor = SystemColors.ActiveCaptionText;
            tsmiSupport.DropDownItems.AddRange(new ToolStripItem[] { tsmiSendMail, tsmiToolUpdate });
            tsmiSupport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tsmiSupport.ForeColor = SystemColors.ButtonHighlight;
            tsmiSupport.Name = "tsmiSupport";
            tsmiSupport.Size = new Size(90, 32);
            tsmiSupport.Text = "Hỗ Trợ";
            // 
            // tsmiSendMail
            // 
            tsmiSendMail.BackColor = SystemColors.ActiveCaptionText;
            tsmiSendMail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tsmiSendMail.ForeColor = SystemColors.ButtonHighlight;
            tsmiSendMail.Name = "tsmiSendMail";
            tsmiSendMail.Size = new Size(293, 32);
            tsmiSendMail.Text = "Gửi Email Hỗ Trợ";
            // 
            // tsmiToolUpdate
            // 
            tsmiToolUpdate.BackColor = SystemColors.ActiveCaptionText;
            tsmiToolUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tsmiToolUpdate.ForeColor = SystemColors.ButtonHighlight;
            tsmiToolUpdate.Name = "tsmiToolUpdate";
            tsmiToolUpdate.Size = new Size(293, 32);
            tsmiToolUpdate.Text = "Cập Nhật Phần Mềm";
            // 
            // tsmiIntroduction
            // 
            tsmiIntroduction.DropDownItems.AddRange(new ToolStripItem[] { tsmiDetailAbout, tsmiUserGuide });
            tsmiIntroduction.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tsmiIntroduction.ForeColor = SystemColors.ButtonHighlight;
            tsmiIntroduction.Name = "tsmiIntroduction";
            tsmiIntroduction.Size = new Size(122, 32);
            tsmiIntroduction.Text = "Thông Tin";
            // 
            // tsmiDetailAbout
            // 
            tsmiDetailAbout.BackColor = SystemColors.ActiveCaptionText;
            tsmiDetailAbout.ForeColor = SystemColors.ButtonHighlight;
            tsmiDetailAbout.Name = "tsmiDetailAbout";
            tsmiDetailAbout.Size = new Size(383, 32);
            tsmiDetailAbout.Text = "Thông Tin Công Ty Phần Mềm";
            tsmiDetailAbout.Click += tsmiDetailAbout_Click;
            // 
            // tsmiUserGuide
            // 
            tsmiUserGuide.BackColor = SystemColors.ActiveCaptionText;
            tsmiUserGuide.ForeColor = SystemColors.ButtonHighlight;
            tsmiUserGuide.Name = "tsmiUserGuide";
            tsmiUserGuide.Size = new Size(383, 32);
            tsmiUserGuide.Text = "Hướng Dẫn Sử Dụng";
            tsmiUserGuide.Click += tsmiUserGuide_Click;
            // 
            // tsmiQuit
            // 
            tsmiQuit.DropDownItems.AddRange(new ToolStripItem[] { tsmiTurnBack });
            tsmiQuit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tsmiQuit.ForeColor = SystemColors.ButtonHighlight;
            tsmiQuit.Name = "tsmiQuit";
            tsmiQuit.Size = new Size(68, 32);
            tsmiQuit.Text = "EXIT";
            // 
            // tsmiTurnBack
            // 
            tsmiTurnBack.BackColor = SystemColors.ActiveCaptionText;
            tsmiTurnBack.ForeColor = SystemColors.ButtonHighlight;
            tsmiTurnBack.Name = "tsmiTurnBack";
            tsmiTurnBack.Size = new Size(224, 32);
            tsmiTurnBack.Text = "Quay Lại";
            tsmiTurnBack.Click += tsmiTurnBack_Click;
            // 
            // picBackGround
            // 
            picBackGround.Image = (Image)resources.GetObject("picBackGround.Image");
            picBackGround.Location = new Point(-72, -64);
            picBackGround.Name = "picBackGround";
            picBackGround.Size = new Size(801, 535);
            picBackGround.TabIndex = 0;
            picBackGround.TabStop = false;
            // 
            // frmHoTro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 468);
            Controls.Add(pnlBackGroundPic);
            Name = "frmHoTro";
            Text = "frmHoTro";
            pnlBackGroundPic.ResumeLayout(false);
            pnlBackGroundPic.PerformLayout();
            msDashBoard.ResumeLayout(false);
            msDashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBackGround).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip miniToolStrip;
        private Panel pnlBackGroundPic;
        private MenuStrip msDashBoard;
        private ToolStripMenuItem tsmiSupport;
        private ToolStripMenuItem tsmiSendMail;
        private ToolStripMenuItem tsmiIntroduction;
        private ToolStripMenuItem tsmiDetailAbout;
        private ToolStripMenuItem tsmiQuit;
        private ToolStripMenuItem tsmiTurnBack;
        private PictureBox picBackGround;
        private ToolStripMenuItem tsmiUserGuide;
        private ToolStripMenuItem tsmiToolUpdate;
    }
}