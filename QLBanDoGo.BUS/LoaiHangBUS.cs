using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanDoGo.DAL;

namespace QLBanDoGo.BUS
{
    public class LoaiHangBUS
    {
        private LoaiHangDAL obj = new LoaiHangDAL();
        public List<LoaiHangObj> LoaiHang_GetByTop(string Top, string Where, string Order)
        {
            return obj.LoaiHang_GetByTop(Top, Where, Order);
        }

    }
}
