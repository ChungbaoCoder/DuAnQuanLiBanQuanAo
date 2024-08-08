using Microsoft.Data.SqlClient;
using QuanLiShopQuanAo.DataBaseConnection;
using QuanLiShopQuanAo.Resources;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace QuanLiShopQuanAo
{
    public partial class frmMainMenu : Form
    {
        Form currentform;
        bool closed = false;
        string maNhanVien = string.Empty;
        string chucVu = string.Empty;
        public frmMainMenu()
        {
            InitializeComponent();
        }

        public void Openchildform(Form childform)
        {
            if (currentform != null)
            {
                currentform.Close();
            }
            currentform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childform);
            pnlContent.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            frmDangNhap form = new frmDangNhap();
            this.Hide();
            form.ShowDialog();
            maNhanVien = form.maNhanVien;
            chucVu = form.chucVu;

            if (!form.IsHandleCreated)
                closed = true;

            if (form.closed)
                this.Show();

            if (chucVu != "Quản Trị")
            {
                pnlKho.Hide();
                pnlNhaCungCap.Hide();
                pnlNhanVien.Hide();
            }

            using (SqlConnection conn = new SqlConnection(DataBaseConnection.DBConnection.ConnectionString))
            {
                string command = "SELECT TenNhanVien, HinhAnh FROM NhanVien WHERE MaNhanVien = '" + maNhanVien + "'";
                SqlCommand sqlCommand = new SqlCommand(command, conn);
                conn.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    lblUserName.Text = (string)reader["TenNhanVien"];

                    try
                    {
                        picAnhNhanVien.ImageLocation = (string)reader["HinhAnh"];
                    }
                    catch { }
                }
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Openchildform(new frmHoaDon { form = this, maNhanVien = this.maNhanVien });
            lblTrangChu.Text = btnHoaDon.Text;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Openchildform(new frmKhachHang());
            lblTrangChu.Text = btnKhachHang.Text;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Openchildform(new frmNhanVien());
            lblTrangChu.Text = btnNhanVien.Text;
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            Openchildform(new frmKho());
            lblTrangChu.Text = btnKho.Text;
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            Openchildform(new frmNhaCungCap());
            lblTrangChu.Text = btnNhaCungCap.Text;
        }

        private void btnHoTro_Click(object sender, EventArgs e)
        {
            frmHoTro t = new frmHoTro();
            this.Hide();
            t.ShowDialog();
            if (t.check)
            {
                this.Show();
            }
        }

        private void btnViewSanPham_Click(object sender, EventArgs e)
        {
            Openchildform(new frmSanPham());
        }

        private void picIconTrangChu_Click(object sender, EventArgs e)
        {
            if (currentform != null)
            {
                currentform.Close();
            }
            lblTrangChu.Text = "Trang chủ";
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất", "Đăng xuất", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                closed = false;
                this.Hide();
                frmDangNhap form = new frmDangNhap();
                this.Hide();
                form.ShowDialog();
                maNhanVien = form.maNhanVien;
                chucVu = form.chucVu;

                if (!form.IsHandleCreated)
                    closed = true;

                if (form.closed)
                    this.Show();

                if (chucVu != "Quản Trị")
                {
                    pnlKho.Hide();
                    pnlNhaCungCap.Hide();
                    pnlNhanVien.Hide();
                }


                using (SqlConnection conn = new SqlConnection(DataBaseConnection.DBConnection.ConnectionString))
                {
                    string command = "SELECT TenNhanVien, HinhAnh FROM NhanVien WHERE MaNhanVien = '" + maNhanVien + "'";
                    SqlCommand sqlCommand = new SqlCommand(command, conn);
                    conn.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        lblUserName.Text = (string)reader["TenNhanVien"];

                        try
                        {
                            picAnhNhanVien.ImageLocation = (string)reader["HinhAnh"];
                        }
                        catch { }
                    }
                }
            }
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closed)
            {
                var res = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (res != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
