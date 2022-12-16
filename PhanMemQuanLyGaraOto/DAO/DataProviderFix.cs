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
           IEnumerable<PHIEUSUACHUA> tmp = db.PHIEUSUACHUAs.Where(a=>a.MAXE == maxe && a.TINHTRANG == 0);
            int s = tmp.Count();
            return tmp.FirstOrDefault();
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
                MakeNotiSuccess(strSave + nameof(PHIEUSUACHUA));
                ReloadDataEvent.Ins.Alert(DataType.Tool);

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
                if (ChangeComfirm(strUpdate)) return;
                if (PHIEUSUACHUA == null) return;
                PHIEUSUACHUA tmp = db.PHIEUSUACHUAs.Where(a => a.MAPHIEU == PHIEUSUACHUA.MAPHIEU).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strUpdate + nameof(PHIEUSUACHUA), FrontEndError);
                    return;
                }
                db.Entry(tmp).CurrentValues.SetValues(PHIEUSUACHUA);
                SaveChange();
                ReloadDataEvent.Ins.Alert(DataType.Tool);
                MakeNotiSuccess(strUpdate + nameof(PHIEUSUACHUA));

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
                ReloadDataEvent.Ins.Alert(DataType.Tool);


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

    }
}
