using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;
using System.Data;

namespace QuanLiShopQuanAo
{
    public partial class frmNhanVien : Form
    {
        public bool closed = false;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HideTextControl();
            HideButtonControl();
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
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (row.Cells[0] is DataGridViewButtonCell button)
                {
                    dgvNhanVien.EndEdit();
                }
                row.Cells[0].Value = ((Button)sender).Enabled;
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
            foreach (Control c in grpThemNhanVien.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).ReadOnly = false;
                if (c is Button)
                    ((Button)c).Enabled = true;
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            foreach (Control c in grpSuaNhanVien.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).ReadOnly = false;
                if (c is Button)
                    ((Button)c).Enabled = true;
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
            if (MessageBox.Show("Bạn có muốn lưu thông tin nhân viên", "Lưu thông tin nhân viên?",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhanVien NhanVien = new NhanVien()
                {
                    TenNhanVien = txtSuaTenNhanVien.Text,
                    ChucVu = cmbThemChucVuNhanVien.Text,
                    Luong = float.Parse(txtThemLuong.Text),
                    Email = txtThemEmailNhanVien.Text,
                    HinhAnh = txtThemHinhAnhNhanVien.Text,
                    TrangThai = txtThemTrangThai.Text,
                    MatKhau = BUS_Account.CreatePassword(5)
                };
                if (BUS_NhanVien.QueryData(NhanVien, "insert"))
                    MessageBox.Show("Thêm thông tin nhân viên thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Question);
                else
                    MessageBox.Show("Không cập nhật được thông tin nhân viên có mã " + NhanVien.TenNhanVien,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);

                HideTextControl();
                HideButtonControl();
                dgvNhanVien.DataSource = BUS_NhanVien.QueryData("data");
            }
        }

        private void btnLuuSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin nhân viên", "Sửa thông tin nhân viên?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhanVien NhanVien = new NhanVien()
                {
                    MaNhanVien = txtSuaMaNhanVien.Text,
                    TenNhanVien = txtSuaTenNhanVien.Text,
                    ChucVu = cmbThemChucVuNhanVien.Text,
                    Luong = float.Parse(txtThemLuong.Text),
                    Email = txtThemEmailNhanVien.Text,
                    HinhAnh = txtThemHinhAnhNhanVien.Text,
                    TrangThai = txtThemTrangThai.Text,
                };
                if (BUS_NhanVien.QueryData(NhanVien, "update"))
                    MessageBox.Show("Cập nhật thông tin khách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                else
                    MessageBox.Show("Không cập nhật được thông tin nhân viên có mã " + NhanVien.MaNhanVien, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                HideTextControl();
                HideButtonControl();
                dgvNhanVien.DataSource = BUS_NhanVien.QueryData("data");
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu", "Xoá nhân viên?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<NhanVien> listNhanVien = new List<NhanVien>();

                foreach (DataGridViewRow row in dgvNhanVien.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                        listNhanVien.Add(new NhanVien
                        {
                            MaNhanVien = row.Cells[1].ToString(),
                        });
                }

                foreach (NhanVien NhanVien in listNhanVien)
                {
                    if (BUS_NhanVien.QueryData(NhanVien, "delete"))
                        MessageBox.Show("Xoá dữ liệu nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    else
                        MessageBox.Show("Lỗi không xoá được dữ liệu nhân viên với mã số " + NhanVien.MaNhanVien, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                HideTextControl();
                HideButtonControl();
                dgvNhanVien.DataSource = BUS_NhanVien.QueryData("data");
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

                Bitmap bitmap = new Bitmap(sFileName);
                picAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
                picAnhNhanVien.Image = Image.FromFile(sFileName);
                bitmap.Dispose();
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

                Bitmap bitmap = new Bitmap(sFileName);
                picAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
                picAnhNhanVien.Image = Image.FromFile(sFileName);
                bitmap.Dispose();
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
                catch { }
            }
        }
    }
}
