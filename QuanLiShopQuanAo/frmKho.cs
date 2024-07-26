using System.Data;
using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;

namespace QuanLiShopQuanAo
{
    public partial class frmKho : Form
    {
        public bool closed = false;
        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            HideTextControl();
            HideButtonControl();
            SetColumns();
            dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
            LoadComboBox();
        }

        private void SetColumns()
        {
            var columnsName = BUS_SanPham.QueryData("data").Columns.
                Cast<DataColumn>().Select(columns => columns.ColumnName).ToArray();

            for (int i = 0; i < columnsName.Length - 1; i++)
                dgvSanPham.Columns[i + 1].DataPropertyName = columnsName[i];
        }

        private void LoadComboBox()
        {
            foreach (DataRow row in BUS_NhaCungCap.QueryData("data").Rows)
            {
                cmbThemNhaCungCap.Items.Add(row[0]);
                cmbSuaNhaCungCap.Items.Add(row[0]);
            } 
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
            try {
                foreach (Control gb in this.Controls)
                {
                    if (gb is GroupBox)
                    {
                        foreach (Control tb in gb.Controls)
                            ((TextBox)tb).Text = string.Empty;
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void OpenFile()
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
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvSanPham.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvSanPham.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[8].ToString());

                try
                {
                    Bitmap bitmap = new Bitmap(cellValue);
                    picAnhSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                    picAnhSanPham.Image = Image.FromFile(cellValue);
                    bitmap.Dispose();
                }
                catch { }
            }
        }

        private void btnChonTatCa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells[0] is DataGridViewButtonCell button)
                    dgvSanPham.EndEdit();

                row.Cells[0].Value = ((Button)sender).Enabled;
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
            foreach (Control c in grpThemSanPham.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).ReadOnly = false;
                if (c is Button)
                    ((Button)c).Enabled = true;
            }
        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            foreach (Control c in grpSuaSanPham.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).ReadOnly = false;
                if (c is Button)
                    ((Button)c).Enabled = true;
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

                Bitmap bitmap = new Bitmap(sFileName);
                picAnhSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                picAnhSanPham.Image = Image.FromFile(sFileName);
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
                txtThemHinhAnhSanPham.Text = sFileName;

                Bitmap bitmap = new Bitmap(sFileName);
                picAnhSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                picAnhSanPham.Image = Image.FromFile(sFileName);
                bitmap.Dispose();
            }
        }

        private void btnLuuThemSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                string trangThai = "";
                if (rdoThemDangBan.Checked)
                    trangThai = "Đang bán";
                else
                    trangThai = "Chưa bán";

                if (MessageBox.Show("Bạn có muốn lưu thông tin sản phẩm", "Lưu thông tin sản phẩm?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
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
                        MessageBox.Show("Thêm thông tin sản phẩm thành công");
                    else
                        MessageBox.Show("Không cập nhật được thông tin sản phẩm có tên " + SanPham.TenSanPham);

                    HideTextControl();
                    HideButtonControl();
                    dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
                    LoadComboBox();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnLuuSuaSanPham_Click(object sender, EventArgs e)
        {
            string trangThai = "";
            if (rdoThemDangBan.Enabled)
                trangThai = "Đang bán";
            else
                trangThai = "Chưa bán";

            if (MessageBox.Show("Bạn có muốn sửa thông tin sản phẩm", "Sửa thông tin sản phẩm?",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
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
                    MessageBox.Show("Cập nhật thông tin khách thành công");
                else
                    MessageBox.Show("Không cập nhật được thông tin sản phẩm có mã " + SanPham.MaSanPham);

                HideTextControl();
                HideButtonControl();
                dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
                LoadComboBox();
            }
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu", "Xoá sản phẩm?",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<SanPham> listSanPham = new List<SanPham>();

                foreach (DataGridViewRow row in dgvSanPham.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                        listSanPham.Add(new SanPham
                        {
                            MaSanPham = row.Cells[1].ToString()
                        });
                }

                foreach (SanPham SanPham in listSanPham)
                {
                    if (BUS_SanPham.QueryData(SanPham, "delete"))
                        MessageBox.Show("Xoá dữ liệu sản phẩm thành công");
                    else
                        MessageBox.Show("Lỗi không xoá được dữ liệu sản phẩm với mã số " + SanPham.MaSanPham);
                }
                HideTextControl();
                HideButtonControl();
                dgvSanPham.DataSource = BUS_SanPham.QueryData("data");
                LoadComboBox();
            }
        }
    }
}
