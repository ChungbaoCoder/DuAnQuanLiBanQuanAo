using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;
using System.Data;

namespace QuanLiShopQuanAo
{
    public partial class frmChiTietHoaDon : Form
    {
        private bool clickdgv = false;
        public string MaHoaDon = string.Empty;
        public string MaKhachHang = string.Empty;
        public string TenKhachHang = string.Empty;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            SetColumns();
            lblTenKhachHang.Text += " " + TenKhachHang;
            dgvChiTietHoaDon.DataSource = BUS_ChiTietHoaDon.QueryData("data", MaHoaDon);
            dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
        }

        private void SetColumns()
        {
            var columnsName = BUS_ChiTietHoaDon.QueryData("data", MaHoaDon).Columns.
                Cast<DataColumn>().Select(columns => columns.ColumnName).ToArray();

            for (int i = 0; i < columnsName.Length; i++)
                dgvChiTietHoaDon.Columns[i + 1].DataPropertyName = columnsName[i];

            DataTable dt = BUS_SanPham.QueryData("data");
            columnsName = dt.Columns.Cast<DataColumn>().Select(columns => columns.ColumnName).ToArray();

            for (int i = 0; i < columnsName.Length; i++)
                dgvSanPham.Columns[i + 1].DataPropertyName = columnsName[i];
        }

        private void btnChonTatCa_Click(object sender, EventArgs e)
        {
            if (clickdgv)
            {
                foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
                {
                    if (row.Cells[0] is DataGridViewButtonCell button)
                        dgvChiTietHoaDon.EndEdit();

                    row.Cells[0].Value = ((Button)sender).Enabled = false;
                    btnChonTatCa.Enabled = true;
                }
                clickdgv = false;
            }
            else
            {
                foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
                {
                    if (row.Cells[0] is DataGridViewButtonCell button)
                        dgvChiTietHoaDon.EndEdit();

                    row.Cells[0].Value = ((Button)sender).Enabled = true;
                }
                clickdgv = true;
            }
        }

        private void btnTaiLaiDanhSach_Click(object sender, EventArgs e)
        {
            dgvChiTietHoaDon.DataSource = BUS_ChiTietHoaDon.QueryData("data", MaHoaDon);
            dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
        }

        private void btnNgungLapHoaDon_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon
                {
                    MaHoaDon = MaHoaDon,
                    MaSanPham = row.Cells[2].Value.ToString(),
                    SoLuong = Convert.ToInt32(row.Cells[4].Value.ToString())
                };
                if (MessageBox.Show("Bạn có muốn ngừng tạo hoá đơn và gỡ hết dữ liệu?", "Ngừng lập hoá đơn",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (BUS_ChiTietHoaDon.QueryData(chiTietHoaDon, "stop"))
                        MessageBox.Show("Ngừng lập hoá đơn thành công về màn hình chính...", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThemVaoHoaDon_Click(object sender, EventArgs e)
        {
            if (nupSoLuong.Value < 1)
            {
                MessageBox.Show("Số lượng thêm vào phải lớn hơn hoặc bằng 1", "Số lượng sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<SanPham> listSanPham = new List<SanPham>();
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true && row.Cells[8].Value.ToString() != "Chưa Bán" && Convert.ToInt32(row.Cells[5].Value.ToString()) > 0)
                {
                    listSanPham.Add(new SanPham
                    {
                        MaSanPham = row.Cells[1].Value.ToString(),
                        SoLuong = Convert.ToInt32(nupSoLuong.Value),
                        Gia = int.Parse(row.Cells[5].Value.ToString())
                    });
                }
            }
            nupSoLuong.Value = 0;

            foreach (SanPham SanPham in listSanPham)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon()
                {
                    MaHoaDon = MaHoaDon,
                    MaKhachHang = MaKhachHang,
                    MaSanPham = SanPham.MaSanPham,
                    SoLuong = SanPham.SoLuong,
                };
                if (!BUS_ChiTietHoaDon.QueryData(chiTietHoaDon, "insert"))
                    MessageBox.Show($"Lỗi thêm sản phẩm với mã {SanPham.MaSanPham} vào hoá đơn có mã {MaHoaDon} của khách hàng {TenKhachHang}", "Thêm sản phẩm vào hoá đơn",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show($"Thêm thành công sản phẩm vào hoá đơn có mã {MaHoaDon} của khách hàng {TenKhachHang}", "Thêm sản phẩm vào hoá đơn",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvChiTietHoaDon.DataSource = BUS_ChiTietHoaDon.QueryData("data", MaHoaDon);
            dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
        }

        private void btnHoanThanhHD_Click(object sender, EventArgs e)
        {
            bool success = true;
            List<ChiTietHoaDon> chiTietHoaDon = new List<ChiTietHoaDon>();
            foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
            {
                chiTietHoaDon.Add(new ChiTietHoaDon
                {
                    MaHoaDon = MaHoaDon,
                    MaKhachHang = MaKhachHang,
                    TongThanhTien = float.Parse(row.Cells[6].Value.ToString())
                });      
            }

            foreach (ChiTietHoaDon hoaDon in chiTietHoaDon)
            {
                if (!BUS_ChiTietHoaDon.QueryData(hoaDon, "update"))
                {
                    MessageBox.Show($"Lỗi cập nhật sản phẩm {hoaDon.MaSanPham} vào hoá đơn có mã {MaHoaDon}", "Lưu hoá đơn",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    success = false;
                }
            }    
            
            if (success)
            {
                MessageBox.Show($"Lập hoá đơn có mã {MaHoaDon} thành công", "Lập hoá đơn thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
                        listChiTietHoaDon.Add(new ChiTietHoaDon
                        {
                            MaHoaDon = MaHoaDon,
                            MaSanPham = row.Cells[2].Value.ToString(),
                            SoLuong = Convert.ToInt32(row.Cells[4].Value.ToString())
                        });
                }

                foreach (ChiTietHoaDon ChiTietHoaDon in listChiTietHoaDon)
                {
                    if (!BUS_ChiTietHoaDon.QueryData(ChiTietHoaDon, "delete"))
                        MessageBox.Show($"Lỗi không xoá được dữ liệu hoá đơn của khách hàng {TenKhachHang} với sản phẩm có mã {ChiTietHoaDon.MaSanPham}" + ChiTietHoaDon.TenSanPham, "Xoá sản phẩm khỏi hoá đơn", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Xoá dữ liệu sản phẩm khỏi hoá đơn thành công", "Xoá sản phẩm khỏi hoá đơn", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvChiTietHoaDon.DataSource = BUS_ChiTietHoaDon.QueryData("data", MaHoaDon);
                dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvSanPham.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvSanPham.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[8].Value.ToString());

                try
                {
                    Bitmap bitmap = new Bitmap(cellValue);
                    picAnhSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                    picAnhSanPham.Image = Image.FromFile(cellValue);
                    bitmap.Dispose();
                }
                catch 
                {
                    picAnhSanPham.Image = null;
                }
            }
        }
    }
}
