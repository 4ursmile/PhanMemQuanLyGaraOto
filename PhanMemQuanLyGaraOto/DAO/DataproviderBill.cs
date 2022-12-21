using PhanMemQuanLyGaraOto.Class;
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
        public async void SavePHIEUTHU(PHIEUTHUTIEN PHIEUTHUTIEN, params AlertNonPara[] Loadawhendones)
        {
            try
            {
                if (PHIEUTHUTIEN == null)
                {
                    MakeNotiError(strSave + nameof(PHIEUTHUTIEN), FrontEndError);
                    return;
                }
                XE xE = db.XEs.Where(a => a.MAXE == PHIEUTHUTIEN.MAXE).FirstOrDefault();
                xE.TONGNO = xE.TONGNO - PHIEUTHUTIEN.SOTIENTHU;
                XE tmp = db.XEs.Where(a => a.MAXE == xE.MAXE).FirstOrDefault();
                db.Entry(tmp).CurrentValues.SetValues(xE);
                db.PHIEUTHUTIENs.Add(PHIEUTHUTIEN);
                db.SaveChanges();
                Notification.MakePaymentSuccesNoti(xE.BIENSO,(decimal)PHIEUTHUTIEN.SOTIENTHU,(decimal)xE.TONGNO);
                //MakeNotiSuccess(strSave + nameof(PHIEUTHUTIEN));
                ReloadDataEvent.Ins.Alert(DataType.Money);
            }
            catch
            {
                MessageBox.Show("Lưu thất bại, Kết nối với máy chủ bị  gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strSave + nameof(PHIEUTHUTIEN), BackEndError);
            }
            foreach (var donefunc in Loadawhendones)
            {
                donefunc?.Invoke();
            }
        }
        public void UpdatePHIEUTHU(PHIEUTHUTIEN PHIEUTHUTIEN, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (PHIEUTHUTIEN == null) return;
                PHIEUTHUTIEN tmp = db.PHIEUTHUTIENs.Where(a => a.MAPHIEUTHU == PHIEUTHUTIEN.MAPHIEUTHU).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strUpdate + nameof(PHIEUTHUTIEN), FrontEndError);
                    return;
                }
                db.Entry(tmp).CurrentValues.SetValues(PHIEUTHUTIEN);
                SaveChange();
                ReloadDataEvent.Ins.Alert(DataType.Money);
                //MakeNotiSuccess(strUpdate + nameof(PHIEUTHUTIEN));

            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại, Kết nối với máy chủ bị gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strUpdate + nameof(PHIEUTHUTIEN), BackEndError);
            }
            foreach (var func in LoadWhendones)
            {
                func?.Invoke();
            }
        }
        public void DeletePHIEUTHU(PHIEUTHUTIEN PHIEUTHUTIEN, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strDelete)) return;
                PHIEUTHUTIEN tmp = db.PHIEUTHUTIENs.Where(a => a.MAPHIEUTHU == PHIEUTHUTIEN.MAPHIEUTHU).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strDelete + nameof(PHIEUTHUTIEN), FrontEndError);
                    return;
                }
                db.PHIEUTHUTIENs.Remove(tmp);
                db.SaveChanges();
                //MakeNotiSuccess(strDelete + nameof(PHIEUTHUTIEN));
                ReloadDataEvent.Ins.Alert(DataType.Money);


            }
            catch (Exception e)
            {
                MakeNotiError(strDelete + nameof(PHIEUTHUTIEN), BackEndError);
                MessageBox.Show("Xóa thất bại ", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (var func in LoadWhendones)
            {
                func?.Invoke();
            }
        }
    }
}
