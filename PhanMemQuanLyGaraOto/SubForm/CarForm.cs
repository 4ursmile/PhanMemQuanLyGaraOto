using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.DDO;
using PhanMemQuanLyGaraOto.SubForm.SubSubForm;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Windows.UI;

namespace PhanMemQuanLyGaraOto.SubForm
{
    public partial class CarForm : Form
    {
        REMCheckCar currentCheckCar;
        public CarForm()
        {
            ReloadDataEvent.Ins.Addlistener(LoadToDGVCarComplex, DataType.Car, DataType.Brand, DataType.Customer, DataType.FixForm);
            InitializeComponent();
            DoubleBuffered = true;
            btbcollect.Enabled = false;
            btbUpdate.Enabled = false;
            LoadToDGVCarComplex();
            cbcFilterFix.SelectedIndex = 0;
            cbcFilterDebt.SelectedIndex = 0;
        }

        private void CarForm_Load(object sender, EventArgs e)
        {

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
                    listFilter = listFilter.Where(a=>a.DebtMoney == 0).ToList();
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
            listFilter = listFilter.Where(a => a.CarOwnerTele.Contains(txtFilterSDT.Text)).ToList<REMCheckCar>();
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
                    rows.DefaultCellStyle.BackColor = System.Drawing.Color.CadetBlue;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
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
            ReloadDataEvent.Ins.RemoveListerner(LoadToDGVCarComplex, DataType.Car, DataType.Brand, DataType.Customer, DataType.FixForm);
            DiposeToRoot(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TiepNhanForm tiepNhanForm = new TiepNhanForm(currentCheckCar);
            tiepNhanForm.ShowDialog();
            tiepNhanForm.Dispose();
        }

        private void dgvCheckCars_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCheckCars.CurrentRow.Index > -1)
            {
                DataGridViewRow cRow = dgvCheckCars.CurrentRow;
                currentCheckCar = (cRow.DataBoundItem as REMCheckCar);
                if (currentCheckCar.DebtMoney > 0)
                    btbcollect.Enabled = true;
                btbUpdate.Enabled = true;
                btbFix.Enabled = true;
            } else
            {
                btbcollect.Enabled = false;
                btbUpdate.Enabled = false;
                btbFix.Enabled = false;
            }
        }

        private void dgvCheckCars_SelectionChanged(object sender, EventArgs e)
        {
            dgvCheckCars_CellMouseClick(sender, null);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FixForm fixform =  new FixForm(currentCheckCar);
            fixform.ShowDialog();
            DiposeToRoot(fixform);
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
            txtFilterSDT.Text = "";
            cbcFilterDebt.SelectedIndex = 0;
            cbcFilterFix.SelectedIndex = 0;
            LoadToDGVCarComplex();
        }
    }
}
