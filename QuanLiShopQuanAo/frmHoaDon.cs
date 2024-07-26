using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;
using System.Data;

namespace QuanLiShopQuanAo
{
    public partial class frmHoaDon : Form
    {
        string MaNhanVien = string.Empty;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        public frmHoaDon(string MaNhanVien)
        {
            this.MaNhanVien = MaNhanVien;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            HideTextControl();
            HideButtonControl();
            SetColumns();
            dgvHoaDon.DataSource = BUS_KhachHang.QueryData("data");
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
            dgvHoaDon.DataSource = BUS_KhachHang.QueryData("data");
        }

        private void btnTimHoaDon_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = BUS_HoaDon.QueryData("search", txtTimKiemHoaDon.Text);
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu thông tin hoá đơn", "Lưu thông tin hoá đơn?",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                HoaDon HoaDon = new HoaDon()
                {
                    TenKhachHang = txtTenKhachMua.Text,
                    SDTKhach = txtSDTKhachMua.Text,
                    NgayTao = dtpLapHoaDon.Value.ToString(),
                    MaNhanVienGhi = MaNhanVien
                };
                if (BUS_HoaDon.QueryData(HoaDon, "insert"))
                {
                    MessageBox.Show("Thêm thông tin hoá đơn thành công");

                    frmChiTietHoaDon chiTietHoaDon = new frmChiTietHoaDon(txtTenKhachMua.Text);
                    this.Hide();
                    chiTietHoaDon.ShowDialog();

                    if (chiTietHoaDon.closed)
                        this.Show();
                }
                else
                    MessageBox.Show("Không cập nhật được thông tin hoá đơn có tên khách " + HoaDon.TenKhachHang);

                HideTextControl();
                HideButtonControl();
                dgvHoaDon.DataSource = BUS_HoaDon.QueryData("data");
            }
        }

        private void btnSuaHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin hoá đơn", "Sửa thông tin hoá đơn?",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                HoaDon HoaDon = new HoaDon()
                {
                    MaHoaDon = txtSuaMaHoaDon.Text,
                    TenKhachHang = txtSuaTenKhach.Text,
                    NgayTao = dtpSuaNgayLap.Text
                };
                if (BUS_HoaDon.QueryData(HoaDon, "update"))
                    MessageBox.Show("Cập nhật thông tin khách thành công");
                else
                    MessageBox.Show("Không cập nhật được thông tin hoá đơn có mã " + HoaDon.MaHoaDon);

                HideTextControl();
                HideButtonControl();
                dgvHoaDon.DataSource = BUS_HoaDon.QueryData("data");
            }
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
                        listHoaDon.Add(new HoaDon
                        {
                            MaHoaDon = row.Cells[1].ToString()
                        });
                }

                foreach (HoaDon HoaDon in listHoaDon)
                {
                    if (BUS_HoaDon.QueryData(HoaDon, "delete"))
                        MessageBox.Show("Xoá dữ liệu hoá đơn thành công");
                    else
                        MessageBox.Show("Lỗi không xoá được dữ liệu hoá đơn với mã số " + HoaDon.MaHoaDon);
                }
                HideTextControl();
                HideButtonControl();
                dgvHoaDon.DataSource = BUS_HoaDon.QueryData("data");
            }
        }  
    }
}
