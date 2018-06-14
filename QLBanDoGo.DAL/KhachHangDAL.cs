using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLBanDoGo.DAL
{
    public class KhachHangDAL:SqlDataProvider
    {
        public List<KhachHangObj> KhachHang_GetByTop(string Top, string Where, string Order)
        {
            List<KhachHangObj> list = new List<KhachHangObj>();
            using (SqlCommand dbCmd = new SqlCommand("sp_KhachHang_getByTop", openConnection()))
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
                        KhachHangObj obj = new KhachHangObj();
                        obj.KhachHangIDataReader(dr);
                        list.Add(obj);
                    }
                }
                dr.Close();
            }
            return list;
        }

        public bool KhachHang_Insert(KhachHangObj data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_KhachHang_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@TenKH", data.TenKH));
                    dbCmd.Parameters.Add(new SqlParameter("@DiaChi", data.DiaChi));
                    dbCmd.Parameters.Add(new SqlParameter("@SDT", data.SDT));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }

        public bool KhachHang_Update(KhachHangObj data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_KhachHang_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@MaKH", data.MaKH));
                    dbCmd.Parameters.Add(new SqlParameter("@TenKH", data.TenKH));
                    dbCmd.Parameters.Add(new SqlParameter("@DiaChi", data.DiaChi));
                    dbCmd.Parameters.Add(new SqlParameter("@SDT", data.SDT));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }

        public bool KhachHang_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_KhachHang_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@MaKH", ID));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }

    }
}
