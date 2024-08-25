using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;
using System.Data;

namespace QuanLiShopQuanAo
{
    public partial class frmHoaDon : Form
    {
        private bool clickthem = false;
        private bool clicksua = false;
        private bool clickdgv = false;
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

        private void ClearTextValue()
        {
            foreach (Control gb in this.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control tb in gb.Controls)
                        if (tb is TextBox)
                            tb.Text = string.Empty;
                }
            }
        }

        private bool CheckTextBoxEmpty(int number)
        {
            switch (number)
            {
                case 0:
                    foreach (TextBox textBox in grpTaoHoaDon.Controls.OfType<TextBox>())
                    {
                        if (string.IsNullOrEmpty(textBox.Text))
                        {
                            MessageBox.Show("Điền đầy đủ thông tin vào", "Thông Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return true;
                        }
                    }
                    break;
                case 1:
                    foreach (TextBox textBox in grpSuaHoaDon.Controls.OfType<TextBox>())
                    {
                        if (string.IsNullOrEmpty(textBox.Text))
                        {
                            MessageBox.Show("Điền đầy đủ thông tin vào", "Thông Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return true;
                        }
                    }
                    break;
            }
            return false;
        }

        private void btnChonTatCa_Click(object sender, EventArgs e)
        {
            if (clickdgv)
            {
                foreach (DataGridViewRow row in dgvHoaDon.Rows)
                {
                    if (row.Cells[0] is DataGridViewButtonCell button)
                        dgvHoaDon.EndEdit();

                    row.Cells[0].Value = ((Button)sender).Enabled = false;
                    btnChonTatCa.Enabled = true;
                }
                clickdgv = false;
            }
            else
            {
                foreach (DataGridViewRow row in dgvHoaDon.Rows)
                {
                    if (row.Cells[0] is DataGridViewButtonCell button)
                        dgvHoaDon.EndEdit();

                    row.Cells[0].Value = ((Button)sender).Enabled = true;
                }
                clickdgv = true;
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
            if (MessageBox.Show("Bạn có muốn lập hoá đơn", "Lập hoá đơn mới?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckTextBoxEmpty(0))
                    return;

                bool create = false;
                HoaDon HoaDon = new HoaDon()
                {
                    TenKhachHang = txtTenKhachMua.Text,
                    SDTKhach = txtSDTKhachMua.Text,
                    NgayTao = dtpLapHoaDon.Value.ToString("MM/dd/yyyy"),
                    MaNhanVienGhi = maNhanVien
                };
                if (BUS_HoaDon.QueryData(HoaDon, "insert"))
                {
                    MessageBox.Show("Thêm thông tin hoá đơn thành công", "Lập hoá đơn mới",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    create = true;
                }
                else
                    MessageBox.Show("Không lập được hoá đơn mới có tên khách " + HoaDon.TenKhachHang, "Lỗi lập hoá đơn mới",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                dgvHoaDon.DataSource = BUS_HoaDon.QueryData("data");

                if (create)
                {
                    string? maHoaDon = dgvHoaDon.Rows[dgvHoaDon.Rows.Count - 1].Cells[1].Value.ToString();
                    string? maKhachHang = dgvHoaDon.Rows[dgvHoaDon.Rows.Count - 1].Cells[2].Value.ToString();
                    form.Openchildform(new frmChiTietHoaDon
                    {
                        MaHoaDon = maHoaDon,
                        MaKhachHang = maKhachHang,
                        TenKhachHang = txtTenKhachMua.Text,
                    });
                }

                ClearTextValue();
            }
        }

        private void btnSuaHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin hoá đơn " + txtSuaMaHoaDon.Text, "Sửa thông tin hoá đơn?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckTextBoxEmpty(1))
                    return;

                HoaDon HoaDon = new HoaDon()
                {
                    MaHoaDon = txtSuaMaHoaDon.Text,
                    MaKhachHang = txtSuaMaKhachHang.Text,
                    TenKhachHang = txtSuaTenKhach.Text,
                    NgayTao = dtpSuaNgayLap.Text,
                    TrangThai = cmbTrangThai.Text
                };
                if (BUS_HoaDon.QueryData(HoaDon, "update"))
                    MessageBox.Show($"Cập nhật thông tin hoá đơn có mã {HoaDon.MaHoaDon} của khách hàng {HoaDon.TenKhachHang} thành công", "Cập nhật thông tin hoá đơn",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không cập nhật được thông tin hoá đơn có mã " + HoaDon.MaHoaDon, "Lỗi cập nhật thông tin hoá đơn",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearTextValue();
                dgvHoaDon.DataSource = BUS_HoaDon.QueryData("data");
            }
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu", "Xoá hoá đơn?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool deleted = true;
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
                    if (!BUS_HoaDon.QueryData(HoaDon, "delete"))
                    {
                        MessageBox.Show("Lỗi không xoá được dữ liệu hoá đơn có mã số " + HoaDon.MaHoaDon, "Lỗi xoá dữ liệu",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        deleted = false;
                    }
                }

                if (deleted)
                    MessageBox.Show("Xoá dữ liệu hoá đơn thành công", "Cập nhật dữ liệu thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvHoaDon.DataSource = BUS_HoaDon.QueryData("data");
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgvHoaDon.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvHoaDon.Rows[selectedrowindex];
            txtSuaMaHoaDon.Text = selectedRow.Cells[1].Value.ToString();
            txtSuaMaKhachHang.Text = selectedRow.Cells[2].Value.ToString();
            txtSuaTenKhach.Text = selectedRow.Cells[3].Value.ToString();
            dtpLapHoaDon.Text = selectedRow.Cells[5].Value.ToString();
            dtpSuaNgayLap.Text = selectedRow.Cells[5].Value.ToString();
            cmbTrangThai.Text = selectedRow.Cells[7].Value.ToString();
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedrow = dgvHoaDon.Rows[e.RowIndex];

                try
                {
                    frmShowChiTiet chiTietHoaDon = new frmShowChiTiet();
                    chiTietHoaDon.MaHoaDon = selectedrow.Cells[1].Value.ToString();
                    chiTietHoaDon.ShowDialog();
                }
                catch { }
            }
        }
    }
}
