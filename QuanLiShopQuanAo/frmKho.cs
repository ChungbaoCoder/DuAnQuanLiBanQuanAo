using System.Data;
using System.Diagnostics;
using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;

namespace QuanLiShopQuanAo
{
    public partial class frmKho : Form
    {
        private bool clickthem = false;
        private bool clicksua = false;
        private bool clickdgv = false;
        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            HideControl();
            SetColumns();
            rdoThemChuaBan.Checked = true;
            rdoSuaChuaBan.Checked = true;
            dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
            LoadComboBox();
        }

        private void SetColumns()
        {
            var columnsName = BUS_SanPham.QueryData("data").Columns.
                Cast<DataColumn>().Select(columns => columns.ColumnName).ToArray();

            for (int i = 0; i < columnsName.Length; i++)
                dgvSanPham.Columns[i + 1].DataPropertyName = columnsName[i];
        }

        private void HideControl()
        {
            foreach (Control control in grpThemSanPham.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(Button) || control.GetType() == typeof(RadioButton) || control.GetType() == typeof(ComboBox))
                    control.Enabled = false;
            }
            foreach (Control control in grpSuaSanPham.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(Button) || control.GetType() == typeof(RadioButton) || control.GetType() == typeof(ComboBox))
                    control.Enabled = false;
            }
        }

        private void EnableThemControl()
        {
            foreach (Control control in grpThemSanPham.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(Button) || control.GetType() == typeof(RadioButton) || control.GetType() == typeof(ComboBox))
                    control.Enabled = true;
            }
        }

        private void EnableSuaControl()
        {
            foreach (Control control in grpSuaSanPham.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(Button) || control.GetType() == typeof(RadioButton) || control.GetType() == typeof(ComboBox))
                    control.Enabled = true;
            }
        }

        private void LoadComboBox()
        {
            cmbThemNhaCungCap.Items.Clear();
            cmbSuaNhaCungCap.Items.Clear();

            foreach (DataRow row in BUS_NhaCungCap.QueryData("data").Rows)
            {
                cmbThemNhaCungCap.Items.Add(row[0]);
                cmbSuaNhaCungCap.Items.Add(row[0]);
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
                    foreach (TextBox textBox in grpThemSanPham.Controls.OfType<TextBox>())
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
                    foreach (TextBox textBox in grpSuaSanPham.Controls.OfType<TextBox>())
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
                    if (!int.TryParse(txtThemSoLuongSanPham.Text, out _) || !float.TryParse(txtThemGiaSanPham.Text, out _))
                    {
                        MessageBox.Show("Dữ liệu số lượng và sản phẩm phải là dạng số", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                    break;
                case 1:
                    if (!int.TryParse(txtSuaSoLuongSanPham.Text, out _) || !float.TryParse(txtSuaGiaSanPham.Text, out _))
                    {
                        MessageBox.Show("Dữ liệu số lượng và sản phẩm phải là dạng số", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                    break;
            }
            return false;
        }

        private void btnChonTatCa_Click(object sender, EventArgs e)
        {
            if (clickdgv)
            {
                foreach (DataGridViewRow row in dgvSanPham.Rows)
                {
                    if (row.Cells[0] is DataGridViewButtonCell button)
                        dgvSanPham.EndEdit();

                    row.Cells[0].Value = ((Button)sender).Enabled = false;
                    btnChonTatCa.Enabled = true;
                }
                clickdgv = false;
            }
            else
            {
                foreach (DataGridViewRow row in dgvSanPham.Rows)
                {
                    if (row.Cells[0] is DataGridViewButtonCell button)
                        dgvSanPham.EndEdit();

                    row.Cells[0].Value = ((Button)sender).Enabled = true;
                }
                clickdgv = true;
            }     
        }

        private void btnTaiLaiDanhSach_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
            LoadComboBox();
        }

        private void btnTimSanPham_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = BUS_SanPham.QueryData("search", txtTimKiemSanPham.Text);
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
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

        private void btnSuaSanPham_Click(object sender, EventArgs e)
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

        private void btnClearThemSanPham_Click(object sender, EventArgs e)
        {
            ClearTextValue();
        }

        private void btnClearSuaSanPham_Click(object sender, EventArgs e)
        {
            ClearTextValue();
        }

        private void btnLuuThemSanPham_Click(object sender, EventArgs e)
        {
            string trangThai = "";
            if (rdoThemDangBan.Checked)
                trangThai = "Đang Bán";
            else
                trangThai = "Chưa Bán";

            if (MessageBox.Show("Bạn có muốn lưu thông tin sản phẩm " + txtThemTenSanPham.Text, "Lưu thông tin sản phẩm?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckTextBoxEmpty(0))
                    return;

                if (CheckIsNumber(0))
                    return;

                SanPham SanPham = new SanPham()
                {
                    TenSanPham = txtThemTenSanPham.Text,
                    LoaiSanPham = txtThemLoaiSanPham.Text,
                    HinhAnh = txtThemHinhAnhSanPham.Text,
                    SoLuong = int.Parse(txtThemSoLuongSanPham.Text),
                    Gia = float.Parse(txtThemGiaSanPham.Text),
                    TrangThai = trangThai,
                    MaNhaCungCap = cmbThemNhaCungCap.Text,
                };
                if (BUS_SanPham.QueryData(SanPham, "insert"))
                    MessageBox.Show($"Thêm thông tin sản phẩm {SanPham.TenSanPham} thành công", "Thêm thông tin sản phẩm",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không cập nhật được thông tin sản phẩm có tên " + SanPham.TenSanPham, "Lỗi thêm thông tin sản phẩm",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                HideControl();
                ClearTextValue();
                dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
                LoadComboBox();
            }
        }

        private void btnLuuSuaSanPham_Click(object sender, EventArgs e)
        {
            string trangThai = "";
            if (rdoSuaDangBan.Enabled)
                trangThai = "Đang Bán";
            else
                trangThai = "Chưa Bán";

            if (MessageBox.Show("Bạn có muốn sửa thông tin sản phẩm " + txtSuaTenSanPham.Text, "Sửa thông tin sản phẩm?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckTextBoxEmpty(1))
                    return;

                if (CheckIsNumber(1))
                    return;

                SanPham SanPham = new SanPham()
                {
                    MaSanPham = txtSuaMaSanPham.Text,
                    TenSanPham = txtSuaTenSanPham.Text,
                    LoaiSanPham = txtSuaLoaiSanPham.Text,
                    HinhAnh = txtSuaHinhAnhSanPham.Text,
                    SoLuong = int.Parse(txtSuaSoLuongSanPham.Text),
                    Gia = float.Parse(txtSuaGiaSanPham.Text),
                    TrangThai = trangThai,
                    MaNhaCungCap = cmbSuaNhaCungCap.Text,
                };
                if (BUS_SanPham.QueryData(SanPham, "update"))
                    MessageBox.Show($"Cập nhật thông tin sản phẩm có mã {SanPham.MaSanPham} thành công", "Cập nhật thông tin sản phẩm",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không cập nhật được thông tin sản phẩm có mã " + SanPham.MaSanPham, "Lỗi cập nhật thông tin sản phẩm",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                HideControl();
                ClearTextValue();
                dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
                LoadComboBox();
            }
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu", "Xoá sản phẩm?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool deleted = true;
                List<SanPham> listSanPham = new List<SanPham>();
                foreach (DataGridViewRow row in dgvSanPham.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                        listSanPham.Add(new SanPham
                        {
                            MaSanPham = row.Cells[1].Value.ToString()
                        });
                }

                foreach (SanPham SanPham in listSanPham)
                {
                    if (!BUS_SanPham.QueryData(SanPham, "delete"))
                    {
                        MessageBox.Show("Lỗi không xoá được dữ liệu sản phẩm với mã số " + SanPham.MaSanPham, "Lỗi xoá dữ liệu",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        deleted = false;
                    }
                }

                if (deleted)
                    MessageBox.Show("Xoá dữ liệu sản phẩm thành công", "Cập nhật thành công", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                HideControl();
                dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
                LoadComboBox();
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvSanPham.SelectedCells[0].RowIndex;
            DataGridViewRow data = dgvSanPham.Rows[row];
            txtSuaMaSanPham.Text = data.Cells[1].Value.ToString();
            txtSuaTenSanPham.Text = data.Cells[2].Value.ToString();
            txtSuaLoaiSanPham.Text = data.Cells[3].Value.ToString();
            txtSuaSoLuongSanPham.Text = data.Cells[4].Value.ToString();
            txtSuaHinhAnhSanPham.Text = data.Cells[8].Value.ToString();
            txtSuaGiaSanPham.Text = data.Cells[5].Value.ToString();
            cmbSuaNhaCungCap.Text = data.Cells[7].Value.ToString();

            if (data.Cells[6].Value.ToString() == "Đang Bán")
                rdoSuaDangBan.Checked = true;
            else
                rdoSuaChuaBan.Checked = true;

            if (dgvSanPham.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvSanPham.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvSanPham.Rows[selectedrowindex];
                string cellValue = selectedRow.Cells[8].Value.ToString();

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

        private void btnMoFileThem_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true
                txtThemHinhAnhSanPham.Text = sFileName;

                try
                {
                    Bitmap bitmap = new Bitmap(sFileName);
                    picAnhSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                    picAnhSanPham.Image = Image.FromFile(sFileName);
                    bitmap.Dispose();
                }
                catch
                {
                    MessageBox.Show("Không tải lên được hình ảnh", "Tải ảnh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    picAnhSanPham.Image = null;
                }
            }
        }

        private void btnMoFileSua_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true
                txtThemHinhAnhSanPham.Text = sFileName;

                try
                {
                    Bitmap bitmap = new Bitmap(sFileName);
                    picAnhSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                    picAnhSanPham.Image = Image.FromFile(sFileName);
                    bitmap.Dispose();
                }
                catch
                {
                    MessageBox.Show("Không tải lên được hình ảnh", "Tải ảnh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    picAnhSanPham.Image = null;
                }
            }
        }
    }
}
