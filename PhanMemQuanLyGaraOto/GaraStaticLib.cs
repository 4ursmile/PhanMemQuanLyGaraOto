using System;

namespace PhanMemQuanLyGaraOto
{
    public static class SuperHash
    {
        private const int hasMod1 = 524287;
        private const int hasMod2 = 8388607;

        private static int function(int value, int index)
        {
            return value * index * index - value * 3 + index * 2;
        }
        private static long hashfunction(int value, int index, int delta = 0)
        {
            long res = value * (index + 2 + delta) * (((int)Math.Pow(value, index + 1 + delta)) % hasMod1);
            return res;
        }
        public static string GetHashPassWord(string password)
        {
            int len = password.Length;
            string hasPass = "";
            long hash1 = 0, hash2 = 0;
            for (int i = 0; i < len; i++)
            {
                hash1 = (hash1 % hasMod1 + hashfunction((int)password[i], i) % hasMod1) % hasMod1;
                hash2 = (hash2 % hasMod2 + hashfunction((int)password[i], i, 2) % hasMod2) % hasMod2;
                hasPass += function((int)password[i], i).ToString();
            }
            hasPass += "eq|" + hash1.ToString() + hash2.ToString();
            return hasPass;
        }
    }
    public static class PosNameMap
    {
        private static string[] map = { "Quản trị viên", "Quản lý", "Nhân viên" };
        public static string GetAccountPosName(int type)
        {
            return map[type];
        }

    }
}
