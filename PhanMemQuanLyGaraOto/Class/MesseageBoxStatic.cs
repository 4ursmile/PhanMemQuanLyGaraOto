using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.Class
{
    public static partial class MesseageBoxStatic
    {
        public static DialogResult MessageBoxQuestion(string content, string header = "Xác nhận?", MessageBoxButtons boxButtons = MessageBoxButtons.YesNo, MessageBoxIcon messageIcon = MessageBoxIcon.Question)
        {
            return MessageBox.Show(content, header, boxButtons, messageIcon);
        }
        public static void MessageBoxNoti(string content, string header = "Thông báo")
        {
            MessageBox.Show(content, header);
        }
    }
}
