using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanDoGo.DAL;

namespace QLBanDoGo.BUS
{
    public class HangHoaBUS
    {
        private HangHoaDAL obj = new HangHoaDAL();
        public List<HangHoaObj> HangHoa_GetByTop(string Top, string Where, string Order)
        {
            return obj.HangHoa_GetByTop(Top, Where, Order);
        }
   /*     public bool HangHoa_Insert(HangHoaObj data)
        {
            return obj.HangHoa_Insert(data);
        }
        */
     
        
    }
}
