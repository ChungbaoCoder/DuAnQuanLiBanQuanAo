using System.Data;
using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;

namespace QuanLiShopQuanAo
{
    public partial class frmSanPham : Form
    {
        public bool closed = false;
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            DataTable dt = BUS_SanPham.QueryData("data");
            List<SanPham> listSanPham = new List<SanPham>();

            foreach (DataRow dataRow in dt.Rows)
            {
                listSanPham.Add(new SanPham
                {
                    TenSanPham = dataRow["TenSanPham"].ToString(),
                    Gia = Convert.ToInt32(dataRow["Gia"].ToString()),
                    HinhAnh = dataRow["HinhAnh"].ToString(),
                    TrangThai = dataRow["TrangThai"].ToString()
                });
            }

            foreach (SanPham sanPhams in listSanPham)
            {
                if (sanPhams.TrangThai != "Chưa Bán")
                {
                    ProductControl pc = new ProductControl();
                    pc.lblTenSanPham.Text = sanPhams.TenSanPham;
                    pc.lblGiaTien.Text = sanPhams.Gia.ToString();

                    try
                    {
                        pc.picSanPham.Load(sanPhams.HinhAnh);
                    }
                    catch { }
                    fpnlSanPham.Controls.Add(pc); 
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ProductControl pC = new();
            pC.lblTenSanPham.Text = txtTenSanPham.Text;
            pC.label2.Text = txtMoTaSanPham.Text;
            pC.lblGiaTien.Text = txtGiaSanPham.Text;
            pC.picSanPham.Image = picAddHinhSanPham.Image;
            fpnlSanPham.Controls.Add(pC);
        }

        private void picAddHinhSanPham_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();
            if (ofd.ShowDialog() == DialogResult.OK)
                picAddHinhSanPham.ImageLocation = ofd.FileName;
        }
    }
}
