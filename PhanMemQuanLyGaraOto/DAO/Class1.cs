
using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance { 
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            } 
            private set => instance = value; }
        public GARAOTOEntities db;
        private DataProvider()
        {
            db = new GARAOTOEntities();
        }
        public void SaveChange()
        {
            db.SaveChanges();
        }
        public void SaveAccount(ACCOUNT aCCOUNT,params AlertNonPara[] Loadawhendones)
        {
            if (aCCOUNT == null) return;
            ACCOUNT tmp = db.ACCOUNTs.Where(a => a.USERNAME == aCCOUNT.USERNAME).First();
            if (tmp != null)
            {
                MessageBox.Show("Người dùng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            db.ACCOUNTs.Add(aCCOUNT);
            db.SaveChanges();
            foreach (var donefunc in Loadawhendones)
            {
                donefunc?.Invoke();
            }
        }
        public void UpdateAccount(ACCOUNT aCCOUNT)
        {
            ACCOUNT tmp = db.ACCOUNTs.Where(a => a.USERID == aCCOUNT.USERID).FirstOrDefault();
            if (tmp != null)
                db.Entry(tmp).CurrentValues.SetValues(aCCOUNT);
            SaveChange();
        }

    }
}
