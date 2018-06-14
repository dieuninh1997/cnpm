using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanDoGo.DAL;

namespace QLBanDoGo.BUS
{
   public class KhachHangBUS
    {
        private KhachHangDAL obj = new KhachHangDAL();
        public List<KhachHangObj> KhachHang_GetByTop(string Top, string Where, string Order)
        {
            return obj.KhachHang_GetByTop(Top, Where, Order);
        }
        public bool KhachHang_Insert(KhachHangObj data)
        {
            return obj.KhachHang_Insert(data);
        }

        public bool KhachHang_Update(KhachHangObj data)
        {
            return obj.KhachHang_Update(data);
        }
        public bool KhachHang_Delete(string ID)
        {
            return obj.KhachHang_Delete(ID);
        }
    }
}
