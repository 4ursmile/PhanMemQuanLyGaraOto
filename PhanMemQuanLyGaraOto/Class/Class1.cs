using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyGaraOto.Class
{
    public class UniversalSetting
    {
        private static UniversalSetting instance;
        public static UniversalSetting Instance => instance ?? (instance = new UniversalSetting());
        private UniversalSetting()
        {
            isNotiDataOn = true;
            isNotiGeneralOn = false;
        }
        public bool isNotiDataOn;
        public bool isNotiGeneralOn;
    }
}
