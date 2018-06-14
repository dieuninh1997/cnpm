using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanDoGo.BUS;
using QLBanDoGo.Properties;
using System.Security.Cryptography;

namespace QLBanDoGo
{
    public partial class FormDangNhap : Form
    {
        NhanVienBUS obj = new NhanVienBUS();
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            txtMatKhau.Text = "";
            txtTaiKhoan.Text = "";
        }

        private String findMaNV(String u, String p)
        {
            return obj.getIdNhanVien(u,p);
        }
        private bool LoginValid(String u, String p)
        {
            
            if (obj.NhanVien_LoginValid(u, p))
            {
                NhanVienBUS nvBUS = new NhanVienBUS();
                Settings.Default["TaiKhoan"] = txtTaiKhoan.Text;
                Settings.Default["MatKhau"] = txtMatKhau.Text;
                Settings.Default["MaNV"] = nvBUS.NhanVien_GetByTop(""," TaiKhoan = '"+ txtTaiKhoan.Text.Trim()+"' and MatKhau = '"+ txtMatKhau.Text+"'","")[0].MaNV;
                Settings.Default.Save();

                //MessageBox.Show("Login successful! ");

                return true;
            }
            else
            {
                MessageBox.Show("Login unsuccessful!");
                Clear();
                txtTaiKhoan.Focus();
                return false;
            }
        }

        private bool ValidField()
        {
            return (txtTaiKhoan.Text.Equals("") || txtMatKhau.Text.Equals("")) ? true : false;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Please fill user name and password!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Select();
                return;
            }
            if (LoginValid(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                new FormHome().Show();
                this.Hide();
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Select();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnDangNhap.Focus();
            }
        }

        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
