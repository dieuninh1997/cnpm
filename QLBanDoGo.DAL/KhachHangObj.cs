using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLBanDoGo.DAL
{
    public class KhachHangObj
    {
        private String maKH;
        private String tenKH;
        private String diaChi;
        private String sDT;

        public KhachHangObj()
        { }


        public KhachHangObj(String maKH, String tenKH)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.diaChi = "";
            this.sDT = "";
        }

        public KhachHangObj(String maKH, String tenKH, String diaChi, String sdt)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.diaChi = diaChi;
            this.sDT = sdt;
        }

        public void KhachHangIDataReader(SqlDataReader dr)
        {
            MaKH = dr["MaKH"] is DBNull ? string.Empty : dr["MaKH"].ToString();
            TenKH = dr["TenKH"] is DBNull ? string.Empty : dr["TenKH"].ToString();
            DiaChi = dr["DiaChi"] is DBNull ? "" : dr["DiaChi"].ToString();
            SDT = dr["SDT"] is DBNull ? "" : dr["SDT"].ToString();
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

        public string TenKH
        {
            get
            {
                return tenKH;
            }

            set
            {
                tenKH = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string SDT
        {
            get
            {
                return sDT;
            }

            set
            {
                sDT = value;
            }
        }
    }
}
