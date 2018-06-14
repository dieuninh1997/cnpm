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
    public partial class FormBanHangThem : Form
    {
        bool isThem = false;
        string maHDBH = "";
        ChiTietHDBH obj = new ChiTietHDBH();

        HangHoaBUS hhBUS = new HangHoaBUS();
        LoaiHangBUS loaiHangBUS = new LoaiHangBUS();
        ChiTietHDBH_BUS cthdbhBUS = new ChiTietHDBH_BUS();

        UcBanHang ucBH = new UcBanHang();

        List<HangHoaObj> lst = null;


        public FormBanHangThem()
        {
            InitializeComponent();
        }
        public FormBanHangThem(bool isThem, string title, string maHDBH)
        {
            InitializeComponent();
            this.isThem = isThem;
            this.Text = title;
            this.maHDBH = maHDBH;
        }
        public FormBanHangThem(bool isThem, string title, string maHDBH, ChiTietHDBH obj)
        {
            InitializeComponent();
            this.isThem = isThem;
            this.Text = title;
            this.maHDBH = maHDBH;
            this.obj = obj;
        }
        private void Clear()
        {
            txtGia.Text = "";
            txtSoLuong.Text = "";
        }

        public void BindDataCmbHH()
        {

            lst = hhBUS.HangHoa_GetByTop("", "", "");
            lst.Insert(0, new HangHoaObj("0", "--Select All--"));
            cmbThemHH.DataSource = lst;
            cmbThemHH.DisplayMember = "TenHH";
            cmbThemHH.ValueMember = "MaHH";
            cmbThemHH.SelectedIndex = 0;
            txtGia.Text = "0";
        }

        private void FormBanHangThem_Load(object sender, EventArgs e)
        {
            txtGia.Enabled = false;
            Clear();
            BindDataCmbHH();
            if (!isThem)
            {
                cmbThemHH.SelectedValue = obj.MaHH;
                txtGia.Text = obj.GiaBan;
                txtSoLuong.Text = obj.SoLuongMua;
            }

        }

        private bool checkValid()
        {
            if (String.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {


                //them vao ct hoa don
                ChiTietHDBH hh = new ChiTietHDBH();
                hh.MaHDBH = maHDBH;
                if (String.IsNullOrEmpty(cmbThemHH.SelectedValue.ToString()))
                {
                    MessageBox.Show("Nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                    hh.MaHH = cmbThemHH.SelectedValue.ToString();

                HangHoaObj o1 = hhBUS.HangHoa_GetByTop("", "MaHH='" + hh.MaHH + "'", "")[0];
                hh.MaLoai = o1.MaLoai;
                hh.TenLoai = loaiHangBUS.LoaiHang_GetByTop("", "MaLoai='" + hh.MaLoai + "'", "")[0].TenLoai;
                hh.SoLuongMua = txtSoLuong.Text;
                hh.GiaBan = txtGia.Text;

                bool isExisted = false;
                var lst = new HoaDonBanHangBUS().HoaDonBanHang_Query("", " and tb_HDBanHang.MaHDBH='" + hh.MaHDBH + "' and tb_HangHoa.MaHH='" + hh.MaHH + "'", "");

                if (lst.Count == 1)
                {
                    isExisted = true;
                }
                else
                {
                    isExisted = false;
                }

                if (isThem)
                {
                    if (!isExisted)
                    {
                        if (cthdbhBUS.ChiTietHDBH_Insert(hh))
                            MessageBox.Show("Ok Add 1 item");
                        else
                            MessageBox.Show("Fail Add 1 item");

                    }
                    else
                    {
                        int sl = int.Parse(lst[0].SoLuongMua);
                        hh.SoLuongMua = (sl + int.Parse(txtSoLuong.Text)).ToString();

                        if (cthdbhBUS.ChiTietHDBH_Update(hh))
                        {
                            MessageBox.Show("Ok Add 1 item!");
                        }
                        else
                            MessageBox.Show(" Fail Add 1 item!");

                    }
                }
                else
                {
                    if (cthdbhBUS.ChiTietHDBH_Update(hh))
                    {
                        MessageBox.Show("Ok Update 1 item");
                    }
                    else
                    {
                        MessageBox.Show("Fail Update 1 item");

                    }
                }
                // ucBH.bindDataGridView();

            }
            else
            {
                txtSoLuong.Focus();
            }
        }

        private void cmbThemHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbThemHH.SelectedIndex > 0)
            {
                HangHoaObj i = lst[cmbThemHH.SelectedIndex];
                if (i.MaHH.Equals(cmbThemHH.SelectedValue))
                {
                    txtGia.Text = i.GiaBan.ToString();
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
