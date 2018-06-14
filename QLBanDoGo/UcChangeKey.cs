using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanDoGo.DAL;
using QLBanDoGo.BUS;
using QLBanDoGo.Properties;

namespace QLBanDoGo
{
    public partial class UcChangeKey : UserControl
    {
        public UcChangeKey()
        {
            InitializeComponent();
        }

        private void UcChangeKey_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Enabled = false;
            txtTaiKhoan.Text = Settings.Default["TaiKhoan"].ToString();
            txtMkCu.Focus();
        }

        private void txtMkCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMkMoi.Focus();
            }
        }

        private void txtMkMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtXacNhanMk.Focus();
            }
        }

        private void txtXacNhanMk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnXacNhan.Focus();
            }
        }

        private bool Valid()
        {
            if (String.IsNullOrEmpty(txtMkCu.Text) || String.IsNullOrEmpty(txtMkMoi.Text) || String.IsNullOrEmpty(txtXacNhanMk.Text))
            {
                return false;
            }
            else if (txtMkCu.Text.Trim().Equals(Settings.Default["MatKhau"].ToString().Trim()))
            {
                if (txtXacNhanMk.Text.Trim().Equals(txtMkMoi.Text.Trim()))
                {

                    return true;
                }
            }
            return false;
        }
        private void clear()
        {
            txtMkCu.Text = "";
            txtMkMoi.Text = "";
            txtXacNhanMk.Text = "";
            txtMkCu.Focus();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
           if(Valid())
            {
                NhanVienBUS nvBUS = new NhanVienBUS();
                NhanVienObj nv = new NhanVienObj();
                nv.MatKhau = txtMkMoi.Text;
                nv.MaNV = Settings.Default["MaNV"].ToString();
                if (nvBUS.NhanVien_ChangeKey(nv))
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                clear();
            }
        }
    }
}
