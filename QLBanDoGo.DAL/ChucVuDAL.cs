using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLBanDoGo.DAL
{
    public class ChucVuDAL:SqlDataProvider
    {

        public List<ChucVuObj> ChucVu_GetByTop(string Top, string Where, string Order)
        {
            List<ChucVuObj> list = new List<ChucVuObj>();
            using (SqlCommand dbCmd = new SqlCommand("sp_ChucVu_getByTop", openConnection()))
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
                        ChucVuObj obj = new ChucVuObj();
                        obj.ChucVuIDataReader(dr);
                        list.Add(obj);
                    }
                }
                dr.Close();
            }
            return list;
        }

    }
}
