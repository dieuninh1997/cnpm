using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLBanDoGo.DAL
{
    public class ChiTietHDBH
    {
        private string maHH;
        private string soLuongMua;
        private string giaBan;
        private string maHDBH;
        private string ngayLap;
        private string maKH;
        //
        private string tenHH;
        private string maLoai;
        private string tenLoai;

        public ChiTietHDBH()
        {
        }
        public ChiTietHDBH(string maHDBH, string maHH, string soLuong, string giaBan)
        {
            this.maHDBH = maHDBH;
            this.maHH = maHH;
            this.soLuongMua = soLuong;
            this.giaBan = giaBan;
        }

        public void ChiTietHDBHIDataReader(SqlDataReader dr)
        {
            MaHDBH = dr["MaHDBH"] is DBNull ? string.Empty : dr["MaHDBH"].ToString();
            MaLoai = dr["MaLoai"] is DBNull ? string.Empty : dr["MaLoai"].ToString();
            TenLoai = dr["TenLoai"] is DBNull ? string.Empty : dr["TenLoai"].ToString();
            TenHH = dr["TenHH"] is DBNull ? string.Empty : dr["TenHH"].ToString();
            MaHH = dr["MaHH"] is DBNull ? string.Empty : dr["MaHH"].ToString();
            SoLuongMua = dr["SoLuong"] is DBNull ? string.Empty : dr["SoLuong"].ToString();
            GiaBan = dr["GiaBan"] is DBNull ? "" : dr["GiaBan"].ToString();
            NgayLap = dr["NgayLap"] is DBNull ? "" : dr["NgayLap"].ToString();
            MaKH = dr["MaKH"] is DBNull ? "" : dr["MaKH"].ToString();
        }
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

        public string SoLuongMua
        {
            get
            {
                return soLuongMua;
            }

            set
            {
                soLuongMua = value;
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

        public string MaHDBH
        {
            get
            {
                return maHDBH;
            }

            set
            {
                maHDBH = value;
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

        public string TenLoai
        {
            get
            {
                return tenLoai;
            }

            set
            {
                tenLoai = value;
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

        public string NgayLap
        {
            get
            {
                return ngayLap;
            }

            set
            {
                ngayLap = value;
            }
        }

        public string MaKH
        {
            get
            {
                return maKH;
            }

            set
            {
                maKH = value;
            }
        }
    }
}
