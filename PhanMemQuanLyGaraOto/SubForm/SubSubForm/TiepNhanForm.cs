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
        XE currentXe;
        AlertNonPara[] LoadWhenDones;
        public TiepNhanForm(REMCheckCar rEM = null,params AlertNonPara[] func)
        {
            InitializeComponent();
            dtpTiepNhan.CustomFormat = "dd/MM/yyyy";
            if (rEM == null)
            {
                isUpdate = false;
            }
            else
            {
                isUpdate = true;
                currentXe = new XE();
                currentXe.MAXE = rEM.CarId;
                currentXe.BIENSO = rEM.CarNumber;
                currentXe.TONGNO = rEM.DebtMoney;
                currentXe.NGAYTIEPNHAN = rEM.DateIn;
                currentXe.TINHTRANG = rEM.TinhTrang;
                btbDelete.Visible = true;
            }
            dtpTiepNhan.MaxDate = DateTime.Today.AddDays(1);
            LoadWhenDones = func;
            LoadHieuXe();
            AddCustomerBiding();
            if (isUpdate)
            {
                btbSave.Enabled = false;
                cbcCusSDT.DropDownStyle = ComboBoxStyle.DropDownList;
                cbcCusSDT.Text = rEM.CarOwnerTele;
                cbcBrand.Text = rEM.CarBrand;
                txtBienSo.Text = rEM.CarNumber;
                dtpTiepNhan.Value = rEM.DateIn;
            } else
            {
                btbUpdate.Enabled = false;
            }
            isNewCustomer = false;
        }
        void SwitchStateCustomerInfor(bool State = true)
        {
            if (State)
            {
                foreach (TextBox txt in pnlCusInfor.Controls.OfType<TextBox>())
                {
                    txt.DataBindings.Clear();
                }
            }
            foreach (TextBox txt in pnlCusInfor.Controls.OfType<TextBox>())
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
            Task.WaitAll();
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
            k.Dispose();
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
        bool isNewCustomer;
        private void cbcCusSDT_Leave(object sender, EventArgs e)
        {
            if (cbcCusSDT.FindString(cbcCusSDT.Text) < 0)
            {
                SwitchStateCustomerInfor(true);
                txtHoten.Focus();
                isNewCustomer = true;
            } else
            {
                SwitchStateCustomerInfor(false);
                isNewCustomer = false;
            }
        }

        private void btbSave_Click(object sender, EventArgs e)
        {
            if (!DataProvider.Instance.isUniquePlate(txtBienSo.Text))
            {
                DialogResult result = MessageBox.Show("Biển Số xe bị trùng, Vui lòng nhập lại", "Trùng biển số", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (isNewCustomer)
            {
                currentCustomer = new CHUXE();
                currentCustomer.DIENTHOAI = cbcCusSDT.Text;
                currentCustomer.TENCHUXE = txtHoten.Text;
                currentCustomer.EMAIL = txtEmail.Text;
                currentCustomer.DIACHI = txtDiaChi.Text;
                DataProvider.Instance.SaveCustomer(currentCustomer);
            }
            currentCustomer = DataProvider.Instance.GetCHUXEBYSDT(cbcCusSDT.Text);
            currentXe = new XE();
            currentXe.MAHIEUXE = (cbcBrand.SelectedValue as HIEUXE).MAHIEUXE;
            currentXe.MACHUXE = currentCustomer.MACHUXE;
            currentXe.BIENSO = txtBienSo.Text;
            currentXe.NGAYTIEPNHAN = dtpTiepNhan.Value;
            currentXe.TONGNO = 0;
            currentXe.TINHTRANG = 1;
            DataProvider.Instance.SaveCar(currentXe);
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btbUpdate_Click(object sender, EventArgs e)
        {
            if (!DataProvider.Instance.isUniquePlate(txtBienSo.Text, currentXe.MAXE))
            {
                DialogResult result = MessageBox.Show("Biển Số xe bị trùng, Vui lòng nhập lại", "Trùng biển số", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            currentXe.MAHIEUXE = (cbcBrand.SelectedValue as HIEUXE).MAHIEUXE;
            currentXe.MACHUXE = (cbcCusSDT.SelectedValue as CHUXE).MACHUXE;
            currentXe.BIENSO = txtBienSo.Text;
            currentXe.NGAYTIEPNHAN = dtpTiepNhan.Value;
            DataProvider.Instance.UpdateCar(currentXe);
            this.Close();
        }

        private void txtBienSo_Leave(object sender, EventArgs e)
        {
            bool isUnique = true;
            if (isUpdate)
            {
                isUnique = DataProvider.Instance.isUniquePlate(txtBienSo.Text, currentXe.MAXE);
            } else
            {
                isUnique = DataProvider.Instance.isUniquePlate(txtBienSo.Text);
            }
            if (!isUnique)
            {
                DialogResult result = MessageBox.Show("Biển Số xe bị trùng, bạn có muốn nhập lại không?", "Trùng biển số", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    txtBienSo.Focus();
                } else
                {
                    btbCancle_Click(null, null);
                }
            }
        }

        private void dtpTiepNhan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbcBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btbDelete_Click(object sender, EventArgs e)
        {
            if (currentXe == null) return;
            DataProvider.Instance.DeleteCar(currentXe);
        }
    }
}
