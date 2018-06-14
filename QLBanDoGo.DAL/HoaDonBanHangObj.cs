using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLBanDoGo.DAL
{
    public class HoaDonBanHangObj
    {
        private string maHDBH;
        private string maKH;
        private string maNV;
        private string ngayLap;
        private string tongTien;
        public HoaDonBanHangObj(string manv)
        {
            this.maNV = manv;
        }
        public void HoaDonBanHangIDataReader(SqlDataReader dr)
        {
            MaNV = dr["MaNV"] is DBNull ? string.Empty : dr["MaNV"].ToString();
            MaHDBH = dr["MaHDBH"] is DBNull ? "" : dr["MaHDBH"].ToString();
            MaKH = dr["MaKH"] is DBNull ? "" : dr["MaKH"].ToString();
            NgayLap = dr["NgayLap"] is DBNull ? "" : dr["NgayLap"].ToString();
            TongTien = dr["TongTien"] is DBNull ? "" : dr["TongTien"].ToString();
        }
        public HoaDonBanHangObj()
        {

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

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
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

        public string TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }
    }
}
