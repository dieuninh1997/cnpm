using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLBanDoGo.DAL
{
    public class HangHoaDAL:SqlDataProvider
    {
        public List<HangHoaObj> HangHoa_GetByTop(string Top, string Where, string Order)
        {
            List<HangHoaObj> list = new List<HangHoaObj>();
            using (SqlCommand dbCmd = new SqlCommand("sp_HangHoa_getByTop", openConnection()))
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
                        HangHoaObj obj = new HangHoaObj();
                        obj.HangHoaIDataReader(dr);
                        list.Add(obj);
                    }
                }
                dr.Close();
            }
            return list;
        }

        public bool HangHoa_Insert(HangHoaObj data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_HangHoa_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@TenHH", data.TenHH));
                    dbCmd.Parameters.Add(new SqlParameter("@SoLuong", data.SoLuong));
                    dbCmd.Parameters.Add(new SqlParameter("@GiaBan", data.GiaBan));
                    dbCmd.Parameters.Add(new SqlParameter("@MaLoai", data.MaLoai));
                    dbCmd.Parameters.Add(new SqlParameter("@MoTa", data.MoTa));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }
        public bool HangHoa_Update(HangHoaObj data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_HangHoa_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@MaHH", data.MaHH));
                    dbCmd.Parameters.Add(new SqlParameter("@TenHH", data.TenHH));
                    dbCmd.Parameters.Add(new SqlParameter("@SoLuong", data.SoLuong));
                    dbCmd.Parameters.Add(new SqlParameter("@GiaBan", data.GiaBan));
                    dbCmd.Parameters.Add(new SqlParameter("@MaLoai", data.MaLoai));
                    dbCmd.Parameters.Add(new SqlParameter("@MoTa", data.MoTa));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }

        public bool HangHoa_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_HangHoa_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@MaHH", ID));
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
