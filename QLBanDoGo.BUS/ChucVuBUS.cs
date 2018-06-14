using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanDoGo.DAL;

namespace QLBanDoGo.BUS
{
    public class ChucVuBUS
    {
        private ChucVuDAL obj = new ChucVuDAL();
        public List<ChucVuObj> ChucVu_GetByTop(string Top, string Where, string Order)
        {
            return obj.ChucVu_GetByTop(Top, Where, Order);
        }
    }
}
