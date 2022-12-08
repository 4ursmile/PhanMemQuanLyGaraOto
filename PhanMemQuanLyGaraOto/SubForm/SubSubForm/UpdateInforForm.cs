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

        private async void btbSavePassChange_Click(object sender, EventArgs e)
        {
            UniversalUser.Ins.account.DISPLAYNAME = txtDisplayName.Text;
            UniversalUser.Ins.account.DESCRIPTION = txtDesCription.Text;
            DataProvider.Instance.db.Entry(UniversalUser.Ins.account).State = System.Data.Entity.EntityState.Modified;
            btbSavePassChange.Enabled = false;
            button1.Enabled = false;
            this.Close();
            DataProvider.Instance.SaveChange();
            UniversalAlert.Ins.Alert();
            MessageBox.Show("Cập nhật thông tin người dùng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);;
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
