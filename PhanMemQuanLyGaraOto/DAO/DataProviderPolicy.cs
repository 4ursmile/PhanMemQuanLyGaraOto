using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.DAO
{
    public partial class DataProvider
    {
        public void UpdatePolicy(THAMSO THAMSO, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (THAMSO == null) return;
                THAMSO tmp = db.THAMSOes.Where(a => a.MATHAMSO == THAMSO.MATHAMSO).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strUpdate + nameof(THAMSO), FrontEndError);
                    return;
                }
                db.Entry(tmp).CurrentValues.SetValues(THAMSO);
                SaveChange();
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại, Kết nối với máy chủ bị gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strUpdate + nameof(THAMSO), BackEndError);
            }
            foreach (var func in LoadWhendones)
            {
                func?.Invoke();
            }
        }
        public THAMSO getSoXeSuaChuaToiDa()
        {
            return db.THAMSOes.Where(a => a.MATHAMSO == 1).FirstOrDefault();
        }
        public THAMSO getTyLeLinhKienBanRa()
        {
            return db.THAMSOes.Where(a => a.MATHAMSO == 3).FirstOrDefault();
        }
        public THAMSO getBoolInOverOut()
        {
            return db.THAMSOes.Where(a => a.MATHAMSO == 2).FirstOrDefault();
        }
    }
}
