using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanDoGo.DAL;

namespace QLBanDoGo.BUS
{
    public class ChiTietHDBH_BUS
    {
        private ChiTietHDBH_DAL obj = new ChiTietHDBH_DAL();
        public List<ChiTietHDBH> ChiTietHDBH_GetByTop(string Top, string Where, string Order)
        {
            return obj.ChiTietHDBH_GetByTop(Top, Where, Order);
        }
        public bool ChiTietHDBH_Insert(ChiTietHDBH data)
        {
            return obj.ChiTietHDBH_Insert(data);
        }

        public bool ChiTietHDBH_Update(ChiTietHDBH data)
        {
            return obj.ChiTietHDBH_Update(data);
        }

        public bool ChiTietHDBH_Delete(string idHD, string idHH)
        {
            return obj.ChiTietHDBH_Delete(idHD, idHH);
        }
    }
}
