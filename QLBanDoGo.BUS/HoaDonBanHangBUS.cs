using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanDoGo.DAL;

namespace QLBanDoGo.BUS
{
    public class HoaDonBanHangBUS
    {
        private HoaDonBanHangDAL obj = new HoaDonBanHangDAL();
        public List<HoaDonBanHangObj> HoaDonBanHang_GetByTop(string Top, string Where, string Order)
        {
            return obj.HoaDonBanHang_GetByTop(Top, Where, Order);
        }
        public List<ChiTietHDBH> HoaDonBanHang_Query(string mahdbh)
        {
            return obj.HoaDonBanHang_Query(mahdbh);
        }

        public List<ChiTietHDBH> HoaDonBanHang_Query(string Top, string Where, string Order)
        {
            return obj.HoaDonBanHang_Query(Top, Where, Order);
        }
        public bool HoaDonBanHang_Insert(HoaDonBanHangObj data)
        {
            return obj.HoaDonBanHang_Insert(data);
        }
        public bool HoaDonBanHang_Insert_ByMaNV(HoaDonBanHangObj data)
        {
            return obj.HoaDonBanHang_Insert_ByMaNV(data);
        }
        public bool HoaDonBanHang_Update(HoaDonBanHangObj data)
        {
            return obj.HoaDonBanHang_Update(data);
        }

        public bool HoaDonBanHang_Delete(string ID)
        {
            return obj.HoaDonBanHang_Delete(ID);
        }
    }
}
