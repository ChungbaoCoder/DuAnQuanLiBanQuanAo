using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;
using System.Data;

namespace QuanLiShopQuanAo
{
    public partial class frmNhanVien : Form
    {
        private bool clickthem = false;
        private bool clicksua = false;
        private bool clickdgv = false;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HideControl();
            SetColumns();
            dgvNhanVien.DataSource = BUS_NhanVien.QueryData("data");
        }

        private void SetColumns()
        {
            var columnsName = BUS_NhanVien.QueryData("data").Columns.
                Cast<DataColumn>().Select(columns => columns.ColumnName).ToArray();

            for (int i = 0; i < columnsName.Length; i++)
                dgvNhanVien.Columns[i + 1].DataPropertyName = columnsName[i];
        }

        private void HideControl()
        {
            foreach (Control control in grpThemNhanVien.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(Button) || control.GetType() == typeof(RadioButton) || control.GetType() == typeof(ComboBox))
                    control.Enabled = false;
            }
            foreach (Control control in grpSuaNhanVien.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(Button) || control.GetType() == typeof(RadioButton) || control.GetType() == typeof(ComboBox))
                    control.Enabled = false;
            }
        }

        private void EnableThemControl()
        {
            foreach (Control control in grpThemNhanVien.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(Button) || control.GetType() == typeof(RadioButton) || control.GetType() == typeof(ComboBox))
                    control.Enabled = true;
            }
        }

        private void EnableSuaControl()
        {
            foreach (Control control in grpSuaNhanVien.Controls)
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
                    foreach (TextBox textBox in grpThemNhanVien.Controls.OfType<TextBox>())
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
                    foreach (TextBox textBox in grpSuaNhanVien.Controls.OfType<TextBox>())
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
                    if (!float.TryParse(txtThemLuongNhanVien.Text, out _) || !float.TryParse(txtThemLuongNhanVien.Text, out _))
                    {
                        MessageBox.Show("Dữ liệu số lượng và sản phẩm phải là dạng số", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                    break;
                case 1:
                    if (!float.TryParse(txtSuaLuongNhanVien.Text, out _) || !float.TryParse(txtSuaLuongNhanVien.Text, out _))
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
                foreach (DataGridViewRow row in dgvNhanVien.Rows)
                {
                    if (row.Cells[0] is DataGridViewButtonCell button)
                        dgvNhanVien.EndEdit();

                    row.Cells[0].Value = ((Button)sender).Enabled = false;
                    btnChonTatCa.Enabled = true;
                }
                clickdgv = false;
            }
            else
            {
                foreach (DataGridViewRow row in dgvNhanVien.Rows)
                {
                    if (row.Cells[0] is DataGridViewButtonCell button)
                        dgvNhanVien.EndEdit();

                    row.Cells[0].Value = ((Button)sender).Enabled = true;
                }
                clickdgv = true;
            }
        }

        private void btnTaiLaiDanhSach_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = BUS_NhanVien.QueryData("data");
        }

        private void btnTimNhanVien_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = BUS_NhanVien.QueryData("search", txtTimKiemNhanVien.Text);
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
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

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
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

        private void btnClearThemNhanVien_Click(object sender, EventArgs e)
        {
            ClearTextValue();
        }

        private void btnClearSuaNhanVien_Click(object sender, EventArgs e)
        {
            ClearTextValue();
        }

        private void btnLuuThemNhanVien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu thông tin nhân viên " + txtThemTenNhanVien.Text, "Lưu thông tin nhân viên?",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckTextBoxEmpty(0))
                    return;

                if (CheckIsNumber(0))
                    return;

                NhanVien NhanVien = new NhanVien()
                {
                    TenNhanVien = txtThemTenNhanVien.Text,
                    ChucVu = cmbThemChucVuNhanVien.Text,
                    Luong = float.Parse(txtThemLuongNhanVien.Text),
                    Email = txtThemEmailNhanVien.Text,
                    HinhAnh = txtThemHinhAnhNhanVien.Text,
                    TrangThai = txtThemTrangThai.Text,
                    MatKhau = BUS_Account.CreatePassword(5)
                };
                if (BUS_NhanVien.QueryData(NhanVien, "insert"))
                    MessageBox.Show($"Thêm thông tin nhân viên {NhanVien.TenNhanVien} thành công", "Thêm thông tin nhân viên",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không cập nhật được thông tin nhân viên có mã " + NhanVien.TenNhanVien, "Lỗi thêm thông tin nhân viên",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                HideControl();
                ClearTextValue();
                dgvNhanVien.DataSource = BUS_NhanVien.QueryData("data");
            }
        }

        private void btnLuuSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin nhân viên " + txtSuaTenNhanVien.Text, "Sửa thông tin nhân viên?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckTextBoxEmpty(1))
                    return;

                if (CheckIsNumber(1))
                    return;

                NhanVien NhanVien = new NhanVien()
                {
                    MaNhanVien = txtSuaMaNhanVien.Text,
                    TenNhanVien = txtSuaTenNhanVien.Text,
                    ChucVu = cmbSuaChucVuNhanVien.Text,
                    Luong = float.Parse(txtSuaLuongNhanVien.Text),
                    Email = txtSuaEmailNhanVien.Text,
                    HinhAnh = txtSuaHinhAnhNhanVien.Text,
                    TrangThai = txtSuaTrangThai.Text,
                };
                if (BUS_NhanVien.QueryData(NhanVien, "update"))
                    MessageBox.Show($"Cập nhật thông tin nhân viên có mã {NhanVien.MaNhanVien} thành công", "Cập nhật thông tin nhân viên",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không cập nhật được thông tin nhân viên có mã " + NhanVien.MaNhanVien, "Lỗi cập nhật thông tin nhân viên",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                HideControl();
                ClearTextValue();
                dgvNhanVien.DataSource = BUS_NhanVien.QueryData("data");
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu", "Xoá nhân viên?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool deleted = true;
                List<NhanVien> listNhanVien = new List<NhanVien>();
                foreach (DataGridViewRow row in dgvNhanVien.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                        listNhanVien.Add(new NhanVien
                        {
                            MaNhanVien = row.Cells[1].Value.ToString(),
                        });
                }

                foreach (NhanVien NhanVien in listNhanVien)
                {
                    if (!BUS_NhanVien.QueryData(NhanVien, "delete"))
                    {
                        MessageBox.Show("Lỗi không xoá được dữ liệu nhân viên với mã số " + NhanVien.MaNhanVien, "Lỗi xoá dữu liệu",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        deleted = false;
                    }
                }
                
                if (deleted)
                    MessageBox.Show("Xoá dữ liệu nhân viên thành công", "Cập nhật thành công", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                HideControl();
                dgvNhanVien.DataSource = BUS_NhanVien.QueryData("data");
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvNhanVien.SelectedCells[0].RowIndex;
            DataGridViewRow data = dgvNhanVien.Rows[row];
            txtSuaMaNhanVien.Text = data.Cells[1].Value.ToString();
            txtSuaTenNhanVien.Text = data.Cells[2].Value.ToString();
            txtSuaEmailNhanVien.Text = data.Cells[5].Value.ToString();
            txtSuaHinhAnhNhanVien.Text = data.Cells[7].Value.ToString();
            txtSuaLuongNhanVien.Text = data.Cells[4].Value.ToString();
            txtSuaTrangThai.Text = data.Cells[6].Value.ToString();

            if (data.Cells[3].Value.ToString() == "Quản Trị")
                cmbSuaChucVuNhanVien.Text = "Quản Trị";
            else
                cmbSuaChucVuNhanVien.Text = "Nhân Viên";

            if (dgvNhanVien.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvNhanVien.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvNhanVien.Rows[selectedrowindex];
                string cellValue = selectedRow.Cells[7].Value.ToString();

                try
                {
                    Bitmap bitmap = new Bitmap(cellValue);
                    picAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
                    picAnhNhanVien.Image = Image.FromFile(cellValue);
                    bitmap.Dispose();
                }
                catch 
                {
                    picAnhNhanVien.Image = null;
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
                txtThemHinhAnhNhanVien.Text = sFileName;

                try
                {
                    Bitmap bitmap = new Bitmap(sFileName);
                    picAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
                    picAnhNhanVien.Image = Image.FromFile(sFileName);
                    bitmap.Dispose();
                }
                catch
                {
                    MessageBox.Show("Không tải lên được hình ảnh", "Tải ảnh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    picAnhNhanVien.Image = null;
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
                txtSuaHinhAnhNhanVien.Text = sFileName;

                try
                {
                    Bitmap bitmap = new Bitmap(sFileName);
                    picAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
                    picAnhNhanVien.Image = Image.FromFile(sFileName);
                    bitmap.Dispose();
                }
                catch
                {
                    MessageBox.Show("Không tải lên được hình ảnh", "Tải ảnh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    picAnhNhanVien.Image = null;
                }
            }
        }
    }
}
