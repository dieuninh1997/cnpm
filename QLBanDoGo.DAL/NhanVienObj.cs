using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLBanDoGo.DAL
{
    public class NhanVienObj
    {
        private string maNV;
        private string tenNV;
        private string ngaySinh;
        private string diaChi;
        private string sDT;
        private string cMT;
        private string taiKhoan;
        private string matKhau;
        private string maCV;
        private string gioiTinh;

        public NhanVienObj()
        { }
        public NhanVienObj(string maNV, string tenNV, string ngs, string dc, string sdt, string cmt,
            string tk, string mk, string maCV, string gioiTinh)
        {
            this.gioiTinh = gioiTinh;
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.ngaySinh = ngs;
            this.diaChi = dc;
            this.sDT = sdt;
            this.cMT = cmt;
            this.taiKhoan = tk;
            this.matKhau = mk;
            this.maCV = maCV;

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

        public string TenNV
        {
            get
            {
                return tenNV;
            }

            set
            {
                tenNV = value;
            }
        }

        public string NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
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

        public string CMT
        {
            get
            {
                return cMT;
            }

            set
            {
                cMT = value;
            }
        }

        public string TaiKhoan
        {
            get
            {
                return taiKhoan;
            }

            set
            {
                taiKhoan = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public string MaCV
        {
            get
            {
                return maCV;
            }

            set
            {
                maCV = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public void NhanVienIDataReader(SqlDataReader dr)
        {
            MaNV = dr["MaNV"] is DBNull ? string.Empty : dr["MaNV"].ToString();
            TenNV = dr["TenNV"] is DBNull ? string.Empty : dr["TenNV"].ToString();
            NgaySinh = dr["NgaySinh"] is DBNull ? string.Empty : dr["NgaySinh"].ToString();
            DiaChi = dr["DiaChi"] is DBNull ? "" : dr["DiaChi"].ToString();
            SDT = dr["SDT"] is DBNull ? "" : dr["SDT"].ToString();
            CMT = dr["CMT"] is DBNull ? "" : dr["CMT"].ToString();
            TaiKhoan = dr["TaiKhoan"] is DBNull ? "" : dr["TaiKhoan"].ToString();
            MatKhau = dr["MatKhau"] is DBNull ? "" : dr["MatKhau"].ToString();
            MaCV = dr["MaCV"] is DBNull ? "" : dr["MaCV"].ToString();
            GioiTinh = dr["GioiTinh"] is DBNull ? "" : dr["GioiTinh"].ToString();
            //avatar
            //   Avatar = dr["avatar"] is DBNull ? "" : dr["avatar"].ToString();
        }
    }
}
