using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyGaraOto.DDo
{
    public class UniversalUser
    {
        private static UniversalUser ins;

        public static UniversalUser Ins { 
            get
            {
                if (ins == null) ins = new UniversalUser();
                return ins;
            } 
            private set => ins = value; 
        }
        public ACCOUNT account;
        public void SetUser(ACCOUNT ac)
        {
            account = ac;
        }
    }
    public static class ExitInforHolder
    {
        public static bool isQuit;
    }
}
