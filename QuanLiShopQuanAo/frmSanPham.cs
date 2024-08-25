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
    }
}
