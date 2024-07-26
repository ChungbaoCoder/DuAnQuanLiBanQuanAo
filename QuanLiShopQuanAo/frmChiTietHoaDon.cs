using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;
using System.Data;

namespace QuanLiShopQuanAo
{
    public partial class frmChiTietHoaDon : Form
    {
        public bool closed = false;
        string TenKhachHang = string.Empty;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        public frmChiTietHoaDon(string tenKhach)
        {
            this.TenKhachHang = tenKhach;
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            SetColumns();
            dgvChiTietHoaDon.DataSource = BUS_ChiTietHoaDon.QueryData("data", TenKhachHang);
            dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
        }

        private void SetColumns()
        {
            var columnsName = BUS_ChiTietHoaDon.QueryData("data", TenKhachHang).Columns.
                Cast<DataColumn>().Select(columns => columns.ColumnName).ToArray();

            for (int i = 0; i < columnsName.Length; i++)
                dgvChiTietHoaDon.Columns[i + 1].DataPropertyName = columnsName[i];

            dgvSanPham.Columns[1].DataPropertyName = "MaSanPham";
            dgvSanPham.Columns[2].DataPropertyName = "TenSanPham";
            dgvSanPham.Columns[3].DataPropertyName = "LoaiSanPham";
            dgvSanPham.Columns[4].DataPropertyName = "Gia";
            dgvSanPham.Columns[5].DataPropertyName = "HinhAnh";
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
                string cellValue = Convert.ToString(selectedRow.Cells[5].ToString());

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
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    listSanPham.Add(new SanPham
                    {
                        MaSanPham = row.Cells[1].ToString(),
                        SoLuong = Convert.ToInt32(nupSoLuong.Value),
                        Gia = int.Parse(row.Cells[4].ToString())
                    });
            }
            nupSoLuong.Value = 0;

            foreach (SanPham SanPham in listSanPham)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon()
                {
                    MaKhachHang = TenKhachHang,
                    MaSanPham = SanPham.MaSanPham,
                    SoLuong = SanPham.SoLuong,
                    TongThanhTien = SanPham.Gia * SanPham.SoLuong
                };
                if (BUS_ChiTietHoaDon.QueryData(chiTietHoaDon, "insert"))
                    MessageBox.Show("Thêm thành công sản phẩm " + SanPham.MaSanPham, "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Lỗi thêm sản phẩm với mã " + SanPham.MaSanPham, "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoanThanhHD_Click(object sender, EventArgs e)
        {
            List<ChiTietHoaDon> listChiTietHoaDon = new List<ChiTietHoaDon>();

            foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
            {
                listChiTietHoaDon.Add(new ChiTietHoaDon()
                {
                    MaKhachHang = TenKhachHang,
                    TongThanhTien = float.Parse(row.Cells[6].ToString())
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
                        listChiTietHoaDon.Add(new ChiTietHoaDon { MaSanPham = row.Cells[2].ToString() });
                }

                foreach (ChiTietHoaDon ChiTietHoaDon in listChiTietHoaDon)
                {
                    if (BUS_ChiTietHoaDon.QueryData(ChiTietHoaDon, "delete"))
                        MessageBox.Show($"Xoá dữ liệu hoá đơn sản phẩm {ChiTietHoaDon.MaSanPham} thành công", "Xoá hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Lỗi không xoá được dữ liệu hoá đơn khách hàng với mã sản phẩm " + ChiTietHoaDon.MaSanPham, "Xoá hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvChiTietHoaDon.DataSource = BUS_KhachHang.QueryData("data");
            }
        }

        private void frmChiTietHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            closed = false;
            this.Close();
        }
    }
}
