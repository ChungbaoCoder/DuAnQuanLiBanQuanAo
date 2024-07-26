using QuanLiShopQuanAo.DataBaseConnection;

namespace QuanLiShopQuanAo
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private Form currentform;
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
            panel9.Controls.Add(childform);
            panel9.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void tsmiSanPham_Click(object sender, EventArgs e)
        {

        }

        private void tsmiNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien form = new frmNhanVien();
            this.Hide();
            form.ShowDialog();

            if (form.closed)
                this.Show();
        }

        private void tsmiHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon form = new frmHoaDon();
            this.Hide();
            form.ShowDialog();

            if (form.closed)
                this.Show();
        }

        private void tsmiKho_Click(object sender, EventArgs e)
        {
            frmKho form = new frmKho();
            this.Hide();
            form.ShowDialog();

            if (form.closed)
                this.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            frmDangNhap form = new frmDangNhap();
            this.Hide();
            form.ShowDialog();

            if (form.closed)
                this.Show();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            Openchildform(new frmHoaDon());
            label1.Text = btn_HoaDon.Text;
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            Openchildform(new frmSanPham());
            label1.Text = btn_SanPham.Text;
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            Openchildform(new frmKhachHang());
            label1.Text = btn_KhachHang.Text;
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            Openchildform(new frmNhanVien());
            label1.Text = btn_NhanVien.Text;
        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {
            Openchildform(new frmKho());
            label1.Text = btn_Kho.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Openchildform(new frmNhaCungCap());
            label1.Text = btn_Ncc.Text;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (currentform != null)
            {
                currentform.Close();
            }
            label1.Text = "Trang Chủ";
        }
    }
}
