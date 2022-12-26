using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.DDO;
using PhanMemQuanLyGaraOto.Model;
using PhanMemQuanLyGaraOto.SubForm.SubSubForm;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI;

namespace PhanMemQuanLyGaraOto.SubForm
{
    public partial class CarForm : Form
    {
        REMCheckCar currentCheckCar;
        public CarForm()
        {
            ReloadDataEvent.Ins.Addlistener(LoadToDGVCarComplex, DataType.Car, DataType.Brand, DataType.Customer, DataType.FixForm, DataType.Money);
            ReloadDataEvent.Ins.Addlistener(UpdateChar, DataType.TimesFix);
            ReloadDataEvent.Ins.Addlistener(UpdateMaxChart, DataType.Policy);
            ReloadDataEvent.Ins.Addlistener(LoadTocbcBrand, DataType.Brand);
            InitializeComponent();
            btbcollect.Enabled = false;
            btbUpdate.Enabled = false;
            LoadToDGVCarComplex();
            cbcFilterFix.SelectedIndex = 0;
            cbcFilterDebt.SelectedIndex = 0;
            LoadLuotSuaToiDa();
            ChartInit();
            ResetButton();
        }
        async void LoadTocbcBrand()
        {
            List<HIEUXE> hIEUXEs = await DataProvider.Instance.GetHIEUXEsAsync();
            HIEUXE hIEUXE = new HIEUXE { MAHIEUXE = 0, TENHIEUXE = "Tát cả" };
            hIEUXEs.Insert(0, hIEUXE);
            cbcHieuXe.DataSource = hIEUXEs;
            cbcHieuXe.DisplayMember = "TENHIEUXE";
        }
        private void CarForm_Load(object sender, EventArgs e)
        {

        }
        int SoLuotSua;
        int LuotSuaToiDa = 30;
        void LoadLuotSuaToiDa()
        {
            try
            {
                LuotSuaToiDa = (int)DataProvider.Instance.db.THAMSOes.Where(a => a.TENTHAMSO == "SOXESUACHUATOIDA").FirstOrDefault().GIATRI;
            } catch
            {
                
            }
        }
        void ChartInit()
        {
            SoLuotSua = DataProvider.Instance.GetSoLuotSuaTrongNgay() - 1;
            chart1.Series[0].Points.AddY(1);
            chart1.Series[0].Points.AddY(9);
            UpdateChar();
        }
        void UpdateChar()
        {
            SoLuotSua++;
            chart1.Series[0].Points.RemoveAt(0);
            chart1.Series[0].Points.RemoveAt(0);

            chart1.Series[0].Points.AddY(SoLuotSua);
            chart1.Series[0].Points.AddY(LuotSuaToiDa - SoLuotSua);
            chart1.Series[0].Points[0].Color = System.Drawing.Color.HotPink;
            chart1.Series[0].Points[1].Color = System.Drawing.Color.LawnGreen;
        }
        void UpdateMaxChart()
        {

            try
            {
                LuotSuaToiDa = (int)DataProvider.Instance.db.THAMSOes.Where(a => a.TENTHAMSO == "SOXESUACHUATOIDA").FirstOrDefault().GIATRI;
            }
            catch
            {
                return;
            }
            chart1.Series[0].Points.RemoveAt(0);
            chart1.Series[0].Points.RemoveAt(0);

            chart1.Series[0].Points.AddY(SoLuotSua);
            chart1.Series[0].Points.AddY(LuotSuaToiDa - SoLuotSua);
            chart1.Series[0].Points[0].Color = System.Drawing.Color.HotPink;
            chart1.Series[0].Points[1].Color = System.Drawing.Color.LawnGreen;
        }
        void LoadToDGVCarComplex()
        {
            dgvCheckCars.DataSource = DataProvider.Instance.GetCheckCar();
            cbcBienSo.DataSource = dgvCheckCars.DataSource;
            cbcBienSo.DisplayMember = "CarNumber";
        }

