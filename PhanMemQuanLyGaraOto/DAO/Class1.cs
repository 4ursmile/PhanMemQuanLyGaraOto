
using CommunityToolkit.WinUI.Notifications;
using PhanMemQuanLyGaraOto.Model;
using PhanMemQuanLyGaraOto.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.System;
using Windows.UI.Xaml.Shapes;

namespace PhanMemQuanLyGaraOto.DAO
{
    public class DataProvider
    {
      
        private static DataProvider instance;
        const string BackEndError = "Kết nối với máy chủ thất bại";
        const string FrontEndError = "Lỗi không xác định";
        const string strUpdate = "Cập nhật ";
        const string strDelete = "Xóa ";
        const string strSave = "Thêm ";
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

        void MakeNotiError(string ActionName = "Thay đổi", string resson = "Kết nối với máy chủ thất bại")
        {
            string path1 = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
            string path2 = System.IO.Path.Combine(path1, "Resources", "error.jpg");
            if (!File.Exists(path2)) path2 = @"https://picsum.photos/200";
            string path3 = System.IO.Path.Combine(path1, "Resources", "StaffAvatar.png");
            if (!File.Exists(path3)) path3 = @"https://picsum.photos/200";
            new ToastContentBuilder()
                .AddText(ActionName + " không thành công, một lỗi không mong muốn đã xảy ra")
                .AddInlineImage(new Uri(path2))
                .AddAppLogoOverride(new Uri(path3), ToastGenericAppLogoCrop.Circle)
                .AddText(resson)
                .Show(toast => toast.ExpirationTime = DateTime.Now.AddSeconds(1));
        }
        void MakeNotiSuccess(string ActionName = "Thay đổi")
        {
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
        public void SaveChange()
        {
            db.SaveChanges();
        }
        #region ACCount
        public void SaveAccount(ACCOUNT aCCOUNT,params AlertNonPara[] Loadawhendones)
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
            } catch
            {
                MakeNotiError();
            }

        }
        public void DeleteAccount(ACCOUNT aCCOUNT, params AlertNonPara[] LoadWhendones)
        {
            try
            {
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
                foreach (var donefunc in Loadawhendones)
                {
                    donefunc?.Invoke();
                }
                MakeNotiSuccess();
            } catch
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
                if (tIENCONG == null) return;
                TIENCONG tmp = db.TIENCONGs.Where(a => a.MANDTC == tIENCONG.MANDTC).FirstOrDefault();
                if (tmp == null) return;

                db.Entry(tmp).CurrentValues.SetValues(tIENCONG);
                SaveChange();
                MakeNotiSuccess();
                foreach (var func in LoadWhendones)
                {
                    func?.Invoke();
                }
            } catch
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
                TIENCONG tmp = db.TIENCONGs.Where(a => a.MANDTC == tIENCONG.MANDTC).FirstOrDefault();
                if (tmp == null) return;
                db.TIENCONGs.Remove(tmp);
                db.SaveChanges();
                MakeNotiSuccess();
                foreach (var func in LoadWhendones)
                {
                    func?.Invoke();
                }
            } catch
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
            }
            catch (Exception e) 
            {
                MakeNotiError(strDelete + nameof(HIEUXE), BackEndError);
                MessageBox.Show("Xóa thất bại ", e.Message , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        #endregion
    }
}
