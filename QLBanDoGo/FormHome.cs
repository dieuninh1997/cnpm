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
using QLBanDoGo.DAL;
using QLBanDoGo.Properties;

namespace QLBanDoGo
{
    public partial class FormHome : Form
    {

        //var
        bool isLogInSuccess = false;


        //form, uc
        UcBanHang ucBanHang = new UcBanHang();
        UcThongKeBanHang ucTkBanHang = new UcThongKeBanHang();
        UcDangNhap ucDangNhap = new UcDangNhap();
        UcUserInfo ucUserInfo = new UcUserInfo();
        UcChangeKey ucChangeKey = new UcChangeKey();



        public FormHome()
        {
            InitializeComponent();
        }

        private void btnTkBanHang_Click(object sender, EventArgs e)
        {
            btnTkBanHang.BackColor= Color.FromArgb(255, 224, 192);
            pnThongKeContainer.Controls.Add(ucTkBanHang);
        }

      
        public void LoadGUI(bool b)
        {
            /*if (!b)
            {
                //tabHeThong
                btnLogout.Enabled = false;
                btnChangeKey.Enabled = false;
                btnSaoLuu.Enabled = false;
                btnPhucHoi.Enabled = false;
                btnThoat.Enabled = false;
                //tab others
                flpnDanhMuc.Enabled = false;
                flpnChucNang.Enabled = false;
                flpnThongKe.Enabled = false;
                flpnTienIch.Enabled = false;
            }
            else
            {
                //tabHeThong
                btnLogin.Enabled = false;
                btnLogout.Enabled = true;
                btnChangeKey.Enabled = true;
                btnSaoLuu.Enabled = true;
                btnPhucHoi.Enabled = true;
                btnThoat.Enabled = true;
                //tab others
                flpnDanhMuc.Enabled = true;
                flpnChucNang.Enabled = true;
                flpnThongKe.Enabled = true;
                flpnTienIch.Enabled = true;
            }*/
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            LoadGUI(isLogInSuccess);


        }

        private void btnCNBanHang_Click(object sender, EventArgs e)
        {
            btnCNBanHang.BackColor = Color.FromArgb(255, 224, 192);
            pnChucNangContainer.Controls.Add(ucBanHang);
         //   HoaDonBanHangBUS hdbhBUS = new HoaDonBanHangBUS();
         //a   hdbhBUS.HoaDonBanHang_Insert_ByMaNV(new HoaDonBanHangObj(Settings.Default["MaNV"].ToString()));
             //   MessageBox.Show("Ok");
          //  else
                //MessageBox.Show("Noooo");

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            //uc User info
            btnUser.BackColor = Color.FromArgb(255, 224, 192);
            pnHeThongContainer.Controls.Add(ucUserInfo);
            ucUserInfo.BringToFront();

            btnChangeKey.BackColor = Color.LightGray;

        }

        private void btnChangeKey_Click(object sender, EventArgs e)
        {
            btnChangeKey.BackColor = Color.FromArgb(255, 224, 192);
            pnHeThongContainer.Controls.Add(ucChangeKey);
            ucChangeKey.BringToFront();

            btnUser.BackColor = Color.LightGray;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            DialogResult res = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if(res==DialogResult.Yes)
            {
                Settings.Default.Reset();
                this.Close();
                new FormDangNhap().Show();

            }
        }

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
          //  DialogResult rs=MessageBox.Show("")
          //  HoaDonBanHangBUS bus = new HoaDonBanHangBUS();
           
          //  List<HoaDonBanHangObj> lstHDBH = bus.HoaDonBanHang_GetByTop("", "", "MaHDBH desc");
         //   if(bus.HoaDonBanHang_Delete(lstHDBH[0].MaHDBH))
            {

            }
            Application.Exit();
        }

        private void pnHeThongContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
