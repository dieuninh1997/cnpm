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
using QLBanDoGo.DAL;
using QLBanDoGo.Properties;


namespace QLBanDoGo
{
    public partial class UcUserInfo : UserControl
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        ChucVuBUS cvBUS = new ChucVuBUS();
        public UcUserInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindData()
        {
            string manv = Settings.Default["MaNV"].ToString();
          //  MessageBox.Show(manv);
            var lst = nvBUS.NhanVien_GetByTop("", "manv='" + manv+"'", "");
            NhanVienObj nv = lst[0];
            txtHoTenNV.Text = nv.TenNV;
            txtNgaySinhNV.Text = nv.NgaySinh;
            txtDiaChiNV.Text = nv.DiaChi;
            txtCMT.Text = nv.CMT;
            txtSDT.Text = nv.SDT;
            txtMaNV.Text = nv.MaNV;
            if(nv.GioiTinh.Equals("0"))
            {
                radioNam.Checked = true;
            }else
            {
                radioNu.Checked = true;
            }
            var cv = cvBUS.ChucVu_GetByTop("", "MaCV='"+nv.MaCV+"'", "");
            txtChucVu.Text = cv[0].TenCV;
        }
        private void UcUserInfo_Load(object sender, EventArgs e)
        {
            txtHoTenNV.Enabled = false;
            txtNgaySinhNV.Enabled = false;
            txtSDT.Enabled = false;
            txtMaNV.Enabled = false;
            txtDiaChiNV.Enabled = false;
            txtCMT.Enabled = false;
            txtChucVu.Enabled = false;

            gpChucNangNV.Enabled = false;
            bindData();
        }
    }
}
