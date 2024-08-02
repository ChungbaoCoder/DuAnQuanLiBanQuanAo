using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;
using System.Data;

namespace QuanLiShopQuanAo
{
    public partial class frmKhachHang : Form
    {
        private bool clickthem = false;
        private bool clicksua = false;
        private bool clickdgv = false;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HideControl();
            SetColumns();
            dgvKhachHang.DataSource = BUS_KhachHang.QueryData("data");
        }

        private void SetColumns()
        {
            var columnsName = BUS_KhachHang.QueryData("data").Columns.
                Cast<DataColumn>().Select(columns => columns.ColumnName).ToArray();

            for (int i = 0; i < columnsName.Length; i++)
                dgvKhachHang.Columns[i + 1].DataPropertyName = columnsName[i];
        }

        private void HideControl()
        {
            foreach (Control control in grpThemKhachHang.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(Button) || control.GetType() == typeof(RadioButton) || control.GetType() == typeof(ComboBox))
                    control.Enabled = false;
            }
            foreach (Control control in grpSuaKhachHang.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(Button) || control.GetType() == typeof(RadioButton) || control.GetType() == typeof(ComboBox))
                    control.Enabled = false;
            }
        }

        private void EnableThemControl()
        {
            foreach (Control control in grpThemKhachHang.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(Button) || control.GetType() == typeof(RadioButton) || control.GetType() == typeof(ComboBox))
                    control.Enabled = true;
            }
        }

        private void EnableSuaControl()
        {
            foreach (Control control in grpSuaKhachHang.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(Button) || control.GetType() == typeof(RadioButton) || control.GetType() == typeof(ComboBox))
                    control.Enabled = true;
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

        private bool CheckTextBoxEmpty(int number)
        {
            switch (number)
            {
                case 0:
                    foreach (TextBox textBox in grpThemKhachHang.Controls.OfType<TextBox>())
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
                    foreach (TextBox textBox in grpSuaKhachHang.Controls.OfType<TextBox>())
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

        private bool CheckIsNumber(int number)
        {
            switch (number)
            {
                case 0:
                    if (!int.TryParse(txtThemSDTKhachHang.Text, out _))
                        return true;
                    break;
                case 1:
                    if (!int.TryParse(txtSuaSDTKhachHang.Text, out _))
                        return true;
                    break;
            }
            return false;
        }

        private void btnChonTatCa_Click(object sender, EventArgs e)
        {
            if (clickdgv)
            {
                foreach (DataGridViewRow row in dgvKhachHang.Rows)
                {
                    if (row.Cells[0] is DataGridViewButtonCell button)
                        dgvKhachHang.EndEdit();

                    row.Cells[0].Value = ((Button)sender).Enabled = false;
                    btnChonTatCa.Enabled = true;
                }
                clickdgv = false;
            }
            else
            {
                foreach (DataGridViewRow row in dgvKhachHang.Rows)
                {
                    if (row.Cells[0] is DataGridViewButtonCell button)
                        dgvKhachHang.EndEdit();

                    row.Cells[0].Value = ((Button)sender).Enabled = true;
                }
                clickdgv = true;
            }
        }

        private void btnTaiLaiDanhSach_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = BUS_KhachHang.QueryData("data");
        }

        private void btnTimKhachHang_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = BUS_KhachHang.QueryData("search", txtTimKiemKhachHang.Text);
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            if (!clickthem)
            {
                if (clicksua)
                {
                    HideControl();
                    clicksua = false;
                }
                EnableThemControl();
                clickthem = true;
            }
            else
            {
                HideControl();
                clickthem = false;
            }
        }

        private void btnSuaKhach_Click(object sender, EventArgs e)
        {
            if (!clicksua)
            {
                if (clickthem)
                {
                    HideControl();
                    clickthem = false;
                }
                EnableSuaControl();
                clicksua = true;
            }
            else
            {
                HideControl();
                clicksua = false;
            }
        }

        private void btnClearThemKhachHang_Click(object sender, EventArgs e)
        {
            ClearTextValue();
        }

        private void btnClearSuaKhachHang_Click(object sender, EventArgs e)
        {
            ClearTextValue();
        }

        private void btnLuuThemKhachHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu thông tin khách hàng " + txtThemTenKhachHang.Text, "Lưu thông tin khách hàng?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckTextBoxEmpty(0))
                    return;

                if (CheckIsNumber(0))
                    return;

                KhachHang KhachHang = new KhachHang()
                {
                    TenKhachHang = txtThemTenKhachHang.Text,
                    SDT = txtThemSDTKhachHang.Text,
                    DiaChi = txtThemDiaChiKhachHang.Text,
                };
                if (BUS_KhachHang.QueryData(KhachHang, "insert"))
                    MessageBox.Show($"Thêm thông tin khách hàng {KhachHang.TenKhachHang} thành công", "Thêm thông tin khách hàng",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không cập nhật được thông tin khách hàng có tên " + KhachHang.TenKhachHang, "Lỗi thêm thông tin khách hàng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                HideControl();
                dgvKhachHang.DataSource = BUS_KhachHang.QueryData("data");
            }
        }

        private void btnLuuSuaKhachHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin khách hàng " + txtSuaTenKhachHang.Text, "Sửa thông tin khách hàng?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckTextBoxEmpty(1))
                    return;

                if (CheckIsNumber(1))
                    return;

                KhachHang KhachHang = new KhachHang()
                {
                    MaKhachHang = txtSuaMaKhachHang.Text,
                    TenKhachHang = txtSuaTenKhachHang.Text,
                    SDT = txtSuaSDTKhachHang.Text,
                    DiaChi = txtSuaDiaChiKhachHang.Text,
                };
                if (BUS_KhachHang.QueryData(KhachHang, "update"))
                    MessageBox.Show($"Cập nhật thông tin khách hàng có mã {KhachHang.MaKhachHang} thành công", "Cập nhật thông tin khách hàng",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không cập nhật được thông tin khách hàng có mã " + KhachHang.MaKhachHang, "Lỗi cập nhật thông tin khách hàng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                HideControl();
                dgvKhachHang.DataSource = BUS_KhachHang.QueryData("data");
            }
        }

        private void btnXoaKhach_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu", "Xoá khách hàng?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool deleted = true;
                List<KhachHang> listKhach = new List<KhachHang>();
                foreach (DataGridViewRow row in dgvKhachHang.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                        listKhach.Add(new KhachHang
                        {
                            MaKhachHang = row.Cells[1].Value.ToString(),
                            SDT = row.Cells[3].Value.ToString()
                        });
                }

                foreach (KhachHang Khach in listKhach)
                {
                    if (!BUS_KhachHang.QueryData(Khach, "delete"))
                    {
                        MessageBox.Show("Lỗi không xoá được dữ liệu khách hàng với mã số " + Khach.MaKhachHang, "Lỗi xoá dữ liệu",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        deleted = false;
                    }
                }
                
                if (deleted)
                    MessageBox.Show("Xoá dữ liệu khách hàng thành công", "Cập nhật thành công", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                HideControl();
                dgvKhachHang.DataSource = BUS_KhachHang.QueryData("data");
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvKhachHang.SelectedCells[0].RowIndex;
            DataGridViewRow data = dgvKhachHang.Rows[row];
            txtSuaMaKhachHang.Text = data.Cells[1].Value.ToString();
            txtSuaTenKhachHang.Text = data.Cells[2].Value.ToString();
            txtSuaSDTKhachHang.Text = data.Cells[3].Value.ToString();
            txtSuaDiaChiKhachHang.Text = data.Cells[4].Value.ToString();
        }
    }
}
