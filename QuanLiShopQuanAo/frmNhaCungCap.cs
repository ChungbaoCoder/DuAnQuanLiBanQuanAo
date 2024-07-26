using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;
using System.Data;

namespace QuanLiShopQuanAo
{
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            HideTextControl();
            HideButtonControl();
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
            foreach (DataGridViewRow row in dgvNhaCungCap.Rows)
            {
                if (row.Cells[0] is DataGridViewButtonCell button)
                    dgvNhaCungCap.EndEdit();

                row.Cells[0].Value = ((Button)sender).Enabled;
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
            foreach (Control c in grpThemNhaCungCap.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).ReadOnly = false;
                if (c is Button)
                    ((Button)c).Enabled = true;
            }
        }

        private void btnSuaNhaCungCap_Click(object sender, EventArgs e)
        {
            foreach (Control c in grpSuaNhaCungCap.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).ReadOnly = false;
                if (c is Button)
                    ((Button)c).Enabled = true;
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
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhaCungCap NhaCungCap = new NhaCungCap()
                {
                    TenNhaCungCap = txtThemTenNhaCungCap.Text,
                    SDT = txtThemSDTNhaCungCap.Text,
                    DiaChi = txtThemDiaChiNhaCungCap.Text,
                };
                if (BUS_NhaCungCap.QueryData(NhaCungCap, "insert"))
                    MessageBox.Show("Thêm thông tin nhà cung cấp thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không cập nhật được thông tin nhà cung cấp có tên " + NhaCungCap.TenNhaCungCap,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                HideTextControl();
                HideButtonControl();
                dgvNhaCungCap.DataSource = BUS_NhaCungCap.QueryData("data");
            }
        }

        private void btnLuuSuaNhaCungCap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin nhà cung cấp", "Sửa thông tin nhà cung cấp?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhaCungCap NhaCungCap = new NhaCungCap()
                {
                    MaNhaCungCap = txtSuaMaNhaCungCap.Text,
                    TenNhaCungCap = txtSuaTenNhaCungCap.Text,
                    SDT = txtSuaSDTNhaCungCap.Text,
                    DiaChi = txtSuaDiaChiNhaCungCap.Text,
                };
                if (BUS_NhaCungCap.QueryData(NhaCungCap, "update"))
                    MessageBox.Show("Cập nhật thông tin nhà cung cấp thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không cập nhật được thông tin nhà cung cấp có mã " + NhaCungCap.MaNhaCungCap, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                HideTextControl();
                HideButtonControl();
                dgvNhaCungCap.DataSource = BUS_NhaCungCap.QueryData("data");
            }
        }

        private void btnXoaNhaCungCap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu", "Xoá nhà cung cấp?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<NhaCungCap> listNhaCungCap = new List<NhaCungCap>();

                foreach (DataGridViewRow row in dgvNhaCungCap.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                        listNhaCungCap.Add(new NhaCungCap
                        {
                            MaNhaCungCap = row.Cells[1].ToString(),
                            SDT = row.Cells[3].ToString()
                        });
                }

                foreach (NhaCungCap NhaCungCap in listNhaCungCap)
                {
                    if (BUS_NhaCungCap.QueryData(NhaCungCap, "delete"))
                        MessageBox.Show("Xoá dữ liệu nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Lỗi không xoá được dữ liệu nhà cung cấp với mã số " + NhaCungCap.MaNhaCungCap, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                HideTextControl();
                HideButtonControl();
                dgvNhaCungCap.DataSource = BUS_NhaCungCap.QueryData("data");
            }
        }

    }
}
