using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;
using System.Data;

namespace QuanLiShopQuanAo
{
    public partial class frmHoaDon : Form
    {
        public string maNhanVien = string.Empty;
        public frmMainMenu form;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
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

        private bool CheckTextBoxEmpty(int number)
        {
            switch (number)
            {
                case 0:
                    foreach (TextBox textBox in grpTaoHoaDon.Controls.OfType<TextBox>())
                    {
                        if (string.IsNullOrEmpty(textBox.Text))
                            return true;
                    }
                    break;
                case 1:
                    foreach (TextBox textBox in grpSuaHoaDon.Controls.OfType<TextBox>())
                    {
                        if (string.IsNullOrEmpty(textBox.Text))
                            return true;
                    }
                    break;
            }
            return false;
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
            dgvHoaDon.DataSource = BUS_HoaDon.QueryData("data");
        }

        private void btnTimHoaDon_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = BUS_HoaDon.QueryData("search", txtTimKiemHoaDon.Text);
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu thông tin hoá đơn", "Lưu thông tin hoá đơn?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckTextBoxEmpty(0))
                {
                    MessageBox.Show("Điền đầy đủ thông tin vào", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                HoaDon HoaDon = new HoaDon()
                {
                    TenKhachHang = txtTenKhachMua.Text,
                    SDTKhach = txtSDTKhachMua.Text,
                    NgayTao = dtpLapHoaDon.Value.ToString("dd-MM-yyyy"),
                    MaNhanVienGhi = maNhanVien
                };
                if (BUS_HoaDon.QueryData(HoaDon, "insert"))
                {
                    MessageBox.Show("Thêm thông tin hoá đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.Openchildform(new frmChiTietHoaDon { TenKhachHang = txtTenKhachMua.Text });
                }
                else
                    MessageBox.Show("Không cập nhật được thông tin hoá đơn có tên khách " + HoaDon.TenKhachHang, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                dgvHoaDon.DataSource = BUS_HoaDon.QueryData("data");
            }
        }

        private void btnSuaHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin hoá đơn", "Sửa thông tin hoá đơn?",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckTextBoxEmpty(1))
                {
                    MessageBox.Show("Điền đầy đủ thông tin vào", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                HoaDon HoaDon = new HoaDon()
                {
                    MaHoaDon = txtSuaMaHoaDon.Text,
                    TenKhachHang = txtSuaTenKhach.Text,
                    NgayTao = dtpSuaNgayLap.Text
                };
                if (BUS_HoaDon.QueryData(HoaDon, "update"))
                    MessageBox.Show("Cập nhật thông tin khách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không cập nhật được thông tin hoá đơn có mã " + HoaDon.MaHoaDon,"Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);

                dgvHoaDon.DataSource = BUS_HoaDon.QueryData("data");
            }
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu", "Xoá hoá đơn?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<HoaDon> listHoaDon = new List<HoaDon>();

                foreach (DataGridViewRow row in dgvHoaDon.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                        listHoaDon.Add(new HoaDon
                        {
                            MaHoaDon = row.Cells[1].Value.ToString()
                        });
                }

                foreach (HoaDon HoaDon in listHoaDon)
                {
                    if (BUS_HoaDon.QueryData(HoaDon, "delete"))
                        MessageBox.Show("Lỗi không xoá được dữ liệu hoá đơn với mã số " + HoaDon.MaHoaDon,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                MessageBox.Show("Xoá dữ liệu hoá đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvHoaDon.DataSource = BUS_HoaDon.QueryData("data");
            }
        }  
    }
}
