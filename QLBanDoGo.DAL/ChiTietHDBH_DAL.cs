using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace QLBanDoGo.DAL
{
    public class ChiTietHDBH_DAL:SqlDataProvider
    {
        public List<ChiTietHDBH> ChiTietHDBH_GetByTop(string Top, string Where, string Order)
        {
            List<ChiTietHDBH> list = new List<ChiTietHDBH>();
            using (SqlCommand dbCmd = new SqlCommand("sp_ChiTietHDBH_getByTop", openConnection()))
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
                        ChiTietHDBH obj = new ChiTietHDBH();
                        obj.ChiTietHDBHIDataReader(dr);
                        list.Add(obj);
                    }
                }
                dr.Close();
            }
            return list;
        }

       


        public bool ChiTietHDBH_Insert(ChiTietHDBH data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_ChiTietHDBH_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@MaHDBH", data.MaHDBH));
                    dbCmd.Parameters.Add(new SqlParameter("@SoLuong", data.SoLuongMua));
                    dbCmd.Parameters.Add(new SqlParameter("@GiaBan", data.GiaBan));
                    dbCmd.Parameters.Add(new SqlParameter("@MaHH", data.MaHH));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }
        public bool ChiTietHDBH_Update(ChiTietHDBH data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_ChiTietHDBH_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@MaHDBH", data.MaHDBH));
                    dbCmd.Parameters.Add(new SqlParameter("@SoLuong", data.SoLuongMua));
                    dbCmd.Parameters.Add(new SqlParameter("@GiaBan", data.GiaBan));
                    dbCmd.Parameters.Add(new SqlParameter("@MaHH", data.MaHH));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }

        public bool ChiTietHDBH_Delete(string idHDBH, string idHH)
        {
            bool check = false;
            //try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_ChiTietHDBH_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@MaHH", idHH));
                    dbCmd.Parameters.Add(new SqlParameter("@MaHDBH", idHDBH));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
         //   catch
            {
            }
            return check;
        }

    }
}
