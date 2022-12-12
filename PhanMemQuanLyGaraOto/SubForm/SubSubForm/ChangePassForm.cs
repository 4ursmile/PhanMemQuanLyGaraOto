using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.DDo;
using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.SubForm.SubSubForm
{
    public partial class ChangePassForm : Form
    {
        public ChangePassForm()
        {
            InitializeComponent();
            LoadInfor();
        }
        void LoadInfor()
        {
            txtUserName.Text = UniversalUser.Ins.account.USERNAME;
        }
        #region Event
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btbSavePassChange_Click(object sender, EventArgs e)
        {
            if (SuperHash.GetHashPassWord(txtOld.Text) != UniversalUser.Ins.account.PASSWORD)
            {
                MessageBox.Show("Mật khẩu cũ không đúng, vui lòng kiểm tra lại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNew.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNew.Text != txtReNew.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng vui lòng kiểm tra lại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                UniversalUser.Ins.account.PASSWORD = SuperHash.GetHashPassWord(txtReNew.Text);
                DataProvider.Instance.UpdateAccount(UniversalUser.Ins.account);
                //DataProvider.Instance.db.ACCOUNTs.Attach(UniversalUser.Ins.account);
                //DataProvider.Instance.db.Entry(UniversalUser.Ins.account).State = System.Data.Entity.EntityState.Modified;
                //DataProvider.Instance.db.SaveChanges();
                MessageBox.Show("Cập nhật mật khẩu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch
            {
                MessageBox.Show("Cập nhật mật khẩu thất bại, một lỗi không mong muốn đã xảy ra" + UniversalUser.Ins.account.USERID, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ptbOld_Click(object sender, EventArgs e)
        {
            char SpecicalChar = '•';
            if (txtOld.PasswordChar == SpecicalChar)
                txtOld.PasswordChar = '\0';
            else
                txtOld.PasswordChar = SpecicalChar;
        }

        private void ptbNew_Click(object sender, EventArgs e)
        {
            char SpecicalChar = '•';
            if (txtNew.PasswordChar == SpecicalChar)
                txtNew.PasswordChar = '\0';
            else
                txtNew.PasswordChar = SpecicalChar;
        }

        private void txtReNew_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptbReNew_Click(object sender, EventArgs e)
        {
            char SpecicalChar = '•';
            if (txtReNew.PasswordChar == SpecicalChar)
                txtReNew.PasswordChar = '\0';
            else
                txtReNew.PasswordChar = SpecicalChar;
        }
        #endregion
    }
}
