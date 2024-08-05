using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using QuanLiShopQuanAo.BUS;
using QuanLiShopQuanAo.BUS.Entities;

namespace QuanLiShopQuanAo
{
    public partial class frmSanPham : Form
    {
        public bool closed = false;
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        PictureBox pic;
        public frmSanPham()
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=LOGINUS\SQLEXPRESS;Initial Catalog=QuanLiCuaHang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductControl pC = new();
            pC.lblTenSanPham.Text = textBox1.Text;
            pC.label2.Text = textBox2.Text;
            pC.lblGiaTien.Text = textBox3.Text;
            pC.picSanPham.Image = picture.Image;
            flowLayoutPanel1.Controls.Add(pC);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();
            if (ofd.ShowDialog() == DialogResult.OK)
                picture.ImageLocation = ofd.FileName;
        }

        private void getdata()
        {
            cn.Open();
            cmd = new SqlCommand("select TenSanPham,HinhAnh,Gia from SanPham");
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                pic = new PictureBox();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            DataTable dt = BUS_SanPham.QueryData("data");

            List<SanPham> listSanPham = new List<SanPham>();

            foreach (DataRow dataRow  in dt.Rows)
            {
                listSanPham.Add(new SanPham
                {
                    TenSanPham = dataRow["TenSanPham"].ToString(),
                    Gia = Convert.ToInt32(dataRow["Gia"].ToString()),
                    HinhAnh = dataRow["HinhAnh"].ToString()
                });
            }

            ProductControl pc = new ProductControl();

            foreach (SanPham sanPhams in listSanPham)
            {
                pc.lblTenSanPham.Text = sanPhams.TenSanPham;
                pc.lblGiaTien.Text = sanPhams.Gia.ToString();
                pc.picSanPham.Load(sanPhams.HinhAnh);
            }
        }
    }
}
