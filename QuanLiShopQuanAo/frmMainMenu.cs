using QuanLiShopQuanAo.DataBaseConnection;

namespace QuanLiShopQuanAo
{
    public partial class frmMainMenu : Form
    {
        private Form currentform;
        string MaNhanVien = string.Empty;
        public frmMainMenu()
        {
            InitializeComponent();
        }
        
        private void Openchildform(Form childform)
        {
            if (currentform != null)
            {
                currentform.Close();
            }
            currentform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childform);
            pnlContent.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            //frmDangNhap form = new frmDangNhap();
            //this.Hide();
            //form.ShowDialog();
            //MaNhanVien = form.MaNhanVien;

            //if (form.closed)
            //{
            //    form.Close();
            //    this.Show();
            //}
            //else
            //    Application.Exit();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Openchildform(new frmHoaDon(MaNhanVien));
            lblTrangChu.Text = btnHoaDon.Text;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            Openchildform(new frmSanPham());
            lblTrangChu.Text = btnSanPham.Text;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Openchildform(new frmKhachHang());
            lblTrangChu.Text = btnKhachHang.Text;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Openchildform(new frmNhanVien());
            lblTrangChu.Text = btnNhanVien.Text;
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            Openchildform(new frmKho());
            lblTrangChu.Text = btnKho.Text;
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            Openchildform(new frmNhaCungCap());
            lblTrangChu.Text = btnNhaCungCap.Text;
        }
    }
}
