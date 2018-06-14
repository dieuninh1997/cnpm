using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanDoGo.BUS;

namespace QLBanDoGo
{
    public partial class UcDangNhap : UserControl
    {
        public bool success = false;

        public UcDangNhap()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            txtMatKhau.Text = "";
            txtTaiKhoan.Text = "";
        }

        private bool LoginValid(String u, String p)
        {
            NhanVienBUS obj = new NhanVienBUS();
            if (obj.NhanVien_LoginValid(u, p))
            {
                MessageBox.Show("Login successful!");
                return true;
            }
            else
            {
                MessageBox.Show("Login unsuccessful!");
                Clear();
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
                success = true;
                //  this.Hide();
            }
        }
    }
}
