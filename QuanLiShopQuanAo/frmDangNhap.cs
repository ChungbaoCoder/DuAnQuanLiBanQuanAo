using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiShopQuanAo.BUS;

namespace QuanLiShopQuanAo.DataBaseConnection
{
    public partial class frmDangNhap : Form
    {
        public bool closed = false;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void linklblQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (BUS_Account.Login(txtUserName.Text, txtPassWord.Text))
                {
                    closed = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closed == false)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
