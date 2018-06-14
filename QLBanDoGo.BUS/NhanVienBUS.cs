using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanDoGo.DAL;

namespace QLBanDoGo.BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAL obj = new NhanVienDAL();
        public List<NhanVienObj> NhanVien_GetByTop(string Top, string Where, string Order)
        {
            return obj.NhanVien_GetByTop(Top, Where, Order);
        }
        public bool NhanVien_Insert(NhanVienObj data)
        {
            return obj.NhanVien_Insert(data);
        }

        public bool NhanVien_Update(NhanVienObj data)
        {
            return obj.NhanVien_Update(data);
        }
        public bool NhanVien_ChangeKey(NhanVienObj data)
        {
            return obj.NhanVien_ChangeKey(data);
        }
        public bool NhanVien_Delete(string ID)
        {
            return obj.NhanVien_Delete(ID);
        }
        public bool NhanVien_LoginValid(String u, String p)
        {
            return obj.NhanVien_LoginValid(u, p);
        }

        public String getIdNhanVien(String u, String p)
        {
            return obj.getIdNhanVien(u, p);
        }
    }
}
