using PhanMemQuanLyGaraOto.DDO;
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
        public List<CustomCTPSC> GetChiTietPSC(int MAPHIEU)
        {
            List<CustomCTPSC> chiTietPSC = (from ct in db.CHITIET_PSC
                                                  join nd in db.TIENCONGs on ct.MANDTC equals nd.MANDTC
                                                  join pt in db.PHUTUNGs on ct.MAPHUTUNG equals pt.MAPHUTUNG
                                                  select new CustomCTPSC
                                                  {
                                                      MACTPSC = ct.MACTPSC,
                                                      MAPHIEU = ct.MAPHIEU,
                                                      MANDTC = ct.MANDTC,
                                                      NOIDUNG = nd.NOIDUNG,
                                                      TIENCONG = ct.TIENCONG,
                                                      MAPHUTUNG = ct.MAPHUTUNG,
                                                      TENPHUTUNG = pt.TENPHUTUNG,
                                                      DONGIA = ct.DONGIA,
                                                      SOLUONG = ct.SOLUONG,
                                                      THANHTIEN = ct.THANHTIEN
                                                  }).Where(a => a.MAPHIEU == MAPHIEU).ToList<CustomCTPSC>();
            return chiTietPSC;
        }
        public void SaveCHITETPHIEUSUACHUA(CHITIET_PSC CHITIET_PSC, params AlertNonPara[] Loadawhendones)
        {
            try
            {
                if (CHITIET_PSC == null)
                {
                    MakeNotiError(strSave + nameof(CHITIET_PSC), FrontEndError);
                    return;
                }
                db.CHITIET_PSC.Add(CHITIET_PSC);
                db.SaveChanges();
                MakeNotiSuccess(strSave + nameof(CHITIET_PSC));
                ReloadDataEvent.Ins.Alert(DataType.Tool);

            }
            catch
            {
                MessageBox.Show("Lưu thất bại, Kết nối với máy chủ bị  gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strSave + nameof(CHITIET_PSC), BackEndError);
            }
            foreach (var donefunc in Loadawhendones)
            {
                donefunc?.Invoke();
            }
        }
        public void UpdateCHITIET_PSC(CHITIET_PSC CHITIET_PSC, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strUpdate)) return;
                if (CHITIET_PSC == null) return;
                CHITIET_PSC tmp = db.CHITIET_PSC.Where(a => a.MACTPSC == CHITIET_PSC.MACTPSC).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strUpdate + nameof(CHITIET_PSC), FrontEndError);
                    return;
                }
                db.Entry(tmp).CurrentValues.SetValues(CHITIET_PSC);
                SaveChange();
                ReloadDataEvent.Ins.Alert(DataType.Tool);
                MakeNotiSuccess(strUpdate + nameof(CHITIET_PSC));

            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại, Kết nối với máy chủ bị gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strUpdate + nameof(CHITIET_PSC), BackEndError);
            }
            foreach (var func in LoadWhendones)
            {
                func?.Invoke();
            }
        }
        public void DeleteCHITIET_PSC(CHITIET_PSC CHITIET_PSC, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strDelete)) return;
                CHITIET_PSC tmp = db.CHITIET_PSC.Where(a => a.MACTPSC == CHITIET_PSC.MACTPSC).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strDelete + nameof(CHITIET_PSC), FrontEndError);
                    return;
                }
                db.CHITIET_PSC.Remove(tmp);
                db.SaveChanges();
                MakeNotiSuccess(strDelete + nameof(CHITIET_PSC));
                ReloadDataEvent.Ins.Alert(DataType.Tool);


            }
            catch (Exception e)
            {
                MakeNotiError(strDelete + nameof(CHITIET_PSC), BackEndError);
                MessageBox.Show("Xóa thất bại ", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (var func in LoadWhendones)
            {
                func?.Invoke();
            }

        }
    }
}
