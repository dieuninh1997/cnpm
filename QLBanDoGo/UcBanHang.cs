using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanDoGo.Properties;
using QLBanDoGo.BUS;
using QLBanDoGo.DAL;

using System.Data.SqlClient;

namespace QLBanDoGo
{
    public partial class UcBanHang : UserControl
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        ChiTietHDBH_BUS cthdbh = new ChiTietHDBH_BUS();
        HangHoaBUS hhBUS = new HangHoaBUS();
        LoaiHangBUS lhBUS = new LoaiHangBUS();
        HoaDonBanHangBUS banHangBUS = new HoaDonBanHangBUS();
        KhachHangBUS khBUS = new KhachHangBUS();





        public UcBanHang()
        {
            InitializeComponent();
        }

        private void showViews()
        {
            txtBH_NhanVien.Enabled = false;
            txtBH_MaNV.Enabled = false;
            txtBH_MaHD.Enabled = false;
            txtBH_DiaChi.Enabled = false;
            txtBH_KhachHang.Enabled = false;
            txtBH_SDT.Enabled = false;

            gbUcBanHang_TT_HDBH.Enabled = false;
            flpnControlBanHang.Enabled = false;

            cmbMaKH.Enabled = true;
            txtTongTien.Enabled = false;
            txtTongTien.Text = "0";

        }

        private void bindDataTT_KhachHang(string top, string where, string order)
        {
            List<KhachHangObj> lst = khBUS.KhachHang_GetByTop(top, where, order);
            if (lst.Count > 0)
            {
                txtBH_KhachHang.Text = lst[0].MaKH;
                txtBH_DiaChi.Text = lst[0].DiaChi;
                txtBH_SDT.Text = lst[0].SDT;
            }
            else
            {
                txtBH_KhachHang.Text = "";
                txtBH_DiaChi.Text = "";
                txtBH_SDT.Text = "";
            }
        }
        private void bindDataCmbMaKH()
        {
            List<KhachHangObj> lst = khBUS.KhachHang_GetByTop("", "", "");
            lst.Insert(0, new KhachHangObj("0", "--Select All--"));
            cmbMaKH.DataSource = lst;
            cmbMaKH.ValueMember = "MaKH";
            cmbMaKH.DisplayMember = "TenKH";
            cmbMaKH.SelectedIndex = 0;
        }
        private void bindDataNhanVien()
        {

            txtBH_MaNV.Text = Settings.Default["MaNV"].ToString();
            var list = nvBUS.NhanVien_GetByTop("", "MaNV = '" + txtBH_MaNV.Text + "'", "");
            if (list.Count > 0)
                txtBH_NhanVien.Text = list[0].TenNV;
        }

        private long sumTongTien(List<ChiTietHDBH> lst)
        {
            long s = 0;
            foreach(ChiTietHDBH i in lst)
            {
                int sl = int.Parse(i.SoLuongMua);
                long gia = long.Parse(i.GiaBan);
                s = s + (sl * gia);
            }
            return s;
        }

        public void bindDataGridView()
        {
            dgvBH.DataSource = null;
            //chi tiet hoa don
            var lst= banHangBUS.HoaDonBanHang_Query(txtBH_MaHD.Text);
            dgvBH.DataSource = lst;

            dgvBH.Columns["MaHDBH"].DisplayIndex = 0;
            dgvBH.Columns["MaHDBH"].HeaderText = "Mã hóa đơn";

            dgvBH.Columns["MaHH"].DisplayIndex = 1;
            dgvBH.Columns["MaHH"].HeaderText = "Mã hàng hóa";

            dgvBH.Columns["TenHH"].DisplayIndex = 2;
            dgvBH.Columns["TenHH"].HeaderText = "Tên hàng hóa";

            dgvBH.Columns["MaLoai"].DisplayIndex = 3;
            dgvBH.Columns["MaLoai"].HeaderText = "Mã loại";

            dgvBH.Columns["TenLoai"].DisplayIndex = 4;
            dgvBH.Columns["TenLoai"].HeaderText = "Tên loại hàng";

            dgvBH.Columns["SoLuongMua"].DisplayIndex = 5;
            dgvBH.Columns["SoLuongMua"].HeaderText = "Số lượng mua";

            dgvBH.Columns["GiaBan"].DisplayIndex = 6;
            dgvBH.Columns["GiaBan"].HeaderText = "Giá";

            dgvBH.Columns["NgayLap"].DisplayIndex = 7;
            dgvBH.Columns["NgayLap"].HeaderText = "Ngày mua";
            dgvBH.Columns["NgayLap"].Visible = false;


            dgvBH.Columns["MaKH"].DisplayIndex = 8;
            dgvBH.Columns["MaKH"].HeaderText = "Mã kh";
            dgvBH.Columns["MaKH"].Visible = false;

            

            //  dgvBH.Columns["MaHDBH"].Visible = false;
        }

