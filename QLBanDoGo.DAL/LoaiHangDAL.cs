using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLBanDoGo.DAL
{
    public class LoaiHangDAL:SqlDataProvider
    {
        public List<LoaiHangObj> LoaiHang_GetByTop(string Top, string Where, string Order)
        {
            List<LoaiHangObj> list = new List<LoaiHangObj>();
            using (SqlCommand dbCmd = new SqlCommand("sp_LoaiHang_getByTop", openConnection()))
            {
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@Top", Top));
                dbCmd.Parameters.Add(new SqlParameter("@Where", Where));
                dbCmd.Parameters.Add(new SqlParameter("@Order", Order));
                SqlDataReader dr = dbCmd.ExecuteReader();
                dr.Close();
                dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        LoaiHangObj obj = new LoaiHangObj();
                        obj.LoaiHangIDataReader(dr);
                        list.Add(obj);
                    }
                }
                dr.Close();
            }
            return list;
        }

    }
}
