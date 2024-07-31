using QuanLiShopQuanAo.BUS;
using System.Xml.Linq;

namespace QuanLiShopQuanAo
{
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnGuiEmail_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (BUS_Account.SendMail(txtEmail.Text))
                {
                    MessageBox.Show("Kiểm tra inbox của bạn, nhấn ok để thoát màn hình quên mật khẩu", "Đã gửi mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể gửi được mail hoặc do mail không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Text = string.Empty;
                }
            }
            else
                MessageBox.Show("Hãy điền vào thông tin trước khi gửi", "Nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuiDoiMatKhau_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin vào", "Điền thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhauCu.Text = string.Empty;
                    txtMatKhauMoi.Text = string.Empty;
                    txtXacNhanMatKhauMoi.Text = string.Empty;
                    return;
                }
            }

            if (BUS_Account.ChangePassword(txtEmail.Text, txtMatKhauCu.Text, txtMatKhauMoi.Text, txtXacNhanMatKhauMoi.Text))
            {
                MessageBox.Show("Đã đổi thông tin mật khẩu cho tài khoản này", "Đổi mật khẩu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không thể gửi được mail hoặc do mail không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = string.Empty;
                txtMatKhauCu.Text = string.Empty;
                txtMatKhauMoi.Text = string.Empty;
                txtXacNhanMatKhauMoi.Text = string.Empty;
            }
        }

        private void frmQuenMatKhau_ResizeEnd(object sender, EventArgs e)
        {
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;
            this.Top = (area.Height - this.Height) / 2;
            this.Left = (area.Width - this.Width) / 2;
        }

        private void llblDoiMatKhau_Click(object sender, EventArgs e)
        {
            lblMatKhauCu.Visible = true;
            lblMatKhauMoi.Visible = true;
            lblXacNhanMatKhauMoi.Visible = true;
            txtMatKhauCu.Visible = true;
            txtMatKhauMoi.Visible = true;
            txtXacNhanMatKhauMoi.Visible = true;
            llblQuenMatKhau.Visible = true;
            btnGuiDoiMatKhau.Visible = true;

            llblDoiMatKhau.Visible = false;
            btnGuiDoiEmail.Visible = false;
            lblTitle.Text = "Đổi Mật Khẩu";
        }

        private void llblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblMatKhauCu.Visible = false;
            lblMatKhauMoi.Visible = false;
            lblXacNhanMatKhauMoi.Visible = false;
            txtMatKhauCu.Visible = false;
            txtMatKhauMoi.Visible = false;
            txtXacNhanMatKhauMoi.Visible = false;
            llblQuenMatKhau.Visible = false;
            btnGuiDoiMatKhau.Visible = false;

            llblDoiMatKhau.Visible = true;
            btnGuiDoiEmail.Visible = true;
            lblTitle.Text = "Quên Mật Khẩu";
        }
    }
}
