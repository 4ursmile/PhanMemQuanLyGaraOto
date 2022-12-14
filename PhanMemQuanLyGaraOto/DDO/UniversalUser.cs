using PhanMemQuanLyGaraOto.Model;

namespace PhanMemQuanLyGaraOto.DDo
{
    public class UniversalUser
    {
        private static UniversalUser ins;

        public static UniversalUser Ins
        {
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
        private static bool Logout;
        public static bool IsLogout
        {
            get
            {
                if (Logout == true)
                {
                    Logout = false;
                    return true;
                }
                return false;
            }
            set { Logout = value; }
        }
    }
}
