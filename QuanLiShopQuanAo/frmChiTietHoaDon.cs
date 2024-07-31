using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;
using System.Data;

namespace QuanLiShopQuanAo
{
    public partial class frmChiTietHoaDon : Form
    {
        public string TenKhachHang = string.Empty;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            SetColumns();
            lblTenKhachHang.Text += " " + TenKhachHang;
            dgvChiTietHoaDon.DataSource = BUS_ChiTietHoaDon.QueryData("data", TenKhachHang);
            dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
        }

        private void SetColumns()
        {
            var columnsName = BUS_ChiTietHoaDon.QueryData("data", TenKhachHang).Columns.
                Cast<DataColumn>().Select(columns => columns.ColumnName).ToArray();

            for (int i = 0; i < columnsName.Length; i++)
                dgvChiTietHoaDon.Columns[i + 1].DataPropertyName = columnsName[i];

            DataTable dt = BUS_SanPham.QueryData("data");
            dt.Columns.Remove("MaNCC");
            columnsName = dt.Columns.Cast<DataColumn>().Select(columns => columns.ColumnName).ToArray();

            for (int i = 0; i < columnsName.Length; i++)
                dgvSanPham.Columns[i + 1].DataPropertyName = columnsName[i];
        }

        private void btnChonTatCa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
            {
                if (row.Cells[0] is DataGridViewButtonCell button)
                    dgvChiTietHoaDon.EndEdit();

                row.Cells[0].Value = ((Button)sender).Enabled;
            }
        }

        private void btnTaiLaiDanhSach_Click(object sender, EventArgs e)
        {
            dgvChiTietHoaDon.DataSource = BUS_ChiTietHoaDon.QueryData("data", TenKhachHang);
            dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvSanPham.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvSanPham.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[5].Value.ToString());

                try
                {
                    Bitmap bitmap = new Bitmap(cellValue);
                    picAnhSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                    picAnhSanPham.Image = Image.FromFile(cellValue);
                    bitmap.Dispose();
                }
                catch { }
            }
        }

        private void btnThemVaoHoaDon_Click(object sender, EventArgs e)
        {
            List<SanPham> listSanPham = new List<SanPham>();

            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true && row.Cells[7].Value.ToString() != "Hết Hàng")
                    listSanPham.Add(new SanPham
                    {
                        MaSanPham = row.Cells[1].Value.ToString(),
                        TenSanPham = row.Cells[2].Value.ToString(),
                        SoLuong = Convert.ToInt32(nupSoLuong.Value),
                        Gia = int.Parse(row.Cells[4].Value.ToString())
                    });
            }
            nupSoLuong.Value = 0;

            foreach (SanPham SanPham in listSanPham)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon()
                {
                    MaSanPham = SanPham.MaSanPham,
                    TenKhachHang = lblTenKhachHang.Text,
                    TenSanPham = SanPham.TenSanPham,
                    SoLuong = SanPham.SoLuong,
                    TongThanhTien = SanPham.Gia * SanPham.SoLuong
                };
                if (BUS_ChiTietHoaDon.QueryData(chiTietHoaDon, "insert"))
                    MessageBox.Show("Thêm thành công sản phẩm " + SanPham.TenSanPham, "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Lỗi thêm sản phẩm với mã " + SanPham.TenSanPham, "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvChiTietHoaDon.DataSource = BUS_ChiTietHoaDon.QueryData("data", TenKhachHang);
            dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
        }

        private void btnHoanThanhHD_Click(object sender, EventArgs e)
        {
            List<ChiTietHoaDon> listChiTietHoaDon = new List<ChiTietHoaDon>();

            foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
            {
                listChiTietHoaDon.Add(new ChiTietHoaDon()
                {
                    MaHoaDon = dgvChiTietHoaDon.Rows[0].Cells[1].Value.ToString(),
                    TongThanhTien = float.Parse(row.Cells[6].Value.ToString())
                });
            }

            foreach (ChiTietHoaDon ChiTietHoaDon in listChiTietHoaDon)
            {
                if (BUS_ChiTietHoaDon.QueryData(ChiTietHoaDon, "insert"))
                    MessageBox.Show("Thêm thông tin hoá đơn của khách hàng thành công", "Thêm hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không cập nhật được thông tin hoá đơn khách hàng có mã hoá đơn " + ChiTietHoaDon.MaHoaDon, "Thêm hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu", "Xoá hoá đơn?",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<ChiTietHoaDon> listChiTietHoaDon = new List<ChiTietHoaDon>();

                foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                        listChiTietHoaDon.Add(new ChiTietHoaDon { 
                            MaSanPham = row.Cells[1].Value.ToString(),
                            TenSanPham = row.Cells[2].Value.ToString()
                        });
                }

                foreach (ChiTietHoaDon ChiTietHoaDon in listChiTietHoaDon)
                {
                    if (BUS_ChiTietHoaDon.QueryData(ChiTietHoaDon, "delete"))
                        MessageBox.Show($"Xoá dữ liệu hoá đơn sản phẩm {ChiTietHoaDon.TenSanPham} thành công", "Xoá hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Lỗi không xoá được dữ liệu hoá đơn khách hàng với mã sản phẩm " + ChiTietHoaDon.TenSanPham, "Xoá hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvChiTietHoaDon.DataSource = BUS_ChiTietHoaDon.QueryData("data", TenKhachHang);
                dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
            }
        }
    }
}
