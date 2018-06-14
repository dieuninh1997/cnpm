using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDoGo
{
    public class Common
    {
        public static string _DoiSoSangDonViTienTe(object _object)
        {
            try
            {
                if (_object.ToString().Trim().Length == 0)
                { return " "; }

                if (_object.ToString() == "0")
                {
                    return "0,000";
                }

                decimal dThanhTien = Convert.ToDecimal(_object);
                string strThanhTien = string.Format("{0:#,#.}", dThanhTien);
                return strThanhTien;
            }
            catch (Exception)
            {

            }
            return "0.000";
        }
    }
}