        void LoadToDGVCarComplexFilter()
        {
            List < REMCheckCar > listFilter = DataProvider.Instance.GetCheckCar();
            switch (cbcFilterDebt.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    listFilter = listFilter.Where(a=>a.DebtMoney <= 0).ToList();
                    break;
                case 2:
                    listFilter = listFilter.Where(a=>a.DebtMoney > 0).ToList();
                    break;
            }
          
            switch (cbcFilterFix.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    listFilter= listFilter.Where(a=>a.TinhTrang == 0).ToList();
                    break;
                case 2:
                    listFilter = listFilter.Where(a =>a.TinhTrang == 1).ToList();
                    break;
            }
            if (cbcHieuXe.SelectedIndex > 0)
            {
                listFilter = listFilter.Where(a => a.CarBrand.Contains(cbcHieuXe.Text)).ToList<REMCheckCar>();

            }
            listFilter = listFilter.Where(a => a.CarOwnerTele.Contains(txtFilterSDT.Text) && a.CarNumber.Contains(txtCarNumber.Text)).ToList<REMCheckCar>();
            dgvCheckCars.DataSource = listFilter;
            cbcBienSo.DataSource = dgvCheckCars.DataSource;
            cbcBienSo.DisplayMember = "CarNumber";
        }
        void IsFixingHightlight()
        {
            foreach(DataGridViewRow rows in dgvCheckCars.Rows)
            {
                if (Convert.ToUInt16(rows.Cells["TinhTrang"].Value) == 0)
                {
                    rows.DefaultCellStyle.BackColor = System.Drawing.Color.CornflowerBlue;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Task.WaitAll();
            TiepNhanForm tiepNhanForm = new TiepNhanForm();
            tiepNhanForm.ShowDialog();
            tiepNhanForm.Dispose();
        }

        private void dgvAccounts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        void DiposeToRoot(Control k)
        {
            if (k == null) return;
            foreach (Control e in k.Controls)
            {
                e.Dispose();

                DiposeToRoot(e);
            }
            k.Dispose();
        }
        private void CarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReloadDataEvent.Ins.RemoveListerner(LoadToDGVCarComplex, DataType.Car, DataType.Brand, DataType.Customer, DataType.FixForm, DataType.Money);
            ReloadDataEvent.Ins.RemoveListerner(UpdateChar, DataType.TimesFix);
            ReloadDataEvent.Ins.RemoveListerner(UpdateMaxChart, DataType.Policy);
            ReloadDataEvent.Ins.RemoveListerner(LoadTocbcBrand, DataType.Brand);
            DiposeToRoot(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TiepNhanForm tiepNhanForm = new TiepNhanForm(currentCheckCar);
            tiepNhanForm.ShowDialog();
            tiepNhanForm.Dispose();
        }
        void ResetButton()
        {
            btbcollect.Enabled = false;
            btbUpdate.Enabled = false;
            btbFix.Enabled = false;
        }
        private void dgvCheckCars_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCheckCars.CurrentRow.Index > -1)
            {
                DataGridViewRow cRow = dgvCheckCars.CurrentRow;
                currentCheckCar = (cRow.DataBoundItem as REMCheckCar);
                if (currentCheckCar.DebtMoney > 0)
                    btbcollect.Enabled = true;
                else
                    btbcollect.Enabled = false;
                btbUpdate.Enabled = true;
                btbFix.Enabled = true;
            } else
            {
                ResetButton();
            }
        }

        private void dgvCheckCars_SelectionChanged(object sender, EventArgs e)
        {
            dgvCheckCars_CellMouseClick(sender, null);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btbFilter_Click(object sender, EventArgs e)
        {
            LoadToDGVCarComplexFilter();
        }

        private void dgvCheckCars_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
           IsFixingHightlight();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            txtFilterSDT.Text = txtCarNumber.Text = "";
            cbcFilterDebt.SelectedIndex = 0;
            cbcFilterFix.SelectedIndex = 0;
            LoadToDGVCarComplex();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void btbcollect_Click(object sender, EventArgs e)
        {
            if (currentCheckCar == null) return;
            BillForm billForm = new BillForm(currentCheckCar);
            billForm.ShowDialog();
            DiposeToRoot(billForm);
        }

        private void btbFix_Click(object sender, EventArgs e)
        {
            if (SoLuotSua < LuotSuaToiDa)
            {
                FixForm fixform = new FixForm(currentCheckCar);
                fixform.ShowDialog();
                DiposeToRoot(fixform);
            }
            else
            {
                MessageBox.Show("Số lượt sửa chữa đã đạt đến tối đa, vui lòng không sữa chữa thêm xe", "Quá mức");
            }
        }

        private void dgvCheckCars_SelectionChanged_1(object sender, EventArgs e)
        {
            dgvCheckCars_CellMouseClick(sender, null);
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            txtFilterSDT.Text = "";
            cbcFilterDebt.SelectedIndex = 0;
            cbcFilterFix.SelectedIndex = 0;
            cbcHieuXe.SelectedIndex = 0;
            LoadToDGVCarComplex();
        }

        private void dgvCheckCars_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvCheckCars.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvCheckCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool firstTime = true;
        private void cbcHieuXe_Enter(object sender, EventArgs e)
        {
            if (!firstTime) return;
            LoadTocbcBrand();
            firstTime = false;
        }
    }
}
