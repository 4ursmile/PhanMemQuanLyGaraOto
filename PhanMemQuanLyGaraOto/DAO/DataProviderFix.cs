using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.ApplicationModel.Calls;
using Windows.UI.Xaml.Controls;

namespace PhanMemQuanLyGaraOto.DAO
{
    public partial class DataProvider
    {
        public PHIEUSUACHUA GetPHIEUSUACHUA(int maxe)
        {
            using (GARAOTOEntities db = new GARAOTOEntities())
            {
                IEnumerable<PHIEUSUACHUA> tmp = db.PHIEUSUACHUAs.Where(a => a.MAXE == maxe && a.TINHTRANG == 0);
                return tmp.FirstOrDefault();
            }

        }
        public void SavePHIEUSUACHUA(PHIEUSUACHUA PHIEUSUACHUA, params AlertNonPara[] Loadawhendones)
        {
            try
            {
                if (PHIEUSUACHUA == null)
                {
                    MakeNotiError(strSave + nameof(PHIEUSUACHUA), FrontEndError);
                    return;
                }
                db.PHIEUSUACHUAs.Add(PHIEUSUACHUA);
                db.SaveChanges();
                //MakeNotiSuccess(strSave + nameof(PHIEUSUACHUA));
                ReloadDataEvent.Ins.Alert(DataType.FixForm);

            }
            catch
            {
                MessageBox.Show("Lưu thất bại, Kết nối với máy chủ bị  gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strSave + nameof(PHIEUSUACHUA), BackEndError);
            }
            foreach (var donefunc in Loadawhendones)
            {
                donefunc?.Invoke();
            }
        }
        public void UpdatePHIEUSUACHUA(PHIEUSUACHUA PHIEUSUACHUA, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (PHIEUSUACHUA == null) return;
                PHIEUSUACHUA tmp = db.PHIEUSUACHUAs.Where(a => a.MAPHIEU == PHIEUSUACHUA.MAPHIEU).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strUpdate + nameof(PHIEUSUACHUA), FrontEndError);
                    return;
                }
                db.Entry(tmp).CurrentValues.SetValues(PHIEUSUACHUA);
                SaveChange();
                ReloadDataEvent.Ins.Alert(DataType.FixForm);
                //MakeNotiSuccess(strUpdate + nameof(PHIEUSUACHUA));

            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại, Kết nối với máy chủ bị gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strUpdate + nameof(PHIEUSUACHUA), BackEndError);
            }
            foreach (var func in LoadWhendones)
            {
                func?.Invoke();
            }
        }
        public void DeletePHIEUSUACHUA(PHIEUSUACHUA PHIEUSUACHUA, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strDelete)) return;
                PHIEUSUACHUA tmp = db.PHIEUSUACHUAs.Where(a => a.MAPHIEU == PHIEUSUACHUA.MAPHIEU).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strDelete + nameof(PHIEUSUACHUA), FrontEndError);
                    return;
                }
                db.PHIEUSUACHUAs.Remove(tmp);
                db.SaveChanges();
                MakeNotiSuccess(strDelete + nameof(PHIEUSUACHUA));
                ReloadDataEvent.Ins.Alert(DataType.FixForm);


            }
            catch (Exception e)
            {
                MakeNotiError(strDelete + nameof(PHIEUSUACHUA), BackEndError);
                MessageBox.Show("Xóa thất bại ", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (var func in LoadWhendones)
            {
                func?.Invoke();
            }
        }
        public void XoaPhieuSuachua(int maphieu)
        {

                IEnumerable<CHITIET_PSC> chitiet = db.CHITIET_PSC.Where(a => a.MAPHIEU == maphieu);
                db.CHITIET_PSC.RemoveRange(chitiet);
                PHIEUSUACHUA psc = db.PHIEUSUACHUAs.Where(a => a.MAPHIEU == maphieu).FirstOrDefault();
                db.PHIEUSUACHUAs.Remove(psc);
                db.SaveChanges();
                ReloadDataEvent.Ins.Alert(DataType.FixForm);

        }
        public int GetSoLuotSuaTrongNgay()
        {
            int res = db.PHIEUSUACHUAs.Where(a => a.NGAYLAP == DateTime.Today).Count();
            return res;
        }
    }
}
