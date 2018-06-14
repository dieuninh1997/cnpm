using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLBanDoGo.DAL
{
    public class HoaDonBanHangDAL: SqlDataProvider
    {
        public List<HoaDonBanHangObj> HoaDonBanHang_GetByTop(string Top, string Where, string Order)
        {
            List<HoaDonBanHangObj> list = new List<HoaDonBanHangObj>();
            using (SqlCommand dbCmd = new SqlCommand("sp_HoaDonBanHang_getByTop", openConnection()))
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
                        HoaDonBanHangObj obj = new HoaDonBanHangObj();
                        obj.HoaDonBanHangIDataReader(dr);
                        list.Add(obj);
                    }
                }
                dr.Close();
            }
            return list;
        }

        public List<ChiTietHDBH> HoaDonBanHang_Query(string mahdbh)
        {
            List<ChiTietHDBH> list = new List<ChiTietHDBH>();
            string query = "select tb_HDBanHang.*, tb_CTHDBanHang.SoLuong, tb_CTHDBanHang.GiaBan, tb_CTHDBanHang.MaHH, tb_HangHoa.TenHH," +
                       " tb_HangHoa.MaLoai, tb_LoaiHangHoa.TenLoai from tb_HDBanHang, tb_CTHDBanHang, tb_HangHoa, tb_LoaiHangHoa " +
                       "where tb_HDBanHang.MaHDBH = tb_CTHDBanHang.MaHDBH and tb_CTHDBanHang.MaHH = tb_HangHoa.MaHH and" +
                       " tb_HangHoa.MaLoai = tb_LoaiHangHoa.MaLoai and tb_HDBanHang.MaHDBH = '" + mahdbh + "'";
            using (SqlCommand dbCmd = new SqlCommand(query, openConnection()))
            {
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
        public List<ChiTietHDBH> HoaDonBanHang_Query(string top, string where, string order)
        {
            List<ChiTietHDBH> list = new List<ChiTietHDBH>();
            string query = "select tb_HDBanHang.*, tb_CTHDBanHang.SoLuong, tb_CTHDBanHang.GiaBan, tb_CTHDBanHang.MaHH, tb_HangHoa.TenHH," +
                       " tb_HangHoa.MaLoai, tb_LoaiHangHoa.TenLoai from tb_HDBanHang, tb_CTHDBanHang, tb_HangHoa, tb_LoaiHangHoa " +
                       "where tb_HDBanHang.MaHDBH = tb_CTHDBanHang.MaHDBH and tb_CTHDBanHang.MaHH = tb_HangHoa.MaHH and" +
                       " tb_HangHoa.MaLoai = tb_LoaiHangHoa.MaLoai " + where ;
            using (SqlCommand dbCmd = new SqlCommand(query, openConnection()))
            {
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
        public bool HoaDonBanHang_Insert(HoaDonBanHangObj data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_HoaDonBanHang_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@NgayLap", data.NgayLap));
                    dbCmd.Parameters.Add(new SqlParameter("@TongTien", data.TongTien));
                    dbCmd.Parameters.Add(new SqlParameter("@MaNV", data.MaNV));
                    dbCmd.Parameters.Add(new SqlParameter("@MaKH", data.MaKH));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }
        //sp_HoaDonBanHang_Insert_ByMaNV

        public bool HoaDonBanHang_Insert_ByMaNV(HoaDonBanHangObj data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_HoaDonBanHang_Insert_ByMaNV", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@MaNV", data.MaNV));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }
        public bool HoaDonBanHang_Update(HoaDonBanHangObj data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_HoaDonBanHang_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@MaHDBH", data.MaHDBH));
                    dbCmd.Parameters.Add(new SqlParameter("@NgayLap", data.NgayLap));
                    dbCmd.Parameters.Add(new SqlParameter("@TongTien", data.TongTien));
                    dbCmd.Parameters.Add(new SqlParameter("@MaNV", data.MaNV));
                    dbCmd.Parameters.Add(new SqlParameter("@MaKH", data.MaKH));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }

        public bool HoaDonBanHang_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_HoaDonBanHang_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@MaHDBH", ID));
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
