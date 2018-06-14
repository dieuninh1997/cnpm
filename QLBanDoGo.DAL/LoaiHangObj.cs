using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLBanDoGo.DAL
{
    public class LoaiHangObj
    {
        private string maLoai;
        private string tenLoai;

        public LoaiHangObj()
        {  }
        public LoaiHangObj(string maLoai, string tenLoai)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
        }
        public void LoaiHangIDataReader(SqlDataReader dr)
        {
            MaLoai = dr["MaLoai"] is DBNull ? string.Empty : dr["MaLoai"].ToString();
            TenLoai = dr["TenLoai"] is DBNull ? string.Empty : dr["TenLoai"].ToString();
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
    }
}
