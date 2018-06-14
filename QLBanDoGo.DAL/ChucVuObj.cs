using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLBanDoGo.DAL
{
    public class ChucVuObj
    {
        private string maCV;
        private string tenCV;
        public ChucVuObj()
        {

        }

        public ChucVuObj(string macv, string tencv)
        {
            this.maCV = macv;
            this.tenCV = tencv;
        }
        public void ChucVuIDataReader(SqlDataReader dr)
        {
            MaCV = dr["MaCV"] is DBNull ? string.Empty : dr["MaCV"].ToString();
            TenCV = dr["TenCV"] is DBNull ? string.Empty : dr["TenCV"].ToString();
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

        public string TenCV
        {
            get
            {
                return tenCV;
            }

            set
            {
                tenCV = value;
            }
        }
    }
}
