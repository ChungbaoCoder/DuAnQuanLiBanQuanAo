﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            closed = true;
            this.Close();
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            closed = true;
        }
    }
}
