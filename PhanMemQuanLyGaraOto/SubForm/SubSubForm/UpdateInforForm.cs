using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.DDo;
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
    public partial class UpdateInforForm : Form
    {
        bool isLoadl;
        public UpdateInforForm()
        {
            isLoadl = false;
            InitializeComponent();
            LoadInfo();
        }
        void LoadInfo()
        {
            txtDisplayName.Text = UniversalUser.Ins.account.DISPLAYNAME;
            txtDesCription.Text = UniversalUser.Ins.account.DESCRIPTION;
        }
        private void UpdateInforForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btbSavePassChange_Click(object sender, EventArgs e)
        {
            try
            {
                UniversalUser.Ins.account.DISPLAYNAME = txtDisplayName.Text;
                UniversalUser.Ins.account.DESCRIPTION = txtDesCription.Text;
                btbSavePassChange.Enabled = false;
                button1.Enabled = false;
                DataProvider.Instance.UpdateAccount(UniversalUser.Ins.account);
                this.Close();
                UniversalAlert.Ins.Alert();
                MessageBox.Show("Cập nhật thông tin người dùng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            } catch
            {
                MessageBox.Show("Cập nhật thông tin người dùng thất bại, một lỗi không mong muốn đã xảy ra", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }

            
        }
        void CloseThisForm()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateInforForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
