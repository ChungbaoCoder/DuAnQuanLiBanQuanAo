using QuanLiShopQuanAo.BUS;

namespace QuanLiShopQuanAo.DataBaseConnection
{
    public partial class frmDangNhap : Form
    {
        public bool closed = false;
        public string maNhanVien = string.Empty;
        public string chucVu = string.Empty;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserEmail.Text) && !string.IsNullOrEmpty(txtPassWord.Text))
            {
                if (BUS_Account.Login(txtUserEmail.Text, txtPassWord.Text))
                {
                    maNhanVien = BUS_Account.MaNguoiDangNhap(txtUserEmail.Text);
                    chucVu = BUS_Account.ChucVuNguoiDangNhap(txtUserEmail.Text);
                    closed = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu xin hãy nhập lại", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserEmail.Text = string.Empty;
                    txtPassWord.Text = string.Empty;
                }
            }
            else
                MessageBox.Show("Hãy nhập hết vào các trường còn trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void llblQuenMK_Click(object sender, EventArgs e)
        {
            frmQuenMatKhau form = new frmQuenMatKhau();
            form.Show();
        }

        private void frmDangNhap_ResizeEnd(object sender, EventArgs e)
        {
            Screen thisScreen = Screen.FromControl(this);
            Rectangle area = thisScreen.WorkingArea;
            this.Top = (area.Height - this.Height) / 2;
            this.Left = (area.Width - this.Width) / 2;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closed)
                return;
            else
            {
                var res = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (res != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
