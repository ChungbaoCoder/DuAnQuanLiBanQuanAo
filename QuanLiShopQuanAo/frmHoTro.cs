using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;

namespace QuanLiShopQuanAo.Resources
{
    public partial class frmHoTro : Form
    {
        public bool check = false;
        public frmHoTro()
        {
            InitializeComponent();
        }

        private void tsmiUserGuide_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\DELL\Desktop\Project\DuAnQuanLiBanQuanAo";

            if (File.Exists(filePath))
            {
                try
                {
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch
                {
                    MessageBox.Show("Không thể mở file PDF ", "Lỗi mở file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy file PDF!", "Lỗi tìm file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsmiDetailAbout_Click(object sender, EventArgs e)
        {
            frmThongTinCongTy form = new frmThongTinCongTy();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void tsmiTurnBack_Click(object sender, EventArgs e)
        {
            check = true;
            this.Close();
        }
    }
}
    
