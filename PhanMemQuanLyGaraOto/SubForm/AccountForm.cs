using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.DDo;
using PhanMemQuanLyGaraOto.Model;
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
        ACCOUNT currentSelectAccount;
        public AccountForm()
        {
            InitializeComponent();
            if (UniversalUser.Ins.account.TYPE > 1)
            {
                tabcAccount.Controls.Remove(tabPage2);
            }
            if (UniversalUser.Ins.account.TYPE > 0)
            {
                cbbType.Enabled = false;
            }
            LoadInfor();
            LoadUserToDataGridView();
            Reset();

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
            DialogResult result = MessageBox.Show("Bạn có muốn đóng chương trình?", "Xác nhận đóng chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.No) return;
            ExitInforHolder.isQuit = true;
            MainForm.ActiveForm.Close();
        }

        private void btbLogout_Click(object sender, EventArgs e)
        {
            ExitInforHolder.IsLogout = true;
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
            UpdateInforForm inforForm = new UpdateInforForm();
            inforForm.ShowDialog();
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btbCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {
            currentSelectAccount = new ACCOUNT();
            btbDelete2.Enabled = false;
            cbbType.SelectedIndex = 2;
            txtDescription.Text = txtDisplay.Text = txtPassword.Text = txtUser.Text = "";
            btbAdd.Text = "Thêm";
            btbAdd.Enabled = true;
            txtPassword.Enabled = true;
            txtDisplay.Enabled = true;
            txtDescription.Enabled = true;
            IsUpdate = false;
            txtUser.Enabled = true;

        }
        void LoadUserToDataGridView()
        {
            dgvAccounts.AutoGenerateColumns = false;
            dgvAccounts.DataSource = DataProvider.Instance.db.ACCOUNTs.ToList<ACCOUNT>();
        }
        bool IsUpdate = false;
        void ResetMainUser()
        {
            if (currentSelectAccount.USERID == UniversalUser.Ins.account.USERID)
            {
                UniversalUser.Ins.account = currentSelectAccount;
                UniversalAlert.Ins.Alert();
            }
        }
        private void btbAdd_Click(object sender, EventArgs e)
        {
            btbAdd.Enabled = false;
            if (IsUpdate)
            {
                if (txtUser.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu là bắt buộc!", "Không hợp lệ");
                    btbAdd.Enabled = true;
                    return;
                }
                if (txtPassword.Text != "Edit to change password")
                    currentSelectAccount.PASSWORD = SuperHash.GetHashPassWord(txtPassword.Text);
                else
                    currentSelectAccount.PASSWORD = dgvAccounts.CurrentRow.Cells[2].Value.ToString();
                currentSelectAccount.DESCRIPTION = txtDescription.Text;
                currentSelectAccount.DISPLAYNAME = txtDisplay.Text;
                currentSelectAccount.USERNAME = txtUser.Text;
                currentSelectAccount.TYPE = cbbType.SelectedIndex;

                DataProvider.Instance.UpdateAccount(currentSelectAccount,ResetMainUser,Reset, LoadUserToDataGridView);
                btbAdd.Enabled = true;
            } else
            {
                btbAdd.Enabled = false;
                if (txtUser.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu là bắt buộc!", "Không hợp lệ");
                    btbAdd.Enabled = true;
                    return;
                }
                currentSelectAccount.DESCRIPTION = txtDescription.Text;
                currentSelectAccount.PASSWORD = SuperHash.GetHashPassWord(txtPassword.Text);
                currentSelectAccount.DISPLAYNAME = txtDisplay.Text;
                currentSelectAccount.USERNAME = txtUser.Text;
                currentSelectAccount.TYPE = cbbType.SelectedIndex;

                DataProvider.Instance.SaveAccount(currentSelectAccount, Reset, LoadUserToDataGridView);
                btbAdd.Enabled = true;
            }

        }
        void UpdateViewData(ACCOUNT cCOUNT)
        {
            txtDescription.Text = cCOUNT.DESCRIPTION;
            txtDisplay.Text = cCOUNT.DISPLAYNAME;
            txtUser.Text = cCOUNT.USERNAME;
            txtPassword.Text = cCOUNT.PASSWORD;
            cbbType.SelectedIndex = (int)cCOUNT.TYPE;
            if ((UniversalUser.Ins.account.TYPE >= cCOUNT.TYPE) && UniversalUser.Ins.account.TYPE > 0)
            {
                txtPassword.Enabled = false;
                txtDisplay.Enabled = false;
                txtDescription.Enabled = false;
                btbDelete2.Enabled = false;
                btbAdd.Enabled=false;
            } else
            {
                btbDelete2.Enabled = true;
                txtDisplay.Enabled = true;
                txtPassword.Enabled = true;
                btbAdd.Enabled = true;
                txtDescription.Enabled = true;
            }
            if (UniversalUser.Ins.account.TYPE != 0)
            {
                txtUser.Enabled = false;
            } else
            {
                txtUser.Enabled = true;
            }
        }
        private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvAccounts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvAccounts.CurrentRow.Index != -1)
            {
                currentSelectAccount = new ACCOUNT();
                currentSelectAccount.USERID = Convert.ToInt32(dgvAccounts.CurrentRow.Cells[0].Value);
                currentSelectAccount.USERNAME = dgvAccounts.CurrentRow.Cells[1].Value.ToString();
                currentSelectAccount.PASSWORD = "Edit to change password";
                currentSelectAccount.DISPLAYNAME = dgvAccounts.CurrentRow.Cells[3].Value.ToString();
                currentSelectAccount.DESCRIPTION = dgvAccounts.CurrentRow.Cells[4].Value.ToString();
                currentSelectAccount.TYPE = Convert.ToInt32(dgvAccounts.CurrentRow.Cells[5].Value);
                UpdateViewData(currentSelectAccount);
                btbAdd.Text = "Cập nhật";
                IsUpdate = true;
            } else
            {
                Reset();
            }
        }

        private void btbDelete2_Click(object sender, EventArgs e)
        {
            if (currentSelectAccount == null) return;
            btbDelete2.Enabled = false;
            DataProvider.Instance.DeleteAccount(currentSelectAccount, Reset, LoadUserToDataGridView);
        }
    }
}
