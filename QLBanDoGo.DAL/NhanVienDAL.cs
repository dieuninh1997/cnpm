using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLBanDoGo.DAL
{
    public class NhanVienDAL: SqlDataProvider
    {
        public List<NhanVienObj> NhanVien_GetByTop(string Top, string Where, string Order)
        {
            List<NhanVienObj> list = new List<NhanVienObj>();
            using (SqlCommand dbCmd = new SqlCommand("sp_NhanVien_getByTop", openConnection()))
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
                        NhanVienObj obj = new NhanVienObj();
                        obj.NhanVienIDataReader(dr);
                        list.Add(obj);
                    }
                }
                dr.Close();
            }
            return list;
        }

        public bool NhanVien_Insert(NhanVienObj data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_NhanVien_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@TenNV", data.TenNV));
                    dbCmd.Parameters.Add(new SqlParameter("@DiaChi", data.DiaChi));
                    dbCmd.Parameters.Add(new SqlParameter("@NgaySinh", data.NgaySinh));
                    dbCmd.Parameters.Add(new SqlParameter("@SDT", data.SDT));
                    dbCmd.Parameters.Add(new SqlParameter("@CMT", data.CMT));
                    dbCmd.Parameters.Add(new SqlParameter("@TaiKhoan", data.TaiKhoan));
                    dbCmd.Parameters.Add(new SqlParameter("@MatKhau", data.MatKhau));
                    dbCmd.Parameters.Add(new SqlParameter("@MaCV", data.MaCV));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }

        public bool NhanVien_Update(NhanVienObj data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_NhanVien_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@MaNV", data.MaNV));
                    dbCmd.Parameters.Add(new SqlParameter("@TenNV", data.TenNV));
                    dbCmd.Parameters.Add(new SqlParameter("@DiaChi", data.DiaChi));
                    dbCmd.Parameters.Add(new SqlParameter("@NgaySinh", data.NgaySinh));
                    dbCmd.Parameters.Add(new SqlParameter("@SDT", data.SDT));
                    dbCmd.Parameters.Add(new SqlParameter("@CMT", data.CMT));
                    dbCmd.Parameters.Add(new SqlParameter("@TaiKhoan", data.TaiKhoan));
                    dbCmd.Parameters.Add(new SqlParameter("@MatKhau", data.MatKhau));
                    dbCmd.Parameters.Add(new SqlParameter("@MaCV", data.MaCV));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }
        //
        public bool NhanVien_ChangeKey(NhanVienObj data)
        {
            bool check = false;
         //   try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_NhanVien_ChangeKey", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@MaNV", data.MaNV));
                    dbCmd.Parameters.Add(new SqlParameter("@MatKhau", data.MatKhau));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
          //  catch
            {
            }
            return check;
        }
        public bool NhanVien_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_NhanVien_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@MaNV", ID));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }

        public bool NhanVien_LoginValid(String u, String p)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_NhanVien_LoginValid", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@TaiKhoan", u));
                    dbCmd.Parameters.Add(new SqlParameter("@MatKhau", p));
                    int r = (int)dbCmd.ExecuteScalar();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }

        public String getIdNhanVien(String u, String p)
        {
            String id="";
           // try
            {
                SqlCommand cmd = new SqlCommand("select manv from tb_NhanVien where TaiKhoan = '" + u.Trim() + "' and MatKhau = '" + p.Trim() + "'", openConnection());
                using (SqlDataReader r=cmd.ExecuteReader())
                {
                    if (r.Read())
                        id = r["MaNV"].ToString();
                }
            }
         //   catch
            {

            }
            return id;
        }
    }
}
