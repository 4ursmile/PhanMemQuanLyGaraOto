using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.DAO
{
    public partial class DataProvider
    {
        public void SaveTool(PHUTUNG PHUTUNG, params AlertNonPara[] Loadawhendones)
        {
            try
            {
                if (PHUTUNG == null)
                {
                    MakeNotiError(strSave + nameof(PHUTUNG), FrontEndError);
                    return;
                }
                db.PHUTUNGs.Add(PHUTUNG);
                db.SaveChanges();
                MakeNotiSuccess(strSave + nameof(PHUTUNG));
                ReloadDataEvent.Ins.Alert(DataType.Tool);

            }
            catch
            {
                MessageBox.Show("Lưu thất bại, Kết nối với máy chủ bị  gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strSave + nameof(PHUTUNG), BackEndError);
            }
            foreach (var donefunc in Loadawhendones)
            {
                donefunc?.Invoke();
            }
        }
        public void UpdateTool(PHUTUNG PHUTUNG, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strUpdate)) return;
                if (PHUTUNG == null) return;
                PHUTUNG tmp = db.PHUTUNGs.Where(a => a.MAPHUTUNG == PHUTUNG.MAPHUTUNG).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strUpdate + nameof(PHUTUNG), FrontEndError);
                    return;
                }
                db.Entry(tmp).CurrentValues.SetValues(PHUTUNG);
                SaveChange();
                ReloadDataEvent.Ins.Alert(DataType.Tool);
                MakeNotiSuccess(strUpdate + nameof(PHUTUNG));

            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại, Kết nối với máy chủ bị gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strUpdate + nameof(PHUTUNG), BackEndError);
            }
            foreach (var func in LoadWhendones)
            {
                func?.Invoke();
            }
        }
        public void DeleteTool(PHUTUNG PHUTUNG, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                MakeNotiError(strDelete + nameof(PHUTUNG), BackEndError);
                return;
                if (ChangeComfirm(strDelete)) return;
                PHUTUNG tmp = db.PHUTUNGs.Where(a => a.MAPHUTUNG == PHUTUNG.MAPHUTUNG).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strDelete + nameof(PHUTUNG), FrontEndError);
                    return;
                }
                db.PHUTUNGs.Remove(tmp);
                db.SaveChanges();
                MakeNotiSuccess(strDelete + nameof(PHUTUNG));
                ReloadDataEvent.Ins.Alert(DataType.Tool);


            }
            catch (Exception e)
            {
                MakeNotiError(strDelete + nameof(PHUTUNG), BackEndError);
                MessageBox.Show("Xóa thất bại ", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (var func in LoadWhendones)
            {
                func?.Invoke();
            }
        }
        public async Task<List<PHUTUNG>> GetPHUTUNGs()
        {
            try
            {
                using (GARAOTOEntities db = new GARAOTOEntities())
                {
                    List<PHUTUNG> pHUTUNGs = await Task.Run(()=> db.PHUTUNGs.ToList<PHUTUNG>());
                    return pHUTUNGs;
                }
            }
            catch
            {
                MakeNotiError(strSave + nameof(PHUTUNG), BackEndError);
            }
            return new List<PHUTUNG>();
        }
        public async Task<String> GetCarOwnerEmailAsync(string sdt)
        {
            try
            {
                CHUXE res = await db.CHUXEs.Where(a => a.DIENTHOAI == sdt).FirstOrDefaultAsync();
                return res.EMAIL;
            } catch
            {
                return "abc@gm.uit.edu.vn";
            }
        }
    }

}
