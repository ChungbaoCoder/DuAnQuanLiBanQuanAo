﻿using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;
using System.Data;

namespace QuanLiShopQuanAo
{
    public partial class frmKhachHang : Form
    {
        public bool closed = false;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HideTextControl();
            HideButtonControl();
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
            foreach (DataGridViewRow row in dgvKhachHang.Rows)
            {
                if (row.Cells[0] is DataGridViewButtonCell button)
                    dgvKhachHang.EndEdit();

                row.Cells[0].Value = ((Button)sender).Enabled;
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
            foreach (Control c in grpThemKhachHang.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).ReadOnly = false;
                if (c is Button)
                    ((Button)c).Enabled = true;
            }    
        }

        private void btnSuaKhach_Click(object sender, EventArgs e)
        {
            foreach (Control c in grpSuaKhachHang.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).ReadOnly = false;
                if (c is Button)
                    ((Button)c).Enabled = true;
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
            if (MessageBox.Show("Bạn có muốn lưu thông tin khách hàng", "Lưu thông tin khách hàng?", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                KhachHang Khach = new KhachHang()
                {
                    TenKhachHang = txtThemTenKhachHang.Text,
                    SDT = txtThemSDTKhachHang.Text,
                    DiaChi = txtThemDiaChiKhachHang.Text,
                };
                if (BUS_KhachHang.QueryData(Khach, "insert"))
                    MessageBox.Show("Thêm thông tin khách hàng thành công");
                else
                    MessageBox.Show("Không cập nhật được thông tin khách hàng có tên " + Khach.TenKhachHang);

                HideTextControl();
                HideButtonControl();
                dgvKhachHang.DataSource = BUS_KhachHang.QueryData("data");
            }     
        }

        private void btnLuuSuaKhachHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin khách hàng", "Sửa thông tin khách hàng?",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                KhachHang Khach = new KhachHang()
                {
                    MaKhachHang = txtSuaMaKhachHang.Text,
                    TenKhachHang = txtSuaTenKhachHang.Text,
                    SDT = txtSuaSDTKhachHang.Text,
                    DiaChi = txtSuaDiaChiKhachHang.Text,
                };
                if (BUS_KhachHang.QueryData(Khach, "update"))
                    MessageBox.Show("Cập nhật thông tin khách thành công");
                else
                    MessageBox.Show("Không cập nhật được thông tin khách hàng có mã " + Khach.MaKhachHang);

                HideTextControl();
                HideButtonControl();
                dgvKhachHang.DataSource = BUS_KhachHang.QueryData("data");
            }
        }

        private void btnXoaKhach_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu", "Xoá khách hàng?", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<KhachHang> listKhach = new List<KhachHang>();

                foreach (DataGridViewRow row in dgvKhachHang.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                        listKhach.Add(new KhachHang { MaKhachHang = row.Cells[1].ToString(), 
                                                      SDT = row.Cells[3].ToString() });
                }

                foreach (KhachHang Khach in listKhach)
                {
                    if (BUS_KhachHang.QueryData(Khach, "delete"))
                        MessageBox.Show("Xoá dữ liệu khách hàng thành công");
                    else
                        MessageBox.Show("Lỗi không xoá được dữ liệu khách hàng với mã số " + Khach.MaKhachHang);   
                }
                HideTextControl();
                HideButtonControl();
                dgvKhachHang.DataSource = BUS_KhachHang.QueryData("data");
            }
        }
    }
}
