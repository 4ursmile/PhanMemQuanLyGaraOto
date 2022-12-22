
using CommunityToolkit.WinUI.Notifications;
using PhanMemQuanLyGaraOto.Class;
using PhanMemQuanLyGaraOto.DDO;
using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Windows.Foundation.Metadata;

namespace PhanMemQuanLyGaraOto.DAO
{
    public partial class DataProvider
    {

        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
            private set => instance = value;
        }
        public GARAOTOEntities db;
        private DataProvider()
        {
            db = new GARAOTOEntities();
        }
        public void SaveChange()
        {
            db.SaveChanges();
        }
        public bool ChangeComfirm(string Action = "Thay đổi")
        {
            DialogResult res = MessageBox.Show($"Bạn có chắc chắn muốn {Action} không?", "Xác nhận lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                return false;
            return true;
        }
        public List<REMCheckCar> GetCheckCar()
        {
            using(GARAOTOEntities db = new GARAOTOEntities())
            {
                List<REMCheckCar> list = (from x in db.XEs
                                          join c in db.CHUXEs on x.MACHUXE equals c.MACHUXE
                                          join b in db.HIEUXEs on x.MAHIEUXE equals b.MAHIEUXE
                                          select new REMCheckCar
                                          {
                                              CarId = x.MAXE,
                                              CarBrand = b.TENHIEUXE,
                                              CarNumber = x.BIENSO,
                                              CarOwnerName = c.TENCHUXE,
                                              CarOwnerTele = c.DIENTHOAI,
                                              DateIn = x.NGAYTIEPNHAN.Value,
                                              DebtMoney = x.TONGNO.Value,
                                              TinhTrang = x.TINHTRANG
                                          }).OrderByDescending(a=> a.DebtMoney).ToList();
                if (list == null) return new List<REMCheckCar>();
                return list;
            }
        }
        #region Noti
        public const string BackEndError = "Dữ liệu đã bị ràng buộc, bạn không có quyền thục hiện thay đổi này";
        public const string FrontEndError = "Lỗi không xác định";
        public const string strUpdate = "Cập nhật ";
        public const string strDelete = "Xóa ";
        public const string strSave = "Thêm ";
        public void MakeNotiError(string ActionName = "Thay đổi", string resson = "Kết nối với máy chủ thất bại")
        {
            if (!UniversalSetting.Instance.isNotiDataOn) return;
            string path1 = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
            string path2 = System.IO.Path.Combine(path1, "Resources", "error.jpg");
            if (!File.Exists(path2)) path2 = @"https://picsum.photos/200";
            string path3 = System.IO.Path.Combine(path1, "Resources", "StaffAvatar.png");
            if (!File.Exists(path3)) path3 = @"https://picsum.photos/200";
            new ToastContentBuilder()
                .AddText(ActionName + " không thành công")
                .AddInlineImage(new Uri(path2))
                .AddAppLogoOverride(new Uri(path3), ToastGenericAppLogoCrop.Circle)
                .AddText(resson)
                .Show(toast => toast.ExpirationTime = DateTime.Now.AddSeconds(1));
        }
        public void MakeNotiSuccess(string ActionName = "Thay đổi")
        {
            if (!UniversalSetting.Instance.isNotiDataOn) return;
            string path1 = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
            string path2 = System.IO.Path.Combine(path1, "Resources", "succes.png");
            if (!File.Exists(path2)) path2 = @"https://picsum.photos/200";
            string path3 = System.IO.Path.Combine(path1, "Resources", "StaffAvatar.png");
            if (!File.Exists(path3)) path3 = @"https://picsum.photos/200";
            new ToastContentBuilder()
                .AddText(ActionName + " thành công")
                .AddText("Mọi chuyện đều tốt")
                .AddInlineImage(new Uri(path2))
                .AddAppLogoOverride(new Uri(path3), ToastGenericAppLogoCrop.Circle)
                .Show(toast => toast.ExpirationTime = DateTime.Now.AddSeconds(1));
        }
        #endregion

        #region ACCount
        public List<ACCOUNT> LikeAccount(string LikeStr)
        {
            try
            {
                string QuerySTR = String.Format("%{0}%", LikeStr);
                List<ACCOUNT> accountList = db.ACCOUNTs.Where(ak => DbFunctions.Like(ak.DISPLAYNAME, QuerySTR)).ToList<ACCOUNT>();
                return accountList;
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống", "Không thể tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        public void SaveAccount(ACCOUNT aCCOUNT, params AlertNonPara[] Loadawhendones)
        {
            try
            {
                if (aCCOUNT == null) return;
                ACCOUNT tmp = db.ACCOUNTs.Where(a => a.USERNAME == aCCOUNT.USERNAME).FirstOrDefault();
                if (tmp != null)
                {
                    MessageBox.Show("Người dùng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.ACCOUNTs.Add(aCCOUNT);
                db.SaveChanges();
                MakeNotiSuccess();
                foreach (var donefunc in Loadawhendones)
                {
                    donefunc?.Invoke();
                }
            }
            catch
            {
                MakeNotiError();
            }

        }
        public void UpdateAccount(ACCOUNT aCCOUNT, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strUpdate)) return;

                if (aCCOUNT == null) return;
                ACCOUNT tmp = db.ACCOUNTs.Where(a => a.USERID == aCCOUNT.USERID).FirstOrDefault();
                if (tmp == null) return;

                db.Entry(tmp).CurrentValues.SetValues(aCCOUNT);
                SaveChange();
                MakeNotiSuccess();
                foreach (var func in LoadWhendones)
                {
                    func?.Invoke();
                }
            }
            catch
            {
                MakeNotiError();
            }

        }
        public void DeleteAccount(ACCOUNT aCCOUNT, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strDelete)) return;

                ACCOUNT tmp = db.ACCOUNTs.Where(a => a.USERID == aCCOUNT.USERID).FirstOrDefault();
                if (tmp == null) return;
                db.ACCOUNTs.Remove(tmp);
                db.SaveChanges();
                MakeNotiSuccess("Xóa");
                foreach (var func in LoadWhendones)
                {
                    func?.Invoke();
                }
            }
            catch
            {
                MakeNotiError();
            }
        }
        #endregion
        #region TienCong
        public void SaveTienCong(TIENCONG tIENCONG, params AlertNonPara[] Loadawhendones)
        {
            try
            {

                if (tIENCONG == null) return;
                db.TIENCONGs.Add(tIENCONG);
                db.SaveChanges();
                ReloadDataEvent.Ins.Alert(DataType.Money);

                foreach (var donefunc in Loadawhendones)
                {
                    donefunc?.Invoke();
                }
                MakeNotiSuccess();
            }
            catch
            {
                MessageBox.Show("Lưu thất bại, Kết nối với máy chủ bị  gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError();
                return;
            }

        }
        public void UpdateTienCong(TIENCONG tIENCONG, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strUpdate)) return;
                if (tIENCONG == null) return;
                TIENCONG tmp = db.TIENCONGs.Where(a => a.MANDTC == tIENCONG.MANDTC).FirstOrDefault();
                if (tmp == null) return;

                db.Entry(tmp).CurrentValues.SetValues(tIENCONG);
                SaveChange();
                MakeNotiSuccess();
                ReloadDataEvent.Ins.Alert(DataType.Money);

                foreach (var func in LoadWhendones)
                {
                    func?.Invoke();
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại, Kết nối với máy chủ bị gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError();
                return;
            }

        }
        public void DeleteTienCong(TIENCONG tIENCONG, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strDelete)) return;

                TIENCONG tmp = db.TIENCONGs.Where(a => a.MANDTC == tIENCONG.MANDTC).FirstOrDefault();
                if (tmp == null) return;
                db.TIENCONGs.Remove(tmp);
                db.SaveChanges();
                MakeNotiSuccess();
                foreach (var func in LoadWhendones)
                {
                    func?.Invoke();
                }
                ReloadDataEvent.Ins.Alert(DataType.Money);
            }
            catch
            {
                MakeNotiError();
                MessageBox.Show("Xóa thất bại, Kết nối với máy chủ bị gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        #endregion
        #region branD
        public void SaveBrand(HIEUXE hIEUXE, params AlertNonPara[] Loadawhendones)
        {
            try
            {
                if (hIEUXE == null) return;
                db.HIEUXEs.Add(hIEUXE);
                db.SaveChanges();
                ReloadDataEvent.Ins.Alert(DataType.Brand);

                foreach (var donefunc in Loadawhendones)
                {
                    donefunc?.Invoke();
                }
                MakeNotiSuccess(strSave + nameof(HIEUXE));
            }
            catch
            {
                MessageBox.Show("Lưu thất bại, Kết nối với máy chủ bị  gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strSave + nameof(HIEUXE), BackEndError);
                return;
            }

        }
        public void UpdateBrand(HIEUXE hIEUXE, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strUpdate)) return;
                if (hIEUXE == null) return;
                HIEUXE tmp = db.HIEUXEs.Where(a => a.MAHIEUXE == hIEUXE.MAHIEUXE).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strUpdate + nameof(HIEUXE), FrontEndError);
                    return;
                }
                db.Entry(tmp).CurrentValues.SetValues(hIEUXE);
                SaveChange();
                MakeNotiSuccess("Cập nhật hiệu xe");
                foreach (var func in LoadWhendones)
                {
                    func?.Invoke();
                }
                ReloadDataEvent.Ins.Alert(DataType.Brand);
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại, Kết nối với máy chủ bị gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strUpdate + nameof(HIEUXE), BackEndError);
                return;
            }

        }
        public void DeleteBrand(HIEUXE hIEUXE, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strDelete)) return;
                HIEUXE tmp = db.HIEUXEs.Where(a => a.MAHIEUXE == hIEUXE.MAHIEUXE).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strDelete + nameof(HIEUXE), FrontEndError);
                    return;
                }
                db.HIEUXEs.Remove(tmp);
                db.SaveChanges();
                MakeNotiSuccess("Xóa hiệu xe");
                foreach (var func in LoadWhendones)
                {
                    func?.Invoke();
                }
                ReloadDataEvent.Ins.Alert(DataType.Brand);
            }
            catch (Exception e)
            {
                MakeNotiError(strDelete + nameof(HIEUXE), BackEndError);
                MessageBox.Show("Xóa thất bại ", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        #endregion
        #region Customer
        public void SaveCustomer(CHUXE CHUXE, params AlertNonPara[] Loadawhendones)
        {
            try
            {
                if (CHUXE == null)
                {
                    MakeNotiError(strSave + nameof(CHUXE), FrontEndError);
                    return;
                }
                db.CHUXEs.Add(CHUXE);
                db.SaveChanges();
                ReloadDataEvent.Ins.Alert(DataType.Customer);
                foreach (var donefunc in Loadawhendones)
                {
                    donefunc?.Invoke();
                }
                MakeNotiSuccess(strSave + nameof(CHUXE));
            }
            catch
            {
                MessageBox.Show("Lưu thất bại, Kết nối với máy chủ bị  gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strSave + nameof(CHUXE), BackEndError);
                return;
            }

}
        public void UpdateCustomer(CHUXE CHUXE, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strUpdate)) return;
                if (CHUXE == null) return;
                CHUXE tmp = db.CHUXEs.Where(a => a.MACHUXE == CHUXE.MACHUXE).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strUpdate + nameof(CHUXE), FrontEndError);
                    return;
                }
                db.Entry(tmp).CurrentValues.SetValues(CHUXE);
                SaveChange();
                MakeNotiSuccess(strUpdate + nameof(CHUXE));
                ReloadDataEvent.Ins.Alert(DataType.Customer);

                foreach (var func in LoadWhendones)
                {
                    func?.Invoke();
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại, Kết nối với máy chủ bị gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strUpdate + nameof(CHUXE), BackEndError);
                return;
            }

        }
        public void DeleteCustomer(CHUXE CHUXE, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strDelete)) return;
                CHUXE tmp = db.CHUXEs.Where(a => a.MACHUXE == CHUXE.MACHUXE).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strDelete + nameof(CHUXE), FrontEndError);
                    return;
                }
                db.CHUXEs.Remove(tmp);
                db.SaveChanges();
                MakeNotiSuccess(strDelete + nameof(CHUXE));
                ReloadDataEvent.Ins.Alert(DataType.Customer);

                foreach (var func in LoadWhendones)
                {
                    func?.Invoke();
                }
            }
            catch (Exception e)
            {
                MakeNotiError(strDelete + nameof(CHUXE), BackEndError);
                MessageBox.Show("Xóa thất bại ", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        public bool CustomerCheckContainerSDT(string sdt, CHUXE Cus = null)
        {
            List<CHUXE> k;
            if (Cus != null)
                k = db.CHUXEs.Where(a => a.DIENTHOAI == sdt && a.MACHUXE != Cus.MACHUXE).ToList<CHUXE>();
            else
                k = db.CHUXEs.Where(a => a.DIENTHOAI == sdt).ToList<CHUXE>();
            if (k.Count == 0)
                return false;
            return true;
        }
        public CHUXE GetCHUXEBYSDT(string sdt)
        {
            CHUXE cHUXE = db.CHUXEs.Where(a => a.DIENTHOAI == sdt).FirstOrDefault();
            return cHUXE;
        }
        #endregion
        #region CAR
        public void SaveCar(XE XE, params AlertNonPara[] Loadawhendones)
        {
            try
            {
                if (XE == null)
                {
                    MakeNotiError(strSave + nameof(XE), FrontEndError);
                    return;
                }
                db.XEs.Add(XE);
                db.SaveChanges();
                MakeNotiSuccess(strSave + nameof(XE));
                ReloadDataEvent.Ins.Alert(DataType.Car);

            }
            catch
            {
                MessageBox.Show("Lưu thất bại, Kết nối với máy chủ bị  gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strSave + nameof(XE), BackEndError);
            }
            foreach (var donefunc in Loadawhendones)
            {
                donefunc?.Invoke();
            }
        }
        public void UpdateCar(XE XE, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strUpdate)) return;
                if (XE == null) return;
                XE tmp = db.XEs.Where(a => a.MAXE == XE.MAXE).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strUpdate + nameof(XE), FrontEndError);
                    return;
                }
                db.Entry(tmp).CurrentValues.SetValues(XE);
                SaveChange();
                ReloadDataEvent.Ins.Alert(DataType.Car);
                MakeNotiSuccess(strUpdate + nameof(XE));

            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại, Kết nối với máy chủ bị gián đoạn", "Lỗi kết nối đến máy chủ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeNotiError(strUpdate + nameof(XE), BackEndError);
            }
            foreach (var func in LoadWhendones)
            {
                func?.Invoke();
            }

        }
        public void DeleteCar(XE XE, params AlertNonPara[] LoadWhendones)
        {
            try
            {
                if (ChangeComfirm(strDelete)) return;
                XE tmp = db.XEs.Where(a => a.MAXE == XE.MAXE).FirstOrDefault();
                if (tmp == null)
                {
                    MakeNotiError(strDelete + nameof(XE), FrontEndError);
                    return;
                }
                db.XEs.Remove(tmp);
                db.SaveChanges();
                MakeNotiSuccess(strDelete + nameof(XE));
                ReloadDataEvent.Ins.Alert(DataType.Car);

                foreach (var func in LoadWhendones)
                {
                    func?.Invoke();
                }
            }
            catch (Exception e)
            {
                MakeNotiError(strDelete + nameof(XE), "Xe đã thực hiện các dịch vụ của gara nên gara cần lưu lại thông tin xe này");
                return;
            }


        }
        public bool isUniquePlate(string plate, int Maxe = 0)
        {
            XE checkXe = db.XEs.Where(a => a.BIENSO == plate && a.MAXE != Maxe).FirstOrDefault();
            if (checkXe == null)
                return true;
            return false;
        }
        #endregion
    }
    
}
