using QuanLiShopQuanAo.BUS;

namespace QuanLiShopQuanAo
{
    public partial class frmShowChiTiet : Form
    {
        public string MaHoaDon = "";
        public frmShowChiTiet()
        {
            InitializeComponent();
        }

        private void frmShowChiTiet_Load(object sender, EventArgs e)
        {
            dgvChiTietHoaDon.DataSource = BUS_ChiTietHoaDon.QueryData("data", MaHoaDon);
        }
    }
}
