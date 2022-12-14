using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.DDO;
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
using Windows.UI.Composition;

namespace PhanMemQuanLyGaraOto.SubForm.SubSubForm
{
    public partial class TiepNhanForm : Form
    {
        bool isUpdate;
        CHUXE currentCustomer;
        HIEUXE currentHieuXe;
        XE currentXe;
        AlertNonPara[] LoadWhenDones;
        public TiepNhanForm(REMCheckCar rEM = null,params AlertNonPara[] func)
        {
            InitializeComponent();
            if (rEM == null)
                isUpdate = false;
            else
                isUpdate = true;
            LoadWhenDones = func;
            LoadHieuXe();
            if (isUpdate)
            {

            } else
            {
                AddCustomerBiding();
            }
        }
        void SwitchStateCustomerInfor(bool State = true)
        {
            foreach(TextBox txt in pnlCusInfor.Controls.OfType<TextBox>())
            {
                txt.Enabled = State;
            }
        }
        void AddCustomerBiding()
        {
            SwitchStateCustomerInfor(false);
            LoadTocbcCus();
            txtHoten.DataBindings.Add(new Binding("Text", cbcCusSDT.DataSource, "TENCHUXE"));
            txtEmail.DataBindings.Add(new Binding("Text", cbcCusSDT.DataSource,"EMAIL"));
            txtDiaChi.DataBindings.Add(new Binding("Text", cbcCusSDT.DataSource, "DIACHI"));
        }
        void LoadTocbcCus()
        {
            cbcCusSDT.DataSource = DataProvider.Instance.db.CHUXEs.ToList<CHUXE>();
            cbcCusSDT.DisplayMember = "DIENTHOAI";
        }
        void LoadHieuXe()
        {
            cbcBrand.DataSource = DataProvider.Instance.db.HIEUXEs.ToList<HIEUXE>();
            cbcBrand.DisplayMember = "TENHIEUXE";
        }
        private void TiepNhanForm_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btbCancle_Click(object sender, EventArgs e)
        {
            this.Close();


        }
        void DiposeToRoot(Control k)
        {
            if (k == null) return;
            foreach(Control e in k.Controls)
            {
                e.Dispose();

                DiposeToRoot(e);
            }
        }
        private void TiepNhanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DiposeToRoot(this);
            this.SuspendLayout();
            this.Dispose();
        }

        private void cbcCusSDT_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cbcCusSDT_Leave(object sender, EventArgs e)
        {
            if (cbcCusSDT.FindString(cbcCusSDT.Text) < 0)
            {
                SwitchStateCustomerInfor(true);
                txtHoten.Focus();
            }
        }

        private void btbSave_Click(object sender, EventArgs e)
        {
            currentCustomer = new CHUXE();
            currentCustomer.DIENTHOAI = cbcCusSDT.Text;
            currentCustomer.TENCHUXE = txtHoten.Text;
            currentCustomer.EMAIL = txtEmail.Text;
            currentCustomer.DIACHI = txtDiaChi.Text;
            DataProvider.Instance.SaveCustomer(currentCustomer);
            currentCustomer = DataProvider.Instance.GetCHUXEBYSDT(currentCustomer.DIENTHOAI);
            currentXe = new XE();
            currentXe.MAHIEUXE = (cbcBrand.SelectedValue as HIEUXE).MAHIEUXE;
            currentXe.MACHUXE = currentCustomer.MACHUXE;
            currentXe.BIENXO = txtBienSo.Text;
            currentXe.NGAYTIEPNHAN = dtpTiepNhan.Value;
            currentXe.TONGNO = 0;
            DataProvider.Instance.SaveCar(currentXe);
            this.Close();
        }
    }
}
