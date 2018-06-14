using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLBanDoGo.DAL
{
    public class HangHoaObj
    {
        private string maHH;
        private string tenHH;
        private string soLuong;
        private string giaBan;
        private string maLoai;
        private string moTa;

        public string MaHH
        {
            get
            {
                return maHH;
            }

            set
            {
                maHH = value;
            }
        }

        public string TenHH
        {
            get
            {
                return tenHH;
            }

            set
            {
                tenHH = value;
            }
        }

        public string SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public string GiaBan
        {
            get
            {
                return giaBan;
            }

            set
            {
                giaBan = value;
            }
        }

        public string MaLoai
        {
            get
            {
                return maLoai;
            }

            set
            {
                maLoai = value;
            }
        }

        public string MoTa
        {
            get
            {
                return moTa;
            }

            set
            {
                moTa = value;
            }
        }

        public HangHoaObj()
        { }

        public HangHoaObj(string maHH, string tenHH, string sl, string gia, string maLoai, string mt)
        {
            this.MaHH = maHH;
            this.TenHH = tenHH;
            this.SoLuong = sl;
            this.GiaBan = gia;
            this.MaLoai = maLoai;
            this.MoTa = mt;
        }
        public HangHoaObj(string maHH, string tenHH)
        {
            this.MaHH = maHH;
            this.TenHH = tenHH;
            this.SoLuong = "";
            this.GiaBan = "";
            this.MaLoai = "";
            this.MoTa = "";
        }
        public void HangHoaIDataReader(SqlDataReader dr)
        {
            MaHH = dr["MaHH"] is DBNull ? string.Empty : dr["MaHH"].ToString();
            TenHH = dr["TenHH"] is DBNull ? string.Empty : dr["TenHH"].ToString();
            SoLuong = dr["SoLuong"] is DBNull ? string.Empty : dr["SoLuong"].ToString();
            GiaBan = dr["GiaBan"] is DBNull ? "" : dr["GiaBan"].ToString();
            MaLoai = dr["MaLoai"] is DBNull ? "" : dr["MaLoai"].ToString();
            MoTa = dr["MoTa"] is DBNull ? "" : dr["MoTa"].ToString();
        }

    }
}