        private void btnBH_Them_Click(object sender, EventArgs e)
        {
            new FormBanHangThem(true, "Thêm hàng hóa vào hóa đơn", txtBH_MaHD.Text).ShowDialog();
        }



        private void btnBH_Sua_Click(object sender, EventArgs e)
        {

            if (dgvBH.CurrentRow.Index < 0) return;
            //  try
            {
                ChiTietHDBH obj = new ChiTietHDBH();
                //  MessageBox.Show("mahdbh-mahh:" + txtBH_MaHD.Text + " " + dgvBH.CurrentRow.Cells["MaHH"].Value.ToString());
                obj = banHangBUS.HoaDonBanHang_Query(txtBH_MaHD.Text)[dgvBH.CurrentRow.Index];// cthdbh.ChiTietHDBH_GetByTop("", "MaHDBH = '"++"' and MaHH ='" + dgvBH.CurrentRow.Cells["MaHH"].Value.ToString() + "'", "")[0];
                new FormBanHangThem(false, "Sửa", txtBH_MaHD.Text, obj).ShowDialog();


            }
            // catch
            {
                //MessageBox.Show("Chọn 1 sản phẩm muốn sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBH_Xoa_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Bạn muốn xóa?");

            if (dgvBH.CurrentRow.Index < 0) return;
            try
            {
                if (MessageBox.Show("Bạn muốn xóa sản phẩm này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (cthdbh.ChiTietHDBH_Delete(txtBH_MaHD.Text, dgvBH.CurrentRow.Cells["MaHH"].Value.ToString()))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindDataGridView();
                        flpnControlBanHang.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Chọn 1 sản phẩm muốn xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

     
        private void btnBH_In_Click(object sender, EventArgs e)
        {

            
            HoaDonBanHangBUS b = new HoaDonBanHangBUS();
            var lst = b.HoaDonBanHang_Query(txtBH_MaHD.Text);
            if (lst.Count > 0)
            {
                string tenKH = khBUS.KhachHang_GetByTop("", "MaKH='" + lst[0].MaKH + "'", "")[0].TenKH;
                using (FormBanHangIn frm = new FormBanHangIn(lst, txtTongTien.Text, tenKH, txtBH_NhanVien.Text))
                {
                    frm.ShowDialog();
                }
            }else
                MessageBox.Show("Hóa đơn bán hàng rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void UcBanHang_Load(object sender, EventArgs e)
        {
            showViews();
            bindDataNhanVien();
            bindDataCmbMaKH();
            // bindDataGridView();
        }

        private void btnBH_Refresh_Click(object sender, EventArgs e)
        {
            showViews();
            bindDataNhanVien();
            bindDataGridView();
            flpnControlBanHang.Enabled = true;
            var lst = banHangBUS.HoaDonBanHang_Query(txtSearch_TT_HDBH.Text.Trim());
            txtTongTien.Text = Common._DoiSoSangDonViTienTe(sumTongTien(lst));
        }


        private void btnBH_Luu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu hóa đơn " + txtBH_MaHD.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HoaDonBanHangBUS hdbhBUS = new HoaDonBanHangBUS();
            hdbhBUS.HoaDonBanHang_Insert_ByMaNV(new HoaDonBanHangObj(Settings.Default["MaNV"].ToString()));
            //  bindDataGridView();
            //   MessageBox.Show("Ok");
            //  else
            //MessageBox.Show("Noooo");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn hủy hóa đơn " + txtBH_MaHD.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                string msg = "";
                bool r = banHangBUS.HoaDonBanHang_Delete(txtBH_MaHD.Text);
                if (r)
                    msg = "Hủy MaHDBH: " + txtBH_MaHD.Text + " thành công!";
                else
                    msg = "Rất tiếc! Hủy MaHDBH: " + txtBH_MaHD.Text + " thất bại";

                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnTaoHoaDonBH_New_Click(object sender, EventArgs e)
        {
            dgvBH.DataSource = null;
            cmbMaKH.SelectedIndex = 0;
            txtBH_MaHD.Text = "";
            dtk_NgayBan.Value = DateTime.Now;


            //CREATE A New hoa don ban hang
            HoaDonBanHangObj newHDBH = new HoaDonBanHangObj();
            newHDBH.MaKH = cmbMaKH.SelectedValue.ToString();
            newHDBH.MaNV = txtBH_MaNV.Text;
            newHDBH.NgayLap = dtk_NgayBan.Value.ToString();
            newHDBH.TongTien = "0";
            bool v = banHangBUS.HoaDonBanHang_Insert(newHDBH);
            string msg = "";
            if (v)
            {
                string maHoaDonMoi = banHangBUS.HoaDonBanHang_GetByTop("", "", " MaHDBH desc")[0].MaHDBH;
                //  MessageBox.Show("ma hoa don ban hang moi vua tao =" + maHoaDonMoi);
                txtBH_MaHD.Text = maHoaDonMoi;
                gbUcBanHang_TT_HDBH.Enabled = true;
                flpnControlBanHang.Enabled = true;
                btnTaoHoaDonBH_New.Enabled = false;
                msg = "Bạn vừa tạo mới hóa đơn thành công! Hãy tiếp tục thêm sản phẩm vào hóa đơn từ nút ['+' Thêm]";
            }
            else
            {
                string maKhIsEmpty;
                if (String.IsNullOrEmpty(txtBH_KhachHang.Text))
                {
                    maKhIsEmpty = " Xin hãy chọn khách hàng trước khi tạo mới hóa đơn. ";
                }
                else
                {
                    maKhIsEmpty = "";
                }
                msg = "Rất tiếc! Việc tạo mới hóa đơn lỗi." + maKhIsEmpty + " Xin hãy thử lại lần nữa";
            }
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cmbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaKH.SelectedIndex == 0)
            {
                //nothing done
            }
            else
            {
                bindDataTT_KhachHang("", " MaKH = '" + cmbMaKH.SelectedValue.ToString() + "'", "");
            }
        }

        private void btnSearch_TT_HDBH_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (String.IsNullOrEmpty(txtSearch_TT_HDBH.Text))
            {
                msg = "Bạn chưa nhập thông tin tìm kiếm";
            }
            else
            {
                var lst = banHangBUS.HoaDonBanHang_Query(txtSearch_TT_HDBH.Text.Trim());
                if (lst.Count > 0)
                {
                    dgvBH.DataSource = banHangBUS.HoaDonBanHang_Query(txtSearch_TT_HDBH.Text.Trim());
                    txtBH_MaHD.Text = txtSearch_TT_HDBH.Text.Trim();
                    flpnControlBanHang.Enabled = true;
                    txtTongTien.Text = Common._DoiSoSangDonViTienTe( sumTongTien(lst));
                   // MessageBox.Show("$=" + sumTongTien(lst));
                    msg = "Tìm thấy hóa đơn";
                }
                else
                {
                    dgvBH = null;
                    txtBH_MaHD.Text = "";
                    msg = "Không tìm thấy!";
                    txtSearch_TT_HDBH.Text = "";
                    txtSearch_TT_HDBH.Focus();
                }
            }
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgvBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0) return;
            //  MessageBox.Show("mahdbh-ngaylap-makh:"
            //      + dgvBH.Rows[row].Cells["MaHDBH"].Value.ToString()
            //    + dgvBH.Rows[row].Cells["NgayLap"].Value.ToString()
            //    + dgvBH.Rows[row].Cells["MaKH"].Value.ToString());

            txtBH_MaHD.Text = dgvBH.Rows[row].Cells["MaHDBH"].Value.ToString();
            dtk_NgayBan.Value = Convert.ToDateTime(dgvBH.Rows[row].Cells["NgayLap"].Value.ToString());
            cmbMaKH.SelectedValue = dgvBH.Rows[row].Cells["MaKH"].Value.ToString();
        }

        private void dgvBH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
