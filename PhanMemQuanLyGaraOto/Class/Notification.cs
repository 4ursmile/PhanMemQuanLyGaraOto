using CommunityToolkit.WinUI.Notifications;
using PhanMemQuanLyGaraOto.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace PhanMemQuanLyGaraOto.Class
{
    public static class Notification
    {
        public static void MakePaymentSuccesNoti(string carName,decimal paymentValue,  decimal remainDebt)
        {
            string ConStr = $"Thanh toán {paymentValue.ToString("c0")} cho xe có biển số {carName} thành công, ";
            if (remainDebt > 0)
                ConStr += $"dư nợ còn lại là {remainDebt.ToString("c0")}.";
            else
                ConStr += $"Chúc mừng xe {carName} đã hoàn tất các khoản thanh toán.";
            string path1 = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
            string path2 = System.IO.Path.Combine(path1, "Resources", "highfive1.png");
            if (!File.Exists(path2)) path2 = @"https://picsum.photos/200";
            string path3 = System.IO.Path.Combine(path1, "Resources", "StaffAvatar.png");
            if (!File.Exists(path3)) path3 = @"https://picsum.photos/200";
            new ToastContentBuilder()
                .AddText("Thanh toán thành công")
                .AddText(ConStr)
                .AddInlineImage(new Uri(path2))
                .AddAppLogoOverride(new Uri(path3), ToastGenericAppLogoCrop.Circle)
                .Show(toast => toast.ExpirationTime = DateTime.Now.AddSeconds(100));
        }
    }
}
