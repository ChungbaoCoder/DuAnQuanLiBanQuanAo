using QuanLiShopQuanAo.DataBaseConnection;

namespace QuanLiShopQuanAo
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
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
    }
}
