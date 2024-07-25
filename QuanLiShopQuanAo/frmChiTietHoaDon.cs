using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;
using System.Data;

namespace QuanLiShopQuanAo
{
    public partial class frmChiTietHoaDon : Form
    {
        public bool closed = false;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            HideTextControl();
            HideButtonControl();
            SetColumns();
            dgvHoaDon.DataSource = BUS_HoaDon.QueryData("data");
        }

        private void SetColumns()
        {
            var columnsName = BUS_HoaDon.QueryData("data").Columns.
                Cast<DataColumn>().Select(columns => columns.ColumnName).ToArray();

            for (int i = 0; i < columnsName.Length; i++)
                dgvHoaDon.Columns[i + 1].DataPropertyName = columnsName[i];
        }

        private void HideTextControl()
        {
            foreach (Control gb in this.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control tb in gb.Controls)
                    {
                        if (tb is TextBox)
                            ((TextBox)tb).ReadOnly = true;
                    }
                }
            }
        }

        private void HideButtonControl()
        {
            foreach (Control gb in this.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control tb in gb.Controls)
                    {
                        if (tb is Button)
                            ((Button)tb).Enabled = false;
                    }
                }
            }
        }

        private void ClearTextValue()
        {
            foreach (Control gb in this.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control tb in gb.Controls)
                        ((TextBox)tb).Text = string.Empty;
                }
            }
        }

        private void btnChonTatCa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.Cells[0] is DataGridViewButtonCell button)
                    dgvHoaDon.EndEdit();

                row.Cells[0].Value = ((Button)sender).Enabled;
            }
        }

        private void btnTaiLaiDanhSach_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
            dgvHoaDon.DataSource = BUS_HoaDon.QueryData("data");
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu", "Xoá hoá đơn?",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<HoaDon> listHoaDon = new List<HoaDon>();

                foreach (DataGridViewRow row in dgvHoaDon.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                        listHoaDon.Add(new HoaDon { MaSanPham = row.Cells[2].Value.ToString() });
                }

                foreach (HoaDon HoaDon in listHoaDon)
                {
                    if (BUS_HoaDon.QueryData(HoaDon, "delete"))
                        MessageBox.Show($"Xoá dữ liệu hoá đơn sản phẩm {HoaDon.MaSanPham} thành công");
                    else
                        MessageBox.Show("Lỗi không xoá được dữ liệu hoá đơn khách hàng với mã sản phẩm " + HoaDon.MaKhachHang);
                }
                HideTextControl();
                HideButtonControl();
                dgvHoaDon.DataSource = BUS_KhachHang.QueryData("data");
            }    
        }
        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            List<SanPham> listSanPham = new List<SanPham>();

            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    listSanPham.Add(new SanPham { 
                        MaSanPham = row.Cells[1].Value.ToString(),
                        TenSanPham = row.Cells[2].Value.ToString(),
                        LoaiSanPham = row.Cells[3].Value.ToString(),
                        Gia = int.Parse(row.Cells[4].Value.ToString())
                    });
            }

            foreach (SanPham SanPham in  listSanPham)
            {
                if (!BUS_SanPham.QueryData(SanPham, "insert"))
                    MessageBox.Show("Lỗi thêm sản phẩm với mã " + SanPham.MaSanPham);
            }
        }

        private void btnHoanThanhHD_Click(object sender, EventArgs e)
        {
            List<HoaDon> listHoaDon = new List<HoaDon>();

            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                listHoaDon.Add(new HoaDon
                {
                    MaHoaDon = row.Cells[1].Value.ToString(),
                    MaSanPham = row.Cells[2].Value.ToString(),
                    MaKhachHang = lblTenKhachHang.Text,
                    TenSanPham = row.Cells[3].Value.ToString(),
                    SoLuong = int.Parse(row.Cells[4].Value.ToString()),
                    TongTien = float.Parse(row.Cells[6].Value.ToString())
                });
            }

            foreach (HoaDon HoaDon in listHoaDon)
            {
                if (BUS_HoaDon.QueryData(HoaDon, "insert"))
                    MessageBox.Show("Thêm thông tin hoá đơn của khách hàng thành công");
                else
                    MessageBox.Show("Không cập nhật được thông tin hoá đơn khách hàng có mã " + HoaDon.MaHoaDon);

            }
        }

        private void tsmiNhaCungCap_Click(object sender, EventArgs e)
        {
            closed = true;
            this.Close();
        }

        private void tsmiSanPham_Click(object sender, EventArgs e)
        {
            closed = true;
            this.Close();
        }

        private void tsmiKho_Click(object sender, EventArgs e)
        {
            closed = true;
            this.Close();
        }

        private void tsmiHoaDon_Click(object sender, EventArgs e)
        {
            closed = true;
            this.Close();
        }

        private void tsmiNhanVien_Click(object sender, EventArgs e)
        {
            closed = true;
            this.Close();
        }
    }
}
