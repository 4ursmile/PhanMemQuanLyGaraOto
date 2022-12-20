using PhanMemQuanLyGaraOto.DDO;
using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.DAO
{
    public partial class DataProvider
    {
        public void SaveImportDetail(CT_PHIEUNHAP CT_PHIEUNHAP, params AlertNonPara[] Loadawhendones)
        {
            try
            {
                if (CT_PHIEUNHAP == null)
                {
                    MakeNotiError(strSave + nameof(CT_PHIEUNHAP), FrontEndError);
                    return;
                }
                db.CT_PHIEUNHAP.Add(CT_PHIEUNHAP);
                db.SaveChanges();
                ReloadDataEvent.Ins.Alert(DataType.ImportDetail);

            }
            catch
            {
                MessageBox.Show("Lưu thất bại, Kết nối với máy chủ bị  gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strSave + nameof(CT_PHIEUNHAP), BackEndError);
            }
            foreach (var donefunc in Loadawhendones)
            {
                donefunc?.Invoke();
            }
        }
        public void UpdateImportDetail(CT_PHIEUNHAP CT_PHIEUNHAP, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strUpdate)) return;
                if (CT_PHIEUNHAP == null) return;
                CT_PHIEUNHAP tmp = db.CT_PHIEUNHAP.Where(a =>  a.SOPHIEUNHAP == CT_PHIEUNHAP.SOPHIEUNHAP && a.MAPHUTUNG == CT_PHIEUNHAP.MAPHUTUNG).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strUpdate + nameof(CT_PHIEUNHAP), FrontEndError);
                    return;
                }
                db.Entry(tmp).CurrentValues.SetValues(CT_PHIEUNHAP);
                SaveChange();
                ReloadDataEvent.Ins.Alert(DataType.ImportDetail);

            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại, Kết nối với máy chủ bị gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strUpdate + nameof(CT_PHIEUNHAP), BackEndError);
            }
            foreach (var func in LoadWhendones)
            {
                func?.Invoke();
            }
        }
        public void DeleteImportDetail(CT_PHIEUNHAP CT_PHIEUNHAP, params AlertNonPara[] LoadWhendones)
        {
            //try
            //{
                //if (ChangeComfirm(strDelete)) return;
                CT_PHIEUNHAP tmp = db.CT_PHIEUNHAP.Where(a => a.SOPHIEUNHAP == CT_PHIEUNHAP.SOPHIEUNHAP && a.MAPHUTUNG == CT_PHIEUNHAP.MAPHUTUNG).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strDelete + nameof(CT_PHIEUNHAP), FrontEndError);
                    return;
                }
                db.CT_PHIEUNHAP.Remove(tmp);
                db.SaveChanges();
                ReloadDataEvent.Ins.Alert(DataType.ImportDetail);


            //}
            //catch (Exception e)
            //{
            //    MakeNotiError(strDelete + nameof(CT_PHIEUNHAP), BackEndError);
            //    MessageBox.Show("Xóa thất bại ", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            foreach (var func in LoadWhendones)
            {
                func?.Invoke();
            }
        }
        public async Task<List<GETCURRENTPHUTUNGTOSELECT_Result>> GetCurrentListPhuTungAsync(int SoPhieu)
        {
            using (var db = new GARAOTOEntities())
            {
                List<GETCURRENTPHUTUNGTOSELECT_Result> list =await Task.Run(()=> db.GETCURRENTPHUTUNGTOSELECT(SoPhieu).ToList<GETCURRENTPHUTUNGTOSELECT_Result>()); 
                return list;
            }
        }
        public async Task<List<CImportTool>> GetCImportToolsAsync(int SoPhieu)
        {
            using (var db = new GARAOTOEntities())
            {
                List<CImportTool> tools = await Task.Run(()=> (from pt in db.PHUTUNGs
                                           join ct in db.CT_PHIEUNHAP.Where(a=>a.SOPHIEUNHAP == SoPhieu)
                                           on pt.MAPHUTUNG equals ct.MAPHUTUNG
                                           select new CImportTool
                                           {
                                               sophieunhap = ct.SOPHIEUNHAP,
                                                maphutung = ct.MAPHUTUNG,
                                                tenphutung = pt.TENPHUTUNG,
                                                dongia = ct.DONGIA,
                                                soluongnhap = ct.SOLUONGNHAP,
                                                thanhtien = ct.THANHTIEN
                                           }).ToList<CImportTool>());
                return tools;
            }
        }
    }
}
