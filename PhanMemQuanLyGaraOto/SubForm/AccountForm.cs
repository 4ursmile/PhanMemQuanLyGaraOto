using PhanMemQuanLyGaraOto.DDo;
using PhanMemQuanLyGaraOto.SubForm.SubSubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.SubForm
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            if (UniversalUser.Ins.account.TYPE == 0)
            {
                tabcAccount.Controls.Remove(tabPage2);
            }
            LoadInfor();
        }
        void LoadInfor()
        {
            txtDisplayName.Text = UniversalUser.Ins.account.DISPLAYNAME;
            txtPos.Text = PosNameMap.GetAccountPosName((int)UniversalUser.Ins.account.TYPE);
            txtDes.Text = UniversalUser.Ins.account.DESCRIPTION;
        }
        #region Event
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtDisplayName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btbExit_Click(object sender, EventArgs e)
        {
            ExitInforHolder.isQuit = true;
            MainForm.ActiveForm.Close();
        }

        private void btbLogout_Click(object sender, EventArgs e)
        {
            ExitInforHolder.isQuit = false;
            MainForm.ActiveForm.Close();
        }

        private void btbChangePass_Click(object sender, EventArgs e)
        {
            ChangePassForm cpform = new ChangePassForm();
            cpform.ShowDialog();
        }

        private void btbInfo_Click(object sender, EventArgs e)
        {

        }
        private void AccountForm_Load(object sender, EventArgs e)
        {
            UniversalAlert.Ins.AddListener(LoadInfor);
        }

        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UniversalAlert.Ins.RemoveListenr(LoadInfor);
        }
        #endregion


    }
}
