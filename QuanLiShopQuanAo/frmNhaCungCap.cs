using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;
using System.Data;

namespace QuanLiShopQuanAo
{
    public partial class frmNhaCungCap : Form
    {
        private bool clickthem = false;
        private bool clicksua = false;
        private bool clickdgv = false;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            HideControl();
            SetColumns();
            dgvNhaCungCap.DataSource = BUS_NhaCungCap.QueryData("data");
        }

        private void SetColumns()
        {
            var columnsName = BUS_NhaCungCap.QueryData("data").Columns.
                Cast<DataColumn>().Select(columns => columns.ColumnName).ToArray();

            for (int i = 0; i < columnsName.Length; i++)
                dgvNhaCungCap.Columns[i + 1].DataPropertyName = columnsName[i];
        }

        private void HideControl()
        {
            foreach (Control control in grpThemNhaCungCap.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(Button) || control.GetType() == typeof(RadioButton) || control.GetType() == typeof(ComboBox))
                    control.Enabled = false;
            }
            foreach (Control control in grpSuaNhaCungCap.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(Button) || control.GetType() == typeof(RadioButton) || control.GetType() == typeof(ComboBox))
                    control.Enabled = false;
            }
        }

        private void EnableThemControl()
        {
            foreach (Control control in grpThemNhaCungCap.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(Button) || control.GetType() == typeof(RadioButton) || control.GetType() == typeof(ComboBox))
                    control.Enabled = true;
            }
        }

        private void EnableSuaControl()
        {
            foreach (Control control in grpSuaNhaCungCap.Controls)
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
                    foreach (TextBox textBox in grpThemNhaCungCap.Controls.OfType<TextBox>())
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
                    foreach (TextBox textBox in grpSuaNhaCungCap.Controls.OfType<TextBox>())
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
                foreach (DataGridViewRow row in dgvNhaCungCap.Rows)
                {
                    if (row.Cells[0] is DataGridViewButtonCell button)
                        dgvNhaCungCap.EndEdit();

                    row.Cells[0].Value = ((Button)sender).Enabled = false;
                    btnChonTatCa.Enabled = true;
                }
                clickdgv = false;
            }
            else
            {
                foreach (DataGridViewRow row in dgvNhaCungCap.Rows)
                {
                    if (row.Cells[0] is DataGridViewButtonCell button)
                        dgvNhaCungCap.EndEdit();

                    row.Cells[0].Value = ((Button)sender).Enabled = true;
                }
                clickdgv = true;
            }
        }

        private void btnTaiLaiDanhSach_Click(object sender, EventArgs e)
        {
            dgvNhaCungCap.DataSource = BUS_NhaCungCap.QueryData("data");
        }

        private void btnTimNhaCungCap_Click(object sender, EventArgs e)
        {
            dgvNhaCungCap.DataSource = BUS_NhaCungCap.QueryData("search", txtTimKiemNhaCungCap.Text);
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
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

        private void btnSuaNhaCungCap_Click(object sender, EventArgs e)
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

        private void btnClearThemNhaCungCap_Click(object sender, EventArgs e)
        {
            ClearTextValue();
        }

        private void btnClearSuaNhaCungCap_Click(object sender, EventArgs e)
        {
            ClearTextValue();
        }

        private void btnLuuThemNhaCungCap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu thông tin nhà cung cấp", "Lưu thông tin nhà cung cấp?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckTextBoxEmpty(0))
                    return;

                NhaCungCap NhaCungCap = new NhaCungCap()
                {
                    TenNhaCungCap = txtThemTenNhaCungCap.Text,
                    SDT = txtThemSDTNhaCungCap.Text,
                    DiaChi = txtThemDiaChiNhaCungCap.Text,
                };
                if (BUS_NhaCungCap.QueryData(NhaCungCap, "insert"))
                    MessageBox.Show($"Thêm thông tin nhà cung cấp {NhaCungCap.TenNhaCungCap} thành công", "Thêm thông tin nhà cung cấp",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không cập nhật được thông tin nhà cung cấp có tên " + NhaCungCap.TenNhaCungCap, "Lỗi thêm thông tin nhà cung cấp",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                HideControl();
                ClearTextValue();
                dgvNhaCungCap.DataSource = BUS_NhaCungCap.QueryData("data");
            }
        }

        private void btnLuuSuaNhaCungCap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin nhà cung cấp", "Sửa thông tin nhà cung cấp?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckTextBoxEmpty(1))
                    return;

                NhaCungCap NhaCungCap = new NhaCungCap()
                {
                    MaNhaCungCap = txtSuaMaNhaCungCap.Text,
                    TenNhaCungCap = txtSuaTenNhaCungCap.Text,
                    SDT = txtSuaSDTNhaCungCap.Text,
                    DiaChi = txtSuaDiaChiNhaCungCap.Text,
                };
                if (BUS_NhaCungCap.QueryData(NhaCungCap, "update"))
                    MessageBox.Show($"Cập nhật thông tin mã nhà cung cấp {NhaCungCap.MaNhaCungCap} thành công", "Cập nhật thông tin nhà cung cấp",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không cập nhật được thông tin nhà cung cấp có mã " + NhaCungCap.MaNhaCungCap, "Lỗi cập nhật thông tin nhà cung cấp",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                HideControl();
                ClearTextValue();
                dgvNhaCungCap.DataSource = BUS_NhaCungCap.QueryData("data");
            }
        }

        private void btnXoaNhaCungCap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu", "Xoá nhà cung cấp?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool deleted = true;
                List<NhaCungCap> listNhaCungCap = new List<NhaCungCap>();
                foreach (DataGridViewRow row in dgvNhaCungCap.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                        listNhaCungCap.Add(new NhaCungCap
                        {
                            MaNhaCungCap = row.Cells[1].Value.ToString(),
                            SDT = row.Cells[3].Value.ToString()
                        });
                }

                foreach (NhaCungCap NhaCungCap in listNhaCungCap)
                {
                    if (!BUS_NhaCungCap.QueryData(NhaCungCap, "delete"))
                    {
                        MessageBox.Show("Lỗi không xoá được dữ liệu nhà cung cấp với mã số " + NhaCungCap.MaNhaCungCap, "Lỗi xoá dữ liệu",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        deleted = false;
                    }    
                }

                if (deleted)
                    MessageBox.Show("Xoá dữ liệu nhà cung cấp thành công", "Cập nhật thành công", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                HideControl();
                dgvNhaCungCap.DataSource = BUS_NhaCungCap.QueryData("data");
            }
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvNhaCungCap.SelectedCells[0].RowIndex;
            DataGridViewRow data = dgvNhaCungCap.Rows[row];
            txtSuaMaNhaCungCap.Text = data.Cells[1].Value.ToString();
            txtSuaTenNhaCungCap.Text = data.Cells[2].Value.ToString();
            txtSuaDiaChiNhaCungCap.Text = data.Cells[4].Value.ToString();
            txtSuaSDTNhaCungCap.Text = data.Cells[3].Value.ToString();
        }
    }
}
