using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanDoGo.DAL;
using System.Drawing.Printing;

namespace QLBanDoGo
{
    public partial class FormBanHangIn : Form
    {
        List<ChiTietHDBH> objList;
        string tongTien = "0";
        string tenKH, tenNV;
        public FormBanHangIn(List<ChiTietHDBH> objList, string sum, string tenKH, string tenNV)
        {
            InitializeComponent();
            this.objList = objList;
            this.tongTien = sum;
            this.tenKH = tenKH;
            this.tenNV = tenNV;
        }

        private void showViews()
        {
            nudTongTien.Value = long.Parse(tongTien.Replace(",", ""));
        }
        public void bindDataGridView()
        {
            dgvDsHangHoaMua.DataSource = null;
            //chi tiet hoa don
            dgvDsHangHoaMua.DataSource = objList;

            dgvDsHangHoaMua.Columns["MaHDBH"].DisplayIndex = 0;
            dgvDsHangHoaMua.Columns["MaHDBH"].HeaderText = "Mã hóa đơn";
            dgvDsHangHoaMua.Columns["MaHDBH"].Visible = false;


            dgvDsHangHoaMua.Columns["MaHH"].DisplayIndex = 1;
            dgvDsHangHoaMua.Columns["MaHH"].HeaderText = "Mã hàng hóa";

            dgvDsHangHoaMua.Columns["TenHH"].DisplayIndex = 2;
            dgvDsHangHoaMua.Columns["TenHH"].HeaderText = "Tên hàng hóa";

            dgvDsHangHoaMua.Columns["MaLoai"].DisplayIndex = 3;
            dgvDsHangHoaMua.Columns["MaLoai"].HeaderText = "Mã loại";
            dgvDsHangHoaMua.Columns["MaLoai"].Visible = false;

            dgvDsHangHoaMua.Columns["TenLoai"].DisplayIndex = 4;
            dgvDsHangHoaMua.Columns["TenLoai"].HeaderText = "Tên loại hàng";

            dgvDsHangHoaMua.Columns["SoLuongMua"].DisplayIndex = 5;
            dgvDsHangHoaMua.Columns["SoLuongMua"].HeaderText = "Số lượng mua";

            dgvDsHangHoaMua.Columns["GiaBan"].DisplayIndex = 6;
            dgvDsHangHoaMua.Columns["GiaBan"].HeaderText = "Giá";

            dgvDsHangHoaMua.Columns["NgayLap"].DisplayIndex = 7;
            dgvDsHangHoaMua.Columns["NgayLap"].HeaderText = "Ngày mua";
            dgvDsHangHoaMua.Columns["NgayLap"].Visible = false;


            dgvDsHangHoaMua.Columns["MaKH"].DisplayIndex = 8;
            dgvDsHangHoaMua.Columns["MaKH"].HeaderText = "Mã kh";
            dgvDsHangHoaMua.Columns["MaKH"].Visible = false;

        }


        private void FormBanHangIn_Load(object sender, EventArgs e)
        {
            bindDataGridView();
            showViews();
        }


        private void nudTienMat_ValueChanged(object sender, EventArgs e)
        {
            nudTienTra.Value = nudTienMat.Value - long.Parse(tongTien.Replace(",", ""));
        }

        private void _CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);


            graphic.DrawString("KDC Chùa Vần – Phường Chí Minh – Thị xã Chí Linh – Tỉnh Hải Dương", new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)FontHeight; //make the spacing consistent

            graphic.DrawString("SDT liên hệ : 0985105768", new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)FontHeight + 20; //make the spacing consistent

            string khach = "Khách hàng: " + tenKH;
            graphic.DrawString(khach, font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)FontHeight; //make the spacing consistent

            string nhanVien = "Nhân viên: " + tenNV;
            graphic.DrawString(nhanVien, font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)FontHeight; //make the spacing consistent

            string ngay = "Ngày: " + objList[0].NgayLap;
            graphic.DrawString(ngay, font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)FontHeight+20; //make the spacing consistent

            string top = "Mã HH".PadRight(14) + "Tên HH".PadRight(14) + "Loại hàng".PadRight(14) + "SL mua".PadRight(15) + "Giá bán";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)FontHeight; //make the spacing consistent

            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            foreach (ChiTietHDBH item in objList)
            {
                graphic.DrawString(item.MaHH, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(item.TenHH, font, new SolidBrush(Color.Black), startX + 150, startY + offset);
                graphic.DrawString(item.TenLoai, font, new SolidBrush(Color.Black), startX + 2 * 150, startY + offset);
                graphic.DrawString(item.SoLuongMua, font, new SolidBrush(Color.Black), startX + 3 * 150, startY + offset);
                graphic.DrawString(Common._DoiSoSangDonViTienTe(item.GiaBan), font, new SolidBrush(Color.Black), startX + 4 * 150, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            }

            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("Tổng tiền hóa đơn ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(Common._DoiSoSangDonViTienTe(nudTongTien.Value), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Tiền mặt ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(Common._DoiSoSangDonViTienTe(nudTienMat.Value), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Tiền trả ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(Common._DoiSoSangDonViTienTe(nudTienTra.Value), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString(" Xin cảm ơn quý khách !", font, new SolidBrush(Color.Black), startX, startY + offset);
            // offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            // graphic.DrawString(" please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                //  PrintDialog _PrintDialog = new PrintDialog();
                PrintDocument _PrintDocument = new PrintDocument();
                //  _PrintDialog.Document = _PrintDocument; //add the document to the dialog box

                _PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(_CreateReceipt); //add an event handler that will do the printing
                                                                                                               //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                                                                                                               //  DialogResult result = _PrintDialog.ShowDialog();

                //  if (result == DialogResult.OK)
                {
                    _PrintDocument.Print();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
