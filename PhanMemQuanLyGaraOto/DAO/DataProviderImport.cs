using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.DAO
{
    public partial class DataProvider
    {
        public void SaveImport(PHIEUNHAP PHIEUNHAP, params AlertNonPara[] Loadawhendones)
        {
            try
            {
                if (PHIEUNHAP == null)
                {
                    MakeNotiError(strSave + nameof(PHIEUNHAP), FrontEndError);
                    return;
                }
                db.PHIEUNHAPs.Add(PHIEUNHAP);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Lưu thất bại, Kết nối với máy chủ bị  gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strSave + nameof(PHIEUNHAP), BackEndError);
            }
            foreach (var donefunc in Loadawhendones)
            {
                donefunc?.Invoke();
            }
        }
        public void UpdateImport(PHIEUNHAP PHIEUNHAP, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strUpdate)) return;
                if (PHIEUNHAP == null) return;
                PHIEUNHAP tmp = db.PHIEUNHAPs.Where(a => a.SOPHIEUNHAP == PHIEUNHAP.SOPHIEUNHAP).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strUpdate + nameof(PHIEUNHAP), FrontEndError);
                    return;
                }
                db.Entry(tmp).CurrentValues.SetValues(PHIEUNHAP);
                SaveChange();

            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại, Kết nối với máy chủ bị gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strUpdate + nameof(PHIEUNHAP), BackEndError);
            }
            foreach (var func in LoadWhendones)
            {
                func?.Invoke();
            }
        }
        public void DeleteImport(PHIEUNHAP PHIEUNHAP, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                MakeNotiError(strDelete + nameof(PHIEUNHAP), BackEndError);
                return;
                if (ChangeComfirm(strDelete)) return;
                PHIEUNHAP tmp = db.PHIEUNHAPs.Where(a => a.SOPHIEUNHAP == PHIEUNHAP.SOPHIEUNHAP).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strDelete + nameof(PHIEUNHAP), FrontEndError);
                    return;
                }
                db.PHIEUNHAPs.Remove(tmp);
                db.SaveChanges();


            }
            catch (Exception e)
            {
                MakeNotiError(strDelete + nameof(PHIEUNHAP), BackEndError);
                MessageBox.Show("Xóa thất bại ", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (var func in LoadWhendones)
            {
                func?.Invoke();
            }
        }
        public PHIEUNHAP GetPhieuNhapActive()
        {
            PHIEUNHAP res = db.PHIEUNHAPs.Where(a => a.TINHTRANG == 0).FirstOrDefault();
            return res;
        }
    }
}
